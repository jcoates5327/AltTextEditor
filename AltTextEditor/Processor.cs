using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Linq;
using System.IO;

using Blip = DocumentFormat.OpenXml.Drawing.Blip;
using TextBox = System.Windows.Forms.RichTextBox;
using PictureBox = System.Windows.Forms.PictureBox;
using Panel = System.Windows.Forms.Panel;
using Image = System.Drawing.Image;
using Label = System.Windows.Forms.Label;

using System.Text;

class Processor {

    string sourceFile, tmpDir;
    int numImg, curImage;
    int maxCount = 5;

    WordprocessingDocument document;
    Body body;

    public Processor(string sourceFile) {
        this.sourceFile = sourceFile;
        curImage = -1;
    }


    /*
        * Process a DOCX document, extracting data and outputting a DTBOOK XML.
        * 
        * 
        */
    public bool ProcessDocument() {
        // open document - must be existing and not empty
        bool opened = false;
        for (int i = 0; i < maxCount; i++) {
            try {
                document = WordprocessingDocument.Open(sourceFile, true);
                opened = true;
                break;
            } catch (IOException e) {
                System.Threading.Thread.Sleep(1000);
            }
        }

        if (!opened) {
            return false;
        }

        body = document.MainDocumentPart.Document.Body;    // grab document Body
        numImg = document.MainDocumentPart.Document.Body.Descendants<Inline>().Count();

        string filename = sourceFile.Split('/').Last().Split('.').First();
        string tmp = System.IO.Path.GetTempPath();
        DirectoryInfo di = System.IO.Directory.CreateDirectory(tmp + @"\AltTextEditor");
        tmpDir = di.FullName;

        return true;
    }

    public string nextImage(TextBox textBox, PictureBox imgBox, Label label) {
        // check to see if we're at the last image
        if (curImage >= (numImg - 1)) {
            return null;
        }

        // save current alt text
        string txt = textBox.Text == null ? "" : getTextBoxContent(textBox);
        if (curImage > -1) saveAltText(txt);
        curImage++;

        Inline inline = body.Descendants<Inline>().ElementAt(curImage); // our images are stored in Inline elements

        var descr = inline.DocProperties.Description;   // descr attribute - holds alt text
        string altText = descr == null ? "" : inline.DocProperties.Description.Value;

        imgBox.Image = getImageFromInline(inline);
        textBox.Text = altText;
        label.Text = "#" + (curImage + 1);

        return altText;
    }

    public string prevImage(TextBox textBox, PictureBox imgBox, Label label) {
        if (curImage <= 0) {
            return null;
        }

        string txt = textBox.Text == null ? "" : getTextBoxContent(textBox);

        if (curImage > -1) saveAltText(txt);
        curImage--;

        Inline inline = body.Descendants<Inline>().ElementAt(curImage);

        var descr = inline.DocProperties.Description;
        string altText = descr == null ? "" : inline.DocProperties.Description.Value;

        imgBox.Image = getImageFromInline(inline);
        textBox.Text = altText;
        label.Text = "#" + (curImage + 1);

        return altText;
    }

    /*
     * KNOWN ISSUES
     * - says all images have alt text if only current img does not have alt text
     */
    public bool jumpToNextBlankAltText(TextBox textBox, PictureBox imgBox, Label label) {
        string txt = textBox.Text == null ? "" : getTextBoxContent(textBox);
        if (curImage > -1) saveAltText(txt);

        int i = (curImage + 1) % numImg;

        while (i != curImage) {
            Inline inline = body.Descendants<Inline>().ElementAt(i);
            var descr = inline.DocProperties.Description;

            if (descr == null || descr.Value == "" || descr.Value == "http:\\\\") {
                // found blank alt text
                imgBox.Image = getImageFromInline(inline);
                textBox.Text = "";

                curImage = i;
                label.Text = "#" + (curImage + 1);

                return true;
            }

            i = (i + 1) % numImg;
        }

        return false;
    }

    // TODO
    public bool goToImageIndex(TextBox indexTB, TextBox altTB, PictureBox pb, Label label) {
        try {
            int index = int.Parse(getTextBoxContent(indexTB).Trim()) - 1;
            if (index < 0 || index > (numImg - 1)) {
                return false;
            }

            Inline inline = body.Descendants<Inline>().ElementAt(index);

            var descr = inline.DocProperties.Description;
            string altText = descr == null ? "" : inline.DocProperties.Description.Value;

            pb.Image = getImageFromInline(inline);
            altTB.Text = altText;
            curImage = index;
            label.Text = "#" + (curImage + 1);

            return true;

        } catch (System.FormatException fe) {
            return false;
        }
    }

    public void saveAltText(string text) {
        document.MainDocumentPart.Document.Body.Descendants<Inline>().ElementAt(curImage)
            .DocProperties.Description = text;
    }

    public void save() {
        document.Close();
    }

    public int getNumImg() {
        return document.MainDocumentPart.Document.Body.Descendants<Inline>().Count();
    }

    private Image getImageFromInline(Inline inline) {
        Blip blip = inline.Descendants<Blip>().First();
        ImagePart imagePart = (ImagePart)document.MainDocumentPart.GetPartById(blip.Embed.Value);

        var uri = imagePart.Uri;
        var filename = uri.ToString().Split('/').Last();
        var stream = document.Package.GetPart(uri).GetStream();

        var image = Image.FromStream(stream);
        stream.Close();

        return image;
    }

    public string getTextBoxContent(TextBox box) {
        StringBuilder txt = new StringBuilder();
        foreach (string s in box.Lines) {
            txt.Append(s);
        }
        return txt.ToString();
    }

    private void CopyStream(Stream source, Stream destination) {
        byte[] buffer = new byte[0x8000];
        int read;
        while ((read = source.Read(buffer, 0, buffer.Length)) > 0) {
            destination.Write(buffer, 0, read);
        }
    }
}

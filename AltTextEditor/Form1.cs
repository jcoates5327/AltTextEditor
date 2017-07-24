using System;
using System.Windows.Forms;

namespace AltTextEditor {
    public partial class Form1 : Form {
        Processor p;
        string curAltText;

        public Form1() {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e) {
            clearLabels();
            var res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK) {
                string fname = openFileDialog.FileName;
                p = new Processor(fname);
                Boolean success = p.ProcessDocument();
                if (success) {
                    errLabel.Text = "File opened.";

                    curAltText = p.nextImage(textBox, imgBox, imgNumLabel);
                    if (curAltText == null) {
                        imgErrLabel.Text = "No images!";
                    } else {
                        curAltText = curAltText == null ? "" : curAltText;
                        imgErrLabel.Text = "";
                    }
                } else {
                    errLabel.Text = "Unable to open.";
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e) {
            clearLabels();
            p.save();
            errLabel.Text = "File saved!";
        }

        private void prevButton_Click(object sender, EventArgs e) {
            clearLabels();
            curAltText = p.prevImage(textBox, imgBox, imgNumLabel);
            if (curAltText == null) {
                imgErrLabel.Text = "First image!";
            } else {
                curAltText = curAltText == null ? "" : curAltText;
                imgErrLabel.Text = "";
            }

            
        }

        private void nextButton_Click(object sender, EventArgs e) {
            clearLabels();
            curAltText = p.nextImage(textBox, imgBox, imgNumLabel);
            if (curAltText == null) {
                imgErrLabel.Text = "Last image!";
            } else {
                curAltText = curAltText == null ? "" : curAltText;
                imgErrLabel.Text = "";
            }
        }

        private void saveTextButton_Click(object sender, EventArgs e) {
            clearLabels();
            p.saveAltText(textBox.Text);
        }

        private void resetTextButton_Click(object sender, EventArgs e) {
            clearLabels();
            if (curAltText != "") {
                textBox.Text = curAltText;
            }
        }

        private void nextBlankAltTextButton_Click(object sender, EventArgs e) {
            clearLabels();

            bool hasBlankAT = p.jumpToNextBlankAltText(textBox, imgBox, imgNumLabel);
            string curAT = p.getTextBoxContent(textBox);

            bool curBlank;
            if (curAT == null || curAT == "" || curAT == "http:\\\\") {
                curBlank = true;
            } else {
                curBlank = false;
            }

            if (!hasBlankAT && !curBlank) {
                nextBlankATLabel.Text = "All images have alt text!";
            }
        }

        private void clearLabels() {
            errLabel.Text = "";
            imgErrLabel.Text = "";
            nextBlankATLabel.Text = "";
        }

        private void goToButton_Click(object sender, EventArgs e) {
            clearLabels();
            bool good = p.goToImageIndex(goToTextBox, textBox, imgBox, imgNumLabel);

            if (!good) {
                imgNumLabel.Text = "Bad number.";
            }

        }
    }
}

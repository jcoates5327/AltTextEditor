namespace AltTextEditor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.controlPanel = new System.Windows.Forms.Panel();
            this.imgErrLabel = new System.Windows.Forms.Label();
            this.errLabel = new System.Windows.Forms.Label();
            this.resetTextButton = new System.Windows.Forms.Button();
            this.saveTextButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.nextBlankAltTextButton = new System.Windows.Forms.Button();
            this.nextBlankATLabel = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.goToButton = new System.Windows.Forms.Button();
            this.goToTextBox = new System.Windows.Forms.RichTextBox();
            this.imgNumLabel = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.imgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.controlPanel.Controls.Add(this.imgNumLabel);
            this.controlPanel.Controls.Add(this.goToTextBox);
            this.controlPanel.Controls.Add(this.goToButton);
            this.controlPanel.Controls.Add(this.textBox);
            this.controlPanel.Controls.Add(this.nextBlankATLabel);
            this.controlPanel.Controls.Add(this.nextBlankAltTextButton);
            this.controlPanel.Controls.Add(this.imgErrLabel);
            this.controlPanel.Controls.Add(this.errLabel);
            this.controlPanel.Controls.Add(this.resetTextButton);
            this.controlPanel.Controls.Add(this.saveTextButton);
            this.controlPanel.Controls.Add(this.nextButton);
            this.controlPanel.Controls.Add(this.prevButton);
            this.controlPanel.Controls.Add(this.saveButton);
            this.controlPanel.Controls.Add(this.openButton);
            this.controlPanel.Location = new System.Drawing.Point(12, 613);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1205, 177);
            this.controlPanel.TabIndex = 2;
            // 
            // imgErrLabel
            // 
            this.imgErrLabel.AutoSize = true;
            this.imgErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgErrLabel.Location = new System.Drawing.Point(684, 78);
            this.imgErrLabel.Name = "imgErrLabel";
            this.imgErrLabel.Size = new System.Drawing.Size(0, 24);
            this.imgErrLabel.TabIndex = 8;
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLabel.ForeColor = System.Drawing.Color.Black;
            this.errLabel.Location = new System.Drawing.Point(1043, 76);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(0, 24);
            this.errLabel.TabIndex = 7;
            // 
            // resetTextButton
            // 
            this.resetTextButton.AccessibleName = "Reset alt text button";
            this.resetTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetTextButton.Location = new System.Drawing.Point(516, 50);
            this.resetTextButton.Name = "resetTextButton";
            this.resetTextButton.Size = new System.Drawing.Size(102, 23);
            this.resetTextButton.TabIndex = 6;
            this.resetTextButton.Text = "Reset Alt Text";
            this.resetTextButton.UseVisualStyleBackColor = true;
            this.resetTextButton.Click += new System.EventHandler(this.resetTextButton_Click);
            // 
            // saveTextButton
            // 
            this.saveTextButton.AccessibleName = "Save alt text button";
            this.saveTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTextButton.Location = new System.Drawing.Point(516, 21);
            this.saveTextButton.Name = "saveTextButton";
            this.saveTextButton.Size = new System.Drawing.Size(102, 23);
            this.saveTextButton.TabIndex = 5;
            this.saveTextButton.Text = "Save Alt Text";
            this.saveTextButton.UseVisualStyleBackColor = true;
            this.saveTextButton.Click += new System.EventHandler(this.saveTextButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.AccessibleName = "Next image button";
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(717, 19);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(85, 25);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next Image";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.AccessibleName = "Previous image button";
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevButton.Location = new System.Drawing.Point(688, 50);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(114, 25);
            this.prevButton.TabIndex = 3;
            this.prevButton.Text = "Previous Image";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AccessibleName = "Save document button";
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(1035, 50);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Document";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.AccessibleName = "Open document button";
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(1035, 21);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(122, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open Document";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Choose a file";
            // 
            // nextBlankAltTextButton
            // 
            this.nextBlankAltTextButton.AccessibleDescription = "Next blank alt text";
            this.nextBlankAltTextButton.AccessibleName = "Next blank alt text";
            this.nextBlankAltTextButton.AutoSize = true;
            this.nextBlankAltTextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextBlankAltTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBlankAltTextButton.Location = new System.Drawing.Point(516, 93);
            this.nextBlankAltTextButton.Name = "nextBlankAltTextButton";
            this.nextBlankAltTextButton.Size = new System.Drawing.Size(133, 28);
            this.nextBlankAltTextButton.TabIndex = 9;
            this.nextBlankAltTextButton.Text = "Next Blank Alt Text";
            this.nextBlankAltTextButton.UseVisualStyleBackColor = true;
            this.nextBlankAltTextButton.Click += new System.EventHandler(this.nextBlankAltTextButton_Click);
            // 
            // nextBlankATLabel
            // 
            this.nextBlankATLabel.AutoSize = true;
            this.nextBlankATLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBlankATLabel.Location = new System.Drawing.Point(664, 97);
            this.nextBlankATLabel.Name = "nextBlankATLabel";
            this.nextBlankATLabel.Size = new System.Drawing.Size(0, 24);
            this.nextBlankATLabel.TabIndex = 10;
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(0, 3);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(100, 50);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            // 
            // imgPanel
            // 
            this.imgPanel.AutoScroll = true;
            this.imgPanel.AutoSize = true;
            this.imgPanel.Controls.Add(this.imgBox);
            this.imgPanel.Location = new System.Drawing.Point(0, 0);
            this.imgPanel.MaximumSize = new System.Drawing.Size(1217, 607);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(1217, 607);
            this.imgPanel.TabIndex = 3;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(3, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(507, 171);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            // 
            // goToButton
            // 
            this.goToButton.AccessibleDescription = "Next blank alt text";
            this.goToButton.AccessibleName = "Next blank alt text";
            this.goToButton.AutoSize = true;
            this.goToButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.goToButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToButton.Location = new System.Drawing.Point(808, 19);
            this.goToButton.Name = "goToButton";
            this.goToButton.Size = new System.Drawing.Size(60, 28);
            this.goToButton.TabIndex = 11;
            this.goToButton.Text = "Go To";
            this.goToButton.UseVisualStyleBackColor = true;
            this.goToButton.Click += new System.EventHandler(this.goToButton_Click);
            // 
            // goToTextBox
            // 
            this.goToTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToTextBox.Location = new System.Drawing.Point(874, 19);
            this.goToTextBox.Multiline = false;
            this.goToTextBox.Name = "goToTextBox";
            this.goToTextBox.Size = new System.Drawing.Size(39, 28);
            this.goToTextBox.TabIndex = 13;
            this.goToTextBox.Text = "";
            // 
            // imgNumLabel
            // 
            this.imgNumLabel.AutoSize = true;
            this.imgNumLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgNumLabel.Location = new System.Drawing.Point(808, 53);
            this.imgNumLabel.Name = "imgNumLabel";
            this.imgNumLabel.Size = new System.Drawing.Size(0, 19);
            this.imgNumLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AccessibleName = "AltTextEditor";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1229, 802);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "AltTextEditor";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.imgPanel.ResumeLayout(false);
            this.imgPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button resetTextButton;
        private System.Windows.Forms.Button saveTextButton;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.Label imgErrLabel;
        private System.Windows.Forms.Button nextBlankAltTextButton;
        private System.Windows.Forms.Label nextBlankATLabel;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label imgNumLabel;
        private System.Windows.Forms.RichTextBox goToTextBox;
        private System.Windows.Forms.Button goToButton;
    }
}


namespace ArpasingAliaser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dictionaryFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dictionaryFileTextBox = new System.Windows.Forms.TextBox();
            this.dictionaryFileBrowseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.otoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.otoFileBrowseButton = new System.Windows.Forms.Button();
            this.otoFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dictionary File:";
            // 
            // dictionaryFileDialog
            // 
            this.dictionaryFileDialog.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            this.dictionaryFileDialog.Title = "Load Dictionary File...";
            // 
            // dictionaryFileTextBox
            // 
            this.dictionaryFileTextBox.Location = new System.Drawing.Point(12, 28);
            this.dictionaryFileTextBox.Name = "dictionaryFileTextBox";
            this.dictionaryFileTextBox.Size = new System.Drawing.Size(290, 23);
            this.dictionaryFileTextBox.TabIndex = 1;
            this.dictionaryFileTextBox.Text = "xsampa.txt";
            // 
            // dictionaryFileBrowseButton
            // 
            this.dictionaryFileBrowseButton.Location = new System.Drawing.Point(308, 28);
            this.dictionaryFileBrowseButton.Name = "dictionaryFileBrowseButton";
            this.dictionaryFileBrowseButton.Size = new System.Drawing.Size(35, 23);
            this.dictionaryFileBrowseButton.TabIndex = 2;
            this.dictionaryFileBrowseButton.Text = "...";
            this.dictionaryFileBrowseButton.UseVisualStyleBackColor = true;
            this.dictionaryFileBrowseButton.Click += new System.EventHandler(this.dictionaryFileBrowseButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "The dict. file should consist of multiple lines, where first there is an ARPAbet " +
                               "phoneme on the left and another phoneme on the right, separated by space. Ex: ay" +
                               " aI\r\n\r\n";
            // 
            // otoFileDialog
            // 
            this.otoFileDialog.Filter =
                "UTAU Voice Configuration File|oto.ini|Configuration Files (*.ini)|*.ini|All Files (*.*)|*.*";
            this.otoFileDialog.Title = "Load oto File...";
            // 
            // otoFileBrowseButton
            // 
            this.otoFileBrowseButton.Location = new System.Drawing.Point(308, 138);
            this.otoFileBrowseButton.Name = "otoFileBrowseButton";
            this.otoFileBrowseButton.Size = new System.Drawing.Size(35, 23);
            this.otoFileBrowseButton.TabIndex = 6;
            this.otoFileBrowseButton.Text = "...";
            this.otoFileBrowseButton.UseVisualStyleBackColor = true;
            this.otoFileBrowseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // otoFileTextBox
            // 
            this.otoFileTextBox.Location = new System.Drawing.Point(12, 138);
            this.otoFileTextBox.Name = "otoFileTextBox";
            this.otoFileTextBox.Size = new System.Drawing.Size(290, 23);
            this.otoFileTextBox.TabIndex = 5;
            this.otoFileTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Voice Configuration (oto.ini) File:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "The oto file itself will be modified. A backup called (filename).backup will be c" +
                               "reated. Duplicate entries\' numbers are placed with a space before them.\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Alias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.otoFileBrowseButton);
            this.Controls.Add(this.otoFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dictionaryFileBrowseButton);
            this.Controls.Add(this.dictionaryFileTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Arpasing Aliaser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dictionaryFileDialog;
        private System.Windows.Forms.Button dictionaryFileBrowseButton;
        private System.Windows.Forms.TextBox dictionaryFileTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog otoFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox otoFileTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button otoFileBrowseButton;
        private System.Windows.Forms.Button button1;
    }
}
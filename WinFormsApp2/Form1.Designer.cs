namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelFilename = new Label();
            labelFilepath = new Label();
            labelSize = new Label();
            SuspendLayout();
            // 
            // openFile
            // 
            openFile.Location = new Point(189, 325);
            openFile.Name = "openFile";
            openFile.Size = new Size(140, 34);
            openFile.TabIndex = 0;
            openFile.Text = "Vybrat soubor";
            openFile.UseVisualStyleBackColor = true;
            openFile.Click += openFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 82);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Název souboru:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 117);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Cesta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 149);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Velikost:";
            // 
            // labelFilename
            // 
            labelFilename.AutoSize = true;
            labelFilename.Location = new Point(325, 82);
            labelFilename.Name = "labelFilename";
            labelFilename.Size = new Size(38, 15);
            labelFilename.TabIndex = 4;
            labelFilename.Text = "label4";
            // 
            // labelFilepath
            // 
            labelFilepath.AutoSize = true;
            labelFilepath.Location = new Point(325, 117);
            labelFilepath.Name = "labelFilepath";
            labelFilepath.Size = new Size(38, 15);
            labelFilepath.TabIndex = 5;
            labelFilepath.Text = "label5";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(325, 149);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(38, 15);
            labelSize.TabIndex = 6;
            labelSize.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(labelSize);
            Controls.Add(labelFilepath);
            Controls.Add(labelFilename);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(openFile);
            Name = "Form1";
            Text = "Informace o souboru";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openFile;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelFilename;
        private Label labelFilepath;
        private Label labelSize;
    }
}
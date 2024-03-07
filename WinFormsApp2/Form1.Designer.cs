namespace WinFormsApp2
{
    partial class KinoForm
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
            kinoPictureBox = new PictureBox();
            loadBtn = new Button();
            saveBtn = new Button();
            filenameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)kinoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // kinoPictureBox
            // 
            kinoPictureBox.Location = new Point(12, 12);
            kinoPictureBox.Name = "kinoPictureBox";
            kinoPictureBox.Size = new Size(776, 405);
            kinoPictureBox.TabIndex = 0;
            kinoPictureBox.TabStop = false;
            kinoPictureBox.Paint += kinoPictureBox_Paint;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(12, 423);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(75, 23);
            loadBtn.TabIndex = 1;
            loadBtn.Text = "Načíst sál";
            loadBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(93, 423);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Uložit sál";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(174, 427);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(0, 15);
            filenameLabel.TabIndex = 3;
            // 
            // KinoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(filenameLabel);
            Controls.Add(saveBtn);
            Controls.Add(loadBtn);
            Controls.Add(kinoPictureBox);
            Name = "KinoForm";
            Text = "Evidence sedadel";
            Load += KinoForm_Load;
            ((System.ComponentModel.ISupportInitialize)kinoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox kinoPictureBox;
        private Button loadBtn;
        private Button saveBtn;
        private Label filenameLabel;
    }
}
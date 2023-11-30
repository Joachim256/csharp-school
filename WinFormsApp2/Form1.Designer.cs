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
            lettersBox = new TextBox();
            label1 = new Label();
            foundWordsListBox = new ListBox();
            label2 = new Label();
            saveWords = new Button();
            SuspendLayout();
            // 
            // lettersBox
            // 
            lettersBox.Location = new Point(12, 36);
            lettersBox.Name = "lettersBox";
            lettersBox.Size = new Size(176, 23);
            lettersBox.TabIndex = 0;
            lettersBox.TextChanged += textBox1_TextChanged;
            lettersBox.KeyPress += lettersBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 15);
            label1.TabIndex = 1;
            label1.Text = "zadejte písmena, ze kterých se budou skládat slova";
            // 
            // foundWordsListBox
            // 
            foundWordsListBox.FormattingEnabled = true;
            foundWordsListBox.ItemHeight = 15;
            foundWordsListBox.Location = new Point(341, 36);
            foundWordsListBox.Name = "foundWordsListBox";
            foundWordsListBox.Size = new Size(196, 274);
            foundWordsListBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 9);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 3;
            label2.Text = "seznam nalezených slov";
            // 
            // saveWords
            // 
            saveWords.Location = new Point(374, 316);
            saveWords.Name = "saveWords";
            saveWords.Size = new Size(133, 23);
            saveWords.TabIndex = 4;
            saveWords.Text = "Uložit do souboru";
            saveWords.UseVisualStyleBackColor = true;
            saveWords.Click += saveWords_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 371);
            Controls.Add(saveWords);
            Controls.Add(label2);
            Controls.Add(foundWordsListBox);
            Controls.Add(label1);
            Controls.Add(lettersBox);
            Name = "Form1";
            Text = "Vlastní slovník";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lettersBox;
        private Label label1;
        private ListBox foundWordsListBox;
        private Label label2;
        private Button saveWords;
    }
}
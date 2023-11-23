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
            label1 = new Label();
            filePath = new TextBox();
            saveBtn = new Button();
            loadBtn = new Button();
            groupBox1 = new GroupBox();
            appendOption = new RadioButton();
            radioButton1 = new RadioButton();
            contentEditor = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Cesta k souboru:";
            // 
            // filePath
            // 
            filePath.Location = new Point(126, 20);
            filePath.Name = "filePath";
            filePath.Size = new Size(240, 23);
            filePath.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(12, 63);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(141, 36);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Uložit do souboru";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(159, 63);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(146, 36);
            loadBtn.TabIndex = 3;
            loadBtn.Text = "Načíst ze souboru";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(appendOption);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(141, 80);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "přidat/přepsat";
            // 
            // appendOption
            // 
            appendOption.AutoSize = true;
            appendOption.Location = new Point(6, 47);
            appendOption.Name = "appendOption";
            appendOption.Size = new Size(82, 19);
            appendOption.TabIndex = 1;
            appendOption.Text = "přidat data";
            appendOption.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "přepsat data";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // contentEditor
            // 
            contentEditor.Location = new Point(18, 221);
            contentEditor.Multiline = true;
            contentEditor.Name = "contentEditor";
            contentEditor.Size = new Size(498, 217);
            contentEditor.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(contentEditor);
            Controls.Add(groupBox1);
            Controls.Add(loadBtn);
            Controls.Add(saveBtn);
            Controls.Add(filePath);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox filePath;
        private Button saveBtn;
        private Button loadBtn;
        private GroupBox groupBox1;
        private RadioButton appendOption;
        private RadioButton radioButton1;
        private TextBox contentEditor;
    }
}
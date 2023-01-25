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
            this.disableMinimize = new System.Windows.Forms.Button();
            this.enableMinimize = new System.Windows.Forms.Button();
            this.blueForm = new System.Windows.Forms.Button();
            this.whiteForm = new System.Windows.Forms.Button();
            this.displayField = new System.Windows.Forms.Button();
            this.grayForm = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.disableAll = new System.Windows.Forms.Button();
            this.enableAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.copyField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disableMinimize
            // 
            this.disableMinimize.Location = new System.Drawing.Point(12, 12);
            this.disableMinimize.Name = "disableMinimize";
            this.disableMinimize.Size = new System.Drawing.Size(222, 23);
            this.disableMinimize.TabIndex = 0;
            this.disableMinimize.Text = "Zakázat minimalizační tlačítko";
            this.disableMinimize.UseVisualStyleBackColor = true;
            // 
            // enableMinimize
            // 
            this.enableMinimize.Location = new System.Drawing.Point(12, 51);
            this.enableMinimize.Name = "enableMinimize";
            this.enableMinimize.Size = new System.Drawing.Size(222, 23);
            this.enableMinimize.TabIndex = 1;
            this.enableMinimize.Text = "Povolit minimalizační tlačítko";
            this.enableMinimize.UseVisualStyleBackColor = true;
            // 
            // blueForm
            // 
            this.blueForm.Location = new System.Drawing.Point(12, 94);
            this.blueForm.Name = "blueForm";
            this.blueForm.Size = new System.Drawing.Size(222, 23);
            this.blueForm.TabIndex = 2;
            this.blueForm.Text = "Modrý formulář";
            this.blueForm.UseVisualStyleBackColor = true;
            // 
            // whiteForm
            // 
            this.whiteForm.Location = new System.Drawing.Point(12, 180);
            this.whiteForm.Name = "whiteForm";
            this.whiteForm.Size = new System.Drawing.Size(222, 23);
            this.whiteForm.TabIndex = 3;
            this.whiteForm.Text = "Bílý formulář a žlutá políčka";
            this.whiteForm.UseVisualStyleBackColor = true;
            // 
            // displayField
            // 
            this.displayField.Location = new System.Drawing.Point(12, 229);
            this.displayField.Name = "displayField";
            this.displayField.Size = new System.Drawing.Size(222, 23);
            this.displayField.TabIndex = 4;
            this.displayField.Text = "Zobrazit text z políčka 1";
            this.displayField.UseVisualStyleBackColor = true;
            // 
            // grayForm
            // 
            this.grayForm.Location = new System.Drawing.Point(12, 136);
            this.grayForm.Name = "grayForm";
            this.grayForm.Size = new System.Drawing.Size(222, 23);
            this.grayForm.TabIndex = 5;
            this.grayForm.Text = "Šedý formulář";
            this.grayForm.UseVisualStyleBackColor = true;
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(12, 273);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(487, 23);
            this.clearAll.TabIndex = 6;
            this.clearAll.Text = "Vymazat všechna políčka a obarvit na bílo";
            this.clearAll.UseVisualStyleBackColor = true;
            // 
            // disableAll
            // 
            this.disableAll.Location = new System.Drawing.Point(277, 12);
            this.disableAll.Name = "disableAll";
            this.disableAll.Size = new System.Drawing.Size(222, 23);
            this.disableAll.TabIndex = 7;
            this.disableAll.Text = "Zakázat všechna políčka";
            this.disableAll.UseVisualStyleBackColor = true;
            // 
            // enableAll
            // 
            this.enableAll.Location = new System.Drawing.Point(277, 51);
            this.enableAll.Name = "enableAll";
            this.enableAll.Size = new System.Drawing.Size(222, 23);
            this.enableAll.TabIndex = 8;
            this.enableAll.Text = "Povolit všechna políčka";
            this.enableAll.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 23);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 23);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 23);
            this.textBox3.TabIndex = 11;
            // 
            // copyField
            // 
            this.copyField.Location = new System.Drawing.Point(277, 229);
            this.copyField.Name = "copyField";
            this.copyField.Size = new System.Drawing.Size(222, 23);
            this.copyField.TabIndex = 12;
            this.copyField.Text = "Zkopírovat text políčka 1 do ostatních";
            this.copyField.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 326);
            this.Controls.Add(this.copyField);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enableAll);
            this.Controls.Add(this.disableAll);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.grayForm);
            this.Controls.Add(this.displayField);
            this.Controls.Add(this.whiteForm);
            this.Controls.Add(this.blueForm);
            this.Controls.Add(this.enableMinimize);
            this.Controls.Add(this.disableMinimize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button disableMinimize;
        private Button enableMinimize;
        private Button blueForm;
        private Button whiteForm;
        private Button displayField;
        private Button grayForm;
        private Button clearAll;
        private Button disableAll;
        private Button enableAll;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button copyField;
    }
}
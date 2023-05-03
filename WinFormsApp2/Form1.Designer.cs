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
            this.calc1Base = new System.Windows.Forms.TextBox();
            this.calc1Exp = new System.Windows.Forms.TextBox();
            this.calc2Base = new System.Windows.Forms.TextBox();
            this.calc2Exp = new System.Windows.Forms.Label();
            this.calc1Btn = new System.Windows.Forms.Button();
            this.calc2Btn = new System.Windows.Forms.Button();
            this.calc1Result = new System.Windows.Forms.TextBox();
            this.calc2Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calc1Base
            // 
            this.calc1Base.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc1Base.Location = new System.Drawing.Point(64, 81);
            this.calc1Base.MaxLength = 4;
            this.calc1Base.Name = "calc1Base";
            this.calc1Base.Size = new System.Drawing.Size(86, 57);
            this.calc1Base.TabIndex = 0;
            // 
            // calc1Exp
            // 
            this.calc1Exp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc1Exp.Location = new System.Drawing.Point(156, 54);
            this.calc1Exp.MaxLength = 2;
            this.calc1Exp.Name = "calc1Exp";
            this.calc1Exp.Size = new System.Drawing.Size(29, 29);
            this.calc1Exp.TabIndex = 2;
            // 
            // calc2Base
            // 
            this.calc2Base.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc2Base.Location = new System.Drawing.Point(64, 253);
            this.calc2Base.MaxLength = 4;
            this.calc2Base.Name = "calc2Base";
            this.calc2Base.Size = new System.Drawing.Size(86, 57);
            this.calc2Base.TabIndex = 3;
            // 
            // calc2Exp
            // 
            this.calc2Exp.AutoSize = true;
            this.calc2Exp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc2Exp.Location = new System.Drawing.Point(156, 235);
            this.calc2Exp.Name = "calc2Exp";
            this.calc2Exp.Size = new System.Drawing.Size(19, 21);
            this.calc2Exp.TabIndex = 4;
            this.calc2Exp.Text = "2";
            // 
            // calc1Btn
            // 
            this.calc1Btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calc1Btn.Location = new System.Drawing.Point(252, 93);
            this.calc1Btn.Name = "calc1Btn";
            this.calc1Btn.Size = new System.Drawing.Size(73, 43);
            this.calc1Btn.TabIndex = 5;
            this.calc1Btn.Text = "=";
            this.calc1Btn.UseVisualStyleBackColor = true;
            // 
            // calc2Btn
            // 
            this.calc2Btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calc2Btn.Location = new System.Drawing.Point(252, 265);
            this.calc2Btn.Name = "calc2Btn";
            this.calc2Btn.Size = new System.Drawing.Size(73, 43);
            this.calc2Btn.TabIndex = 6;
            this.calc2Btn.Text = "=";
            this.calc2Btn.UseVisualStyleBackColor = true;
            // 
            // calc1Result
            // 
            this.calc1Result.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc1Result.Location = new System.Drawing.Point(419, 81);
            this.calc1Result.Name = "calc1Result";
            this.calc1Result.Size = new System.Drawing.Size(191, 57);
            this.calc1Result.TabIndex = 7;
            // 
            // calc2Result
            // 
            this.calc2Result.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc2Result.Location = new System.Drawing.Point(419, 253);
            this.calc2Result.Name = "calc2Result";
            this.calc2Result.Size = new System.Drawing.Size(191, 57);
            this.calc2Result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 398);
            this.Controls.Add(this.calc2Result);
            this.Controls.Add(this.calc1Result);
            this.Controls.Add(this.calc2Btn);
            this.Controls.Add(this.calc1Btn);
            this.Controls.Add(this.calc2Exp);
            this.Controls.Add(this.calc2Base);
            this.Controls.Add(this.calc1Exp);
            this.Controls.Add(this.calc1Base);
            this.Name = "Form1";
            this.Text = "Mocninová kalkulačka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox calc1Base;
        private TextBox calc1Exp;
        private TextBox calc2Base;
        private Label calc2Exp;
        private Button calc1Btn;
        private Button calc2Btn;
        private TextBox calc1Result;
        private TextBox calc2Result;
    }
}
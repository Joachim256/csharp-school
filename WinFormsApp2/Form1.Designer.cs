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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPointCount = new System.Windows.Forms.Label();
            this.labelTurnCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userN4 = new System.Windows.Forms.TextBox();
            this.userN3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userN2 = new System.Windows.Forms.TextBox();
            this.userN1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.compN4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.compN3 = new System.Windows.Forms.TextBox();
            this.compN1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.compN2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.newTurnBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.labelPointCount);
            this.groupBox1.Controls.Add(this.labelTurnCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelPointCount
            // 
            this.labelPointCount.AutoSize = true;
            this.labelPointCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPointCount.Location = new System.Drawing.Point(618, 19);
            this.labelPointCount.Name = "labelPointCount";
            this.labelPointCount.Size = new System.Drawing.Size(90, 17);
            this.labelPointCount.TabIndex = 2;
            this.labelPointCount.Text = "počet bodů: 0";
            // 
            // labelTurnCount
            // 
            this.labelTurnCount.AutoSize = true;
            this.labelTurnCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTurnCount.Location = new System.Drawing.Point(302, 19);
            this.labelTurnCount.Name = "labelTurnCount";
            this.labelTurnCount.Size = new System.Drawing.Size(84, 17);
            this.labelTurnCount.TabIndex = 1;
            this.labelTurnCount.Text = "počet tahů: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program SPORTKA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.userN4);
            this.panel1.Controls.Add(this.userN3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.userN2);
            this.panel1.Controls.Add(this.userN1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 250);
            this.panel1.TabIndex = 1;
            // 
            // userN4
            // 
            this.userN4.Location = new System.Drawing.Point(64, 198);
            this.userN4.Name = "userN4";
            this.userN4.Size = new System.Drawing.Size(100, 23);
            this.userN4.TabIndex = 8;
            this.userN4.Validating += new System.ComponentModel.CancelEventHandler(this.userN4_Validating);
            // 
            // userN3
            // 
            this.userN3.Location = new System.Drawing.Point(64, 157);
            this.userN3.Name = "userN3";
            this.userN3.Size = new System.Drawing.Size(100, 23);
            this.userN3.TabIndex = 7;
            this.userN3.Validating += new System.ComponentModel.CancelEventHandler(this.userN3_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "číslo 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "číslo 3";
            // 
            // userN2
            // 
            this.userN2.Location = new System.Drawing.Point(64, 114);
            this.userN2.Name = "userN2";
            this.userN2.Size = new System.Drawing.Size(100, 23);
            this.userN2.TabIndex = 4;
            this.userN2.Validating += new System.ComponentModel.CancelEventHandler(this.userN2_Validating);
            // 
            // userN1
            // 
            this.userN1.Location = new System.Drawing.Point(64, 73);
            this.userN1.Name = "userN1";
            this.userN1.Size = new System.Drawing.Size(100, 23);
            this.userN1.TabIndex = 3;
            this.userN1.Validating += new System.ComponentModel.CancelEventHandler(this.userN1_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "číslo 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "číslo 1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Čísla zadaná hráčem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.compN4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.compN3);
            this.panel2.Controls.Add(this.compN1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.compN2);
            this.panel2.Location = new System.Drawing.Point(246, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 250);
            this.panel2.TabIndex = 2;
            // 
            // compN4
            // 
            this.compN4.Enabled = false;
            this.compN4.Location = new System.Drawing.Point(83, 195);
            this.compN4.Name = "compN4";
            this.compN4.Size = new System.Drawing.Size(100, 23);
            this.compN4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Čísla generovaná počítačem";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compN3
            // 
            this.compN3.Enabled = false;
            this.compN3.Location = new System.Drawing.Point(83, 154);
            this.compN3.Name = "compN3";
            this.compN3.Size = new System.Drawing.Size(100, 23);
            this.compN3.TabIndex = 15;
            // 
            // compN1
            // 
            this.compN1.Enabled = false;
            this.compN1.Location = new System.Drawing.Point(83, 70);
            this.compN1.Name = "compN1";
            this.compN1.Size = new System.Drawing.Size(100, 23);
            this.compN1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "číslo 4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "číslo 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "číslo 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "číslo 2";
            // 
            // compN2
            // 
            this.compN2.Enabled = false;
            this.compN2.Location = new System.Drawing.Point(83, 111);
            this.compN2.Name = "compN2";
            this.compN2.Size = new System.Drawing.Size(100, 23);
            this.compN2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(480, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 250);
            this.panel3.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(228, 250);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // newTurnBtn
            // 
            this.newTurnBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newTurnBtn.Location = new System.Drawing.Point(76, 320);
            this.newTurnBtn.Name = "newTurnBtn";
            this.newTurnBtn.Size = new System.Drawing.Size(75, 23);
            this.newTurnBtn.TabIndex = 3;
            this.newTurnBtn.Text = "Nový tah";
            this.newTurnBtn.UseVisualStyleBackColor = true;
            this.newTurnBtn.Click += new System.EventHandler(this.newTurnBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 353);
            this.Controls.Add(this.newTurnBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sportka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label labelPointCount;
        private Label labelTurnCount;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private TextBox userN4;
        private TextBox userN3;
        private Label label6;
        private Label label7;
        private TextBox userN2;
        private TextBox userN1;
        private Label label5;
        private Label label4;
        private TextBox compN4;
        private TextBox compN3;
        private TextBox compN1;
        private Label label8;
        private Label label11;
        private Label label9;
        private Label label10;
        private TextBox compN2;
        private Button newTurnBtn;
        private RichTextBox richTextBox1;
        private ErrorProvider errorProvider1;
    }
}
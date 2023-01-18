namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.GroupBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 34);
            this.name.Name = "name";
            this.name.PlaceholderText = "Sem zadejte svoje jméno";
            this.name.Size = new System.Drawing.Size(201, 23);
            this.name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Příjmení";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(12, 79);
            this.surname.Name = "surname";
            this.surname.PlaceholderText = "Sem zadejte svoje jméno";
            this.surname.Size = new System.Drawing.Size(201, 23);
            this.surname.TabIndex = 4;
            // 
            // gender
            // 
            this.gender.Controls.Add(this.female);
            this.gender.Controls.Add(this.male);
            this.gender.Location = new System.Drawing.Point(219, 34);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(86, 68);
            this.gender.TabIndex = 5;
            this.gender.TabStop = false;
            this.gender.Text = "Pohlaví";
            this.gender.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(6, 19);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 20);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "muž";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(6, 42);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(57, 20);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "žena";
            this.female.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Osobní údaje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox name;
        private Button button1;
        private Label label2;
        private TextBox surname;
        private GroupBox gender;
        private RadioButton female;
        private RadioButton male;
    }
}
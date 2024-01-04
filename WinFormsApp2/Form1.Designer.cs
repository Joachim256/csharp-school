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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            labelDate = new Label();
            labelTime = new Label();
            groupBox2 = new GroupBox();
            inputTime = new DateTimePicker();
            btnStartCountdown = new Button();
            labelCountdown = new Label();
            timerCountdown = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelDate);
            groupBox1.Controls.Add(labelTime);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hodiny";
            // 
            // labelDate
            // 
            labelDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(6, 108);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(256, 30);
            labelDate.TabIndex = 1;
            labelDate.Text = " ";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            labelTime.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.Location = new Point(6, 19);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(256, 65);
            labelTime.TabIndex = 0;
            labelTime.Text = "00:00:00";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(inputTime);
            groupBox2.Controls.Add(btnStartCountdown);
            groupBox2.Controls.Add(labelCountdown);
            groupBox2.Location = new Point(286, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(269, 165);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odpočet";
            // 
            // inputTime
            // 
            inputTime.Format = DateTimePickerFormat.Time;
            inputTime.Location = new Point(33, 117);
            inputTime.Name = "inputTime";
            inputTime.ShowUpDown = true;
            inputTime.Size = new Size(96, 23);
            inputTime.TabIndex = 2;
            inputTime.Value = new DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // btnStartCountdown
            // 
            btnStartCountdown.Location = new Point(135, 117);
            btnStartCountdown.Name = "btnStartCountdown";
            btnStartCountdown.Size = new Size(75, 23);
            btnStartCountdown.TabIndex = 1;
            btnStartCountdown.Text = "Start";
            btnStartCountdown.UseVisualStyleBackColor = true;
            btnStartCountdown.Click += btnStartCountdown_Click;
            // 
            // labelCountdown
            // 
            labelCountdown.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelCountdown.Location = new Point(6, 19);
            labelCountdown.Name = "labelCountdown";
            labelCountdown.Size = new Size(256, 65);
            labelCountdown.TabIndex = 0;
            labelCountdown.Text = "00:00.000";
            labelCountdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerCountdown
            // 
            timerCountdown.Interval = 1;
            timerCountdown.Tick += timerCountdown_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Aplikace Hodiny";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private Label labelDate;
        private Label labelTime;
        private GroupBox groupBox2;
        private Label labelCountdown;
        private System.Windows.Forms.Timer timerCountdown;
        private Button btnStartCountdown;
        private DateTimePicker inputTime;
    }
}
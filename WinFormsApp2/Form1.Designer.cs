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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jumpSize = new System.Windows.Forms.NumericUpDown();
            this.jumpSpeed = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button = new System.Windows.Forms.Button();
            this.fly = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.jumpSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "velikost skoku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "rychlost skoku";
            // 
            // jumpSize
            // 
            this.jumpSize.Location = new System.Drawing.Point(99, 7);
            this.jumpSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.jumpSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumpSize.Name = "jumpSize";
            this.jumpSize.Size = new System.Drawing.Size(50, 23);
            this.jumpSize.TabIndex = 2;
            this.jumpSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumpSize.ValueChanged += new System.EventHandler(this.jumpSize_ValueChanged);
            // 
            // jumpSpeed
            // 
            this.jumpSpeed.Location = new System.Drawing.Point(244, 7);
            this.jumpSpeed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.jumpSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumpSpeed.Name = "jumpSpeed";
            this.jumpSpeed.Size = new System.Drawing.Size(50, 23);
            this.jumpSpeed.TabIndex = 3;
            this.jumpSpeed.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.jumpSpeed.ValueChanged += new System.EventHandler(this.jumpSpeed_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Right;
            this.button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button.Location = new System.Drawing.Point(909, 5);
            this.button.Margin = new System.Windows.Forms.Padding(10);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(88, 34);
            this.button.TabIndex = 4;
            this.button.Text = "Start / Stop";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // fly
            // 
            this.fly.Image = ((System.Drawing.Image)(resources.GetObject("fly.Image")));
            this.fly.Location = new System.Drawing.Point(3, 3);
            this.fly.Name = "fly";
            this.fly.Size = new System.Drawing.Size(60, 60);
            this.fly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fly.TabIndex = 0;
            this.fly.TabStop = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.fly);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1002, 411);
            this.panel.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.button);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.jumpSize);
            this.splitContainer1.Panel1.Controls.Add(this.jumpSpeed);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 454);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 454);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.jumpSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly)).EndInit();
            this.panel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown jumpSize;
        private NumericUpDown jumpSpeed;
        private System.Windows.Forms.Timer timer1;
        private Button button;
        private PictureBox fly;
        private Panel panel;
        private SplitContainer splitContainer1;
    }
}
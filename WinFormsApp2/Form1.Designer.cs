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
            this.grid = new System.Windows.Forms.DataGridView();
            this.animationMode1 = new System.Windows.Forms.RadioButton();
            this.animationMode2 = new System.Windows.Forms.RadioButton();
            this.animationStartBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.animationStatusIco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.animationSpeedInput = new System.Windows.Forms.NumericUpDown();
            this.animationStopBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.animationStepBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.generateCellsBtn = new System.Windows.Forms.Button();
            this.generateCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedInput)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateCount)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.ColumnHeadersVisible = false;
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid.Enabled = false;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 25;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.Size = new System.Drawing.Size(500, 500);
            this.grid.TabIndex = 0;
            // 
            // animationMode1
            // 
            this.animationMode1.AutoSize = true;
            this.animationMode1.Checked = true;
            this.animationMode1.Location = new System.Drawing.Point(522, 12);
            this.animationMode1.Name = "animationMode1";
            this.animationMode1.Size = new System.Drawing.Size(83, 19);
            this.animationMode1.TabIndex = 2;
            this.animationMode1.TabStop = true;
            this.animationMode1.Text = "samovolně";
            this.animationMode1.UseVisualStyleBackColor = true;
            this.animationMode1.CheckedChanged += new System.EventHandler(this.animationMode1_CheckedChanged);
            // 
            // animationMode2
            // 
            this.animationMode2.AutoSize = true;
            this.animationMode2.Location = new System.Drawing.Point(725, 12);
            this.animationMode2.Name = "animationMode2";
            this.animationMode2.Size = new System.Drawing.Size(78, 19);
            this.animationMode2.TabIndex = 3;
            this.animationMode2.Text = "manuálně";
            this.animationMode2.UseVisualStyleBackColor = true;
            this.animationMode2.CheckedChanged += new System.EventHandler(this.animationMode2_CheckedChanged);
            // 
            // animationStartBtn
            // 
            this.animationStartBtn.Location = new System.Drawing.Point(16, 16);
            this.animationStartBtn.Name = "animationStartBtn";
            this.animationStartBtn.Size = new System.Drawing.Size(75, 23);
            this.animationStartBtn.TabIndex = 4;
            this.animationStartBtn.Text = "Start";
            this.animationStartBtn.UseVisualStyleBackColor = true;
            this.animationStartBtn.Click += new System.EventHandler(this.animationStartBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.animationStatusIco);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.animationSpeedInput);
            this.panel1.Controls.Add(this.animationStopBtn);
            this.panel1.Controls.Add(this.animationStartBtn);
            this.panel1.Location = new System.Drawing.Point(522, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 213);
            this.panel1.TabIndex = 6;
            // 
            // animationStatusIco
            // 
            this.animationStatusIco.BackColor = System.Drawing.Color.Red;
            this.animationStatusIco.Location = new System.Drawing.Point(114, 29);
            this.animationStatusIco.Name = "animationStatusIco";
            this.animationStatusIco.Size = new System.Drawing.Size(22, 23);
            this.animationStatusIco.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rychlost";
            // 
            // animationSpeedInput
            // 
            this.animationSpeedInput.Location = new System.Drawing.Point(16, 93);
            this.animationSpeedInput.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.animationSpeedInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.animationSpeedInput.Name = "animationSpeedInput";
            this.animationSpeedInput.Size = new System.Drawing.Size(120, 23);
            this.animationSpeedInput.TabIndex = 5;
            this.animationSpeedInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.animationSpeedInput.ValueChanged += new System.EventHandler(this.animationSpeedInput_ValueChanged);
            // 
            // animationStopBtn
            // 
            this.animationStopBtn.Enabled = false;
            this.animationStopBtn.Location = new System.Drawing.Point(16, 45);
            this.animationStopBtn.Name = "animationStopBtn";
            this.animationStopBtn.Size = new System.Drawing.Size(75, 23);
            this.animationStopBtn.TabIndex = 4;
            this.animationStopBtn.Text = "Stop";
            this.animationStopBtn.UseVisualStyleBackColor = true;
            this.animationStopBtn.Click += new System.EventHandler(this.animationStopBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.animationStepBtn);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(695, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 213);
            this.panel2.TabIndex = 7;
            // 
            // animationStepBtn
            // 
            this.animationStepBtn.Location = new System.Drawing.Point(18, 16);
            this.animationStepBtn.Name = "animationStepBtn";
            this.animationStepBtn.Size = new System.Drawing.Size(75, 23);
            this.animationStepBtn.TabIndex = 6;
            this.animationStepBtn.Text = "Krok";
            this.animationStepBtn.UseVisualStyleBackColor = true;
            this.animationStepBtn.Click += new System.EventHandler(this.animationStepBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // generateCellsBtn
            // 
            this.generateCellsBtn.Location = new System.Drawing.Point(522, 309);
            this.generateCellsBtn.Name = "generateCellsBtn";
            this.generateCellsBtn.Size = new System.Drawing.Size(157, 34);
            this.generateCellsBtn.TabIndex = 8;
            this.generateCellsBtn.Text = "Generovat buňky";
            this.generateCellsBtn.UseVisualStyleBackColor = true;
            this.generateCellsBtn.Click += new System.EventHandler(this.generateCellsBtn_Click);
            // 
            // generateCount
            // 
            this.generateCount.Location = new System.Drawing.Point(522, 280);
            this.generateCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.generateCount.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.generateCount.Name = "generateCount";
            this.generateCount.Size = new System.Drawing.Size(83, 23);
            this.generateCount.TabIndex = 9;
            this.generateCount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 527);
            this.Controls.Add(this.generateCount);
            this.Controls.Add(this.generateCellsBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.animationMode2);
            this.Controls.Add(this.animationMode1);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "C#nway\'s game of life";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedInput)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generateCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView grid;
        private RadioButton animationMode1;
        private RadioButton animationMode2;
        private Button animationStartBtn;
        private Panel panel1;
        private Button animationStopBtn;
        private Panel panel2;
        private Label label2;
        private NumericUpDown animationSpeedInput;
        private Button animationStepBtn;
        private System.Windows.Forms.Timer timer1;
        private Label animationStatusIco;
        private Button generateCellsBtn;
        private NumericUpDown generateCount;
    }
}
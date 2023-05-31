namespace WinFormsApp2
{
    partial class ZapalkyForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            player2Name = new Label();
            panel2 = new Panel();
            player1Name = new Label();
            label3 = new Label();
            label4 = new Label();
            player1Score = new Label();
            player2Score = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.8888855F));
            tableLayoutPanel1.Size = new Size(728, 439);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(722, 367);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 60);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(player2Score);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(player2Name);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(522, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 60);
            panel3.TabIndex = 2;
            // 
            // player2Name
            // 
            player2Name.AutoSize = true;
            player2Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            player2Name.Location = new Point(3, 6);
            player2Name.Name = "player2Name";
            player2Name.Size = new Size(55, 21);
            player2Name.TabIndex = 1;
            player2Name.Text = "Hráč 2";
            // 
            // panel2
            // 
            panel2.Controls.Add(player1Score);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(player1Name);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 60);
            panel2.TabIndex = 1;
            // 
            // player1Name
            // 
            player1Name.AutoSize = true;
            player1Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            player1Name.Location = new Point(9, 6);
            player1Name.Name = "player1Name";
            player1Name.Size = new Size(55, 21);
            player1Name.TabIndex = 0;
            player1Name.Text = "Hráč 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 32);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 1;
            label3.Text = "Skóre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 32);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Skóre:";
            // 
            // player1Score
            // 
            player1Score.AutoSize = true;
            player1Score.Location = new Point(54, 32);
            player1Score.Name = "player1Score";
            player1Score.Size = new Size(13, 15);
            player1Score.TabIndex = 2;
            player1Score.Text = "0";
            // 
            // player2Score
            // 
            player2Score.AutoSize = true;
            player2Score.Location = new Point(48, 32);
            player2Score.Name = "player2Score";
            player2Score.Size = new Size(13, 15);
            player2Score.TabIndex = 3;
            player2Score.Text = "0";
            // 
            // ZapalkyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 439);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(535, 370);
            Name = "ZapalkyForm";
            Text = "Zápalkovaná";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Label player1Name;
        private Panel panel3;
        private Label player2Name;
        private Label label3;
        private Label label4;
        private Label player1Score;
        private Label player2Score;
    }
}
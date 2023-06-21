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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gameGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.player2Score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player1Score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player1Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gameGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 439);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gameGrid
            // 
            this.gameGrid.AllowUserToAddRows = false;
            this.gameGrid.AllowUserToDeleteRows = false;
            this.gameGrid.AllowUserToResizeColumns = false;
            this.gameGrid.AllowUserToResizeRows = false;
            this.gameGrid.CausesValidation = false;
            this.gameGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameGrid.ColumnHeadersVisible = false;
            this.gameGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gameGrid.EnableHeadersVisualStyles = false;
            this.gameGrid.Location = new System.Drawing.Point(3, 69);
            this.gameGrid.MultiSelect = false;
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.ReadOnly = true;
            this.gameGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gameGrid.RowHeadersVisible = false;
            this.gameGrid.RowTemplate.Height = 25;
            this.gameGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gameGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gameGrid.ShowCellErrors = false;
            this.gameGrid.ShowCellToolTips = false;
            this.gameGrid.ShowEditingIcon = false;
            this.gameGrid.ShowRowErrors = false;
            this.gameGrid.Size = new System.Drawing.Size(722, 367);
            this.gameGrid.TabIndex = 0;
            this.gameGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameGrid_CellClick);
            this.gameGrid.SelectionChanged += new System.EventHandler(this.gameGrid_SelectionChanged);
            this.gameGrid.SizeChanged += new System.EventHandler(this.gameGrid_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.player2Score);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.player2Name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(522, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 60);
            this.panel3.TabIndex = 2;
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Location = new System.Drawing.Point(48, 32);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(13, 15);
            this.player2Score.TabIndex = 3;
            this.player2Score.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Skóre:";
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2Name.Location = new System.Drawing.Point(3, 6);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(55, 21);
            this.player2Name.TabIndex = 1;
            this.player2Name.Text = "Hráč 2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.player1Score);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.player1Name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 60);
            this.panel2.TabIndex = 1;
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.Location = new System.Drawing.Point(54, 32);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(13, 15);
            this.player1Score.TabIndex = 2;
            this.player1Score.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Skóre:";
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1Name.Location = new System.Drawing.Point(9, 6);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(55, 21);
            this.player1Name.TabIndex = 0;
            this.player1Name.Text = "Hráč 1";
            // 
            // ZapalkyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 439);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(535, 370);
            this.Name = "ZapalkyForm";
            this.Text = "Zápalkovaná";
            this.Load += new System.EventHandler(this.ZapalkyForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView gameGrid;
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
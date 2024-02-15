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
            labelAuto = new Label();
            tankProgress = new ProgressBar();
            label1 = new Label();
            labelKm = new Label();
            radioButtonCar1 = new RadioButton();
            radioButtonCar2 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            driveInput = new NumericUpDown();
            tankInput = new NumericUpDown();
            driveBtn = new Button();
            tankBtn = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)driveInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tankInput).BeginInit();
            SuspendLayout();
            // 
            // labelAuto
            // 
            labelAuto.AutoSize = true;
            labelAuto.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAuto.Location = new Point(17, 9);
            labelAuto.Name = "labelAuto";
            labelAuto.Size = new Size(84, 40);
            labelAuto.TabIndex = 0;
            labelAuto.Text = "Auto";
            // 
            // tankProgress
            // 
            tankProgress.Location = new Point(12, 100);
            tankProgress.Name = "tankProgress";
            tankProgress.Size = new Size(190, 55);
            tankProgress.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 158);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 2;
            label1.Text = "Najeto: ";
            // 
            // labelKm
            // 
            labelKm.AutoSize = true;
            labelKm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelKm.Location = new Point(81, 158);
            labelKm.Name = "labelKm";
            labelKm.Size = new Size(45, 21);
            labelKm.TabIndex = 3;
            labelKm.Text = "0 km";
            // 
            // radioButtonCar1
            // 
            radioButtonCar1.AutoSize = true;
            radioButtonCar1.Checked = true;
            radioButtonCar1.Location = new Point(20, 279);
            radioButtonCar1.Name = "radioButtonCar1";
            radioButtonCar1.Size = new Size(55, 19);
            radioButtonCar1.TabIndex = 4;
            radioButtonCar1.TabStop = true;
            radioButtonCar1.Text = "auto1";
            radioButtonCar1.UseVisualStyleBackColor = true;
            // 
            // radioButtonCar2
            // 
            radioButtonCar2.AutoSize = true;
            radioButtonCar2.Location = new Point(20, 304);
            radioButtonCar2.Name = "radioButtonCar2";
            radioButtonCar2.Size = new Size(55, 19);
            radioButtonCar2.TabIndex = 5;
            radioButtonCar2.TabStop = true;
            radioButtonCar2.Text = "auto2";
            radioButtonCar2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 261);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Přepínač aut:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(225, 158);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 7;
            label3.Text = "Ujet km:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(225, 190);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 8;
            label4.Text = "Natankovat l:";
            // 
            // driveInput
            // 
            driveInput.Location = new Point(332, 161);
            driveInput.Name = "driveInput";
            driveInput.Size = new Size(120, 23);
            driveInput.TabIndex = 9;
            // 
            // tankInput
            // 
            tankInput.Location = new Point(332, 193);
            tankInput.Name = "tankInput";
            tankInput.Size = new Size(120, 23);
            tankInput.TabIndex = 10;
            // 
            // driveBtn
            // 
            driveBtn.Location = new Point(458, 161);
            driveBtn.Name = "driveBtn";
            driveBtn.Size = new Size(75, 23);
            driveBtn.TabIndex = 11;
            driveBtn.Text = "Jet";
            driveBtn.UseVisualStyleBackColor = true;
            // 
            // tankBtn
            // 
            tankBtn.Location = new Point(458, 193);
            tankBtn.Name = "tankBtn";
            tankBtn.Size = new Size(75, 23);
            tankBtn.TabIndex = 12;
            tankBtn.Text = "Tankovat";
            tankBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 82);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 13;
            label5.Text = "Nádrž";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 366);
            Controls.Add(label5);
            Controls.Add(tankBtn);
            Controls.Add(driveBtn);
            Controls.Add(tankInput);
            Controls.Add(driveInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButtonCar2);
            Controls.Add(radioButtonCar1);
            Controls.Add(labelKm);
            Controls.Add(label1);
            Controls.Add(tankProgress);
            Controls.Add(labelAuto);
            Name = "Form1";
            Text = "Autodoprava";
            ((System.ComponentModel.ISupportInitialize)driveInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)tankInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAuto;
        private ProgressBar tankProgress;
        private Label label1;
        private Label labelKm;
        private RadioButton radioButtonCar1;
        private RadioButton radioButtonCar2;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown driveInput;
        private NumericUpDown tankInput;
        private Button driveBtn;
        private Button tankBtn;
        private Label label5;
    }
}
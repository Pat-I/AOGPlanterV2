namespace AOGPlanterV2
{
    partial class AdvancedSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnSendFertilizerWeight = new Button();
            btnFertilizerZero = new Button();
            numFertilizerWeight = new NumericUpDown();
            btnClose = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            lblHeightVoltage = new Label();
            btnHeightTop = new Button();
            btnHeightOff = new Button();
            btnHeightOn = new Button();
            btnHeightZero = new Button();
            lblHeightOff = new Label();
            lblHeightOn = new Label();
            lblHeight = new Label();
            label3 = new Label();
            lblVaccum1Voltage = new Label();
            lblVaccum2Voltage = new Label();
            btnVaccum1Zero = new Button();
            btnVaccum2Zero = new Button();
            btnVaccum1set = new Button();
            btnVaccum2set = new Button();
            numDownforceWeight1 = new NumericUpDown();
            btnDownforceZero1 = new Button();
            btnDownforceSet1 = new Button();
            label4 = new Label();
            numDownforceWeight2 = new NumericUpDown();
            btnDownforceZero2 = new Button();
            btnDownforceSet2 = new Button();
            label5 = new Label();
            numDownforceWeight3 = new NumericUpDown();
            btnDownforceZero3 = new Button();
            btnDownforceSet3 = new Button();
            label6 = new Label();
            btnAirPressureSet = new Button();
            btnAirPressureZero = new Button();
            lblAirPressureVoltage = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numFertilizerWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDownforceWeight1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDownforceWeight2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDownforceWeight3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 38);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "enter fertilizer weight";
            // 
            // btnSendFertilizerWeight
            // 
            btnSendFertilizerWeight.Location = new Point(21, 106);
            btnSendFertilizerWeight.Name = "btnSendFertilizerWeight";
            btnSendFertilizerWeight.Size = new Size(75, 23);
            btnSendFertilizerWeight.TabIndex = 1;
            btnSendFertilizerWeight.Text = "Send";
            btnSendFertilizerWeight.UseVisualStyleBackColor = true;
            btnSendFertilizerWeight.Click += btnSendFertilizerWeight_Click;
            // 
            // btnFertilizerZero
            // 
            btnFertilizerZero.Location = new Point(21, 12);
            btnFertilizerZero.Name = "btnFertilizerZero";
            btnFertilizerZero.Size = new Size(75, 23);
            btnFertilizerZero.TabIndex = 2;
            btnFertilizerZero.Text = "Zero";
            btnFertilizerZero.UseVisualStyleBackColor = true;
            btnFertilizerZero.Click += btnFertilizerZero_Click;
            // 
            // numFertilizerWeight
            // 
            numFertilizerWeight.Location = new Point(21, 56);
            numFertilizerWeight.Maximum = new decimal(new int[] { 32000, 0, 0, 0 });
            numFertilizerWeight.Name = "numFertilizerWeight";
            numFertilizerWeight.Size = new Size(75, 23);
            numFertilizerWeight.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(597, 326);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 12);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 5;
            label2.Text = "height sensor";
            // 
            // lblHeightVoltage
            // 
            lblHeightVoltage.Location = new Point(132, 27);
            lblHeightVoltage.Name = "lblHeightVoltage";
            lblHeightVoltage.Size = new Size(50, 26);
            lblHeightVoltage.TabIndex = 6;
            lblHeightVoltage.Text = "- V";
            lblHeightVoltage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnHeightTop
            // 
            btnHeightTop.Location = new Point(135, 56);
            btnHeightTop.Name = "btnHeightTop";
            btnHeightTop.Size = new Size(75, 23);
            btnHeightTop.TabIndex = 7;
            btnHeightTop.Text = "Top";
            btnHeightTop.UseVisualStyleBackColor = true;
            btnHeightTop.Click += btnHeightTop_Click;
            // 
            // btnHeightOff
            // 
            btnHeightOff.Location = new Point(135, 96);
            btnHeightOff.Name = "btnHeightOff";
            btnHeightOff.Size = new Size(75, 23);
            btnHeightOff.TabIndex = 8;
            btnHeightOff.Text = "Off Thresh";
            btnHeightOff.UseVisualStyleBackColor = true;
            btnHeightOff.Click += btnHeightOff_Click;
            // 
            // btnHeightOn
            // 
            btnHeightOn.Location = new Point(135, 137);
            btnHeightOn.Name = "btnHeightOn";
            btnHeightOn.Size = new Size(75, 23);
            btnHeightOn.TabIndex = 9;
            btnHeightOn.Text = "On Thresh";
            btnHeightOn.UseVisualStyleBackColor = true;
            btnHeightOn.Click += btnHeightOn_Click;
            // 
            // btnHeightZero
            // 
            btnHeightZero.Location = new Point(135, 183);
            btnHeightZero.Name = "btnHeightZero";
            btnHeightZero.Size = new Size(75, 23);
            btnHeightZero.TabIndex = 10;
            btnHeightZero.Text = "Zero";
            btnHeightZero.UseVisualStyleBackColor = true;
            btnHeightZero.Click += btnHeightZero_Click;
            // 
            // lblHeightOff
            // 
            lblHeightOff.Location = new Point(216, 93);
            lblHeightOff.Name = "lblHeightOff";
            lblHeightOff.Size = new Size(50, 26);
            lblHeightOff.TabIndex = 11;
            lblHeightOff.Text = "- -";
            lblHeightOff.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHeightOn
            // 
            lblHeightOn.Location = new Point(216, 135);
            lblHeightOn.Name = "lblHeightOn";
            lblHeightOn.Size = new Size(50, 26);
            lblHeightOn.TabIndex = 12;
            lblHeightOn.Text = "- -";
            lblHeightOn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHeight
            // 
            lblHeight.Location = new Point(216, 54);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(50, 26);
            lblHeight.TabIndex = 13;
            lblHeight.Text = "- -";
            lblHeight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 220);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 14;
            label3.Text = "1- VACCUM -2";
            // 
            // lblVaccum1Voltage
            // 
            lblVaccum1Voltage.Location = new Point(35, 235);
            lblVaccum1Voltage.Name = "lblVaccum1Voltage";
            lblVaccum1Voltage.Size = new Size(50, 26);
            lblVaccum1Voltage.TabIndex = 15;
            lblVaccum1Voltage.Text = "- V";
            lblVaccum1Voltage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVaccum2Voltage
            // 
            lblVaccum2Voltage.Location = new Point(119, 235);
            lblVaccum2Voltage.Name = "lblVaccum2Voltage";
            lblVaccum2Voltage.Size = new Size(50, 26);
            lblVaccum2Voltage.TabIndex = 16;
            lblVaccum2Voltage.Text = "- V";
            lblVaccum2Voltage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnVaccum1Zero
            // 
            btnVaccum1Zero.Location = new Point(21, 264);
            btnVaccum1Zero.Name = "btnVaccum1Zero";
            btnVaccum1Zero.Size = new Size(75, 23);
            btnVaccum1Zero.TabIndex = 17;
            btnVaccum1Zero.Text = "Zero";
            btnVaccum1Zero.UseVisualStyleBackColor = true;
            btnVaccum1Zero.Click += btnVaccum1Zero_Click;
            // 
            // btnVaccum2Zero
            // 
            btnVaccum2Zero.Location = new Point(132, 264);
            btnVaccum2Zero.Name = "btnVaccum2Zero";
            btnVaccum2Zero.Size = new Size(75, 23);
            btnVaccum2Zero.TabIndex = 18;
            btnVaccum2Zero.Text = "Zero";
            btnVaccum2Zero.UseVisualStyleBackColor = true;
            btnVaccum2Zero.Click += btnVaccum2Zero_Click;
            // 
            // btnVaccum1set
            // 
            btnVaccum1set.Location = new Point(21, 315);
            btnVaccum1set.Name = "btnVaccum1set";
            btnVaccum1set.Size = new Size(75, 23);
            btnVaccum1set.TabIndex = 19;
            btnVaccum1set.Text = "Set 18 inW";
            btnVaccum1set.UseVisualStyleBackColor = true;
            btnVaccum1set.Click += btnVaccum1set_Click;
            // 
            // btnVaccum2set
            // 
            btnVaccum2set.Location = new Point(132, 315);
            btnVaccum2set.Name = "btnVaccum2set";
            btnVaccum2set.Size = new Size(75, 23);
            btnVaccum2set.TabIndex = 20;
            btnVaccum2set.TabStop = false;
            btnVaccum2set.Text = "Set 18 inW";
            btnVaccum2set.UseVisualStyleBackColor = true;
            btnVaccum2set.Click += btnVaccum2set_Click;
            // 
            // numDownforceWeight1
            // 
            numDownforceWeight1.Location = new Point(333, 56);
            numDownforceWeight1.Maximum = new decimal(new int[] { 254, 0, 0, 0 });
            numDownforceWeight1.Name = "numDownforceWeight1";
            numDownforceWeight1.Size = new Size(75, 23);
            numDownforceWeight1.TabIndex = 24;
            numDownforceWeight1.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // btnDownforceZero1
            // 
            btnDownforceZero1.Location = new Point(333, 12);
            btnDownforceZero1.Name = "btnDownforceZero1";
            btnDownforceZero1.Size = new Size(75, 23);
            btnDownforceZero1.TabIndex = 23;
            btnDownforceZero1.Text = "Zero";
            btnDownforceZero1.UseVisualStyleBackColor = true;
            btnDownforceZero1.Click += btnDownforceZero1_Click;
            // 
            // btnDownforceSet1
            // 
            btnDownforceSet1.Location = new Point(333, 106);
            btnDownforceSet1.Name = "btnDownforceSet1";
            btnDownforceSet1.Size = new Size(75, 23);
            btnDownforceSet1.TabIndex = 22;
            btnDownforceSet1.Text = "Send";
            btnDownforceSet1.UseVisualStyleBackColor = true;
            btnDownforceSet1.Click += btnDownforceSet1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 38);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 21;
            label4.Text = "enter unit weight";
            // 
            // numDownforceWeight2
            // 
            numDownforceWeight2.Location = new Point(455, 56);
            numDownforceWeight2.Maximum = new decimal(new int[] { 254, 0, 0, 0 });
            numDownforceWeight2.Name = "numDownforceWeight2";
            numDownforceWeight2.Size = new Size(75, 23);
            numDownforceWeight2.TabIndex = 28;
            numDownforceWeight2.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // btnDownforceZero2
            // 
            btnDownforceZero2.Location = new Point(455, 12);
            btnDownforceZero2.Name = "btnDownforceZero2";
            btnDownforceZero2.Size = new Size(75, 23);
            btnDownforceZero2.TabIndex = 27;
            btnDownforceZero2.Text = "Zero";
            btnDownforceZero2.UseVisualStyleBackColor = true;
            btnDownforceZero2.Click += btnDownforceZero2_Click;
            // 
            // btnDownforceSet2
            // 
            btnDownforceSet2.Location = new Point(455, 106);
            btnDownforceSet2.Name = "btnDownforceSet2";
            btnDownforceSet2.Size = new Size(75, 23);
            btnDownforceSet2.TabIndex = 26;
            btnDownforceSet2.Text = "Send";
            btnDownforceSet2.UseVisualStyleBackColor = true;
            btnDownforceSet2.Click += btnDownforceSet2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 38);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 25;
            label5.Text = "enter unit weight";
            // 
            // numDownforceWeight3
            // 
            numDownforceWeight3.Location = new Point(575, 56);
            numDownforceWeight3.Maximum = new decimal(new int[] { 254, 0, 0, 0 });
            numDownforceWeight3.Name = "numDownforceWeight3";
            numDownforceWeight3.Size = new Size(75, 23);
            numDownforceWeight3.TabIndex = 32;
            numDownforceWeight3.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // btnDownforceZero3
            // 
            btnDownforceZero3.Location = new Point(575, 12);
            btnDownforceZero3.Name = "btnDownforceZero3";
            btnDownforceZero3.Size = new Size(75, 23);
            btnDownforceZero3.TabIndex = 31;
            btnDownforceZero3.Text = "Zero";
            btnDownforceZero3.UseVisualStyleBackColor = true;
            btnDownforceZero3.Click += btnDownforceZero3_Click;
            // 
            // btnDownforceSet3
            // 
            btnDownforceSet3.Location = new Point(575, 106);
            btnDownforceSet3.Name = "btnDownforceSet3";
            btnDownforceSet3.Size = new Size(75, 23);
            btnDownforceSet3.TabIndex = 30;
            btnDownforceSet3.Text = "Send";
            btnDownforceSet3.UseVisualStyleBackColor = true;
            btnDownforceSet3.Click += btnDownforceSet3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 38);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 29;
            label6.Text = "enter unit weight";
            // 
            // btnAirPressureSet
            // 
            btnAirPressureSet.Location = new Point(231, 315);
            btnAirPressureSet.Name = "btnAirPressureSet";
            btnAirPressureSet.Size = new Size(75, 23);
            btnAirPressureSet.TabIndex = 36;
            btnAirPressureSet.Text = "Set 40 PSI";
            btnAirPressureSet.UseVisualStyleBackColor = true;
            btnAirPressureSet.Click += btnAirPressureSet_Click;
            // 
            // btnAirPressureZero
            // 
            btnAirPressureZero.Location = new Point(231, 264);
            btnAirPressureZero.Name = "btnAirPressureZero";
            btnAirPressureZero.Size = new Size(75, 23);
            btnAirPressureZero.TabIndex = 35;
            btnAirPressureZero.Text = "Zero";
            btnAirPressureZero.UseVisualStyleBackColor = true;
            btnAirPressureZero.Click += btnAirPressureZero_Click;
            // 
            // lblAirPressureVoltage
            // 
            lblAirPressureVoltage.Location = new Point(245, 235);
            lblAirPressureVoltage.Name = "lblAirPressureVoltage";
            lblAirPressureVoltage.Size = new Size(50, 26);
            lblAirPressureVoltage.TabIndex = 34;
            lblAirPressureVoltage.Text = "- V";
            lblAirPressureVoltage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(231, 220);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 33;
            label8.Text = "Air Pressure";
            // 
            // AdvancedSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(btnAirPressureSet);
            Controls.Add(btnAirPressureZero);
            Controls.Add(lblAirPressureVoltage);
            Controls.Add(label8);
            Controls.Add(numDownforceWeight3);
            Controls.Add(btnDownforceZero3);
            Controls.Add(btnDownforceSet3);
            Controls.Add(label6);
            Controls.Add(numDownforceWeight2);
            Controls.Add(btnDownforceZero2);
            Controls.Add(btnDownforceSet2);
            Controls.Add(label5);
            Controls.Add(numDownforceWeight1);
            Controls.Add(btnDownforceZero1);
            Controls.Add(btnDownforceSet1);
            Controls.Add(label4);
            Controls.Add(btnVaccum2set);
            Controls.Add(btnVaccum1set);
            Controls.Add(btnVaccum2Zero);
            Controls.Add(btnVaccum1Zero);
            Controls.Add(lblVaccum2Voltage);
            Controls.Add(lblVaccum1Voltage);
            Controls.Add(label3);
            Controls.Add(lblHeight);
            Controls.Add(lblHeightOn);
            Controls.Add(lblHeightOff);
            Controls.Add(btnHeightZero);
            Controls.Add(btnHeightOn);
            Controls.Add(btnHeightOff);
            Controls.Add(btnHeightTop);
            Controls.Add(lblHeightVoltage);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(numFertilizerWeight);
            Controls.Add(btnFertilizerZero);
            Controls.Add(btnSendFertilizerWeight);
            Controls.Add(label1);
            Name = "AdvancedSettingsForm";
            Text = "AdvancedSettingsForm";
            ((System.ComponentModel.ISupportInitialize)numFertilizerWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDownforceWeight1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDownforceWeight2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDownforceWeight3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSendFertilizerWeight;
        private Button btnFertilizerZero;
        private NumericUpDown numFertilizerWeight;
        private Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label lblHeightVoltage;
        private Button btnHeightTop;
        private Button btnHeightOff;
        private Button btnHeightOn;
        private Button btnHeightZero;
        private Label lblHeightOff;
        private Label lblHeightOn;
        private Label lblHeight;
        private Label label3;
        private Label lblVaccum1Voltage;
        private Label lblVaccum2Voltage;
        private Button btnVaccum1Zero;
        private Button btnVaccum2Zero;
        private Button btnVaccum1set;
        private Button btnVaccum2set;
        private NumericUpDown numDownforceWeight1;
        private Button btnDownforceZero1;
        private Button btnDownforceSet1;
        private Label label4;
        private NumericUpDown numDownforceWeight2;
        private Button btnDownforceZero2;
        private Button btnDownforceSet2;
        private Label label5;
        private NumericUpDown numDownforceWeight3;
        private Button btnDownforceZero3;
        private Button btnDownforceSet3;
        private Label label6;
        private Button btnAirPressureSet;
        private Button btnAirPressureZero;
        private Label lblAirPressureVoltage;
        private Label label8;
    }
}
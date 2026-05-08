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
            label1 = new Label();
            btnSendFertilizerWeight = new Button();
            btnFertilizerZero = new Button();
            numFertilizerWeight = new NumericUpDown();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)numFertilizerWeight).BeginInit();
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
            // AdvancedSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(btnClose);
            Controls.Add(numFertilizerWeight);
            Controls.Add(btnFertilizerZero);
            Controls.Add(btnSendFertilizerWeight);
            Controls.Add(label1);
            Name = "AdvancedSettingsForm";
            Text = "AdvancedSettingsForm";
            ((System.ComponentModel.ISupportInitialize)numFertilizerWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSendFertilizerWeight;
        private Button btnFertilizerZero;
        private NumericUpDown numFertilizerWeight;
        private Button btnClose;
    }
}
namespace AOGPlanterV2
{
    partial class FormAOP
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
            lblPopulation = new Button();
            txtPopulation = new Label();
            lblSingulation = new Label();
            txtSingulation = new Label();
            lblSkipPercent = new Label();
            txtSkips = new Label();
            lblDoublesPercent = new Label();
            txtDoubles = new Label();
            lblDisconnected = new Label();
            btnSetUp = new Button();
            btn_disagree = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            btnFertilizer1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnFertilizer2 = new Button();
            btnFertilizer3 = new Button();
            btnFertilizer4 = new Button();
            btnFertilizer5 = new Button();
            btnFertilizer6 = new Button();
            btnFertilizer7 = new Button();
            btnFertilizer8 = new Button();
            lblFertilizerWeight = new Label();
            lblVaccum1 = new Label();
            lblVaccum2 = new Label();
            lblDwPressure = new Label();
            lblDownforce1 = new Label();
            lblDownforce2 = new Label();
            lblDownforce3 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPopulation
            // 
            lblPopulation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPopulation.AutoSize = true;
            lblPopulation.BackColor = Color.Yellow;
            lblPopulation.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPopulation.ForeColor = SystemColors.ActiveCaptionText;
            lblPopulation.Location = new Point(1300, 50);
            lblPopulation.Margin = new Padding(0);
            lblPopulation.Name = "lblPopulation";
            lblPopulation.Size = new Size(150, 45);
            lblPopulation.TabIndex = 0;
            lblPopulation.Text = "125,000";
            lblPopulation.UseVisualStyleBackColor = false;
            lblPopulation.Click += lblPopulation_Click_1;
            // 
            // txtPopulation
            // 
            txtPopulation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPopulation.BackColor = Color.WhiteSmoke;
            txtPopulation.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPopulation.ForeColor = SystemColors.ActiveCaptionText;
            txtPopulation.Location = new Point(1300, 95);
            txtPopulation.Margin = new Padding(4, 0, 4, 0);
            txtPopulation.Name = "txtPopulation";
            txtPopulation.Size = new Size(150, 25);
            txtPopulation.TabIndex = 1;
            txtPopulation.Text = "Population";
            txtPopulation.TextAlign = ContentAlignment.MiddleCenter;
            txtPopulation.Click += txtPopulation_Click;
            // 
            // lblSingulation
            // 
            lblSingulation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSingulation.BackColor = Color.WhiteSmoke;
            lblSingulation.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSingulation.ForeColor = SystemColors.ActiveCaptionText;
            lblSingulation.Location = new Point(1450, 50);
            lblSingulation.Margin = new Padding(4, 0, 4, 0);
            lblSingulation.Name = "lblSingulation";
            lblSingulation.Padding = new Padding(0, 0, 6, 0);
            lblSingulation.Size = new Size(110, 45);
            lblSingulation.TabIndex = 2;
            lblSingulation.Text = "100%";
            lblSingulation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSingulation
            // 
            txtSingulation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSingulation.BackColor = Color.WhiteSmoke;
            txtSingulation.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSingulation.ForeColor = SystemColors.ActiveCaptionText;
            txtSingulation.Location = new Point(1450, 95);
            txtSingulation.Margin = new Padding(4, 0, 4, 0);
            txtSingulation.Name = "txtSingulation";
            txtSingulation.Size = new Size(110, 25);
            txtSingulation.TabIndex = 3;
            txtSingulation.Text = "Singulation";
            txtSingulation.TextAlign = ContentAlignment.MiddleCenter;
            txtSingulation.Click += txtSingulation_Click;
            // 
            // lblSkipPercent
            // 
            lblSkipPercent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSkipPercent.BackColor = Color.WhiteSmoke;
            lblSkipPercent.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSkipPercent.ForeColor = SystemColors.ActiveCaptionText;
            lblSkipPercent.Location = new Point(1560, 50);
            lblSkipPercent.Margin = new Padding(4, 0, 4, 0);
            lblSkipPercent.Name = "lblSkipPercent";
            lblSkipPercent.Padding = new Padding(0, 0, 6, 0);
            lblSkipPercent.Size = new Size(110, 45);
            lblSkipPercent.TabIndex = 4;
            lblSkipPercent.Text = "10.1%";
            lblSkipPercent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSkips
            // 
            txtSkips.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSkips.BackColor = Color.Yellow;
            txtSkips.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSkips.ForeColor = SystemColors.ActiveCaptionText;
            txtSkips.Location = new Point(1560, 95);
            txtSkips.Margin = new Padding(4, 0, 4, 0);
            txtSkips.Name = "txtSkips";
            txtSkips.Size = new Size(110, 25);
            txtSkips.TabIndex = 5;
            txtSkips.Text = "Skips";
            txtSkips.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDoublesPercent
            // 
            lblDoublesPercent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDoublesPercent.BackColor = Color.WhiteSmoke;
            lblDoublesPercent.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoublesPercent.ForeColor = SystemColors.ActiveCaptionText;
            lblDoublesPercent.Location = new Point(1670, 50);
            lblDoublesPercent.Margin = new Padding(4, 0, 4, 0);
            lblDoublesPercent.Name = "lblDoublesPercent";
            lblDoublesPercent.Padding = new Padding(0, 0, 6, 0);
            lblDoublesPercent.Size = new Size(110, 45);
            lblDoublesPercent.TabIndex = 6;
            lblDoublesPercent.Text = "10.1%";
            lblDoublesPercent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDoubles
            // 
            txtDoubles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDoubles.BackColor = Color.MediumPurple;
            txtDoubles.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDoubles.ForeColor = SystemColors.ActiveCaptionText;
            txtDoubles.Location = new Point(1670, 95);
            txtDoubles.Margin = new Padding(4, 0, 4, 0);
            txtDoubles.Name = "txtDoubles";
            txtDoubles.Size = new Size(110, 25);
            txtDoubles.TabIndex = 7;
            txtDoubles.Text = "Doubles";
            txtDoubles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDisconnected
            // 
            lblDisconnected.AutoSize = true;
            lblDisconnected.BackColor = Color.WhiteSmoke;
            lblDisconnected.Font = new Font("Tahoma", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisconnected.ForeColor = Color.Red;
            lblDisconnected.ImageAlign = ContentAlignment.MiddleRight;
            lblDisconnected.Location = new Point(610, 521);
            lblDisconnected.Margin = new Padding(4, 0, 4, 0);
            lblDisconnected.Name = "lblDisconnected";
            lblDisconnected.Size = new Size(302, 33);
            lblDisconnected.TabIndex = 8;
            lblDisconnected.Text = "Planter Disconnected";
            lblDisconnected.Click += label1_Click;
            // 
            // btnSetUp
            // 
            btnSetUp.Image = Properties.Resources.PlanterS;
            btnSetUp.Location = new Point(260, 50);
            btnSetUp.Name = "btnSetUp";
            btnSetUp.Size = new Size(85, 66);
            btnSetUp.TabIndex = 9;
            btnSetUp.UseVisualStyleBackColor = true;
            btnSetUp.Click += clickSetup;
            // 
            // btn_disagree
            // 
            btn_disagree.Image = Properties.Resources.Cancel64;
            btn_disagree.Location = new Point(160, 50);
            btn_disagree.Name = "btn_disagree";
            btn_disagree.Size = new Size(86, 67);
            btn_disagree.TabIndex = 136;
            btn_disagree.TextAlign = ContentAlignment.MiddleRight;
            btn_disagree.UseVisualStyleBackColor = true;
            btn_disagree.Click += CancelClick;
            // 
            // btnFertilizer1
            // 
            btnFertilizer1.Anchor = AnchorStyles.Bottom;
            btnFertilizer1.BackColor = Color.LightGray;
            btnFertilizer1.Location = new Point(3, 3);
            btnFertilizer1.Name = "btnFertilizer1";
            btnFertilizer1.Size = new Size(100, 23);
            btnFertilizer1.TabIndex = 137;
            btnFertilizer1.Text = "1";
            btnFertilizer1.UseVisualStyleBackColor = false;
            btnFertilizer1.Click += btnFertilizer_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(btnFertilizer1);
            flowLayoutPanel1.Controls.Add(btnFertilizer2);
            flowLayoutPanel1.Controls.Add(btnFertilizer3);
            flowLayoutPanel1.Controls.Add(btnFertilizer4);
            flowLayoutPanel1.Controls.Add(btnFertilizer5);
            flowLayoutPanel1.Controls.Add(btnFertilizer6);
            flowLayoutPanel1.Controls.Add(btnFertilizer7);
            flowLayoutPanel1.Controls.Add(btnFertilizer8);
            flowLayoutPanel1.Location = new Point(100, 900);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(848, 29);
            flowLayoutPanel1.TabIndex = 138;
            // 
            // btnFertilizer2
            // 
            btnFertilizer2.Anchor = AnchorStyles.Bottom;
            btnFertilizer2.BackColor = Color.LightGray;
            btnFertilizer2.Location = new Point(109, 3);
            btnFertilizer2.Name = "btnFertilizer2";
            btnFertilizer2.Size = new Size(100, 23);
            btnFertilizer2.TabIndex = 138;
            btnFertilizer2.Text = "2";
            btnFertilizer2.UseVisualStyleBackColor = false;
            btnFertilizer2.Click += btnFertilizer_Click;
            // 
            // btnFertilizer3
            // 
            btnFertilizer3.Anchor = AnchorStyles.Bottom;
            btnFertilizer3.BackColor = Color.LightGray;
            btnFertilizer3.Location = new Point(215, 3);
            btnFertilizer3.Name = "btnFertilizer3";
            btnFertilizer3.Size = new Size(100, 23);
            btnFertilizer3.TabIndex = 139;
            btnFertilizer3.Text = "3";
            btnFertilizer3.UseVisualStyleBackColor = false;
            btnFertilizer3.Click += btnFertilizer_Click;
            // 
            // btnFertilizer4
            // 
            btnFertilizer4.Anchor = AnchorStyles.Bottom;
            btnFertilizer4.BackColor = Color.LightGray;
            btnFertilizer4.Location = new Point(321, 3);
            btnFertilizer4.Name = "btnFertilizer4";
            btnFertilizer4.Size = new Size(100, 23);
            btnFertilizer4.TabIndex = 140;
            btnFertilizer4.Text = "4";
            btnFertilizer4.UseVisualStyleBackColor = false;
            btnFertilizer4.Click += btnFertilizer_Click;
            // 
            // btnFertilizer5
            // 
            btnFertilizer5.Anchor = AnchorStyles.Bottom;
            btnFertilizer5.BackColor = Color.LightGray;
            btnFertilizer5.Location = new Point(427, 3);
            btnFertilizer5.Name = "btnFertilizer5";
            btnFertilizer5.Size = new Size(100, 23);
            btnFertilizer5.TabIndex = 141;
            btnFertilizer5.Text = "5";
            btnFertilizer5.UseVisualStyleBackColor = false;
            btnFertilizer5.Click += btnFertilizer_Click;
            // 
            // btnFertilizer6
            // 
            btnFertilizer6.Anchor = AnchorStyles.Bottom;
            btnFertilizer6.BackColor = Color.LightGray;
            btnFertilizer6.Location = new Point(533, 3);
            btnFertilizer6.Name = "btnFertilizer6";
            btnFertilizer6.Size = new Size(100, 23);
            btnFertilizer6.TabIndex = 142;
            btnFertilizer6.Text = "6";
            btnFertilizer6.UseVisualStyleBackColor = false;
            btnFertilizer6.Click += btnFertilizer_Click;
            // 
            // btnFertilizer7
            // 
            btnFertilizer7.Anchor = AnchorStyles.Bottom;
            btnFertilizer7.BackColor = Color.LightGray;
            btnFertilizer7.Location = new Point(639, 3);
            btnFertilizer7.Name = "btnFertilizer7";
            btnFertilizer7.Size = new Size(100, 23);
            btnFertilizer7.TabIndex = 143;
            btnFertilizer7.Text = "7";
            btnFertilizer7.UseVisualStyleBackColor = false;
            btnFertilizer7.Click += btnFertilizer_Click;
            // 
            // btnFertilizer8
            // 
            btnFertilizer8.Anchor = AnchorStyles.Bottom;
            btnFertilizer8.BackColor = Color.LightGray;
            btnFertilizer8.Location = new Point(745, 3);
            btnFertilizer8.Name = "btnFertilizer8";
            btnFertilizer8.Size = new Size(100, 23);
            btnFertilizer8.TabIndex = 144;
            btnFertilizer8.Text = "8";
            btnFertilizer8.UseVisualStyleBackColor = false;
            btnFertilizer8.Click += btnFertilizer_Click;
            // 
            // lblFertilizerWeight
            // 
            lblFertilizerWeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFertilizerWeight.BackColor = Color.WhiteSmoke;
            lblFertilizerWeight.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFertilizerWeight.ForeColor = SystemColors.ActiveCaptionText;
            lblFertilizerWeight.Location = new Point(1300, 120);
            lblFertilizerWeight.Margin = new Padding(4, 0, 4, 0);
            lblFertilizerWeight.Name = "lblFertilizerWeight";
            lblFertilizerWeight.Size = new Size(150, 25);
            lblFertilizerWeight.TabIndex = 139;
            lblFertilizerWeight.Text = "0 Kg";
            lblFertilizerWeight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVaccum1
            // 
            lblVaccum1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVaccum1.BackColor = Color.WhiteSmoke;
            lblVaccum1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVaccum1.ForeColor = SystemColors.ActiveCaptionText;
            lblVaccum1.Location = new Point(1450, 121);
            lblVaccum1.Margin = new Padding(4, 0, 4, 0);
            lblVaccum1.Name = "lblVaccum1";
            lblVaccum1.Size = new Size(110, 25);
            lblVaccum1.TabIndex = 140;
            lblVaccum1.Text = "0 in.wc";
            lblVaccum1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVaccum2
            // 
            lblVaccum2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVaccum2.BackColor = Color.WhiteSmoke;
            lblVaccum2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVaccum2.ForeColor = SystemColors.ActiveCaptionText;
            lblVaccum2.Location = new Point(1560, 121);
            lblVaccum2.Margin = new Padding(4, 0, 4, 0);
            lblVaccum2.Name = "lblVaccum2";
            lblVaccum2.Size = new Size(110, 25);
            lblVaccum2.TabIndex = 141;
            lblVaccum2.Text = "0 in.wc";
            lblVaccum2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDwPressure
            // 
            lblDwPressure.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDwPressure.BackColor = Color.WhiteSmoke;
            lblDwPressure.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDwPressure.ForeColor = SystemColors.ActiveCaptionText;
            lblDwPressure.Location = new Point(1670, 121);
            lblDwPressure.Margin = new Padding(4, 0, 4, 0);
            lblDwPressure.Name = "lblDwPressure";
            lblDwPressure.Size = new Size(110, 25);
            lblDwPressure.TabIndex = 142;
            lblDwPressure.Text = "0 PSI";
            lblDwPressure.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDownforce1
            // 
            lblDownforce1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDownforce1.BackColor = Color.WhiteSmoke;
            lblDownforce1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDownforce1.ForeColor = SystemColors.ActiveCaptionText;
            lblDownforce1.Location = new Point(1450, 145);
            lblDownforce1.Margin = new Padding(4, 0, 4, 0);
            lblDownforce1.Name = "lblDownforce1";
            lblDownforce1.Size = new Size(110, 25);
            lblDownforce1.TabIndex = 143;
            lblDownforce1.Text = "-- Kg";
            lblDownforce1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDownforce2
            // 
            lblDownforce2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDownforce2.BackColor = Color.WhiteSmoke;
            lblDownforce2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDownforce2.ForeColor = SystemColors.ActiveCaptionText;
            lblDownforce2.Location = new Point(1560, 146);
            lblDownforce2.Margin = new Padding(4, 0, 4, 0);
            lblDownforce2.Name = "lblDownforce2";
            lblDownforce2.Size = new Size(110, 25);
            lblDownforce2.TabIndex = 144;
            lblDownforce2.Text = "-- Kg";
            lblDownforce2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDownforce3
            // 
            lblDownforce3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDownforce3.BackColor = Color.WhiteSmoke;
            lblDownforce3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDownforce3.ForeColor = SystemColors.ActiveCaptionText;
            lblDownforce3.Location = new Point(1670, 146);
            lblDownforce3.Margin = new Padding(4, 0, 4, 0);
            lblDownforce3.Name = "lblDownforce3";
            lblDownforce3.Size = new Size(110, 25);
            lblDownforce3.TabIndex = 145;
            lblDownforce3.Text = "-- Kg";
            lblDownforce3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormAOP
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1920, 1061);
            Controls.Add(lblDownforce3);
            Controls.Add(lblDownforce2);
            Controls.Add(lblDownforce1);
            Controls.Add(lblDwPressure);
            Controls.Add(lblVaccum2);
            Controls.Add(lblVaccum1);
            Controls.Add(lblFertilizerWeight);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btn_disagree);
            Controls.Add(btnSetUp);
            Controls.Add(lblDisconnected);
            Controls.Add(txtDoubles);
            Controls.Add(lblDoublesPercent);
            Controls.Add(txtSkips);
            Controls.Add(lblSkipPercent);
            Controls.Add(txtSingulation);
            Controls.Add(lblSingulation);
            Controls.Add(txtPopulation);
            Controls.Add(lblPopulation);
            Font = new Font("Tahoma", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAOP";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "FormAOP";
            TopMost = true;
            TransparencyKey = Color.White;
            WindowState = FormWindowState.Maximized;
            Load += on_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSingulation;
        private Label txtSingulation;
        private Label lblSkipPercent;
        private Label lblDoublesPercent;
        private Label txtDoubles;
        public Label lblDisconnected;
        private Button btnSetUp;
        private Button btn_disagree;
        private System.Windows.Forms.Timer timer1;
        public Label txtPopulation;
        public Button lblPopulation;
        public Label txtSkips;
        private System.Windows.Forms.Timer timer2;
        private Button btnFertilizer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnFertilizer2;
        private Button btnFertilizer3;
        private Button btnFertilizer4;
        private Button btnFertilizer5;
        private Button btnFertilizer6;
        private Button btnFertilizer7;
        private Button btnFertilizer8;
        public Label lblFertilizerWeight;
        private Label lblVaccum1;
        private Label lblVaccum2;
        private Label lblDwPressure;
        private Label lblDownforce1;
        private Label lblDownforce2;
        private Label lblDownforce3;
    }
}
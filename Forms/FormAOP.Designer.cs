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
            // FormAOP
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1920, 1061);
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
    }
}
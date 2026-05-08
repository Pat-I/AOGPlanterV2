//using System.Windows.Forms;

using System;
using System.Drawing;
using System.Windows.Forms;
using static AOGPlanterV2.OF.OfRowCrop;

namespace AOGPlanterV2
{
    public class FormSkipsDisplay : Form
    {
        private readonly FormAOP mf;
        // private readonly System.Windows.Forms.Timer repaintTimer;
        private readonly int numOfSections;
        private const int HistoryRows = 10; // 1 live + 6 below
        private Color[,] colorBuffer;
        private int numSections;
        private DateTime lastUpdate = DateTime.MinValue;
        int gap = 6;   // pixels between rectangles

        public FormSkipsDisplay(FormAOP mainForm)
        //        public FormSkipsDisplay(Form callingForm)
        {
            InitializeComponent();
            mf = mainForm;
            // mf = callingForm as FormAOP;

            // Subscribe to SkipsChart timer
            mf.skp.TickSync += OnChartTick;
            numOfSections = (int)Properties.Settings.Default.setPlanterNumRows;//(int)mf.tool.numOfSections;
            colorBuffer = new Color[HistoryRows, numOfSections];

            // Initialize everything green
            for (int r = 0; r < HistoryRows; r++)
                for (int c = 0; c < numOfSections; c++)
                    colorBuffer[r, c] = Color.Gray;

            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            BackColor = Color.Lime;          // pick a color that you don't use elsewhere
            TransparencyKey = Color.Lime;    // everything that color becomes transparent
            BackColor = Color.Black;
            //            Opacity = 0.7;
            TopMost = true;

            Bounds = Screen.PrimaryScreen.Bounds;
            var screen = Screen.PrimaryScreen.WorkingArea;
            int rectHeight = screen.Height / 72;   // same value used in OnPaint
            int totalRowsHeight = HistoryRows * rectHeight;
            Height = totalRowsHeight + 10; // small padding
            Width = (int)(screen.Width / 1.45f);
            int y = screen.Bottom - Height - (screen.Height / 8);
            Location = new Point((int)(screen.Width / 6.6f), y);
            Size = new Size(Width, Height);
        }

        private void InitializeComponent()
        {
            btnExitRows = new Button();
            SuspendLayout();
            // 
            // btnExitRows
            // 
            btnExitRows.BackColor = Color.Maroon;
            btnExitRows.Dock = DockStyle.Left;
            btnExitRows.FlatStyle = FlatStyle.Flat;
            btnExitRows.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnExitRows.ForeColor = Color.White;
            btnExitRows.Location = new Point(0, 0);
            btnExitRows.Name = "btnExitRows";
            btnExitRows.Size = new Size(36, 261);
            btnExitRows.TabIndex = 0;
            btnExitRows.Text = "EXI T";
            btnExitRows.UseVisualStyleBackColor = false;
            btnExitRows.MouseClick += btnExitRows_Click;
            // 
            // FormSkipsDisplay
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(btnExitRows);
            Name = "FormSkipsDisplay";
            ResumeLayout(false);
        }

        private void OnChartTick(object sender, EventArgs e)
        {
            if (DateTime.UtcNow - lastUpdate < mf.rc.updateSkipDisplayInterval)
                return;

            lastUpdate = DateTime.UtcNow;

            ShiftRowsDown();
            UpdateTopRowFromLiveData();
            Invalidate();
        }

        private void ShiftRowsDown()
        {
            for (int r = HistoryRows - 1; r > 0; r--)
            {
                for (int c = 0; c < numOfSections; c++)
                {
                    colorBuffer[r, c] = colorBuffer[r - 1, c];
                }
            }
        }
        private void UpdateTopRowFromLiveData()
        {

            for (int i = 0; i < numOfSections; i++)
            {
                Color color = Color.Black; //5 or higher

                if (mf.rc.rcRowStatus[i] == 0) //normal
                    color = Color.Green;

                if (mf.rc.rcRowStatus[i] == 3) //skip
                    color = Color.Purple;

                if (mf.rc.rcRowStatus[i] == 2) //double
                    color = Color.Yellow; // overlays purple

                if (mf.rc.rcRowStatus[i] == 1) // problem
                {
                    color = Color.Red; // overlays yellow
                    if (Properties.Settings.Default.setPlanterAlarm_Active && (Properties.Settings.Default.setPlanter_Active = true)) mf.sounds.sndDisconnected.Play();
                }


                if (mf.rc.rcRowStatus[i] == 4)
                    color = Color.Gray;

                colorBuffer[0, i] = color;
            }
        }
        private Button btnExitRows;

        private void btnExitRows_Click(object sender, MouseEventArgs e)
        {
             Close();
        }
    }
}

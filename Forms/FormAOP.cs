using AOGPlanterV2.OF;
using AOGPlanterV2.OldFarmer;
using System.Media;
using System.Timers;
using System.Windows.Forms;

namespace AOGPlanterV2
{
    public partial class FormAOP : Form
    {

        //To bring forward AgIO if running
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr handle);

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr hWind, int nCmdShow);
        private FormSkipsDisplay skipsDisplay;


        // UDP Socket
        //       private Socket UDPSocket;
        //       private EndPoint endPointUDP = new IPEndPoint(IPAddress.Any, 0);


        // Data stream
        private byte[] buffer = new byte[1024];
        public double nudNumber = 0;
        public double nudValue = 0;
        // row crop path
        public OfRowCrop rc;

        /// <summary>
        /// Sound
        /// </summary>
        public CSound sounds;

        /// <summary>
        /// Sound for planter control box disconnected
        /// </summary>
        public SoundPlayer sndDisconnected;

        public AOPUDP udp;
        public FormSkipsChart skp;
        private DateTime curTime;
        public FormAOP()
        {

            InitializeComponent();

            udp = new AOPUDP(this);
            skp = new FormSkipsChart(this);
            //AOPUDP.msgCount
            //jim CheckSettingsNotNull();
            // Row Crop Planter Data
            rc = new OfRowCrop(this);
            lblSkipPercent.Text = "15.2%";
            lblDoublesPercent.Text = "2.4%";
            this.BackColor = Color.Lime;          // pick a color that you don't use elsewhere
            this.TransparencyKey = Color.Lime;    // everything that color becomes transparent

            tool = new CTool(this);
            sounds = new CSound();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100; // 1000 ms = 1 second
            //timer1.Tick += Timer1_Tick; // attach event handler
            timer1.Tick += new System.EventHandler(Timer1_Tick);
            timer1.Start(); // start the timer

            //timerSim = new System.Windows.Forms.Timer();
            //timerSim.Interval = 93; // 1000 ms = 1 second
            //timerSim.Tick += TimerSim_Tick; // attach event handler
            //timerSim.Start(); // start the timer

            SetupTimer();
            //rc.InitSectionState();
            FlowLayoutPanel1_Center();

        }

        private void FlowLayoutPanel1_Center()
        {
            // Calculate center: (Form Width / 2) - (Panel Width / 2)
            int x = (this.ClientSize.Width - flowLayoutPanel1.Width) / 2;

            // Set Y based on a fixed distance from the bottom
            int distanceFromBottom = 100;
            int y = this.ClientSize.Height - flowLayoutPanel1.Height - distanceFromBottom;

            flowLayoutPanel1.Location = new Point(x, y);
        }

        //Current directory of Tools
        public string toolsDirectory, toolFileName = "Tools";

        //current directory of Environments
        public string envDirectory, envFileName = "Env";

        //The base directory where AgOpenGPS will be stored and fields and vehicles branch from
        public string baseDirectory;

        private bool leftMouseDownOnOpenGL; //mousedown event in opengl window
        public int flagNumberPicked = 0;


        public CTool tool;
        private System.Timers.Timer timerSim;

        private void SetupTimer()
        {
            // Create and configure timer
            timerSim = new System.Timers.Timer();
            timerSim.Interval = 93; // every 100 ms (10 times per second)
            timerSim.Elapsed += TimerSim_Elapsed;
            timerSim.AutoReset = true; // keeps repeating
            timerSim.Start(); // start automatically
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPopulation_Click_1(object sender, EventArgs e)
        {
            //check if window already exists
            //            Form fcg = Application.OpenForms["FormSteerGraph"];
            Form fcg = Application.OpenForms["FormSkipsChart"];
            Form fch = Application.OpenForms["FormPopChart"];
            Form skp = Application.OpenForms["ShowSkipsDisplay"];
            if (fcg != null)
            {
                fcg.Focus();
                //                return;
            }
            else
            {
                Form formH = new FormSkipsChart(this);
                formH.Show(this);
            }
            if (fch != null)
            {
                fch.Focus();
                //                return;
            }
            else
            {
                Form formG = new OldFarmer.FormPopChart(this);
                formG.Show(this);
            }
            if (skp != null)
            {
                skp.Focus();
                return;
            }
            else
            {
                ShowSkipsDisplay();

            }

            //            Form formH = new FormSkipsChart(this);
            //Form formG = new OldFarmer.FormPopChart(this);
            //formG.Show(this);
            //formH.Show(this);
            //ShowSkipsDisplay();
        }

        private void on_Load(object sender, EventArgs e)
        {

            Form fst = Application.OpenForms["Form_First"];
            if (fst != null)
            {
                fst.Focus();
                return;
            }

            Form formF = new Form_First(this);
            formF.Show(this);
            formF.Focus();

            udp = new AOPUDP(this);  // create instance
            udp.StartUDPServer();
        }

        private void clickSetup(object sender, EventArgs e)
        {

            Form formA = new FormArduinoSettings(this);
            formA.ShowDialog(this);
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPopulation_Click(object sender, EventArgs e)
        {

        }

        private void txtSingulation_Click(object sender, EventArgs e)
        {

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            curTime = DateTime.Now;
            TimeSpan diff = curTime - rc.timeDataReceived;

            if (diff.TotalMilliseconds > 3500)
            {
                //disconected
                if (AOGPlanterV2.Properties.Settings.Default.setPlanterSimulator_Active == true)
                {
                    lblPopulation.Text = "32000"; // rc.sumPopulation.ToString("F0");
                    lblSingulation.Text = "98.4%"; // rc.sumSingulation.ToString("F1") + "%";
                    lblSkipPercent.Text = "1.4%"; //rc.sumSkipPercent.ToString("F1") + "%";
                    lblDoublesPercent.Text = ".2%"; // rc.sumDoublePercent.ToString("F1") + "%";
                }
                else
                {
                    lblPopulation.Text = "-";
                    lblSingulation.Text = "-%";
                    lblSkipPercent.Text = "-%";
                    lblDoublesPercent.Text = "-%";
                }
                for (int kk = 0; kk < rc.fbNumSections; kk++)
                {
                    rc.rcPopulation[kk] = 0;
                    rc.rcPopulationPercent[kk] = 0;
                    rc.rcDoubles[kk] = 0;
                    rc.rcSkips[kk] = 0;
                    rc.rcArrayDoubles[kk] = 0;
                    rc.rcArraySkips[kk] = 0;
                }
                lblDisconnected.Visible = true;
                /* //no check for theses PNGs for now
                btnFertilizer1.BackColor = Color.LightGray;
                btnFertilizer2.BackColor = Color.LightGray;
                btnFertilizer3.BackColor = Color.LightGray;
                btnFertilizer4.BackColor = Color.LightGray;
                btnFertilizer5.BackColor = Color.LightGray;
                btnFertilizer6.BackColor = Color.LightGray;
                btnFertilizer7.BackColor = Color.LightGray;
                btnFertilizer8.BackColor = Color.LightGray;
                rc.fertilizerWeight = 0;
                rc.fertilizerActualPosition = 0;
                rc.fertilizerSetPosition = 0;
                rc.fertilizerForcedPosition = 0;
                lblDwPressure.Text = "- PSI";
                lblFertilizerWeight.Text = "- Kg";
                lblVaccum1.Text = "- in.wg";
                lblVaccum2.Text = "- in.wg";
                lblDownforce1.Text = "-- Kg";
                lblDownforce2.Text = "-- Kg";
                lblDownforce3.Text = "-- Kg";
                */
            }
            else
            {
                //connected
                if (Properties.Settings.Default.setMenu_isMetric)
                {
                    lblPopulation.Text = rc.sumPopulation.ToString("F0");
                }
                else
                {
                    lblPopulation.Text = (rc.sumPopulation * 0.404686f).ToString("F0");
                }
                lblSingulation.Text = rc.sumSingulation.ToString("F1") + "%";
                lblSkipPercent.Text = rc.sumSkipPercent.ToString("F1") + "%";
                lblDoublesPercent.Text = rc.sumDoublePercent.ToString("F1") + "%";

                lblDisconnected.Visible = false;
            }

            lblDwPressure.Text = rc.airPressurePSI.ToString("F0") + " PSI";
            lblFertilizerWeight.Text = rc.fertilizerWeight.ToString("F0") + " Kg";
            lblVaccum1.Text = rc.vaccum1inWC.ToString("F1") + " in.wg";
            lblVaccum2.Text = rc.vaccum2inWC.ToString("F1") + " in.wg";
            lblDownforce1.Text = rc.downforceKgSensor1.ToString("F0") + " Kg";
            lblDownforce2.Text = rc.downforceKgSensor2.ToString("F0") + " Kg";
            lblDownforce3.Text = rc.downforceKgSensor3.ToString("F0") + " Kg";

            for (int i = 0; i < 8; i++)
            {
                // Find the button (i+1 because names usually start at 1)
                Control[] found = this.Controls.Find("btnFertilizer" + (i + 1), true);
                UpdateMultiByteColors(rc.fertilizerForcedPosition, rc.fertilizerSetPosition, rc.fertilizerActualPosition);

            }

            //do the backcolor for the pressure arrows
            

                
            // Check Bit 0 (Raise)
            bool isRaiseActive = (rc.receivingDownpressureStatus & (1 << 0)) != 0;
            btnPressureUp.BackColor = isRaiseActive ? Color.LimeGreen : Color.LightGray;

            // Check Bit 1 (Lower)
            bool isLowerActive = (rc.receivingDownpressureStatus & (1 << 1)) != 0;
            btnPressureDown.BackColor = isLowerActive ? Color.IndianRed : Color.LightGray;
        }

        private void UpdateMultiByteColors(byte forcedByte, byte setByte, byte actualByte)
        {
            // Get all buttons from the panel in order
            var buttons = flowLayoutPanel1.Controls.OfType<Button>().ToList();

            for (int i = 0; i < 8; i++)
            {
                if (i >= buttons.Count) break;

                // Extract bit status for this specific position
                bool isForced = (forcedByte & (1 << i)) != 0;
                bool isSet = (setByte & (1 << i)) != 0;
                bool isActual = (actualByte & (1 << i)) != 0;

                Color targetColor;

                if (isForced)
                {
                    targetColor = isActual ? Color.Yellow : Color.MediumVioletRed;
                }
                else
                {
                    if (isSet)
                    {
                        targetColor = isActual ? Color.Green : Color.Pink;
                    }
                    else
                    {
                        targetColor = isActual ? Color.Blue : Color.Red;
                    }
                }

                buttons[i].BackColor = targetColor;
            }
        }

        private void TimerSim_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Run background updates here
            if (Properties.Settings.Default.setPlanterSimulator_Active == true)
            {
                OfTestDriver.Instance.UpdateRc(this);
            }
            // If you need to update UI controls (labels, progress bars, etc.)
            // use Invoke() to run code safely on the UI thread:
            //this.Invoke((System.Windows.Forms.MethodInvoker)delegate
            //{
            //    txtSkips.Text = DateTime.Now.ToString("HH:mm:ss.fff");
            //});
        }

        private void ShowSkipsDisplay()
        {
            if (skipsDisplay == null || skipsDisplay.IsDisposed)
            {
                skipsDisplay = new FormSkipsDisplay(this);
                skipsDisplay.Show(this);   // owner = FormAOP
            }
            else
            {
                skipsDisplay.BringToFront();
            }
        }

        private void btnFertilizer_Click(object sender, EventArgs e)
        {
            byte forceByte = 0;
            Button btn = (Button)sender;

            string name = btn.Name;
            int bitIndex = int.Parse(name.Replace("btnFertilizer", "")) - 1;

            forceByte ^= (byte)(1 << bitIndex);

            udp.SendFertilizerConfig(force: forceByte);
        }

        private void btnPressureUp_MouseDown(object sender, MouseEventArgs e)
        {
            rc.isPressureRaisePressed = true;
            rc.UpdateDownforceStatus();
            udp.SendDownpressureConfig();
        }

        private void btnPressureUp_MouseUp(object sender, MouseEventArgs e)
        {
            rc.isPressureRaisePressed = false;
            rc.UpdateDownforceStatus();
            udp.SendDownpressureConfig();
        }

        private void btnPressureUp_MouseLeave(object sender, EventArgs e)
        {
            rc.isPressureRaisePressed = false;
            rc.UpdateDownforceStatus();
            udp.SendDownpressureConfig();
        }

        private void btnPressureDown_MouseDown(object sender, MouseEventArgs e)
        {
            rc.isPressureLowerPressed = true;
            rc.UpdateDownforceStatus();
            udp.SendDownpressureConfig();
        }

        private void btnPressureDown_MouseUp(object sender, MouseEventArgs e)
        {
            rc.isPressureLowerPressed = false;
            rc.UpdateDownforceStatus();
            udp.SendDownpressureConfig();
        }

        private void btnPressureDown_MouseLeave(object sender, EventArgs e)
        {
            rc.isPressureLowerPressed = false;
            rc.UpdateDownforceStatus();
            udp.SendDownpressureConfig();
        }
    }
}


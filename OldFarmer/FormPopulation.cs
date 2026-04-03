using System.Windows.Forms.DataVisualization.Charting;

namespace AOGPlanterV2.OldFarmer
{
    public partial class PopulationChart2 : Form
    {
        private readonly FormAOP mf = null;

        public PopulationChart2(Form callingForm)
        {
            mf = callingForm as FormAOP;
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void DrawChart()
        {
            Series s = popChart2.Series["SeriesPop"];
            s.Points.Clear();

            for (int i = 0; i < mf.tool.numOfSections; i++)
            {             
                double val = mf.rc.rcPopulation[i];
                if (Properties.Settings.Default.setMenu_isMetric == false) val *= 0.404686;
                if (double.IsNaN(val) || double.IsInfinity(val)) val = 0;
                s.Points.AddXY(i + 1, val);
            }

            if (Properties.Settings.Default.setMenu_isMetric)
            {
                lblTargetPop.Text = Properties.Settings.Default.setPlanterTargetPopulation.ToString();
            }
            else
            {
                lblTargetPop.Text = (Properties.Settings.Default.setPlanterTargetPopulation * 0.404686).ToString();
            }
                
            var chartArea = popChart2.ChartAreas[0];

            chartArea.AxisY.Minimum = 0;

            double target = Properties.Settings.Default.setPlanterTargetPopulation;
            if (target > 0)
            {
                chartArea.AxisY.Maximum = target * 1.5;
                chartArea.AxisY.Interval = target/5.0;
            }
            else
            {
                chartArea.AxisY.Maximum = 100000;
                chartArea.AxisY.Interval = 20000;
            }

            popChart2.Invalidate();
        }
        public PopulationChart2()
        {
            InitializeComponent();
        }

        private void PopulationChart2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
        }

        private void btnExitPop_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPopChart_Click(object sender, EventArgs e)
        {
            Close();
            Form formD = new OldFarmer.FormPopChart(mf);
            formD.Show(mf);
        }

        private void lblTargetPop_Click(object sender, EventArgs e)
        {

        }
    }
}

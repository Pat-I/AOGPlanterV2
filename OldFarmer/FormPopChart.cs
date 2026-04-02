using System.Windows.Forms.DataVisualization.Charting;

namespace AOGPlanterV2.OldFarmer
{
    public partial class FormPopChart : Form
    {

        private readonly FormAOP mf = null;

        public FormPopChart(Form callingForm)
        {
            mf = callingForm as FormAOP;
            InitializeComponent();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void DrawChart()
        {
            Series s = popchart.Series["Population"];
            s.Points.Clear();

            for (int i = 0; i < mf.tool.numOfSections; i++)
            {
                double val = mf.rc.rcPopulationPercent[i];
                s.Points.AddXY(i + 1, val);
            }

            lblGraphPop.Text = Properties.Settings.Default.setPlanterTargetPopulation.ToString();

            var chartArea = popchart.ChartAreas[0];

            chartArea.AxisY.Minimum = -15;
            
            
                chartArea.AxisY.Maximum = 15;
            chartArea.AxisY.Interval = 5;

            popchart.Invalidate();
        }
        private void FormPopChart_Load(object sender, EventArgs e)
        {
            timer2.Interval = 1;
            //			timer1.Interval = (int)((1 / (double)mf.fixUpdateHz) * 1000);
        }
        private void popchart_Click(object sender, EventArgs e)
        {

        }

        private void btnExitPop_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblGraphPop_Click(object sender, EventArgs e)
        {

        }

        private void btnPopChart_Click(object sender, EventArgs e)
        {
            Close();

            Form formJ = new OldFarmer.PopulationChart2(mf);
            formJ.Show(mf);
        }
    }
}

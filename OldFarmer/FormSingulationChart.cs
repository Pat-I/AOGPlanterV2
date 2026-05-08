using System.Windows.Forms.DataVisualization.Charting;

namespace AOGPlanterV2.OldFarmer
{
    public partial class FormSingulationChart : Form
    {

        private readonly FormAOP mf = null;

        public FormSingulationChart(Form callingForm)
        {
            mf = callingForm as FormAOP;
            InitializeComponent();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void DrawChart()
        {
            Series s = singchart.Series["Singulation"];
            s.Points.Clear();
            double SingulationAverage = 0;
            for (int i = 0; i < mf.tool.numOfSections; i++)
            {
                double val = mf.rc.rcSingulationPercent[i];
                SingulationAverage += val;
                if (val < 90) val = 90;
                if (val > 100) val = 100;
                s.Points.AddXY(i + 1, val);
            }
            if (mf.tool.numOfSections > 0) SingulationAverage /= mf.tool.numOfSections;

            lblGraphSing.Text = SingulationAverage.ToString("F1") + "%";

            var chartArea = singchart.ChartAreas[0];

            chartArea.AxisY.Minimum = 90;
            
            
                chartArea.AxisY.Maximum = 100;
            chartArea.AxisY.Interval = 2;

            singchart.Invalidate();
        }
        private void FormSingChart_Load(object sender, EventArgs e)
        {
            timer3.Interval = 1;
            //			timer1.Interval = (int)((1 / (double)mf.fixUpdateHz) * 1000);
        }
        private void singchart_Click(object sender, EventArgs e)
        {

        }

        private void btnExitSing_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblGraphSing_Click(object sender, EventArgs e)
        {

        }

        private void btnSingChart_Click(object sender, EventArgs e)
        {
            Close();

            Form formJ = new OldFarmer.PopulationChart2(mf);
            formJ.Show(mf);
        }
    }
}

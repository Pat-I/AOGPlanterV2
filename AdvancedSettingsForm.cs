using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOGPlanterV2
{
    public partial class AdvancedSettingsForm : Form
    {
        private FormAOP mf = null;

        public AdvancedSettingsForm(FormAOP callingForm)
        {
            mf = callingForm;
            InitializeComponent();
        }

        private void btnFertilizerZero_Click(object sender, EventArgs e)
        {
            if (mf.rc.fertilizerWeight < 32000 && mf.rc.fertilizerWeight > -32000)
            mf.udp.SendFertilizerConfig(zero: (Int16)mf.rc.fertilizerWeight);
        }

        private void btnSendFertilizerWeight_Click(object sender, EventArgs e)
        {
            if (numFertilizerWeight.Value > 0 && numFertilizerWeight.Value < 32000)
            {
                mf.udp.SendFertilizerConfig(weight: (UInt16)numFertilizerWeight.Value);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

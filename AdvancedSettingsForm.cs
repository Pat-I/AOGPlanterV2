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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHeightVoltage.Text = mf.rc.heightVoltage.ToString("F2") + " V";
            lblHeight.Text = mf.rc.planterHeight.ToString("F0");
            lblHeightOff.Text = mf.rc.planterOffThreashold.ToString("F0");
            lblHeightOn.Text = mf.rc.planterOnThreashold.ToString("F0");
            lblVaccum1Voltage.Text = mf.rc.vaccum1Voltage.ToString("F2") + " V";
            lblVaccum2Voltage.Text = mf.rc.vaccum2Voltage.ToString("F2") + " V";
            lblAirPressureVoltage.Text = mf.rc.airPressureVoltage.ToString("F2") + " V";
        }

        private void btnHeightTop_Click(object sender, EventArgs e)
        {
            mf.udp.SendHeightConfig(heightTop: mf.rc.heightAdc);
        }

        private void btnHeightZero_Click(object sender, EventArgs e)
        {
            mf.udp.SendHeightConfig(heightZero: mf.rc.heightAdc);
        }

        private void btnHeightOff_Click(object sender, EventArgs e)
        {
            mf.udp.SendHeightConfig(offThresh: mf.rc.planterHeight);
        }

        private void btnHeightOn_Click(object sender, EventArgs e)
        {
            mf.udp.SendHeightConfig(onThresh: mf.rc.planterHeight);
        }

        private void btnVaccum1Zero_Click(object sender, EventArgs e)
        {
            mf.udp.SendVaccumConfig(vaccum1zero: mf.rc.vaccum1Adc);
        }

        private void btnVaccum2Zero_Click(object sender, EventArgs e)
        {
            mf.udp.SendVaccumConfig(vaccum2zero: mf.rc.vaccum2Adc);
        }

        private void btnVaccum1set_Click(object sender, EventArgs e)
        {
            mf.udp.SendVaccumConfig(vac1: 180);
        }

        private void btnVaccum2set_Click(object sender, EventArgs e)
        {
            mf.udp.SendVaccumConfig(vac2: 180);
        }

        private void btnAirPressureZero_Click(object sender, EventArgs e)
        {
            mf.udp.SendDownpressureConfig(airPressZero: mf.rc.airPressureAdc);
        }

        private void btnAirPressureSet_Click(object sender, EventArgs e)
        {
            mf.udp.SendDownpressureConfig(actAirPress: 40);
        }

        private void btnDownforceZero1_Click(object sender, EventArgs e)
        {
            mf.udp.SendDownpressureConfig(setByte: 1);
        }

        private void btnDownforceZero2_Click(object sender, EventArgs e)
        {
            mf.udp.SendDownpressureConfig(setByte: 2);
        }

        private void btnDownforceZero3_Click(object sender, EventArgs e)
        {
            mf.udp.SendDownpressureConfig(setByte: 4);
        }

        private void btnDownforceSet1_Click(object sender, EventArgs e)
        {
            if (numDownforceWeight1.Value > 0 && numDownforceWeight1.Value < 255)
            {
                mf.udp.SendDownpressureConfig(weight: (byte)numDownforceWeight1.Value, setByte: 16);
            }
        }

        private void btnDownforceSet2_Click(object sender, EventArgs e)
        {

            if (numDownforceWeight2.Value > 0 && numDownforceWeight2.Value < 255)
            {
                mf.udp.SendDownpressureConfig(weight: (byte)numDownforceWeight2.Value, setByte: 32);
            }
        }

        private void btnDownforceSet3_Click(object sender, EventArgs e)
        {

            if (numDownforceWeight3.Value > 0 && numDownforceWeight3.Value < 255)
            {
                mf.udp.SendDownpressureConfig(weight: (byte)numDownforceWeight3.Value, setByte: 64);
            }
        }
    }
}

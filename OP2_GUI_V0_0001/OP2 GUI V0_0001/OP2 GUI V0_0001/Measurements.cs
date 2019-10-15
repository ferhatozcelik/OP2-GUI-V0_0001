using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace OP2_GUI_V0_0001
{
    public partial class Measurements : MetroSet_UI.Forms.MetroSetForm
    {
        public Measurements()
        {
            InitializeComponent();
        }

        public static string[] measumentsMP = new string[7];
        public static int elementCounter;

        private void Measurements_Load(object sender, EventArgs e)
        {
            measurementSaveButton.Enabled = false;
            ConBtn();
        }

        private void ConBtn()
        {
            if (XRDcheckBox.Checked == true | SEMcheckBox.Checked == true | AFMcheckBox.Checked == true |
                EDScheckBox.Checked == true | UVcheckBox.Checked == true | FTIRcheckBox.Checked == true |
                EOCcheckBox.Checked == true)
            {
                measurementSaveButton.Enabled = true;
            }
            else
            {
                measurementSaveButton.Enabled = false;
            }
        }

        private void XRDcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (XRDcheckBox.Checked == true)
            {
                measurementList.Items.Add("XRD");
            }
            else
            {
                measurementList.Items.Remove("XRD");
            }

            ConBtn();
        }

        private void SEMcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SEMcheckBox.Checked == true)
            {
                measurementList.Items.Add("SEM");
            }
            else
            {
                measurementList.Items.Remove("SEM");
            }

            ConBtn();
        }

        private void EDScheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EDScheckBox.Checked == true)
            {
                measurementList.Items.Add("EDS");
            }
            else
            {
                measurementList.Items.Remove("EDS");
            }

            ConBtn();
        }

        private void AFMcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AFMcheckBox.Checked == true)
            {
                measurementList.Items.Add("AFM");
            }
            else
            {
                measurementList.Items.Remove("AFM");
            }

            ConBtn();
        }

        private void UVcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UVcheckBox.Checked == true)
            {
                measurementList.Items.Add("UV-Vis");
            }
            else
            {
                measurementList.Items.Remove("UV-Vis");
            }
            ConBtn();
        }

        private void FTIRcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FTIRcheckBox.Checked == true)
            {
                measurementList.Items.Add("FT-IR");
            }
            else
            {
                measurementList.Items.Remove("FT-IR");
            }

            ConBtn();
        }

        private void EOCcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EOCcheckBox.Checked == true)
            {
                measurementList.Items.Add("E/OC");
            }
            else
            {
                measurementList.Items.Remove("E/OC");
            }
            ConBtn();
        }

        private void Measurements_MouseMove(object sender, MouseEventArgs e)
        {

            if (XRDcheckBox.Checked == true | SEMcheckBox.Checked == true | AFMcheckBox.Checked == true |
                EDScheckBox.Checked == true | UVcheckBox.Checked == true | FTIRcheckBox.Checked == true |
                EOCcheckBox.Checked == true )
            {
                measurementSaveButton.Enabled = true;
            }
            else
            {
                measurementSaveButton.Enabled = false;
            }
            ConBtn();
        }

        private void MeasurementSaveButton_Click(object sender, EventArgs e)
        {

            elementCounter = measurementList.Items.Count;
            for (int i = 0; i < elementCounter; i++)
            {
                measumentsMP[i] = measurementList.Items[i].ToString();
            }
            RefProduction.taskRateBarVar = 100;
            this.Close();
        }

        private void measurementList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}

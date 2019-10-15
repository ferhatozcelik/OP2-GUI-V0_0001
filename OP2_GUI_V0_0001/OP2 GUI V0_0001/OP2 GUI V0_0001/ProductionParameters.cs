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
    public partial class ProductionParameters : MetroSet_UI.Forms.MetroSetForm
    {
        public ProductionParameters()
        {
            InitializeComponent();
        }
        public static string publicProgramName, publicSubstrateHeater, publicFlowRate, publicsolutionInfoText;
        public static string publicPassCount, publicNozzleGas, publicOxygen, publicAmbience, publicHumidity;
        public static bool publicExcapeFunnel, publicNitrogen, publicHumidifier;

        private void productionInfoBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductionParameters_Load(object sender, EventArgs e)
        {
            RefProduction.taskRateBarVar = 0;
            solutionInfoSaveButton.Enabled = false;
            //productionInfoSaveButton.Enabled = false;
            allInfoSaveButton.Enabled = false;
            productionInfoBox.Enabled = false;
            allInfoSaveButton.Visible = false;
        }

        private void SolutionInfoSave_Click(object sender, EventArgs e)
        {
            if (solutionInfoText.Text != null & solutionInfoText.Text != " ")
            {
                productionInfoBox.Enabled = true;
                solutionInfoSaveButton.Visible = false;
            }

        }
        int allinfoentered;
        private void ProductionInfoSaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(programNameTextPP.Text)
                & !string.IsNullOrEmpty(substrateHeaterTextPP.Text)
                & !string.IsNullOrEmpty(flowRateTextPP.Text)
                & !string.IsNullOrEmpty(passCountTextPP.Text)
                & !string.IsNullOrEmpty(nozzleGasPressureTextPP.Text)
                & !string.IsNullOrEmpty(oxygenLevelTextPP.Text)
                & !string.IsNullOrEmpty(ambienceTemperatureTextPP.Text)
                & !string.IsNullOrEmpty(humidityLevelTextPP.Text))
            {
                allinfoentered = 50;
                allInfoSaveButton.Enabled = true;
                allInfoSaveButton.Visible = true;
                //public değişkenlere textboxların içerisindeki değerleri atadık.
                //bu public değişkenlerini üretim formunda ekrana çekeceğiz.
                publicProgramName = programNameTextPP.Text;
                publicSubstrateHeater = substrateHeaterTextPP.Text;
                publicFlowRate = flowRateTextPP.Text;
                publicPassCount = passCountTextPP.Text;
                publicNozzleGas = nozzleGasPressureTextPP.Text;
                publicOxygen = oxygenLevelTextPP.Text;
                publicAmbience = ambienceTemperatureTextPP.Text;
                publicHumidity = humidityLevelTextPP.Text;
                if(excapeFunnelCheckBoxPP.Checked == true)
                {
                    publicExcapeFunnel = true;
                }
                if (nitrojenInletCheckBoxPP.Checked == true)
                {
                    publicNitrogen = true;
                }
                if (humidifierCheckBoxPP.Checked == true)
                {
                    publicHumidifier = true;
                }

                productionInfoSaveButton.Visible = false;
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz");
            }
        }

        private void SolutionInfoText_TextChanged(object sender, EventArgs e)
        {
            publicsolutionInfoText = solutionInfoText.Text;
            solutionInfoSaveButton.Enabled = true;
            if(!string.IsNullOrEmpty(solutionInfoText.Text))
            {
                solutionInfoSaveButton.Enabled = true;
            }
            else
            {
                solutionInfoSaveButton.Enabled = false;
            }
        }

        private void AllInfoSaveButton_Click(object sender, EventArgs e)
        {
            RefProduction.taskRateBarVar = allinfoentered;
            this.Close();
        }

        private void ExcapeFunnelCheckBoxPP_CheckedChanged(object sender, EventArgs e)
        {
            if(excapeFunnelCheckBoxPP.Checked == true)
            {
                excapeFunnelLabelPP.Text = "Açık";
                excapeFunnelLabelPP.ForeColor = Color.Green;
            }
            else
            {
                excapeFunnelLabelPP.Text = "Kapalı";
                excapeFunnelLabelPP.ForeColor = Color.Red;
            }
        }

        private void NitrojenInletCheckBoxPP_CheckedChanged(object sender, EventArgs e)
        {
            if(nitrojenInletCheckBoxPP.Checked == true)
            {
                nitrojenInletLabelPP.Text = "Açık";
                nitrojenInletLabelPP.ForeColor = Color.Green;
            }
            else
            {
                nitrojenInletLabelPP.Text = "Kapalı";
                nitrojenInletLabelPP.ForeColor = Color.Red;
            }
        }

        private void HumidifierCheckBoxPP_CheckedChanged(object sender, EventArgs e)
        {
            if(humidifierCheckBoxPP.Checked == true)
            {
                humidifierLabelPP.Text = "Açık";
                humidifierLabelPP.ForeColor = Color.Green;
            }
            else
            {
                humidifierLabelPP.Text = "Kapalı";
                humidifierLabelPP.ForeColor = Color.Red;
            }
        }
    }
}

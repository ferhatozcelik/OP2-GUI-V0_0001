using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace OP2_GUI_V0_0001
{
    public partial class RefProduction : MetroSet_UI.Forms.MetroSetForm
    {
        public RefProduction()
        {
            InitializeComponent();
        }
      
 
        public static int taskRateBarVar;
        public static string materialNameTextRP, numberOfSamplesTextRP, sampleSizeTextRP;
     
        private void RefProduction_Load(object sender, EventArgs e)
        {

        

        cleaninButton.Enabled = false;
            proParameterButton.Enabled = false;
            postProcessingBotton.Enabled = false;
            measuramentButton.Enabled = false;
            startProduction.Enabled = false;
            startProduction.Visible = false;
            numberOfSamplesText.Enabled = false;
            sampleSizeText.Enabled = false;

        }
       
    
    private void RefProduction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Initialize InitializeForm = new Initialize();
            InitializeForm.Show();
        }

        private void CleaninButton_Click(object sender, EventArgs e)
        {
            CleaningProcess cleaningProcessForm = new CleaningProcess();
            cleaningProcessForm.Show();
        }

        
        private void ProParameterButton_Click(object sender, EventArgs e)
        {
            ProductionParameters productionParametersForm = new ProductionParameters();
            productionParametersForm.Show();
        }

        private void PostProcessingBotton_Click(object sender, EventArgs e)
        {
            PostProcessing postProcessingForm = new PostProcessing();
            postProcessingForm.Show();
        }

        private void MeasuramentButton_Click(object sender, EventArgs e)
        {
            Measurements measurementsForm = new Measurements();
            measurementsForm.Show();
        }

        private void startProduction_Click(object sender, EventArgs e)
        {
            OnProduction onProductionForm = new OnProduction();
            onProductionForm.Show();
            this.Visible = false;
        }

        private void MalzemeAdi_TextChanged(object sender, EventArgs e)
        {//Textboxların kontrolleri yapıldı.
                if (!string.IsNullOrEmpty(materialNameText.Text))
                {
                    numberOfSamplesText.Enabled = true;
                    materialNameTextRP = materialNameText.Text;
                }
                else
                {
                    MessageBox.Show("Malzeme adı boş bırakılamaz!!");
                    numberOfSamplesText.Enabled = false;
                }
        }

        private void RefProduction_MouseMove(object sender, MouseEventArgs e)
        {
            switch (taskRateBarVar)//Butonları teker teker aktif ediyoruz!
            {//processbar her işlemden sonra dolduruluyor
                case 25:
                    {
                        progressBar.Value = 25;
                        proParameterButton.Enabled = true;
                      
                        break;
                    }
                case 50:
                    {
                        postProcessingBotton.Enabled = true;
                        progressBar.Value = 50;
                        break;
                    }
                case 75:
                    {
                        measuramentButton.Enabled = true;
                        progressBar.Value = 75;
                        break;
                    }
                case 100:
                    {
                        progressBar.Value = 100;
                        startProduction.Enabled = true;
                        startProduction.Visible = true;
                        break;
                    }
                default:
                    {
                        taskRateBarVar = 0;
                        break;
                    }
            }
        }

        private void infoRateBar_Click(object sender, EventArgs e)
        {

        }

        private void RefProduction_MouseMove(object sender, EventArgs e)
        {

        }

        private void progressBar_ValueChanged(object sender)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

     
     
    
        private void NumberOfSamplesText_TextChanged(object sender, EventArgs e)
        {
            //Numune sayısının 0 olduğu durum için ve boş olduğu durum için kod yazılmalı

            if (!string.IsNullOrEmpty(numberOfSamplesText.Text))
            {
                sampleSizeText.Enabled = true;
                cleaninButton.Enabled = true;
                numberOfSamplesTextRP = numberOfSamplesText.Text;
            }
            else
            {
                MessageBox.Show("Numune sayısı boş bırakılamaz!");
                sampleSizeText.Enabled = false;
            }
        }

        private void SampleSizeText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sampleSizeText.Text))
            {
                cleaninButton.Enabled = true;
                sampleSizeTextRP = sampleSizeText.Text;
            }
            else
            {
                MessageBox.Show("Numune boyutunu giriniz!");
                cleaninButton.Enabled = false;
            }
        }
    }
}

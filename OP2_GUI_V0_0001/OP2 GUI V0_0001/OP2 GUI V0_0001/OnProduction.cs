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
using System.IO.Ports;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = iTextSharp.text.Font;

namespace OP2_GUI_V0_0001
{
    public partial class OnProduction : MetroSet_UI.Forms.MetroSetForm
    {


        public OnProduction()
        {
            InitializeComponent();

            this.FormClosing += OnProduction_FormClosing;
        }
        private string data;


        private void OnProduction_FormClosing(object sender, FormClosingEventArgs e)
        {
    
            DialogResult dlgresult = MessageBox.Show("Üretimden Çıkmaktan Emin misiniz?",
                               " Emin misiniz?",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Information);

            if (dlgresult == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void OnProduction_Load(object sender, EventArgs e)
        {
          
            //Portları comboBox içerisine ekleyelim.
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            portsComboBox.Items.Add(ports);
            instantDataListBox.Visible = false;


            //Gelen veriyi DataReceived eventini kullanarak alıyoruz
            //Bu evetn ile seri portu dinleyerek porta veri geldiğinde gelen veriyi alarak data
            //değişkenine eşitleyeceğiz.
            // DataReceived olayını oluşturmak için aşağıdaki kodu yazıyoruz.
            sensors.DataReceived += new SerialDataReceivedEventHandler(Sensors_DataReceived);

            //Başlama saatini ekliyoruz.
            startTimeLabel.Text = DateTime.Now.ToShortTimeString();

            //Production Parameters kısmında belirlenen değerler
            programNameLabelOP.Text = ProductionParameters.publicProgramName;
            programNameLabelInstantValueOP.Text = ProductionParameters.publicProgramName;

            substrateHeaterLabelOP.Text = ProductionParameters.publicSubstrateHeater + " °C";
            substrateHeaterLabelInstantValueOP.Text = substrateHeaterLabelOP.Text = ProductionParameters.publicSubstrateHeater + " °C";

            flowRateLabelOP.Text = ProductionParameters.publicFlowRate + " ml/min";
            flowRateLabelInstantValueOP.Text = ProductionParameters.publicFlowRate + " ml/min";

            passCountLabelOP.Text = ProductionParameters.publicPassCount;
            passCountLabelInstantValueOP.Text = ProductionParameters.publicPassCount;

            nozzleGasPressureLabelOP.Text = ProductionParameters.publicNozzleGas + " PSI";
            nozzleGasPressureLabelInstantValueOP.Text = nozzleGasPressureLabelOP.Text = ProductionParameters.publicNozzleGas + " PSI";

            oxygenLevelSetLabelOP.Text = ProductionParameters.publicOxygen + " %";
            oxygenLevelLabelInstantValueOP.Text = ProductionParameters.publicOxygen + " %";

            ambienceTemperatureSetLabelOP.Text = ProductionParameters.publicAmbience + " °C";
            ambienceTemperatureLabelInstantValueOP.Text = ambienceTemperatureSetLabelOP.Text = ProductionParameters.publicAmbience + " °C";

            humidityLevelSetLabelOP.Text = ProductionParameters.publicHumidity + " %";
            humidityLevelLabelInstantValueOP.Text = humidityLevelSetLabelOP.Text = ProductionParameters.publicHumidity + " %";

            //Production Parameters kısmında belirlenen değerlerden anlık grup kutusuna eklenecek değerler
            substrateHeaterLabelInstantValueOP.Text = ProductionParameters.publicSubstrateHeater + " °C";
            flowRateLabelInstantValueOP.Text = ProductionParameters.publicFlowRate + " ml/min";
            nozzleGasPressureLabelInstantValueOP.Text = ProductionParameters.publicNozzleGas + " PSI";

            //Production Parameters kısmında belirlenen değerlerden üretim sırasında
            // belirlenecek parametler grup kutusuna eklenecek olan değerler
            excapeFunnelCheckBoxOP.Checked = ProductionParameters.publicExcapeFunnel;
            nitrojenInletCheckBoxOP.Checked = ProductionParameters.publicNitrogen;
            humidifierCheckBoxOP.Checked = ProductionParameters.publicHumidifier;

            if(excapeFunnelCheckBoxOP.Checked == true)
            {
                excapeFunnelLabelOP.Text = "Açık";
                excapeFunnelLabelOP.ForeColor = Color.Green;
            }
            if(nitrojenInletCheckBoxOP.Checked == true)
            {
                nitrojenInletLabelOP.Text = "Açık";
                nitrojenInletLabelOP.ForeColor = Color.Green;
            }
            if(humidifierCheckBoxOP.Checked == true)
            {
                humidifierLabelOP.Text = "Açık";
                humidifierLabelOP.ForeColor = Color.Green;
            }

            /*startingParametersGroupBox.Enabled = false;
            instantParametersGroupBox.Enabled = false;
            determineParametersGroupBox.Enabled = false;
            takeNoteGroupBox.Enabled = false;
            changesGroupBox.Enabled = false;*/  
            
          

        }


        private void ExcapeFunnelCheckBoxOP_CheckedChanged(object sender, EventArgs e)
        {
            //Çıkış Fanının durumu kontrol ediliyor
            if(excapeFunnelCheckBoxOP.Checked == true)
            {
                changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Çıkış fanı Açıldı.");
                excapeFunnelLabelOP.Text = "Açık";
                excapeFunnelLabelOP.ForeColor = Color.Green;
            
                    
            }
            else
            {
                changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Çıkış fanı Kapatıldı.");
                excapeFunnelLabelOP.Text = "Kapalı";
                excapeFunnelLabelOP.ForeColor = Color.Red;
               
            }
        }

        private void NitrojenInletCheckBoxOP_CheckedChanged(object sender, EventArgs e)
        {
            //Azot girişi seviyesindeki değişim kontrol ediliyor.
            if(nitrojenInletCheckBoxOP.Checked == true)
            {
                changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Azot gazı girişi açıldı.");
                nitrojenInletLabelOP.Text = "Açık";
                nitrojenInletLabelOP.ForeColor = Color.Green;
                
            }
            else
            {
                changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Azot gazı girişi kapatıldı.");
                nitrojenInletLabelOP.Text = "Kapalı";
                nitrojenInletLabelOP.ForeColor = Color.Red;
               
            }
        }

        private void HumidifierCheckBoxOP_CheckedChanged(object sender, EventArgs e)
        {
            //Nebulizerın açık veya kapalı durum değişimi kontrol ediliyor.
            if (humidifierCheckBoxOP.Checked == true)
            {
                changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Nebulizer Açıldı.");
                humidifierLabelOP.Text = "Açık";
                humidifierLabelOP.ForeColor = Color.Green;
                
            }
            else
            {
                changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Nebulizer kapatıldı.");
                humidifierLabelOP.Text = "Kapalı";
                humidifierLabelOP.ForeColor = Color.Red;

            }


        }

        private void Sensors_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            data = sensors.ReadLine();
           
        }

        private void PortsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sensors.PortName = portsComboBox.SelectedItem.ToString();
                sensors.BaudRate = 9600;
                sensors.Open();
                /*startingParametersGroupBox.Enabled = true;
                instantParametersGroupBox.Enabled = true;
                determineParametersGroupBox.Enabled = true;
                takeNoteGroupBox.Enabled = true;
                changesGroupBox.Enabled = true;*/
            }
            catch
            {
                MessageBox.Show("Hata oluştu!");
            }

        }

        private void UpdateParameterButton_Click(object sender, EventArgs e)
        {
      
            //Program Adı textbox'ının değerinin değişimi kontrol ediliyor.
            if (programNameTextActivateOP.Checked == true)
            {
                if(!string.IsNullOrEmpty(programNameTextOP.Text))
                {
                    changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Kullanılan program " + 
                        programNameTextOP.Text + " olarak ayarlandı.");
                    programNameLabelInstantValueOP.Text = programNameTextOP.Text;
                    programNameTextOP.Clear();
                }
            }

            //Alttaş ısıtıcının textbox'ının değerinin değişimi kontrol ediliyor.
            if(substrateHeaterTextActivateOP.Checked == true)
            {
                if(!string.IsNullOrEmpty(substrateHeaterTextOP.Text))
                {
                    changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Alt-taş sıcaklığı " + 
                        substrateHeaterTextOP.Text + " olarak ayarlandı.");
                    substrateHeaterLabelInstantValueOP.Text = substrateHeaterTextOP.Text;
                    substrateHeaterTextOP.Clear();
                }
            }

            //Akış Miktarının Textboxsının değerinin değişimi kontrol ediliyor.
            if (flowRateTextActivateOP.Checked == true)
            {
                if(!string.IsNullOrEmpty(flowRateTextOP.Text))
                {
                    changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Akış miktarı " + 
                        flowRateTextOP.Text + " ml/min olarak ayarlandı.");
                    flowRateLabelInstantValueOP.Text = flowRateTextOP.Text;
                    flowRateTextOP.Clear();
                }
            }

            //Geçiş sayısının textboxsının değerinin değişimi kontrol ediliyor.
            if(passCountTextActivateOP.Checked == true)
            {
                if(!string.IsNullOrEmpty(passCountTextOP.Text))
                {
                    changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Geçiş sayısı " + 
                        passCountTextOP.Text + " olarak ayarlandı.");
                    passCountLabelInstantValueOP.Text = passCountTextOP.Text;
                    passCountTextOP.Clear();
                }
            }

            //Nozzle gazının textboxsının değerinin değişimi kontrol ediliyor.
            if(nozzleGasPressureTextActivateOP.Checked == true)
            {
                if(!string.IsNullOrEmpty(nozzleGasPressureTextOP.Text))
                {
                    changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Nozzle gaz basıncı " + 
                        nozzleGasPressureTextOP.Text + " PSI olarak ayarlandı.");
                    nozzleGasPressureLabelInstantValueOP.Text = nozzleGasPressureTextOP.Text;
                    nozzleGasPressureTextOP.Clear();
                }
            }
            
            //oksijen Seviyesindeki değişim kontrol ediliyor.
            if(oxygenLevelTextActivateOP.Checked == true)
            {
                if(!string.IsNullOrEmpty(oxygenLevelTextOP.Text))
                {
                    changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Oksijen seviyesi % " + 
                        oxygenLevelTextOP.Text + " olarak ayarlandı.");
                    oxygenLevelLabelInstantValueOP.Text = oxygenLevelTextOP.Text;
                    oxygenLevelTextOP.Clear();
                }
            }

            //Ortam sıcaklığı seviyesindeki değişim kontrol ediliyor.
            if(ambienceTemperatureTextActivateOP.Checked == true)
            {
                if(!string.IsNullOrEmpty(ambienceTemperatureTextOP.Text))
                {
                    changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Ortam sıcaklığının üst değeri " + 
                        ambienceTemperatureTextOP.Text + " °C olarak ayarlandı.");
                    ambienceTemperatureLabelInstantValueOP.Text = ambienceTemperatureTextOP.Text;
                    ambienceTemperatureTextOP.Clear();
                }
            }

            //Nem seviyesinin üst değerindeki değişim kontrol ediliyor.
            if(humidityLevelTextActivateOP.Checked == true)
            {
                if(!string.IsNullOrEmpty(humidityLevelTextOP.Text))
                {
                    changesListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - Nemin üst değeri % " + 
                        humidityLevelTextOP.Text + " olarak ayarlandı.");
                    humidityLevelLabelInstantValueOP.Text = humidityLevelTextOP.Text;
                    humidityLevelTextOP.Clear();
                }
            }

            
        }
        string[] newNotes = new string[100];
        int countNote = 0;
        private void TakeNoteButton_Click(object sender, EventArgs e)
        {
            newNotes[countNote] = takeNotesText.Text;
            countNote++;
        }

        iTextSharp.text.Document rapor;
        private void EndOfProductionButton_Click(object sender, EventArgs e)
        {
            string filename = "C:/OP2GUI/";

            if (System.IO.Directory.Exists(filename))
            {
            }
            else
            {
                Directory.CreateDirectory(filename);
            }
        

        
            DateTime now = DateTime.Now;
            rapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(rapor, new FileStream("C:/OP2GUI/" + Initialize.name + DateTime.Now.ToString("yyyyMMddHHmmss") + "OP2GUI.pdf", FileMode.Create));
            rapor.SetMargins(80, 80, 80, 80);
            Initialize.name = TurkceKarakter(Initialize.name);
            rapor.AddAuthor(Initialize.name);
            rapor.AddCreationDate();
            rapor.AddCreator(Initialize.name);
            rapor.AddSubject(Initialize.name+"|OP2-GUI");


            if (rapor.IsOpen() == false)
            {
                rapor.Open();
            }


            BaseFont times = BaseFont.CreateFont("c:\\windows\\fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font16 = new Font(times, 16);
            Font font14 = new Font(times, 14);
            Font font12 = new Font(times, 12);

            ///Tarih Ekle
            Paragraph head0 = new Paragraph(now.ToString(), font12);
            head0.Alignment = Element.ALIGN_RIGHT;
            rapor.Add(head0);

            ////Başlık
            Paragraph head = new Paragraph("OP2-GUI", font16);
            head.Alignment = Element.ALIGN_CENTER;
            rapor.Add(head);

            ///Üretimden Sorumlu kişi
            Paragraph head2 = new Paragraph("Üretimden Sorumlu Kisi: " + Initialize.name, font14);
            head2.Alignment = Element.ALIGN_CENTER;
            rapor.Add(head2);

            /// Yeni Veriler
            PdfNewDataLeft("\n");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataCenter("Başlangıçta Belirlenen Parametreler");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataLeft("\n");


            PdfNewDataLeft("--------------------------------------------------");
            PdfNewDataLeft("Malzemenin Adı: " + RefProduction.materialNameTextRP);
            PdfNewDataLeft("Numume Adedi: " + RefProduction.numberOfSamplesTextRP);
            PdfNewDataLeft("Numune Boyutları: " + RefProduction.sampleSizeTextRP);
            PdfNewDataLeft("Üretim Türü: " + Initialize.publicrefProductiontext);
            PdfNewDataLeft("Solüsyon Bilgisi: " + ProductionParameters.publicsolutionInfoText);
            PdfNewDataLeft("--------------------------------------------------");

            PdfNewDataLeft("Başlangıç Saati: "+ DateTime.Now.ToShortTimeString());
            PdfNewDataLeft("Kullanılan Program: "+ programNameLabelOP.Text);
            PdfNewDataLeft("Alt-taş Sıcaklığı: " + substrateHeaterLabelOP.Text);
            PdfNewDataLeft("Akış Miktarı: "+ flowRateLabelOP.Text);
            PdfNewDataLeft("Geçiş Sayısı: " + passCountLabelOP.Text);
            PdfNewDataLeft("Nozzle Gaz: " + nozzleGasPressureLabelOP.Text);
            PdfNewDataLeft("Oksijen Seviyesi (SET): " + oxygenLevelSetLabelOP.Text);
            PdfNewDataLeft("Oksijen Seviyesi (Başlangıç): " + oxygenLevelStartLabelOP.Text);
            PdfNewDataLeft("Ortam Sıcaklığı (SET): "+ ambienceTemperatureSetLabelOP.Text);
            PdfNewDataLeft("Ortam Sıcaklığı (Başlangıç) :" + ambienceTemperatureStartLabelOP.Text);
            PdfNewDataLeft("Nem Seviyesi (SET) :" + humidityLevelSetLabelOP.Text);
            PdfNewDataLeft("Nem Seviyesi (Başlangıç) :" + humidityLevelStartLabelOP.Text);
            PdfNewDataLeft("Nemlendirici Gerilimi: " + humidityVoltageLabelOP.Text);
            PdfNewDataLeft("Fan Hızı : " + fanRPMLabelOP.Text);
            PdfNewDataLeft("--------------------------------------------------");

            PdfNewDataLeft("\n");
            PdfNewDataLeft("\n");
            PdfNewDataLeft("\n");
            PdfNewDataLeft("\n");
            PdfNewDataLeft("\n");
            PdfNewDataLeft("\n");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataCenter("Üretim Sırasında Belirlenen Parametreler");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataLeft("\n");


            if(changesListBox.Items.Count > 0)
            {
                PdfNewDataLeft("--------------------------------------------------");
                foreach (string item in changesListBox.Items)
                {
                    PdfNewDataLeft(item);
                }
                PdfNewDataLeft("--------------------------------------------------");
            }
           


            PdfNewDataLeft("\n");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataCenter("Üretim Sırasında Anlık Parametreler");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataLeft("\n");


            if (instantDataListBox.Items.Count > 0)
            {
                PdfNewDataLeft("--------------------------------------------------");
                foreach (string item in instantDataListBox.Items)
                {
                    PdfNewDataLeft(item);
                    Console.WriteLine(item);
                }
                PdfNewDataLeft("--------------------------------------------------");

            }

          
            PdfNewDataLeft("\n");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataCenter("Temizlik");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataLeft("\n");

            if(!(CleaningProcess.cleaningProcessCP == "")){ 
            PdfNewDataLeft("--------------------------------------------------");
            PdfNewDataLeft(CleaningProcess.cleaningProcessCP);
            PdfNewDataLeft("--------------------------------------------------");
            }


            PdfNewDataLeft("\n");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataCenter("İleri İşlemler");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataLeft("\n");


            if (!(PostProcessing.postProcessPOP == ""))
            {
                PdfNewDataLeft("--------------------------------------------------");
                PdfNewDataLeft(PostProcessing.postProcessPOP);
                PdfNewDataLeft("--------------------------------------------------");
            }


            PdfNewDataLeft("\n");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataCenter("Alınacak Olçümler");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataLeft("\n");


            if (Measurements.measumentsMP.Length > 0)
            {
                PdfNewDataLeft("--------------------------------------------------");
                foreach (var item in Measurements.measumentsMP)
                {
                PdfNewDataLeft(item);
                }
                PdfNewDataLeft("--------------------------------------------------");
            }


            PdfNewDataLeft("\n");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataCenter("Notlar");
            PdfNewDataCenter("--------------------------------------------------");
            PdfNewDataLeft("\n");


            if (!(takeNotesText.Text == ""))
            {
                PdfNewDataLeft("--------------------------------------------------");
                PdfNewDataLeft(takeNotesText.Text);
                PdfNewDataLeft("--------------------------------------------------");
            }

            rapor.Close();


           
            MessageBox.Show("Dosya Oluşturuldu.\n" + "C:/OP2GUI/" + Initialize.name + DateTime.Now.ToString("yyyyMMddHHmmss") + "OP2GUI.pdf");

            System.Diagnostics.Process.Start("C:/OP2GUI/");

            }

        private string PdfNewDataLeft(string v)
        {
            BaseFont times = BaseFont.CreateFont("c:\\windows\\fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(times, 12);
            Paragraph headv = new Paragraph(TurkceKarakter(v), font);
            headv.Alignment = Element.ALIGN_LEFT;
            rapor.Add(headv);

            return v;
        }
        private string PdfNewDataCenter(string v)
        {
            BaseFont times = BaseFont.CreateFont("c:\\windows\\fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(times, 12);
            Paragraph headv = new Paragraph(TurkceKarakter(v), font);
            headv.Alignment = Element.ALIGN_CENTER;
            rapor.Add(headv);

            return v;
        }

        public string TurkceKarakter(string text)
        {

            try
            {
                text = text.Replace("İ", "\u0130");

                text = text.Replace("ı", "\u0131");

                text = text.Replace("Ş", "\u015e");

                text = text.Replace("ş", "\u015f");

                text = text.Replace("Ğ", "\u011e");

                text = text.Replace("ğ", "\u011f");

                text = text.Replace("Ö", "\u00d6");

                text = text.Replace("ö", "\u00f6");

                text = text.Replace("ç", "\u00e7");

                text = text.Replace("Ç", "\u00c7");

                text = text.Replace("ü", "\u00fc");

                text = text.Replace("Ü", "\u00dc");

            }
            catch (Exception)
            {

            }
           
            return text;
        }

       

        private void programNameLabelInstantValueOP_TextChanged(object sender, EventArgs e)
        {
            //instantStatusListBoxNewData("P"+programNameLabelInstantValueOP.Text);
        }

        private void substrateHeaterLabelInstantValueOP_TextChanged(object sender, EventArgs e)
        {

            instantStatusListBoxNewData("Alt-Taş Sıcaklığı: "+ substrateHeaterLabelInstantValueOP.Text);
        }

        private void flowRateLabelInstantValueOP_TextChanged(object sender, EventArgs e)
        {

            instantStatusListBoxNewData("Akış Miktarı: "+flowRateLabelInstantValueOP.Text);
        }

        private void passCountLabelInstantValueOP_TextChanged(object sender, EventArgs e)
        {

            instantStatusListBoxNewData("Geçiş Sayısı: " + passCountLabelInstantValueOP.Text);
        }

        private void nozzleGasPressureLabelInstantValueOP_TextChanged(object sender, EventArgs e)
        {

            instantStatusListBoxNewData("Nozzle Gazı: " + nozzleGasPressureLabelInstantValueOP.Text);
        }

        private void humidityVoltageLabelInstantValueOP_TextChanged(object sender, EventArgs e)
        {

            instantStatusListBoxNewData("Oksijen Seviyesi: " + humidityVoltageLabelInstantValueOP.Text);
        }

        private void oxygenLevelLabelInstantValueOP_TextChanged(object sender, EventArgs e)
        {

            instantStatusListBoxNewData("Ortam Sıcaklığı: " + oxygenLevelLabelInstantValueOP.Text);
        }

        private void ambienceTemperatureLabelInstantValueOP_TextChanged(object sender, EventArgs e)
        {

            instantStatusListBoxNewData("Nem Seviyesi: " + ambienceTemperatureLabelInstantValueOP.Text);
        }

        private void humidityLevelLabelInstantValueOP_TextChanged(object sender, EventArgs e)
        {
            instantStatusListBoxNewData("Nemlendirici Gerilim: " + humidityLevelLabelInstantValueOP.Text);
        }

        private void fanRPMLabelInstantValueOP_TextChanged(object sender, EventArgs e)
        {

            instantStatusListBoxNewData("Fan Hızı: " + fanRPMLabelInstantValueOP.Text);

        }
        public void instantStatusListBoxNewData(string v)
        {

            instantDataListBox.Items.Add(v);
       
        }

        private void takeNotesText_TextChanged(object sender, EventArgs e)
        {
            newNotes[countNote] = takeNotesText.Text;
            countNote++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}

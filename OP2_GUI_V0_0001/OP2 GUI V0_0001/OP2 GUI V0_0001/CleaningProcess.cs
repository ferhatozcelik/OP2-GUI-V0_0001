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
    public partial class CleaningProcess : MetroSet_UI.Forms.MetroSetForm
    {
        public CleaningProcess()
        {
            InitializeComponent();
        }

        public static string cleaningProcessCP;

        private void CleaningProcess_Load(object sender, EventArgs e)
        {
            cleaningSaveButton.Enabled = false;
        }

        private void CleaningProcessText_TextChanged(object sender, EventArgs e)
        {//Yazı yazılmaya başlandığında kaydet butonu aktifleştiriliyor.
            if (!string.IsNullOrEmpty(cleaningProcessText.Text))
            {//Yazı yazılıp yazılmadığını kontrol ediyoruz.
                cleaningSaveButton.Enabled = true;
            }
            else
            {//Yazı yok ise kaydet butonu deaktif oluyor.
                cleaningSaveButton.Enabled = false;
            }
        }

        private void CleaningSaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cleaningProcessText.Text))
            {//Yazı yazılıp yazılmadığını kontrol ediyoruz.
                cleaningProcessCP = cleaningProcessText.Text;
                RefProduction.taskRateBarVar = 25;
            
            }
            this.Close();//Pencereyi kapatıyor.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

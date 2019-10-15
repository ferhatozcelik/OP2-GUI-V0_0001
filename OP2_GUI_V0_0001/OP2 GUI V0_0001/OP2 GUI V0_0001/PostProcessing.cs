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
    public partial class PostProcessing : MetroSet_UI.Forms.MetroSetForm
    {
        public PostProcessing()
        {
            InitializeComponent();
        }

        public static string postProcessPOP;

        private void PostProcessing_Load(object sender, EventArgs e)
        {
            postProcessSaveButton.Enabled = false;
        }

        private void PostProcessText_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(postProcessText.Text))
            {
                postProcessSaveButton.Enabled = true;
            }
            else
            {
                postProcessSaveButton.Enabled = false;
            }
        }

        private void PostProcessSaveButton_Click(object sender, EventArgs e)
        {
            postProcessPOP = postProcessText.Text;
            RefProduction.taskRateBarVar = 75;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

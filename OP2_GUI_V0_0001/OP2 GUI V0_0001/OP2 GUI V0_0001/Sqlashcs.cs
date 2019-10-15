using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP2_GUI_V0_0001
{
    public partial class Sqlashcs : MetroSet_UI.Forms.MetroSetForm
    {
        public Sqlashcs()
        {
            InitializeComponent();
        }

        private void Start()
        {
            Initialize InitializeForm = new Initialize();
            InitializeForm.Show();

        }

        private void Sqlashcs_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.metroSetProgressBar1.Value != 100)
            {
                this.metroSetProgressBar1.Value += 5;
            }

            if (metroSetProgressBar1.Value == 95)
            {
                this.Hide();
            }
                if (metroSetProgressBar1.Value == 100)
            {
                Start();
                timer1.Stop();
     
            }

            

        }

        private void Sqlashcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start();
        }
    }
}

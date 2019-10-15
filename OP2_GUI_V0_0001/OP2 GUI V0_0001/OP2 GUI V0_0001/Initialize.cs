using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP2_GUI_V0_0001
{
    public partial class Initialize : MetroSet_UI.Forms.MetroSetForm
    {
        /* Formların değişken olarak ayarlanması */
        readonly RefProduction reffProductionForm = new RefProduction();
        readonly CleaningProcess CleaningProcessForm = new CleaningProcess();
        readonly ProductionParameters ProductionParametersForm = new ProductionParameters();
        readonly PostProcessing PostProcessingForm = new PostProcessing();
        readonly Measurements MeasurementsForm = new Measurements();

        public static string publicrefProductiontext ;

       public Initialize()
        {
            InitializeComponent();
        }
        public static string name;


        private void InitializeButton_Click(object sender, EventArgs e)
        {
            if (refProduction.Checked)
                reffProductionForm.Show();

            this.Hide();
        }

        private void InitializeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reffProductionForm.Close();
            CleaningProcessForm.Close();
            ProductionParametersForm.Close();
            PostProcessingForm.Close();
            MeasurementsForm.Close();

            Application.Exit();
        }

        private void Initialize_Load(object sender, EventArgs e)
        {
            publicrefProductiontext = refProduction.Text;
            label2.Visible = false;
            opvProduction.Enabled = false;
            ofetProduction.Enabled = false;
            groupBox1.Visible = false;
            usernameLabel.Visible = false;
            name = nameTextBox.Text;
            this.Size = new Size(500,180);

        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Ad Soyad Giriniz!");
                }
                else
                {
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    singIn.Visible = false;
                    initializeButton.Visible = true;
                    usernameLabel.Visible = true;
                    label2.Visible = true;
                    usernameLabel.Visible = true;
                    usernameLabel.Text = nameTextBox.Text;
                    name = nameTextBox.Text;
                    this.Size = new Size(500, 260);

                }

            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void refProduction_CheckedChanged(object sender, EventArgs e)
        {
            publicrefProductiontext = refProduction.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Ad Soyad Giriniz!");
            }
            else
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                singIn.Visible = false;
                initializeButton.Visible = true;
                usernameLabel.Visible = true; 
                label2.Visible = true;
                usernameLabel.Visible = true;
                usernameLabel.Text = nameTextBox.Text;
                name = nameTextBox.Text;
                this.Size = new Size(500, 260);
              
            }

        }

        private void opvProduction_CheckedChanged(object sender, EventArgs e)
        {
            publicrefProductiontext = opvProduction.Text;
        }

        private void ofetProduction_CheckedChanged(object sender, EventArgs e)
        {
            publicrefProductiontext = ofetProduction.Text;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Initialize_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}

namespace OP2_GUI_V0_0001
{
    partial class RefProduction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefProduction));
            this.label1 = new System.Windows.Forms.Label();
            this.materialNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfSamplesText = new System.Windows.Forms.TextBox();
            this.cleaninButton = new System.Windows.Forms.Button();
            this.proParameterButton = new System.Windows.Forms.Button();
            this.postProcessingBotton = new System.Windows.Forms.Button();
            this.measuramentButton = new System.Windows.Forms.Button();
            this.startProduction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sampleSizeText = new System.Windows.Forms.TextBox();
            this.progressBar = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(97, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzemenin Adı :";
            // 
            // materialNameText
            // 
            this.materialNameText.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialNameText.Location = new System.Drawing.Point(100, 92);
            this.materialNameText.Margin = new System.Windows.Forms.Padding(2);
            this.materialNameText.Name = "materialNameText";
            this.materialNameText.Size = new System.Drawing.Size(115, 21);
            this.materialNameText.TabIndex = 1;
            this.materialNameText.TextChanged += new System.EventHandler(this.MalzemeAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(230, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numune Adedi :";
            // 
            // numberOfSamplesText
            // 
            this.numberOfSamplesText.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfSamplesText.Location = new System.Drawing.Point(233, 92);
            this.numberOfSamplesText.Margin = new System.Windows.Forms.Padding(2);
            this.numberOfSamplesText.Name = "numberOfSamplesText";
            this.numberOfSamplesText.Size = new System.Drawing.Size(107, 21);
            this.numberOfSamplesText.TabIndex = 3;
            this.numberOfSamplesText.TextChanged += new System.EventHandler(this.NumberOfSamplesText_TextChanged);
            // 
            // cleaninButton
            // 
            this.cleaninButton.BackColor = System.Drawing.Color.Transparent;
            this.cleaninButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleaninButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleaninButton.ForeColor = System.Drawing.Color.Maroon;
            this.cleaninButton.Location = new System.Drawing.Point(32, 125);
            this.cleaninButton.Margin = new System.Windows.Forms.Padding(2);
            this.cleaninButton.Name = "cleaninButton";
            this.cleaninButton.Size = new System.Drawing.Size(114, 50);
            this.cleaninButton.TabIndex = 4;
            this.cleaninButton.Text = "Temizlik";
            this.cleaninButton.UseVisualStyleBackColor = false;
            this.cleaninButton.Click += new System.EventHandler(this.CleaninButton_Click);
            // 
            // proParameterButton
            // 
            this.proParameterButton.BackColor = System.Drawing.Color.Transparent;
            this.proParameterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proParameterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proParameterButton.ForeColor = System.Drawing.Color.Maroon;
            this.proParameterButton.Location = new System.Drawing.Point(150, 125);
            this.proParameterButton.Margin = new System.Windows.Forms.Padding(2);
            this.proParameterButton.Name = "proParameterButton";
            this.proParameterButton.Size = new System.Drawing.Size(157, 50);
            this.proParameterButton.TabIndex = 5;
            this.proParameterButton.Text = "Üretim Parametreler";
            this.proParameterButton.UseVisualStyleBackColor = false;
            this.proParameterButton.Click += new System.EventHandler(this.ProParameterButton_Click);
            // 
            // postProcessingBotton
            // 
            this.postProcessingBotton.BackColor = System.Drawing.Color.Transparent;
            this.postProcessingBotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postProcessingBotton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postProcessingBotton.ForeColor = System.Drawing.Color.Maroon;
            this.postProcessingBotton.Location = new System.Drawing.Point(311, 125);
            this.postProcessingBotton.Margin = new System.Windows.Forms.Padding(2);
            this.postProcessingBotton.Name = "postProcessingBotton";
            this.postProcessingBotton.Size = new System.Drawing.Size(125, 51);
            this.postProcessingBotton.TabIndex = 6;
            this.postProcessingBotton.Text = "İleri İşlemler";
            this.postProcessingBotton.UseVisualStyleBackColor = false;
            this.postProcessingBotton.Click += new System.EventHandler(this.PostProcessingBotton_Click);
            // 
            // measuramentButton
            // 
            this.measuramentButton.BackColor = System.Drawing.Color.Transparent;
            this.measuramentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.measuramentButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measuramentButton.ForeColor = System.Drawing.Color.Maroon;
            this.measuramentButton.Location = new System.Drawing.Point(440, 125);
            this.measuramentButton.Margin = new System.Windows.Forms.Padding(2);
            this.measuramentButton.Name = "measuramentButton";
            this.measuramentButton.Size = new System.Drawing.Size(110, 51);
            this.measuramentButton.TabIndex = 7;
            this.measuramentButton.Text = "Alınacak Ölçümler";
            this.measuramentButton.UseVisualStyleBackColor = false;
            this.measuramentButton.Click += new System.EventHandler(this.MeasuramentButton_Click);
            // 
            // startProduction
            // 
            this.startProduction.BackColor = System.Drawing.Color.Transparent;
            this.startProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startProduction.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startProduction.ForeColor = System.Drawing.Color.Maroon;
            this.startProduction.Location = new System.Drawing.Point(369, 5);
            this.startProduction.Margin = new System.Windows.Forms.Padding(2);
            this.startProduction.Name = "startProduction";
            this.startProduction.Size = new System.Drawing.Size(183, 30);
            this.startProduction.TabIndex = 9;
            this.startProduction.Text = "ÜRETİMİ BAŞLAT";
            this.startProduction.UseVisualStyleBackColor = false;
            this.startProduction.Click += new System.EventHandler(this.startProduction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(358, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numune Boyutları :";
            // 
            // sampleSizeText
            // 
            this.sampleSizeText.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleSizeText.Location = new System.Drawing.Point(361, 92);
            this.sampleSizeText.Margin = new System.Windows.Forms.Padding(2);
            this.sampleSizeText.Name = "sampleSizeText";
            this.sampleSizeText.Size = new System.Drawing.Size(128, 21);
            this.sampleSizeText.TabIndex = 11;
            this.sampleSizeText.TextChanged += new System.EventHandler(this.SampleSizeText_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.BackgroundColor = System.Drawing.Color.Transparent;
            this.progressBar.BorderColor = System.Drawing.Color.Maroon;
            this.progressBar.DisabledBackColor = System.Drawing.Color.Maroon;
            this.progressBar.DisabledBorderColor = System.Drawing.Color.Maroon;
            this.progressBar.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBar.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar.Location = new System.Drawing.Point(42, 5);
            this.progressBar.Maximum = 100;
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBar.Size = new System.Drawing.Size(322, 30);
            this.progressBar.Style = MetroSet_UI.Design.Style.Custom;
            this.progressBar.StyleManager = null;
            this.progressBar.TabIndex = 12;
            this.progressBar.ThemeAuthor = "Narwin";
            this.progressBar.ThemeName = "MetroDark";
            this.progressBar.Value = 0;
            this.progressBar.ValueChanged += new MetroSet_UI.Controls.MetroSetProgressBar.ValueChangedEventHandler(this.progressBar_ValueChanged);
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RefProduction_MouseMove);
            this.progressBar.MouseEnter += new System.EventHandler(this.RefProduction_MouseMove);
            this.progressBar.MouseLeave += new System.EventHandler(this.RefProduction_MouseMove);
            this.progressBar.MouseHover += new System.EventHandler(this.RefProduction_MouseMove);
            this.progressBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RefProduction_MouseMove);
            this.progressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RefProduction_MouseMove);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.CausesValidation = false;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(8, 5);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // RefProduction
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(569, 186);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.sampleSizeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startProduction);
            this.Controls.Add(this.measuramentButton);
            this.Controls.Add(this.postProcessingBotton);
            this.Controls.Add(this.proParameterButton);
            this.Controls.Add(this.cleaninButton);
            this.Controls.Add(this.numberOfSamplesText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialNameText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RefProduction";
            this.Padding = new System.Windows.Forms.Padding(13, 66, 13, 11);
            this.SmallLineColor1 = System.Drawing.Color.Maroon;
            this.SmallLineColor2 = System.Drawing.Color.Maroon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Referans Belirleme Üretimi";
            this.TextColor = System.Drawing.Color.Maroon;
            this.UseSlideAnimation = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RefProduction_FormClosed);
            this.Load += new System.EventHandler(this.RefProduction_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RefProduction_MouseMove);
            this.MouseEnter += new System.EventHandler(this.RefProduction_MouseMove);
            this.MouseLeave += new System.EventHandler(this.RefProduction_MouseMove);
            this.MouseHover += new System.EventHandler(this.RefProduction_MouseMove);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RefProduction_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RefProduction_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox materialNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberOfSamplesText;
        private System.Windows.Forms.Button cleaninButton;
        private System.Windows.Forms.Button proParameterButton;
        private System.Windows.Forms.Button postProcessingBotton;
        private System.Windows.Forms.Button measuramentButton;
        private System.Windows.Forms.Button startProduction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sampleSizeText;
        private MetroSet_UI.Controls.MetroSetProgressBar progressBar;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
namespace OP2_GUI_V0_0001
{
    partial class Initialize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initialize));
            this.refProduction = new System.Windows.Forms.RadioButton();
            this.opvProduction = new System.Windows.Forms.RadioButton();
            this.ofetProduction = new System.Windows.Forms.RadioButton();
            this.initializeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.singIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // refProduction
            // 
            this.refProduction.AutoSize = true;
            this.refProduction.Checked = true;
            this.refProduction.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refProduction.ForeColor = System.Drawing.Color.Maroon;
            this.refProduction.Location = new System.Drawing.Point(5, 31);
            this.refProduction.Margin = new System.Windows.Forms.Padding(2);
            this.refProduction.Name = "refProduction";
            this.refProduction.Size = new System.Drawing.Size(204, 20);
            this.refProduction.TabIndex = 1;
            this.refProduction.TabStop = true;
            this.refProduction.Text = "Referans belirleme Üretimi";
            this.refProduction.UseVisualStyleBackColor = true;
            this.refProduction.CheckedChanged += new System.EventHandler(this.refProduction_CheckedChanged);
            // 
            // opvProduction
            // 
            this.opvProduction.AutoSize = true;
            this.opvProduction.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opvProduction.ForeColor = System.Drawing.Color.Red;
            this.opvProduction.Location = new System.Drawing.Point(5, 66);
            this.opvProduction.Margin = new System.Windows.Forms.Padding(2);
            this.opvProduction.Name = "opvProduction";
            this.opvProduction.Size = new System.Drawing.Size(230, 20);
            this.opvProduction.TabIndex = 2;
            this.opvProduction.Text = "Organik Güneş Hücresi Üretimi";
            this.opvProduction.UseVisualStyleBackColor = true;
            this.opvProduction.CheckedChanged += new System.EventHandler(this.opvProduction_CheckedChanged);
            // 
            // ofetProduction
            // 
            this.ofetProduction.AutoSize = true;
            this.ofetProduction.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ofetProduction.ForeColor = System.Drawing.Color.Red;
            this.ofetProduction.Location = new System.Drawing.Point(5, 104);
            this.ofetProduction.Margin = new System.Windows.Forms.Padding(2);
            this.ofetProduction.Name = "ofetProduction";
            this.ofetProduction.Size = new System.Drawing.Size(273, 20);
            this.ofetProduction.TabIndex = 3;
            this.ofetProduction.TabStop = true;
            this.ofetProduction.Text = "Organik Alan Etkili Transistor Üretimi";
            this.ofetProduction.UseVisualStyleBackColor = true;
            this.ofetProduction.CheckedChanged += new System.EventHandler(this.ofetProduction_CheckedChanged);
            // 
            // initializeButton
            // 
            this.initializeButton.BackColor = System.Drawing.Color.White;
            this.initializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initializeButton.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initializeButton.ForeColor = System.Drawing.Color.Maroon;
            this.initializeButton.Location = new System.Drawing.Point(323, 156);
            this.initializeButton.Margin = new System.Windows.Forms.Padding(2);
            this.initializeButton.Name = "initializeButton";
            this.initializeButton.Size = new System.Drawing.Size(137, 45);
            this.initializeButton.TabIndex = 4;
            this.initializeButton.Text = "Baslat";
            this.initializeButton.UseVisualStyleBackColor = false;
            this.initializeButton.Visible = false;
            this.initializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.refProduction);
            this.groupBox1.Controls.Add(this.opvProduction);
            this.groupBox1.Controls.Add(this.ofetProduction);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(19, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üretim Türünüzü Seçiniz";
            this.groupBox1.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(107, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 27);
            this.nameTextBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 62);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Girisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad Soyad";
            // 
            // singIn
            // 
            this.singIn.BackColor = System.Drawing.Color.White;
            this.singIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singIn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singIn.ForeColor = System.Drawing.Color.Maroon;
            this.singIn.Location = new System.Drawing.Point(323, 113);
            this.singIn.Margin = new System.Windows.Forms.Padding(2);
            this.singIn.Name = "singIn";
            this.singIn.Size = new System.Drawing.Size(137, 52);
            this.singIn.TabIndex = 8;
            this.singIn.Text = "Giris Yap";
            this.singIn.UseVisualStyleBackColor = false;
            this.singIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Üretimi Yapan Kisi:";
            this.label2.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(206, 77);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(20, 23);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(465, 5);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(430, 4);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Initialize
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BorderColor = System.Drawing.Color.Maroon;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(500, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.singIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.initializeButton);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Initialize";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.SmallLineColor1 = System.Drawing.Color.Maroon;
            this.SmallLineColor2 = System.Drawing.Color.Maroon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORGANİK CİHAZ ÜRETİMİ KULLANICI ARAYÜZÜ";
            this.TextColor = System.Drawing.Color.Maroon;
            this.UseSlideAnimation = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InitializeForm_FormClosed);
            this.Load += new System.EventHandler(this.Initialize_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Initialize_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton refProduction;
        private System.Windows.Forms.RadioButton opvProduction;
        private System.Windows.Forms.RadioButton ofetProduction;
        private System.Windows.Forms.Button initializeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button singIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


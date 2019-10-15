namespace OP2_GUI_V0_0001
{
    partial class CleaningProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleaningProcess));
            this.cleaningProcessText = new System.Windows.Forms.RichTextBox();
            this.cleaningSaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cleaningProcessText
            // 
            this.cleaningProcessText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cleaningProcessText.ForeColor = System.Drawing.Color.Maroon;
            this.cleaningProcessText.Location = new System.Drawing.Point(14, 83);
            this.cleaningProcessText.Margin = new System.Windows.Forms.Padding(2);
            this.cleaningProcessText.Name = "cleaningProcessText";
            this.cleaningProcessText.Size = new System.Drawing.Size(304, 137);
            this.cleaningProcessText.TabIndex = 0;
            this.cleaningProcessText.Text = "";
            this.cleaningProcessText.TextChanged += new System.EventHandler(this.CleaningProcessText_TextChanged);
            // 
            // cleaningSaveButton
            // 
            this.cleaningSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.cleaningSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleaningSaveButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleaningSaveButton.ForeColor = System.Drawing.Color.Maroon;
            this.cleaningSaveButton.Location = new System.Drawing.Point(14, 224);
            this.cleaningSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.cleaningSaveButton.Name = "cleaningSaveButton";
            this.cleaningSaveButton.Size = new System.Drawing.Size(304, 33);
            this.cleaningSaveButton.TabIndex = 1;
            this.cleaningSaveButton.Text = "KAYDET";
            this.cleaningSaveButton.UseVisualStyleBackColor = false;
            this.cleaningSaveButton.Click += new System.EventHandler(this.CleaningSaveButton_Click);
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
            this.button1.Location = new System.Drawing.Point(288, 5);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CleaningProcess
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BorderColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(332, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cleaningSaveButton);
            this.Controls.Add(this.cleaningProcessText);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CleaningProcess";
            this.SmallLineColor1 = System.Drawing.Color.Maroon;
            this.SmallLineColor2 = System.Drawing.Color.Maroon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temizlik İşlemi";
            this.TextColor = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.CleaningProcess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox cleaningProcessText;
        private System.Windows.Forms.Button cleaningSaveButton;
        private System.Windows.Forms.Button button1;
    }
}
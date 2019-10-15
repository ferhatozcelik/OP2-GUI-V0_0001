namespace OP2_GUI_V0_0001
{
    partial class PostProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostProcessing));
            this.postProcessText = new System.Windows.Forms.RichTextBox();
            this.postProcessSaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postProcessText
            // 
            this.postProcessText.Location = new System.Drawing.Point(15, 69);
            this.postProcessText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postProcessText.Name = "postProcessText";
            this.postProcessText.Size = new System.Drawing.Size(359, 144);
            this.postProcessText.TabIndex = 0;
            this.postProcessText.Text = "";
            this.postProcessText.TextChanged += new System.EventHandler(this.PostProcessText_TextChanged);
            // 
            // postProcessSaveButton
            // 
            this.postProcessSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.postProcessSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postProcessSaveButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postProcessSaveButton.ForeColor = System.Drawing.Color.Maroon;
            this.postProcessSaveButton.Location = new System.Drawing.Point(15, 216);
            this.postProcessSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postProcessSaveButton.Name = "postProcessSaveButton";
            this.postProcessSaveButton.Size = new System.Drawing.Size(359, 42);
            this.postProcessSaveButton.TabIndex = 1;
            this.postProcessSaveButton.Text = "Devam Et";
            this.postProcessSaveButton.UseVisualStyleBackColor = false;
            this.postProcessSaveButton.Click += new System.EventHandler(this.PostProcessSaveButton_Click);
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
            this.button1.Location = new System.Drawing.Point(341, 8);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PostProcessing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BorderColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(388, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.postProcessSaveButton);
            this.Controls.Add(this.postProcessText);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PostProcessing";
            this.Padding = new System.Windows.Forms.Padding(14, 66, 14, 12);
            this.SmallLineColor1 = System.Drawing.Color.Maroon;
            this.SmallLineColor2 = System.Drawing.Color.Maroon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üretim Sonrası İşlemler";
            this.TextColor = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.PostProcessing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox postProcessText;
        private System.Windows.Forms.Button postProcessSaveButton;
        private System.Windows.Forms.Button button1;
    }
}
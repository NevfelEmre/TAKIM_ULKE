
namespace TAKIM_ULKE
{
    partial class AdderForm
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
            this.takimEkleButtonAdder = new System.Windows.Forms.Button();
            this.takimLabel = new System.Windows.Forms.Label();
            this.takimComboBoxAdder = new System.Windows.Forms.ComboBox();
            this.ulkeLabel = new System.Windows.Forms.Label();
            this.ulkeComboBoxAdder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kurulusTextBoxAdder = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // takimEkleButtonAdder
            // 
            this.takimEkleButtonAdder.BackColor = System.Drawing.Color.Aqua;
            this.takimEkleButtonAdder.Font = new System.Drawing.Font("Swis721 Blk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takimEkleButtonAdder.Location = new System.Drawing.Point(272, 236);
            this.takimEkleButtonAdder.Name = "takimEkleButtonAdder";
            this.takimEkleButtonAdder.Size = new System.Drawing.Size(240, 80);
            this.takimEkleButtonAdder.TabIndex = 8;
            this.takimEkleButtonAdder.Text = "Takım Ekle / \r\nTarih Değiştir";
            this.takimEkleButtonAdder.UseVisualStyleBackColor = false;
            this.takimEkleButtonAdder.Click += new System.EventHandler(this.takimEkleButtonAdder_Click);
            // 
            // takimLabel
            // 
            this.takimLabel.AccessibleName = "";
            this.takimLabel.AutoSize = true;
            this.takimLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takimLabel.Location = new System.Drawing.Point(40, 112);
            this.takimLabel.Name = "takimLabel";
            this.takimLabel.Size = new System.Drawing.Size(70, 21);
            this.takimLabel.TabIndex = 12;
            this.takimLabel.Text = "Takım";
            // 
            // takimComboBoxAdder
            // 
            this.takimComboBoxAdder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takimComboBoxAdder.FormattingEnabled = true;
            this.takimComboBoxAdder.Location = new System.Drawing.Point(128, 104);
            this.takimComboBoxAdder.Name = "takimComboBoxAdder";
            this.takimComboBoxAdder.Size = new System.Drawing.Size(384, 28);
            this.takimComboBoxAdder.TabIndex = 11;
            this.takimComboBoxAdder.SelectedIndexChanged += new System.EventHandler(this.takimComboBoxAdder_SelectedIndexChanged);
            // 
            // ulkeLabel
            // 
            this.ulkeLabel.AutoSize = true;
            this.ulkeLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ulkeLabel.Location = new System.Drawing.Point(40, 37);
            this.ulkeLabel.Name = "ulkeLabel";
            this.ulkeLabel.Size = new System.Drawing.Size(55, 21);
            this.ulkeLabel.TabIndex = 10;
            this.ulkeLabel.Text = "Ülke";
            // 
            // ulkeComboBoxAdder
            // 
            this.ulkeComboBoxAdder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ulkeComboBoxAdder.FormattingEnabled = true;
            this.ulkeComboBoxAdder.Location = new System.Drawing.Point(128, 31);
            this.ulkeComboBoxAdder.Name = "ulkeComboBoxAdder";
            this.ulkeComboBoxAdder.Size = new System.Drawing.Size(384, 28);
            this.ulkeComboBoxAdder.TabIndex = 9;
            this.ulkeComboBoxAdder.SelectedIndexChanged += new System.EventHandler(this.ulkeComboBoxAdder_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kuruluş Tarihi";
            // 
            // kurulusTextBoxAdder
            // 
            this.kurulusTextBoxAdder.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kurulusTextBoxAdder.Location = new System.Drawing.Point(40, 246);
            this.kurulusTextBoxAdder.Name = "kurulusTextBoxAdder";
            this.kurulusTextBoxAdder.Size = new System.Drawing.Size(147, 70);
            this.kurulusTextBoxAdder.TabIndex = 15;
            this.kurulusTextBoxAdder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Violet;
            this.backButton.Font = new System.Drawing.Font("Swis721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(403, 162);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(109, 55);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Geri =>";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AdderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(542, 343);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.kurulusTextBoxAdder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.takimLabel);
            this.Controls.Add(this.takimComboBoxAdder);
            this.Controls.Add(this.ulkeLabel);
            this.Controls.Add(this.ulkeComboBoxAdder);
            this.Controls.Add(this.takimEkleButtonAdder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AdderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takım Ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdderForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button takimEkleButtonAdder;
        internal System.Windows.Forms.Label takimLabel;
        internal System.Windows.Forms.ComboBox takimComboBoxAdder;
        internal System.Windows.Forms.Label ulkeLabel;
        internal System.Windows.Forms.ComboBox ulkeComboBoxAdder;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox kurulusTextBoxAdder;
        private System.Windows.Forms.Button backButton;
    }
}
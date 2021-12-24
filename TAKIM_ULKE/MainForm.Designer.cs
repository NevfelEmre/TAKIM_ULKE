
namespace TAKIM_ULKE
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ulkeComboBox = new System.Windows.Forms.ComboBox();
            this.ulkeLabel = new System.Windows.Forms.Label();
            this.takimLabel = new System.Windows.Forms.Label();
            this.takimComboBox = new System.Windows.Forms.ComboBox();
            this.kurulusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.takimEkleButton = new System.Windows.Forms.Button();
            this.takimCikarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ulkeComboBox
            // 
            this.ulkeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ulkeComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ulkeComboBox.FormattingEnabled = true;
            this.ulkeComboBox.Location = new System.Drawing.Point(139, 46);
            this.ulkeComboBox.Name = "ulkeComboBox";
            this.ulkeComboBox.Size = new System.Drawing.Size(384, 28);
            this.ulkeComboBox.TabIndex = 0;
            this.ulkeComboBox.SelectedIndexChanged += new System.EventHandler(this.ulkeComboBox_SelectedIndexChanged);
            // 
            // ulkeLabel
            // 
            this.ulkeLabel.AutoSize = true;
            this.ulkeLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ulkeLabel.Location = new System.Drawing.Point(51, 52);
            this.ulkeLabel.Name = "ulkeLabel";
            this.ulkeLabel.Size = new System.Drawing.Size(55, 21);
            this.ulkeLabel.TabIndex = 1;
            this.ulkeLabel.Text = "Ülke";
            // 
            // takimLabel
            // 
            this.takimLabel.AccessibleName = "";
            this.takimLabel.AutoSize = true;
            this.takimLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takimLabel.Location = new System.Drawing.Point(51, 127);
            this.takimLabel.Name = "takimLabel";
            this.takimLabel.Size = new System.Drawing.Size(70, 21);
            this.takimLabel.TabIndex = 3;
            this.takimLabel.Text = "Takım";
            // 
            // takimComboBox
            // 
            this.takimComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.takimComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takimComboBox.FormattingEnabled = true;
            this.takimComboBox.Location = new System.Drawing.Point(139, 119);
            this.takimComboBox.Name = "takimComboBox";
            this.takimComboBox.Size = new System.Drawing.Size(384, 28);
            this.takimComboBox.TabIndex = 2;
            this.takimComboBox.SelectedIndexChanged += new System.EventHandler(this.takimComboBox_SelectedIndexChanged);
            // 
            // kurulusLabel
            // 
            this.kurulusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kurulusLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kurulusLabel.Location = new System.Drawing.Point(346, 219);
            this.kurulusLabel.Name = "kurulusLabel";
            this.kurulusLabel.Size = new System.Drawing.Size(177, 83);
            this.kurulusLabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(259, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "=>";
            // 
            // takimEkleButton
            // 
            this.takimEkleButton.BackColor = System.Drawing.Color.Aqua;
            this.takimEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.takimEkleButton.Font = new System.Drawing.Font("Swis721 Blk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takimEkleButton.Location = new System.Drawing.Point(51, 330);
            this.takimEkleButton.Name = "takimEkleButton";
            this.takimEkleButton.Size = new System.Drawing.Size(220, 80);
            this.takimEkleButton.TabIndex = 7;
            this.takimEkleButton.Text = "Takım Ekle / \r\nTarih Değiştir";
            this.takimEkleButton.UseVisualStyleBackColor = false;
            this.takimEkleButton.Click += new System.EventHandler(this.takimEkleButton_Click);
            // 
            // takimCikarButton
            // 
            this.takimCikarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.takimCikarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.takimCikarButton.Font = new System.Drawing.Font("Swis721 Blk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takimCikarButton.Location = new System.Drawing.Point(303, 330);
            this.takimCikarButton.Name = "takimCikarButton";
            this.takimCikarButton.Size = new System.Drawing.Size(220, 80);
            this.takimCikarButton.TabIndex = 8;
            this.takimCikarButton.Text = "Takım Çıkar";
            this.takimCikarButton.UseVisualStyleBackColor = false;
            this.takimCikarButton.Click += new System.EventHandler(this.takimCikarButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 83);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kuruluş Tarihi ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.takimCikarButton);
            this.Controls.Add(this.takimEkleButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kurulusLabel);
            this.Controls.Add(this.takimLabel);
            this.Controls.Add(this.takimComboBox);
            this.Controls.Add(this.ulkeLabel);
            this.Controls.Add(this.ulkeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takım - Ülke";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox ulkeComboBox;
        internal System.Windows.Forms.Label takimLabel;
        internal System.Windows.Forms.ComboBox takimComboBox;
        internal System.Windows.Forms.Label kurulusLabel;
        internal System.Windows.Forms.Label ulkeLabel;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button takimEkleButton;
        internal System.Windows.Forms.Button takimCikarButton;
        internal System.Windows.Forms.Label label1;
    }
}


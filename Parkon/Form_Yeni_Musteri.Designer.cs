namespace Parkon
{
    partial class Form_Yeni_Musteri
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
            this.Tb_Yeni_Musteri_Adi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.B_OK = new System.Windows.Forms.Button();
            this.B_Iptal = new System.Windows.Forms.Button();
            this.Lb_Uyari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tb_Yeni_Musteri_Adi
            // 
            this.Tb_Yeni_Musteri_Adi.Location = new System.Drawing.Point(103, 8);
            this.Tb_Yeni_Musteri_Adi.Name = "Tb_Yeni_Musteri_Adi";
            this.Tb_Yeni_Musteri_Adi.Size = new System.Drawing.Size(280, 20);
            this.Tb_Yeni_Musteri_Adi.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Müşteri Firma Adı :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Müşteri Kodu :";
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(315, 36);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(59, 17);
            this.checkBox19.TabIndex = 24;
            this.checkBox19.Text = "değiştir";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // B_OK
            // 
            this.B_OK.Location = new System.Drawing.Point(303, 65);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(81, 33);
            this.B_OK.TabIndex = 25;
            this.B_OK.Text = "OK";
            this.B_OK.UseVisualStyleBackColor = true;
            this.B_OK.Click += new System.EventHandler(this.B_OK_Click);
            // 
            // B_Iptal
            // 
            this.B_Iptal.Location = new System.Drawing.Point(218, 65);
            this.B_Iptal.Name = "B_Iptal";
            this.B_Iptal.Size = new System.Drawing.Size(81, 33);
            this.B_Iptal.TabIndex = 26;
            this.B_Iptal.Text = "İptal";
            this.B_Iptal.UseVisualStyleBackColor = true;
            this.B_Iptal.Click += new System.EventHandler(this.B_Iptal_Click);
            // 
            // Lb_Uyari
            // 
            this.Lb_Uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lb_Uyari.ForeColor = System.Drawing.Color.Red;
            this.Lb_Uyari.Location = new System.Drawing.Point(6, 57);
            this.Lb_Uyari.Name = "Lb_Uyari";
            this.Lb_Uyari.Size = new System.Drawing.Size(206, 49);
            this.Lb_Uyari.TabIndex = 27;
            // 
            // Form_Yeni_Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 106);
            this.Controls.Add(this.Lb_Uyari);
            this.Controls.Add(this.B_Iptal);
            this.Controls.Add(this.B_OK);
            this.Controls.Add(this.checkBox19);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Tb_Yeni_Musteri_Adi);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Yeni_Musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.Form_Yeni_Musteri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Tb_Yeni_Musteri_Adi;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.CheckBox checkBox19;
        public System.Windows.Forms.Button B_OK;
        public System.Windows.Forms.Button B_Iptal;
        public System.Windows.Forms.Label Lb_Uyari;

    }
}
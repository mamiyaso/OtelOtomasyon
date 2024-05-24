namespace OtelOtomasyon
{
    partial class RoomRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMusteriTC;
        private System.Windows.Forms.Label labelGirisTarihi;
        private System.Windows.Forms.Label labelCikisTarihi;
        private System.Windows.Forms.Label labelYemekDahil;
        private System.Windows.Forms.TextBox textBoxMusteriTC;
        private System.Windows.Forms.DateTimePicker dateTimePickerGiris;
        private System.Windows.Forms.DateTimePicker dateTimePickerCikis;
        private System.Windows.Forms.CheckBox checkBoxYemekDahil;
        private System.Windows.Forms.Button buttonKaydet;

        private void InitializeComponent()
        {
            this.labelMusteriTC = new System.Windows.Forms.Label();
            this.labelGirisTarihi = new System.Windows.Forms.Label();
            this.labelCikisTarihi = new System.Windows.Forms.Label();
            this.labelYemekDahil = new System.Windows.Forms.Label();
            this.textBoxMusteriTC = new System.Windows.Forms.TextBox();
            this.dateTimePickerGiris = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCikis = new System.Windows.Forms.DateTimePicker();
            this.checkBoxYemekDahil = new System.Windows.Forms.CheckBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMusteriTC
            // 
            this.labelMusteriTC.AutoSize = true;
            this.labelMusteriTC.Location = new System.Drawing.Point(30, 30);
            this.labelMusteriTC.Name = "labelMusteriTC";
            this.labelMusteriTC.Size = new System.Drawing.Size(66, 13);
            this.labelMusteriTC.TabIndex = 0;
            this.labelMusteriTC.Text = "Müşteri T.C.:";
            // 
            // labelGirisTarihi
            // 
            this.labelGirisTarihi.AutoSize = true;
            this.labelGirisTarihi.Location = new System.Drawing.Point(30, 70);
            this.labelGirisTarihi.Name = "labelGirisTarihi";
            this.labelGirisTarihi.Size = new System.Drawing.Size(61, 13);
            this.labelGirisTarihi.TabIndex = 1;
            this.labelGirisTarihi.Text = "Giriş Tarihi:";
            // 
            // labelCikisTarihi
            // 
            this.labelCikisTarihi.AutoSize = true;
            this.labelCikisTarihi.Location = new System.Drawing.Point(30, 110);
            this.labelCikisTarihi.Name = "labelCikisTarihi";
            this.labelCikisTarihi.Size = new System.Drawing.Size(63, 13);
            this.labelCikisTarihi.TabIndex = 2;
            this.labelCikisTarihi.Text = "Çıkış Tarihi:";
            // 
            // labelYemekDahil
            // 
            this.labelYemekDahil.AutoSize = true;
            this.labelYemekDahil.Location = new System.Drawing.Point(30, 150);
            this.labelYemekDahil.Name = "labelYemekDahil";
            this.labelYemekDahil.Size = new System.Drawing.Size(70, 13);
            this.labelYemekDahil.TabIndex = 3;
            this.labelYemekDahil.Text = "Yemek Dâhil:";
            // 
            // textBoxMusteriTC
            // 
            this.textBoxMusteriTC.Location = new System.Drawing.Point(150, 27);
            this.textBoxMusteriTC.Name = "textBoxMusteriTC";
            this.textBoxMusteriTC.Size = new System.Drawing.Size(200, 20);
            this.textBoxMusteriTC.TabIndex = 4;
            // 
            // dateTimePickerGiris
            // 
            this.dateTimePickerGiris.Location = new System.Drawing.Point(150, 67);
            this.dateTimePickerGiris.Name = "dateTimePickerGiris";
            this.dateTimePickerGiris.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGiris.TabIndex = 5;
            // 
            // dateTimePickerCikis
            // 
            this.dateTimePickerCikis.Location = new System.Drawing.Point(150, 107);
            this.dateTimePickerCikis.Name = "dateTimePickerCikis";
            this.dateTimePickerCikis.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCikis.TabIndex = 6;
            // 
            // checkBoxYemekDahil
            // 
            this.checkBoxYemekDahil.AutoSize = true;
            this.checkBoxYemekDahil.Location = new System.Drawing.Point(150, 149);
            this.checkBoxYemekDahil.Name = "checkBoxYemekDahil";
            this.checkBoxYemekDahil.Size = new System.Drawing.Size(15, 14);
            this.checkBoxYemekDahil.TabIndex = 7;
            this.checkBoxYemekDahil.UseVisualStyleBackColor = true;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(150, 190);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(100, 30);
            this.buttonKaydet.TabIndex = 8;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // RoomRegistrationForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.checkBoxYemekDahil);
            this.Controls.Add(this.dateTimePickerCikis);
            this.Controls.Add(this.dateTimePickerGiris);
            this.Controls.Add(this.textBoxMusteriTC);
            this.Controls.Add(this.labelYemekDahil);
            this.Controls.Add(this.labelCikisTarihi);
            this.Controls.Add(this.labelGirisTarihi);
            this.Controls.Add(this.labelMusteriTC);
            this.Name = "RoomRegistrationForm";
            this.Text = "Oda Kayıt Formu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

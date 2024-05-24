namespace OtelOtomasyon
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonMusteriKayit;
        private System.Windows.Forms.Button buttonOdaKayit;
        private System.Windows.Forms.Button buttonOdaDurum;
        private System.Windows.Forms.Button buttonOdaBosalt;
        private System.Windows.Forms.Button buttonMusteriHareket;
        private System.Windows.Forms.Button buttonMesajlar;

        private void InitializeComponent()
        {
            this.buttonMusteriKayit = new System.Windows.Forms.Button();
            this.buttonOdaKayit = new System.Windows.Forms.Button();
            this.buttonOdaDurum = new System.Windows.Forms.Button();
            this.buttonOdaBosalt = new System.Windows.Forms.Button();
            this.buttonMusteriHareket = new System.Windows.Forms.Button();
            this.buttonMesajlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMusteriKayit
            // 
            this.buttonMusteriKayit.Location = new System.Drawing.Point(30, 30);
            this.buttonMusteriKayit.Name = "buttonMusteriKayit";
            this.buttonMusteriKayit.Size = new System.Drawing.Size(150, 30);
            this.buttonMusteriKayit.TabIndex = 0;
            this.buttonMusteriKayit.Text = "Müşteri Kayıt";
            this.buttonMusteriKayit.UseVisualStyleBackColor = true;
            this.buttonMusteriKayit.Click += new System.EventHandler(this.buttonMusteriKayit_Click);
            // 
            // buttonOdaKayit
            // 
            this.buttonOdaKayit.Location = new System.Drawing.Point(30, 70);
            this.buttonOdaKayit.Name = "buttonOdaKayit";
            this.buttonOdaKayit.Size = new System.Drawing.Size(150, 30);
            this.buttonOdaKayit.TabIndex = 1;
            this.buttonOdaKayit.Text = "Oda Kayıt";
            this.buttonOdaKayit.UseVisualStyleBackColor = true;
            this.buttonOdaKayit.Click += new System.EventHandler(this.buttonOdaKayit_Click);
            // 
            // buttonOdaDurum
            // 
            this.buttonOdaDurum.Location = new System.Drawing.Point(30, 110);
            this.buttonOdaDurum.Name = "buttonOdaDurum";
            this.buttonOdaDurum.Size = new System.Drawing.Size(150, 30);
            this.buttonOdaDurum.TabIndex = 2;
            this.buttonOdaDurum.Text = "Oda Durum";
            this.buttonOdaDurum.UseVisualStyleBackColor = true;
            this.buttonOdaDurum.Click += new System.EventHandler(this.buttonOdaDurum_Click);
            // 
            // buttonOdaBosalt
            // 
            this.buttonOdaBosalt.Location = new System.Drawing.Point(30, 150);
            this.buttonOdaBosalt.Name = "buttonOdaBosalt";
            this.buttonOdaBosalt.Size = new System.Drawing.Size(150, 30);
            this.buttonOdaBosalt.TabIndex = 3;
            this.buttonOdaBosalt.Text = "Oda Boşalt";
            this.buttonOdaBosalt.UseVisualStyleBackColor = true;
            this.buttonOdaBosalt.Click += new System.EventHandler(this.buttonOdaBosalt_Click);
            // 
            // buttonMusteriHareket
            // 
            this.buttonMusteriHareket.Location = new System.Drawing.Point(30, 190);
            this.buttonMusteriHareket.Name = "buttonMusteriHareket";
            this.buttonMusteriHareket.Size = new System.Drawing.Size(150, 30);
            this.buttonMusteriHareket.TabIndex = 4;
            this.buttonMusteriHareket.Text = "Müşteri Hareket";
            this.buttonMusteriHareket.UseVisualStyleBackColor = true;
            this.buttonMusteriHareket.Click += new System.EventHandler(this.buttonMusteriHareket_Click);
            // 
            // buttonMesajlar
            // 
            this.buttonMesajlar.Location = new System.Drawing.Point(30, 230);
            this.buttonMesajlar.Name = "buttonMesajlar";
            this.buttonMesajlar.Size = new System.Drawing.Size(150, 30);
            this.buttonMesajlar.TabIndex = 5;
            this.buttonMesajlar.Text = "Mesajlar";
            this.buttonMesajlar.UseVisualStyleBackColor = true;
            this.buttonMesajlar.Click += new System.EventHandler(this.buttonMesajlar_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.buttonMesajlar);
            this.Controls.Add(this.buttonMusteriHareket);
            this.Controls.Add(this.buttonOdaBosalt);
            this.Controls.Add(this.buttonOdaDurum);
            this.Controls.Add(this.buttonOdaKayit);
            this.Controls.Add(this.buttonMusteriKayit);
            this.Name = "MainForm";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }
    }
}

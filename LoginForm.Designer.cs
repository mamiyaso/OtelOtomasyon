namespace OtelOtomasyon
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button buttonGiris;

        private void InitializeComponent()
        {
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(30, 30);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(97, 20);
            this.labelKullaniciAdi.TabIndex = 0;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Location = new System.Drawing.Point(30, 70);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(58, 20);
            this.labelParola.TabIndex = 1;
            this.labelParola.Text = "Parola:";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(150, 27);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(200, 26);
            this.textBoxKullaniciAdi.TabIndex = 2;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(150, 67);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(200, 26);
            this.textBoxParola.TabIndex = 3;
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(150, 110);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(100, 30);
            this.buttonGiris.TabIndex = 4;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 170);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Name = "LoginForm";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

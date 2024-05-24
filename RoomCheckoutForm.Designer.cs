namespace OtelOtomasyon
{
    partial class RoomCheckoutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMusteriTC;
        private System.Windows.Forms.Label labelToplamTutar;
        private System.Windows.Forms.TextBox textBoxMusteriTC;
        private System.Windows.Forms.TextBox textBoxToplamTutar;
        private System.Windows.Forms.Button buttonOdaBosalt;

        private void InitializeComponent()
        {
            this.labelMusteriTC = new System.Windows.Forms.Label();
            this.labelToplamTutar = new System.Windows.Forms.Label();
            this.textBoxMusteriTC = new System.Windows.Forms.TextBox();
            this.textBoxToplamTutar = new System.Windows.Forms.TextBox();
            this.buttonOdaBosalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMusteriTC
            // 
            this.labelMusteriTC.AutoSize = true;
            this.labelMusteriTC.Location = new System.Drawing.Point(30, 30);
            this.labelMusteriTC.Name = "labelMusteriTC";
            this.labelMusteriTC.Size = new System.Drawing.Size(64, 13);
            this.labelMusteriTC.TabIndex = 0;
            this.labelMusteriTC.Text = "Müşteri T.C:";
            // 
            // labelToplamTutar
            // 
            this.labelToplamTutar.AutoSize = true;
            this.labelToplamTutar.Location = new System.Drawing.Point(30, 70);
            this.labelToplamTutar.Name = "labelToplamTutar";
            this.labelToplamTutar.Size = new System.Drawing.Size(72, 13);
            this.labelToplamTutar.TabIndex = 1;
            this.labelToplamTutar.Text = "Toplam Tutar:";
            // 
            // textBoxMusteriTC
            // 
            this.textBoxMusteriTC.Location = new System.Drawing.Point(150, 27);
            this.textBoxMusteriTC.Name = "textBoxMusteriTC";
            this.textBoxMusteriTC.Size = new System.Drawing.Size(200, 20);
            this.textBoxMusteriTC.TabIndex = 2;
            // 
            // textBoxToplamTutar
            // 
            this.textBoxToplamTutar.Location = new System.Drawing.Point(150, 67);
            this.textBoxToplamTutar.Name = "textBoxToplamTutar";
            this.textBoxToplamTutar.ReadOnly = true;
            this.textBoxToplamTutar.Size = new System.Drawing.Size(200, 20);
            this.textBoxToplamTutar.TabIndex = 3;
            // 
            // buttonOdaBosalt
            // 
            this.buttonOdaBosalt.Location = new System.Drawing.Point(150, 110);
            this.buttonOdaBosalt.Name = "buttonOdaBosalt";
            this.buttonOdaBosalt.Size = new System.Drawing.Size(100, 30);
            this.buttonOdaBosalt.TabIndex = 4;
            this.buttonOdaBosalt.Text = "Oda Boşalt";
            this.buttonOdaBosalt.UseVisualStyleBackColor = true;
            this.buttonOdaBosalt.Click += new System.EventHandler(this.buttonOdaBosalt_Click);
            // 
            // RoomCheckoutForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 170);
            this.Controls.Add(this.buttonOdaBosalt);
            this.Controls.Add(this.textBoxToplamTutar);
            this.Controls.Add(this.textBoxMusteriTC);
            this.Controls.Add(this.labelToplamTutar);
            this.Controls.Add(this.labelMusteriTC);
            this.Name = "RoomCheckoutForm";
            this.Text = "Oda Boşalt Formu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

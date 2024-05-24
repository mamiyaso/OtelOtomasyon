namespace OtelOtomasyon
{
    partial class MessagesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMusteriTC;
        private System.Windows.Forms.Label labelMesaj;
        private System.Windows.Forms.TextBox textBoxMusteriTC;
        private System.Windows.Forms.TextBox textBoxMesaj;
        private System.Windows.Forms.Button buttonMesajGonder;

        private void InitializeComponent()
        {
            this.labelMusteriTC = new System.Windows.Forms.Label();
            this.labelMesaj = new System.Windows.Forms.Label();
            this.textBoxMusteriTC = new System.Windows.Forms.TextBox();
            this.textBoxMesaj = new System.Windows.Forms.TextBox();
            this.buttonMesajGonder = new System.Windows.Forms.Button();
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
            // labelMesaj
            // 
            this.labelMesaj.AutoSize = true;
            this.labelMesaj.Location = new System.Drawing.Point(30, 70);
            this.labelMesaj.Name = "labelMesaj";
            this.labelMesaj.Size = new System.Drawing.Size(39, 13);
            this.labelMesaj.TabIndex = 1;
            this.labelMesaj.Text = "Mesaj:";
            // 
            // textBoxMusteriTC
            // 
            this.textBoxMusteriTC.Location = new System.Drawing.Point(150, 27);
            this.textBoxMusteriTC.Name = "textBoxMusteriTC";
            this.textBoxMusteriTC.Size = new System.Drawing.Size(200, 20);
            this.textBoxMusteriTC.TabIndex = 2;
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.Location = new System.Drawing.Point(150, 67);
            this.textBoxMesaj.Multiline = true;
            this.textBoxMesaj.Name = "textBoxMesaj";
            this.textBoxMesaj.Size = new System.Drawing.Size(200, 100);
            this.textBoxMesaj.TabIndex = 3;
            // 
            // buttonMesajGonder
            // 
            this.buttonMesajGonder.Location = new System.Drawing.Point(150, 180);
            this.buttonMesajGonder.Name = "buttonMesajGonder";
            this.buttonMesajGonder.Size = new System.Drawing.Size(100, 30);
            this.buttonMesajGonder.TabIndex = 4;
            this.buttonMesajGonder.Text = "Mesaj Gönder";
            this.buttonMesajGonder.UseVisualStyleBackColor = true;
            this.buttonMesajGonder.Click += new System.EventHandler(this.buttonMesajGonder_Click);
            // 
            // MessagesForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.buttonMesajGonder);
            this.Controls.Add(this.textBoxMesaj);
            this.Controls.Add(this.textBoxMusteriTC);
            this.Controls.Add(this.labelMesaj);
            this.Controls.Add(this.labelMusteriTC);
            this.Name = "MessagesForm";
            this.Text = "Mesajlar Formu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

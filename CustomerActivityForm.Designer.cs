namespace OtelOtomasyon
{
    partial class CustomerActivityForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMusteriHareketleri;
        private System.Windows.Forms.DataGridView dataGridViewMusteriHareketleri;

        private void InitializeComponent()
        {
            this.labelMusteriHareketleri = new System.Windows.Forms.Label();
            this.dataGridViewMusteriHareketleri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriHareketleri)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMusteriHareketleri
            // 
            this.labelMusteriHareketleri.AutoSize = true;
            this.labelMusteriHareketleri.Location = new System.Drawing.Point(30, 30);
            this.labelMusteriHareketleri.Name = "labelMusteriHareketleri";
            this.labelMusteriHareketleri.Size = new System.Drawing.Size(98, 13);
            this.labelMusteriHareketleri.TabIndex = 0;
            this.labelMusteriHareketleri.Text = "Müşteri Hareketleri:";
            // 
            // dataGridViewMusteriHareketleri
            // 
            this.dataGridViewMusteriHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteriHareketleri.Location = new System.Drawing.Point(30, 60);
            this.dataGridViewMusteriHareketleri.Name = "dataGridViewMusteriHareketleri";
            this.dataGridViewMusteriHareketleri.Size = new System.Drawing.Size(500, 300);
            this.dataGridViewMusteriHareketleri.TabIndex = 1;
            // 
            // CustomerActivityForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dataGridViewMusteriHareketleri);
            this.Controls.Add(this.labelMusteriHareketleri);
            this.Name = "CustomerActivityForm";
            this.Text = "Müşteri Hareket Formu";
            this.Load += new System.EventHandler(this.CustomerActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriHareketleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

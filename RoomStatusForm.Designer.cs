namespace OtelOtomasyon
{
    partial class RoomStatusForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelOdaDurum;
        private System.Windows.Forms.DataGridView dataGridViewOdaDurum;

        private void InitializeComponent()
        {
            this.labelOdaDurum = new System.Windows.Forms.Label();
            this.dataGridViewOdaDurum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdaDurum)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOdaDurum
            // 
            this.labelOdaDurum.AutoSize = true;
            this.labelOdaDurum.Location = new System.Drawing.Point(30, 30);
            this.labelOdaDurum.Name = "labelOdaDurum";
            this.labelOdaDurum.Size = new System.Drawing.Size(87, 13);
            this.labelOdaDurum.TabIndex = 0;
            this.labelOdaDurum.Text = "Oda Durumu:";
            // 
            // dataGridViewOdaDurum
            // 
            this.dataGridViewOdaDurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdaDurum.Location = new System.Drawing.Point(30, 60);
            this.dataGridViewOdaDurum.Name = "dataGridViewOdaDurum";
            this.dataGridViewOdaDurum.Size = new System.Drawing.Size(500, 300);
            this.dataGridViewOdaDurum.TabIndex = 1;
            // 
            // RoomStatusForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dataGridViewOdaDurum);
            this.Controls.Add(this.labelOdaDurum);
            this.Name = "RoomStatusForm";
            this.Text = "Oda Durum Formu";
            this.Load += new System.EventHandler(this.RoomStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdaDurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

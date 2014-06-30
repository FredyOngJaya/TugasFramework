namespace TugasFramework.Laporan
{
    partial class FormLaporanPeminjamanBuku
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
            this.buttonCetak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonCetak
            // 
            this.buttonCetak.Location = new System.Drawing.Point(15, 93);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(75, 30);
            this.buttonCetak.TabIndex = 21;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dari tanggal";
            // 
            // dateTimePickerTanggalAwal
            // 
            this.dateTimePickerTanggalAwal.Location = new System.Drawing.Point(15, 48);
            this.dateTimePickerTanggalAwal.Name = "dateTimePickerTanggalAwal";
            this.dateTimePickerTanggalAwal.Size = new System.Drawing.Size(160, 25);
            this.dateTimePickerTanggalAwal.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "-";
            // 
            // dateTimePickerTanggalAkhir
            // 
            this.dateTimePickerTanggalAkhir.Location = new System.Drawing.Point(200, 48);
            this.dateTimePickerTanggalAkhir.Name = "dateTimePickerTanggalAkhir";
            this.dateTimePickerTanggalAkhir.Size = new System.Drawing.Size(160, 25);
            this.dateTimePickerTanggalAkhir.TabIndex = 26;
            // 
            // FormLaporanPeminjamanBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 142);
            this.Controls.Add(this.dateTimePickerTanggalAkhir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerTanggalAwal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCetak);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLaporanPeminjamanBuku";
            this.ShowIcon = false;
            this.Text = "Laporan Peminjaman Buku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalAwal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalAkhir;
    }
}
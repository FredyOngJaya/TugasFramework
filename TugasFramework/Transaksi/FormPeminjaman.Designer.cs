namespace TugasFramework.Transaksi
{
    partial class FormPeminjaman
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDMember = new System.Windows.Forms.TextBox();
            this.textBoxNamaMember = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowseMember = new System.Windows.Forms.Button();
            this.buttonBrowsePeminjaman = new System.Windows.Forms.Button();
            this.textBoxIDPeminjaman = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.textBoxIDBuku = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxJudulBuku = new System.Windows.Forms.TextBox();
            this.buttonBrowseBuku = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerTanggalPeminjaman = new System.Windows.Forms.DateTimePicker();
            this.buttonBaru = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Member";
            // 
            // textBoxIDMember
            // 
            this.textBoxIDMember.Location = new System.Drawing.Point(113, 13);
            this.textBoxIDMember.Name = "textBoxIDMember";
            this.textBoxIDMember.Size = new System.Drawing.Size(100, 25);
            this.textBoxIDMember.TabIndex = 1;
            this.textBoxIDMember.Leave += new System.EventHandler(this.textBoxIDMember_Leave);
            // 
            // textBoxNamaMember
            // 
            this.textBoxNamaMember.Location = new System.Drawing.Point(113, 44);
            this.textBoxNamaMember.Name = "textBoxNamaMember";
            this.textBoxNamaMember.ReadOnly = true;
            this.textBoxNamaMember.Size = new System.Drawing.Size(242, 25);
            this.textBoxNamaMember.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // buttonBrowseMember
            // 
            this.buttonBrowseMember.Location = new System.Drawing.Point(219, 13);
            this.buttonBrowseMember.Name = "buttonBrowseMember";
            this.buttonBrowseMember.Size = new System.Drawing.Size(31, 23);
            this.buttonBrowseMember.TabIndex = 4;
            this.buttonBrowseMember.Text = "...";
            this.buttonBrowseMember.UseVisualStyleBackColor = true;
            this.buttonBrowseMember.Click += new System.EventHandler(this.buttonBrowseMember_Click);
            // 
            // buttonBrowsePeminjaman
            // 
            this.buttonBrowsePeminjaman.Location = new System.Drawing.Point(248, 12);
            this.buttonBrowsePeminjaman.Name = "buttonBrowsePeminjaman";
            this.buttonBrowsePeminjaman.Size = new System.Drawing.Size(31, 23);
            this.buttonBrowsePeminjaman.TabIndex = 7;
            this.buttonBrowsePeminjaman.Text = "...";
            this.buttonBrowsePeminjaman.UseVisualStyleBackColor = true;
            this.buttonBrowsePeminjaman.Click += new System.EventHandler(this.buttonBrowsePeminjaman_Click);
            // 
            // textBoxIDPeminjaman
            // 
            this.textBoxIDPeminjaman.Location = new System.Drawing.Point(142, 12);
            this.textBoxIDPeminjaman.Name = "textBoxIDPeminjaman";
            this.textBoxIDPeminjaman.Size = new System.Drawing.Size(100, 25);
            this.textBoxIDPeminjaman.TabIndex = 6;
            this.textBoxIDPeminjaman.Leave += new System.EventHandler(this.textBoxIDPeminjaman_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nomor Peminjaman";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(96, 267);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 30);
            this.buttonSimpan.TabIndex = 8;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(177, 267);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 30);
            this.buttonHapus.TabIndex = 9;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(258, 267);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(75, 30);
            this.buttonBatal.TabIndex = 10;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.textBoxIDBuku);
            this.panelData.Controls.Add(this.label5);
            this.panelData.Controls.Add(this.label6);
            this.panelData.Controls.Add(this.textBoxJudulBuku);
            this.panelData.Controls.Add(this.buttonBrowseBuku);
            this.panelData.Controls.Add(this.label4);
            this.panelData.Controls.Add(this.dateTimePickerTanggalPeminjaman);
            this.panelData.Controls.Add(this.textBoxIDMember);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Controls.Add(this.textBoxNamaMember);
            this.panelData.Controls.Add(this.buttonBrowseMember);
            this.panelData.Location = new System.Drawing.Point(15, 43);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(605, 218);
            this.panelData.TabIndex = 11;
            // 
            // textBoxIDBuku
            // 
            this.textBoxIDBuku.Location = new System.Drawing.Point(113, 137);
            this.textBoxIDBuku.Name = "textBoxIDBuku";
            this.textBoxIDBuku.Size = new System.Drawing.Size(100, 25);
            this.textBoxIDBuku.TabIndex = 8;
            this.textBoxIDBuku.Leave += new System.EventHandler(this.textBoxIDBuku_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID Buku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Judul Buku";
            // 
            // textBoxJudulBuku
            // 
            this.textBoxJudulBuku.Location = new System.Drawing.Point(113, 168);
            this.textBoxJudulBuku.Name = "textBoxJudulBuku";
            this.textBoxJudulBuku.ReadOnly = true;
            this.textBoxJudulBuku.Size = new System.Drawing.Size(242, 25);
            this.textBoxJudulBuku.TabIndex = 10;
            // 
            // buttonBrowseBuku
            // 
            this.buttonBrowseBuku.Location = new System.Drawing.Point(219, 137);
            this.buttonBrowseBuku.Name = "buttonBrowseBuku";
            this.buttonBrowseBuku.Size = new System.Drawing.Size(31, 23);
            this.buttonBrowseBuku.TabIndex = 11;
            this.buttonBrowseBuku.Text = "...";
            this.buttonBrowseBuku.UseVisualStyleBackColor = true;
            this.buttonBrowseBuku.Click += new System.EventHandler(this.buttonBrowseBuku_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tanggal";
            // 
            // dateTimePickerTanggalPeminjaman
            // 
            this.dateTimePickerTanggalPeminjaman.Enabled = false;
            this.dateTimePickerTanggalPeminjaman.Location = new System.Drawing.Point(113, 92);
            this.dateTimePickerTanggalPeminjaman.Name = "dateTimePickerTanggalPeminjaman";
            this.dateTimePickerTanggalPeminjaman.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerTanggalPeminjaman.TabIndex = 5;
            // 
            // buttonBaru
            // 
            this.buttonBaru.Location = new System.Drawing.Point(15, 267);
            this.buttonBaru.Name = "buttonBaru";
            this.buttonBaru.Size = new System.Drawing.Size(75, 30);
            this.buttonBaru.TabIndex = 12;
            this.buttonBaru.Text = "Baru";
            this.buttonBaru.UseVisualStyleBackColor = true;
            this.buttonBaru.Click += new System.EventHandler(this.buttonBaru_Click);
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(632, 326);
            this.Controls.Add(this.buttonBaru);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonBrowsePeminjaman);
            this.Controls.Add(this.textBoxIDPeminjaman);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPeminjaman";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Peminjaman";
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDMember;
        private System.Windows.Forms.TextBox textBoxNamaMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowseMember;
        private System.Windows.Forms.Button buttonBrowsePeminjaman;
        private System.Windows.Forms.TextBox textBoxIDPeminjaman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalPeminjaman;
        private System.Windows.Forms.Button buttonBaru;
        private System.Windows.Forms.TextBox textBoxIDBuku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxJudulBuku;
        private System.Windows.Forms.Button buttonBrowseBuku;
    }
}
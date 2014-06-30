namespace TugasFramework.Master
{
    partial class FormBuku
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
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.dataGridViewDataBuku = new System.Windows.Forms.DataGridView();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtjudul = new System.Windows.Forms.TextBox();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.groupBoxDataPengarang = new System.Windows.Forms.GroupBox();
            this.dataGridViewDataPengarang = new System.Windows.Forms.DataGridView();
            this.buttonHapusGrid = new System.Windows.Forms.Button();
            this.buttonBrowsePengarang = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPengarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBuku)).BeginInit();
            this.groupBoxDataPengarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPengarang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(174, 141);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 26);
            this.btnhapus.TabIndex = 39;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(93, 141);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(75, 26);
            this.btnubah.TabIndex = 40;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(12, 141);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 26);
            this.btntambah.TabIndex = 41;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // dataGridViewDataBuku
            // 
            this.dataGridViewDataBuku.AllowUserToAddRows = false;
            this.dataGridViewDataBuku.AllowUserToDeleteRows = false;
            this.dataGridViewDataBuku.AllowUserToResizeColumns = false;
            this.dataGridViewDataBuku.AllowUserToResizeRows = false;
            this.dataGridViewDataBuku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDataBuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBuku.Location = new System.Drawing.Point(336, 12);
            this.dataGridViewDataBuku.MultiSelect = false;
            this.dataGridViewDataBuku.Name = "dataGridViewDataBuku";
            this.dataGridViewDataBuku.ReadOnly = true;
            this.dataGridViewDataBuku.RowHeadersVisible = false;
            this.dataGridViewDataBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDataBuku.Size = new System.Drawing.Size(436, 388);
            this.dataGridViewDataBuku.TabIndex = 38;
            this.dataGridViewDataBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataBuku_CellClick);
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(84, 110);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(246, 25);
            this.txtstok.TabIndex = 34;
            // 
            // txtjudul
            // 
            this.txtjudul.Location = new System.Drawing.Point(84, 46);
            this.txtjudul.Name = "txtjudul";
            this.txtjudul.Size = new System.Drawing.Size(246, 25);
            this.txtjudul.TabIndex = 32;
            // 
            // txtkode
            // 
            this.txtkode.Location = new System.Drawing.Point(84, 12);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(246, 25);
            this.txtkode.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Stok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Judul Buku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kode Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kategori";
            // 
            // cmbkategori
            // 
            this.cmbkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Items.AddRange(new object[] {
            "-",
            "Komik",
            "Science",
            "Novel",
            "Majalah"});
            this.cmbkategori.Location = new System.Drawing.Point(84, 79);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(246, 25);
            this.cmbkategori.TabIndex = 42;
            // 
            // groupBoxDataPengarang
            // 
            this.groupBoxDataPengarang.Controls.Add(this.dataGridViewDataPengarang);
            this.groupBoxDataPengarang.Controls.Add(this.buttonHapusGrid);
            this.groupBoxDataPengarang.Controls.Add(this.buttonBrowsePengarang);
            this.groupBoxDataPengarang.Location = new System.Drawing.Point(12, 173);
            this.groupBoxDataPengarang.Name = "groupBoxDataPengarang";
            this.groupBoxDataPengarang.Size = new System.Drawing.Size(318, 227);
            this.groupBoxDataPengarang.TabIndex = 43;
            this.groupBoxDataPengarang.TabStop = false;
            this.groupBoxDataPengarang.Text = "Data Pengarang";
            // 
            // dataGridViewDataPengarang
            // 
            this.dataGridViewDataPengarang.AllowUserToAddRows = false;
            this.dataGridViewDataPengarang.AllowUserToDeleteRows = false;
            this.dataGridViewDataPengarang.AllowUserToResizeColumns = false;
            this.dataGridViewDataPengarang.AllowUserToResizeRows = false;
            this.dataGridViewDataPengarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDataPengarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDataPengarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataPengarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NamaPengarang});
            this.dataGridViewDataPengarang.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewDataPengarang.MultiSelect = false;
            this.dataGridViewDataPengarang.Name = "dataGridViewDataPengarang";
            this.dataGridViewDataPengarang.ReadOnly = true;
            this.dataGridViewDataPengarang.RowHeadersVisible = false;
            this.dataGridViewDataPengarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDataPengarang.Size = new System.Drawing.Size(306, 161);
            this.dataGridViewDataPengarang.TabIndex = 24;
            // 
            // buttonHapusGrid
            // 
            this.buttonHapusGrid.Location = new System.Drawing.Point(87, 24);
            this.buttonHapusGrid.Name = "buttonHapusGrid";
            this.buttonHapusGrid.Size = new System.Drawing.Size(75, 30);
            this.buttonHapusGrid.TabIndex = 23;
            this.buttonHapusGrid.Text = "Hapus";
            this.buttonHapusGrid.UseVisualStyleBackColor = true;
            this.buttonHapusGrid.Click += new System.EventHandler(this.buttonHapusGrid_Click);
            // 
            // buttonBrowsePengarang
            // 
            this.buttonBrowsePengarang.Location = new System.Drawing.Point(6, 24);
            this.buttonBrowsePengarang.Name = "buttonBrowsePengarang";
            this.buttonBrowsePengarang.Size = new System.Drawing.Size(75, 30);
            this.buttonBrowsePengarang.TabIndex = 22;
            this.buttonBrowsePengarang.Text = "Tambah";
            this.buttonBrowsePengarang.UseVisualStyleBackColor = true;
            this.buttonBrowsePengarang.Click += new System.EventHandler(this.buttonBrowsePengarang_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 25;
            // 
            // NamaPengarang
            // 
            this.NamaPengarang.HeaderText = "NamaPengarang";
            this.NamaPengarang.Name = "NamaPengarang";
            this.NamaPengarang.ReadOnly = true;
            this.NamaPengarang.Width = 131;
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(255, 141);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(75, 26);
            this.buttonBatal.TabIndex = 44;
            this.buttonBatal.Text = "batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // FormBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.groupBoxDataPengarang);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.dataGridViewDataBuku);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtjudul);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBuku";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Buku";
            this.Load += new System.EventHandler(this.FormBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBuku)).EndInit();
            this.groupBoxDataPengarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPengarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.DataGridView dataGridViewDataBuku;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtjudul;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.GroupBox groupBoxDataPengarang;
        private System.Windows.Forms.DataGridView dataGridViewDataPengarang;
        private System.Windows.Forms.Button buttonHapusGrid;
        private System.Windows.Forms.Button buttonBrowsePengarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPengarang;
        private System.Windows.Forms.Button buttonBatal;
    }
}
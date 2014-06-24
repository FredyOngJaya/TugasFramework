namespace TugasFramework.Transaksi
{
    partial class FormPengembalian
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
            this.buttonBaru = new System.Windows.Forms.Button();
            this.textBoxIDMember = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNamaMember = new System.Windows.Forms.TextBox();
            this.buttonBrowseMember = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.groupBoxDataPeminjaman = new System.Windows.Forms.GroupBox();
            this.dataGridViewDataPeminjaman = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Judul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonHapusGrid = new System.Windows.Forms.Button();
            this.buttonBrowsePeminjaman = new System.Windows.Forms.Button();
            this.groupBoxDataPeminjaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBaru
            // 
            this.buttonBaru.Location = new System.Drawing.Point(15, 326);
            this.buttonBaru.Name = "buttonBaru";
            this.buttonBaru.Size = new System.Drawing.Size(75, 30);
            this.buttonBaru.TabIndex = 20;
            this.buttonBaru.Text = "Baru";
            this.buttonBaru.UseVisualStyleBackColor = true;
            this.buttonBaru.Click += new System.EventHandler(this.buttonBaru_Click);
            // 
            // textBoxIDMember
            // 
            this.textBoxIDMember.Location = new System.Drawing.Point(115, 12);
            this.textBoxIDMember.Name = "textBoxIDMember";
            this.textBoxIDMember.Size = new System.Drawing.Size(100, 25);
            this.textBoxIDMember.TabIndex = 1;
            this.textBoxIDMember.Leave += new System.EventHandler(this.textBoxIDMember_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // textBoxNamaMember
            // 
            this.textBoxNamaMember.Location = new System.Drawing.Point(115, 43);
            this.textBoxNamaMember.Name = "textBoxNamaMember";
            this.textBoxNamaMember.ReadOnly = true;
            this.textBoxNamaMember.Size = new System.Drawing.Size(242, 25);
            this.textBoxNamaMember.TabIndex = 3;
            // 
            // buttonBrowseMember
            // 
            this.buttonBrowseMember.Location = new System.Drawing.Point(221, 12);
            this.buttonBrowseMember.Name = "buttonBrowseMember";
            this.buttonBrowseMember.Size = new System.Drawing.Size(31, 23);
            this.buttonBrowseMember.TabIndex = 4;
            this.buttonBrowseMember.Text = "...";
            this.buttonBrowseMember.UseVisualStyleBackColor = true;
            this.buttonBrowseMember.Click += new System.EventHandler(this.buttonBrowseMember_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(177, 326);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(75, 30);
            this.buttonBatal.TabIndex = 18;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(96, 326);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 30);
            this.buttonSimpan.TabIndex = 16;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // groupBoxDataPeminjaman
            // 
            this.groupBoxDataPeminjaman.Controls.Add(this.dataGridViewDataPeminjaman);
            this.groupBoxDataPeminjaman.Controls.Add(this.buttonHapusGrid);
            this.groupBoxDataPeminjaman.Controls.Add(this.buttonBrowsePeminjaman);
            this.groupBoxDataPeminjaman.Location = new System.Drawing.Point(15, 74);
            this.groupBoxDataPeminjaman.Name = "groupBoxDataPeminjaman";
            this.groupBoxDataPeminjaman.Size = new System.Drawing.Size(685, 246);
            this.groupBoxDataPeminjaman.TabIndex = 21;
            this.groupBoxDataPeminjaman.TabStop = false;
            this.groupBoxDataPeminjaman.Text = "Data peminjaman";
            // 
            // dataGridViewDataPeminjaman
            // 
            this.dataGridViewDataPeminjaman.AllowUserToAddRows = false;
            this.dataGridViewDataPeminjaman.AllowUserToDeleteRows = false;
            this.dataGridViewDataPeminjaman.AllowUserToResizeColumns = false;
            this.dataGridViewDataPeminjaman.AllowUserToResizeRows = false;
            this.dataGridViewDataPeminjaman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDataPeminjaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDataPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataPeminjaman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Judul,
            this.Tanggal});
            this.dataGridViewDataPeminjaman.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewDataPeminjaman.MultiSelect = false;
            this.dataGridViewDataPeminjaman.Name = "dataGridViewDataPeminjaman";
            this.dataGridViewDataPeminjaman.ReadOnly = true;
            this.dataGridViewDataPeminjaman.RowHeadersVisible = false;
            this.dataGridViewDataPeminjaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDataPeminjaman.Size = new System.Drawing.Size(673, 180);
            this.dataGridViewDataPeminjaman.TabIndex = 24;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 45;
            // 
            // Judul
            // 
            this.Judul.HeaderText = "Judul Buku";
            this.Judul.Name = "Judul";
            this.Judul.ReadOnly = true;
            this.Judul.Width = 87;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal Peminjaman";
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.ReadOnly = true;
            this.Tanggal.Width = 141;
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
            // buttonBrowsePeminjaman
            // 
            this.buttonBrowsePeminjaman.Location = new System.Drawing.Point(6, 24);
            this.buttonBrowsePeminjaman.Name = "buttonBrowsePeminjaman";
            this.buttonBrowsePeminjaman.Size = new System.Drawing.Size(75, 30);
            this.buttonBrowsePeminjaman.TabIndex = 22;
            this.buttonBrowsePeminjaman.Text = "Tambah";
            this.buttonBrowsePeminjaman.UseVisualStyleBackColor = true;
            this.buttonBrowsePeminjaman.Click += new System.EventHandler(this.buttonBrowsePeminjaman_Click);
            // 
            // FormPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(712, 371);
            this.Controls.Add(this.groupBoxDataPeminjaman);
            this.Controls.Add(this.buttonBaru);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textBoxIDMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowseMember);
            this.Controls.Add(this.textBoxNamaMember);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPengembalian";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Pengembalian";
            this.groupBoxDataPeminjaman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPeminjaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBaru;
        private System.Windows.Forms.TextBox textBoxIDMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNamaMember;
        private System.Windows.Forms.Button buttonBrowseMember;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.GroupBox groupBoxDataPeminjaman;
        private System.Windows.Forms.Button buttonHapusGrid;
        private System.Windows.Forms.Button buttonBrowsePeminjaman;
        private System.Windows.Forms.DataGridView dataGridViewDataPeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Judul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
    }
}
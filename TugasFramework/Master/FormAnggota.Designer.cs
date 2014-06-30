namespace TugasFramework.Master
{
    partial class FormAnggota
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txttelepon = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.rd0 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.dataGridViewDataAnggota = new System.Windows.Forms.DataGridView();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataAnggota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Identitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "No Telp";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(123, 20);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(128, 25);
            this.txtno.TabIndex = 1;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(123, 54);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(128, 25);
            this.txtnama.TabIndex = 1;
            // 
            // txttelepon
            // 
            this.txttelepon.Location = new System.Drawing.Point(123, 152);
            this.txttelepon.Name = "txttelepon";
            this.txttelepon.Size = new System.Drawing.Size(128, 25);
            this.txttelepon.TabIndex = 1;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(123, 118);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(128, 25);
            this.txtalamat.TabIndex = 1;
            // 
            // rd0
            // 
            this.rd0.AutoSize = true;
            this.rd0.Location = new System.Drawing.Point(123, 86);
            this.rd0.Name = "rd0";
            this.rd0.Size = new System.Drawing.Size(72, 21);
            this.rd0.TabIndex = 2;
            this.rd0.TabStop = true;
            this.rd0.Text = "Laki-laki";
            this.rd0.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(230, 86);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(92, 21);
            this.rd1.TabIndex = 2;
            this.rd1.TabStop = true;
            this.rd1.Text = "Perempuan";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDataAnggota
            // 
            this.dataGridViewDataAnggota.AllowUserToAddRows = false;
            this.dataGridViewDataAnggota.AllowUserToDeleteRows = false;
            this.dataGridViewDataAnggota.AllowUserToResizeColumns = false;
            this.dataGridViewDataAnggota.AllowUserToResizeRows = false;
            this.dataGridViewDataAnggota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDataAnggota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDataAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataAnggota.Location = new System.Drawing.Point(25, 250);
            this.dataGridViewDataAnggota.MultiSelect = false;
            this.dataGridViewDataAnggota.Name = "dataGridViewDataAnggota";
            this.dataGridViewDataAnggota.ReadOnly = true;
            this.dataGridViewDataAnggota.RowHeadersVisible = false;
            this.dataGridViewDataAnggota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDataAnggota.Size = new System.Drawing.Size(673, 212);
            this.dataGridViewDataAnggota.TabIndex = 25;
            this.dataGridViewDataAnggota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataAnggota_CellClick);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(33, 208);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 26);
            this.btntambah.TabIndex = 26;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(141, 208);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(75, 26);
            this.btnubah.TabIndex = 26;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(247, 208);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 26);
            this.btnhapus.TabIndex = 26;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // FormAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 474);
            this.Controls.Add(this.dataGridViewDataAnggota);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.rd1);
            this.Controls.Add(this.rd0);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txttelepon);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAnggota";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Anggota";
            this.Load += new System.EventHandler(this.FormAnggota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataAnggota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txttelepon;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.RadioButton rd0;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.DataGridView dataGridViewDataAnggota;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnhapus;
    }
}
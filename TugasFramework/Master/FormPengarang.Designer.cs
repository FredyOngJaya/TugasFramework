namespace TugasFramework.Master
{
    partial class FormPengarang
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
            this.dataGridViewDataPengarang = new System.Windows.Forms.DataGridView();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd0 = new System.Windows.Forms.RadioButton();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txttelepon = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPengarang)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewDataPengarang.Location = new System.Drawing.Point(34, 235);
            this.dataGridViewDataPengarang.MultiSelect = false;
            this.dataGridViewDataPengarang.Name = "dataGridViewDataPengarang";
            this.dataGridViewDataPengarang.ReadOnly = true;
            this.dataGridViewDataPengarang.RowHeadersVisible = false;
            this.dataGridViewDataPengarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDataPengarang.Size = new System.Drawing.Size(673, 244);
            this.dataGridViewDataPengarang.TabIndex = 38;
            this.dataGridViewDataPengarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataPengarang_CellClick);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(270, 197);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 26);
            this.btnhapus.TabIndex = 40;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(164, 197);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(75, 26);
            this.btnubah.TabIndex = 41;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(56, 197);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 26);
            this.btntambah.TabIndex = 39;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(270, 75);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(92, 21);
            this.rd1.TabIndex = 36;
            this.rd1.TabStop = true;
            this.rd1.Text = "Perempuan";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd0
            // 
            this.rd0.AutoSize = true;
            this.rd0.Location = new System.Drawing.Point(163, 75);
            this.rd0.Name = "rd0";
            this.rd0.Size = new System.Drawing.Size(72, 21);
            this.rd0.TabIndex = 37;
            this.rd0.TabStop = true;
            this.rd0.Text = "Laki-laki";
            this.rd0.UseVisualStyleBackColor = true;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(163, 107);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(128, 25);
            this.txtalamat.TabIndex = 35;
            // 
            // txttelepon
            // 
            this.txttelepon.Location = new System.Drawing.Point(163, 141);
            this.txttelepon.Name = "txttelepon";
            this.txttelepon.Size = new System.Drawing.Size(128, 25);
            this.txttelepon.TabIndex = 34;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(163, 43);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(128, 25);
            this.txtnama.TabIndex = 32;
            // 
            // txtkode
            // 
            this.txtkode.Location = new System.Drawing.Point(163, 9);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(128, 25);
            this.txtkode.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "No Telp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kode Pengarang";
            // 
            // FormPengarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.dataGridViewDataPengarang);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.rd1);
            this.Controls.Add(this.rd0);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txttelepon);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPengarang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Pengarang";
            this.Load += new System.EventHandler(this.FormPengarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPengarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataPengarang;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd0;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.TextBox txttelepon;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
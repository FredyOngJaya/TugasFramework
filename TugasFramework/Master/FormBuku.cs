using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using TugasFramework.Library;
using lib = TugasFramework.Library.LibGlobal;

namespace TugasFramework.Master
{
    public partial class FormBuku : Form
    {
        DataTable Buku = new DataTable();
        TextBox[] arrayTextbox;
        List<int> listIDPengarang = new List<int>();

        public FormBuku()
        {
            InitializeComponent();
            arrayTextbox = new TextBox[] { txtkode, txtjudul, txtstok, txtkode };

            refreshData();

            dataGridViewDataBuku.DataSource = Buku;
            dataGridViewDataBuku.Columns["id"].Visible = false;
            dataGridViewDataBuku.Columns["kode_buku"].HeaderText = "Kode Buku";
            dataGridViewDataBuku.Columns["judul"].HeaderText = "Judul";
            dataGridViewDataBuku.Columns["kategori"].HeaderText = "Kategori";
            dataGridViewDataBuku.Columns["stok"].HeaderText = "Stok";

            buttonBatal_Click(null, null);
        }

        private void refreshData()
        {
            Buku.Rows.Clear();
            using (SqlDataAdapter da = new SqlDataAdapter("select * from buku", lib._SqlConnection))
            {
                da.Fill(Buku);
            }
        }

        private void AturButton(bool tambah, bool ubah, bool hapus, bool batal)
        {
            btntambah.Enabled = tambah;
            btnubah.Enabled = ubah;
            btnhapus.Enabled = hapus;
            buttonBatal.Enabled = batal;
        }

        void bersihkan()
        {
            lib.ClearTextBox(arrayTextbox);
            cmbkategori.Text = "-";
            listIDPengarang.Clear();
            dataGridViewDataPengarang.Rows.Clear();
            btnubah.Tag = "";
        }

        private void dataGridViewDataBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridViewDataBuku.Rows[e.RowIndex];
            bersihkan();
            DataRow row = lib.GetDataBuku(dr.Cells["id"].Value.ToString());
            btnubah.Tag = row["id"];
            txtkode.Text = row["kode_buku"].ToString();
            txtjudul.Text = row["judul"].ToString();
            cmbkategori.Text = row["kategori"].ToString();
            txtstok.Text = row["stok"].ToString();
            DataTable daftar = lib.GetDataTable("select * from pengarang_buku a " +
                "inner join pengarang b on a.id_pengarang=b.id where a.id_buku=" + row["id"]);
            foreach (DataRow r in daftar.Rows)
            {
                listIDPengarang.Add(Convert.ToInt32(r["id_pengarang"]));
                dataGridViewDataPengarang.Rows.Add(new object[] { r["id_buku"], r["nama"] });
            }
            AturButton(false, true, true, true);
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            if (txtkode.Text.Equals(""))
            {
                lib.PesanInformasi("Kode Buku Belum Diisi");
            }
            else if (txtjudul.Text.Equals(""))
            {
                lib.PesanInformasi("Judul Buku Belum Diisi");
            }
            else if (cmbkategori.SelectedIndex < 0)
            {
                lib.PesanInformasi("Kategori Buku Belum Dipilih");
            }
            else if (dataGridViewDataPengarang.RowCount == 0)
            {
                lib.PesanInformasi("Pengarang Buku Belum Diisi");
            }
            else if (txtstok.Text.Equals(""))
            {
                lib.PesanInformasi("Stok Buku Belum Diisi");
            }
            else
            {
                try
                {
                    lib.BukaKoneksi();
                    SqlCommand cmd = new SqlCommand("insert into buku values(@kode_buku,@judul,@kategori,@stok)", lib._SqlConnection);
                    cmd.Parameters.AddWithValue("kode_buku", txtkode.Text);
                    cmd.Parameters.AddWithValue("judul", txtjudul.Text);
                    cmd.Parameters.AddWithValue("kategori", cmbkategori.Text);
                    cmd.Parameters.AddWithValue("stok", txtstok.Text);
                    cmd.ExecuteNonQuery();
                    int newId = Convert.ToInt32(lib.GetObject("select top 1 id from buku order by id desc"));
                    foreach (int t in listIDPengarang)
                    {
                        cmd.CommandText = "insert into pengarang_buku values(" + newId + "," + t + ")";
                        cmd.ExecuteNonQuery();
                    }
                    lib.TutupKoneksi();
                    refreshData();
                    buttonBatal_Click(null, null);
                }
                catch (Exception ex)
                {
                    lib.PesanError(ex.Message);
                }
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (lib.Pertanyaan("Hapus data ini?") == DialogResult.Yes)
            {
                lib.BukaKoneksi();
                SqlCommand cmd = new SqlCommand("delete from buku where id=" + btnubah.Tag + ";" +
                    "delete from pengarang_buku where id_buku=" + btnubah.Tag, lib._SqlConnection);
                cmd.ExecuteNonQuery();
                lib.TutupKoneksi();
                buttonBatal_Click(null, null);
                refreshData();
            }
        }

        private void FormBuku_Load(object sender, EventArgs e)
        {
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            lib.BukaKoneksi();
            SqlCommand cmd = new SqlCommand("update buku set kode_buku=@kode_buku,judul=@judul,kategori=@kategori,stok=@stok where id=@id", lib._SqlConnection);
            cmd.Parameters.AddWithValue("id", btnubah.Tag);
            cmd.Parameters.AddWithValue("kode_buku", txtkode.Text);
            cmd.Parameters.AddWithValue("judul", txtjudul.Text);
            cmd.Parameters.AddWithValue("kategori", cmbkategori.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("stok", txtstok.Text);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from pengarang_buku where id_buku=@id";
            cmd.ExecuteNonQuery();
            foreach (int t in listIDPengarang)
            {
                cmd.CommandText = "insert into pengarang_buku values(" + btnubah.Tag + "," + t + ")";
                cmd.ExecuteNonQuery();
            }
            lib.TutupKoneksi();
            refreshData();
            buttonBatal_Click(null, null);
        }

        private void buttonBrowsePengarang_Click(object sender, EventArgs e)
        {
            FormBrowse browse = new FormBrowse("Cari Pengarang",
                "select id, kode_pengarang as [Kode Pengarang], Nama, jenis_kelamin as [Jenis Kelamin], Alamat, HP from pengarang",
                "Nama Pengarang", "Nama", new string[] { "id" }, (sd, ev) =>
                {
                    DataGridViewRow row = (sd as DataGridView).Rows[ev.RowIndex];
                    int id_pengarang = Convert.ToInt32(row.Cells["id"].Value);
                    if (listIDPengarang.Count(x => x == id_pengarang) == 0)
                    {
                        listIDPengarang.Add(id_pengarang);
                        dataGridViewDataPengarang.Rows.Add(new object[] { row.Cells["id"].Value, row.Cells["Nama"].Value });
                    }
                    else
                    {
                        lib.PesanInformasi("Data pengarang ini sudah ditambahkan");
                    }
                });
            browse.ShowDialog();
            browse.Dispose();
        }

        private void buttonHapusGrid_Click(object sender, EventArgs e)
        {
            if (dataGridViewDataPengarang.RowCount > 0 && dataGridViewDataPengarang.SelectedRows != null)
            {
                listIDPengarang.Remove(Convert.ToInt32(dataGridViewDataPengarang.SelectedRows[0].Cells["id"].Value));
                dataGridViewDataPengarang.Rows.Remove(dataGridViewDataPengarang.SelectedRows[0]);
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            AturButton(true, false, false, true);
            bersihkan();
        }
    }
}

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
    public partial class FormPengarang : Form
    {
        public FormPengarang()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            txtkode.Clear();
            txtnama.Clear();
            txtalamat.Clear();
            txttelepon.Clear();
            rd0.Checked = false;
            rd1.Checked = false;
            txtkode.Focus();
        }

        void tampilkan()
        {
            DataTable dt = lib.GetDataTable("Select * from Pengarang");
            dataGridViewDataPengarang.DataSource = dt;
            dataGridViewDataPengarang.Columns["id"].Visible = false;
        }

        private void FormPengarang_Load(object sender, EventArgs e)
        {
            lib.BukaKoneksi();
            tampilkan();
            lib.TutupKoneksi();
        }

        private void dataGridViewDataPengarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridViewDataPengarang.Rows[e.RowIndex];
            txtkode.Text = dr.Cells["kode_pengarang"].Value.ToString();
            txtnama.Text = dr.Cells["nama"].Value.ToString();
            if (dr.Cells["jenis_kelamin"].Value.ToString() == "Perempuan")
                rd1.Checked = true;
            else
                rd0.Checked = true;
            txtalamat.Text = dr.Cells["alamat"].Value.ToString();
            txttelepon.Text = dr.Cells["hp"].Value.ToString();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            lib.BukaKoneksi();
            if (txtkode.Text.Equals(""))
            {
                lib.PesanInformasi("Kode Pengarang Belum Diisi");
            }
            else if (txtnama.Text.Equals(""))
            {
                lib.PesanInformasi("Nama Pengarang Belum Diisi");
            }
            else if (txtalamat.Text.Equals(""))
            {
                lib.PesanInformasi("Alamat Pengarang Belum Diisi");
            }
            else if (txttelepon.Text.Equals(""))
            {
                lib.PesanInformasi("Telepon Pengarang Belum Diisi");
            }
            else if (!rd0.Checked && !rd1.Checked)
            {
                lib.PesanInformasi("Jenis Kelamin Tidak Jelas");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert Into Pengarang values('" + txtkode.Text + "','" + txtnama.Text + "','" + (rd0.Checked ? "Laki-Laki" : "Perempuan") + "','" + txtalamat.Text + "','" + txttelepon.Text + "')", lib._SqlConnection);
                cmd.ExecuteNonQuery();
                lib.PesanInformasi("Add berhasil");
                bersihkan();
                tampilkan();
            }

            lib.TutupKoneksi();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            lib.BukaKoneksi();
            SqlCommand cmd = new SqlCommand("delete from pengarang where kode_pengarang='" + txtkode.Text + "'", lib._SqlConnection);
            cmd.ExecuteNonQuery();
            lib.PesanInformasi("Delete berhasil");
            tampilkan();
            bersihkan();
            lib.TutupKoneksi();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            lib.BukaKoneksi();
            SqlCommand cmd = new SqlCommand("update pengarang set nama='" + txtnama.Text + "', jenis_kelamin='" + (rd0.Checked ? "Laki-Laki" : "Perempuan") + "', alamat='" + txtalamat.Text + "', hp='" + txttelepon.Text + "' where kode_pengarang = '" + txtkode.Text + "'", lib._SqlConnection);
            cmd.ExecuteNonQuery();
            lib.PesanInformasi("Update berhasil");
            tampilkan();
            bersihkan();
            lib.TutupKoneksi();
        }
    }
}

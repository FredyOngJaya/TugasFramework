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
    public partial class FormAnggota : Form
    {
        public FormAnggota()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            txtno.Clear();
            txtnama.Clear();
            txtalamat.Clear();
            txttelepon.Clear();
            rd0.Checked = false;
            rd1.Checked = false;
            txtno.Focus();
        }

        void tampilkan()
        {
            DataTable dt = lib.GetDataTable("Select * from Anggota");
            dataGridViewDataAnggota.DataSource = dt;
            dataGridViewDataAnggota.Columns["id"].Visible = false;
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            lib.BukaKoneksi();
            if (txtno.Text.Equals(""))
            {
                lib.PesanInformasi("No Identitas Belum Diisi");
            }
            else if (txtnama.Text.Equals(""))
            {
                lib.PesanInformasi("Nama Anggota Belum Diisi");
            }
            else if (txtalamat.Text.Equals(""))
            {
                lib.PesanInformasi("Alamat Anggota Belum Diisi");
            }
            else if (txttelepon.Text.Equals(""))
            {
                lib.PesanInformasi("Telepon Anggota Belum Diisi");
            }
            else if (!rd0.Checked && !rd1.Checked)
            {
                lib.PesanInformasi("Jenis Kelamin Tidak Jelas");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert Into Anggota values('" + txtno.Text + "','" + txtnama.Text + "','" + (rd0.Checked ? "Laki-Laki" : "Perempuan") + "','" + txtalamat.Text + "','" + txttelepon.Text + "')", lib._SqlConnection);
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
            SqlCommand cmd = new SqlCommand("delete from anggota where nomor_identitas='" + txtno.Text + "'",lib._SqlConnection);
            cmd.ExecuteNonQuery();
            lib.PesanInformasi("Delete berhasil");
            tampilkan();
            bersihkan();
            lib.TutupKoneksi();
        }

        private void FormAnggota_Load(object sender, EventArgs e)
        {
            lib.BukaKoneksi();
            tampilkan();
            lib.TutupKoneksi();
        }

        private void dataGridViewDataAnggota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridViewDataAnggota.Rows[e.RowIndex];
            txtno.Text = dr.Cells["nomor_identitas"].Value.ToString();
            txtnama.Text = dr.Cells["nama"].Value.ToString();
            if (dr.Cells["jenis_kelamin"].Value.ToString() == "Perempuan")
                rd1.Checked = true;
            else
                rd0.Checked = true;
            txtalamat.Text = dr.Cells["alamat"].Value.ToString();
            txttelepon.Text = dr.Cells["hp"].Value.ToString();

        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            lib.BukaKoneksi();
            SqlCommand cmd = new SqlCommand("update anggota set nama='" + txtnama.Text + "', jenis_kelamin='" + (rd0.Checked ? "Laki-Laki" : "Perempuan") + "', alamat='" + txtalamat.Text + "', hp='" + txttelepon.Text + "' where nomor_identitas = '" + txtno.Text + "'", lib._SqlConnection);
            cmd.ExecuteNonQuery();
            lib.PesanInformasi("Update berhasil");
            tampilkan();
            bersihkan();
            lib.TutupKoneksi();
        }
    }
}

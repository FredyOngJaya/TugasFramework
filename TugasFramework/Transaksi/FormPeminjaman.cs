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

namespace TugasFramework.Transaksi
{
    public partial class FormPeminjaman : Form
    {
        TextBox[] arrayTextbox;

        public FormPeminjaman()
        {
            InitializeComponent();
            arrayTextbox = new TextBox[] { textBoxIDPeminjaman, textBoxIDMember, textBoxIDBuku, textBoxNamaMember, textBoxJudulBuku };
            buttonBatal.Click += new EventHandler(buttonBaru_Click);
        }

        private void buttonBrowseMember_Click(object sender, EventArgs e)
        {
            lib.BrowseMember(textBoxIDMember as Control);
        }

        private void textBoxIDMember_Leave(object sender, EventArgs e)
        {
            if (!textBoxIDMember.Text.Trim().Equals(""))
            {
                DataRow row = lib.GetDataAnggota(textBoxIDMember.Text);
                if (row != null)
                {
                    textBoxNamaMember.Text = row["nama"].ToString();
                }
            }
        }

        private void buttonBrowsePeminjaman_Click(object sender, EventArgs e)
        {
            lib.BrowsePeminjaman(textBoxIDPeminjaman as Control);
        }

        private void textBoxIDPeminjaman_Leave(object sender, EventArgs e)
        {
            if (!textBoxIDPeminjaman.Text.Trim().Equals(""))
            {
                DataRow row = lib.GetDataPeminjaman(textBoxIDPeminjaman.Text);
                if (row != null)
                {
                    //sudah ada peminjaman fill data
                    textBoxIDMember.Text = row["id"].ToString();
                    textBoxIDMember_Leave(null, null);
                }
            }
        }

        private void buttonBrowseBuku_Click(object sender, EventArgs e)
        {
            lib.BrowseBuku(textBoxIDBuku);
        }

        private void textBoxIDBuku_Leave(object sender, EventArgs e)
        {
            if (!textBoxIDBuku.Text.Trim().Equals(""))
            {
                DataRow row = lib.GetDataBuku(textBoxIDBuku.Text);
                if (row != null)
                {
                    textBoxJudulBuku.Text = row["judul"].ToString();
                }
            }
        }

        private void buttonBaru_Click(object sender, EventArgs e)
        {
            lib.ClearTextBox(arrayTextbox);
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into peminjaman values(@id_anggota,@id_buku,GETDATE(),0,null)", lib._SqlConnection);
                cmd.ExecuteNonQuery();
                lib.PesanInformasi("Data peminjaman sudah disimpan");
            }
            catch (Exception ex)
            {
                lib.PesanError(ex.Message);
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (lib.Pertanyaan("Yakin menghapus data ini?") == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from peminjaman where ID=@id", lib._SqlConnection);
                    cmd.Parameters.AddWithValue("@id", textBoxIDPeminjaman.Text);
                    cmd.ExecuteNonQuery();
                    lib.PesanInformasi("Data sudah terhapus");
                }
                catch (Exception ex)
                {
                    lib.PesanError(ex.Message);
                }
            }
        }
    }
}

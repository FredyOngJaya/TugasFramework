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
            arrayTextbox = new TextBox[] { textBoxIDPeminjaman, textBoxIDMember, textBoxIDBuku,
                textBoxNamaMember, textBoxJudulBuku };
            buttonBatal_Click(null, null);
        }

        #region Browse

        private void buttonBrowsePeminjaman_Click(object sender, EventArgs e)
        {
            lib.BrowsePeminjaman(textBoxIDPeminjaman as Control);
            textBoxIDPeminjaman_Leave(null, null);
        }

        private void buttonBrowseMember_Click(object sender, EventArgs e)
        {
            lib.BrowseMember(textBoxIDMember as Control);
            textBoxIDMember_Leave(null, null);
        }

        private void buttonBrowseBuku_Click(object sender, EventArgs e)
        {
            lib.BrowseBuku(textBoxIDBuku);
            textBoxIDBuku_Leave(null, null);
        }

        #endregion

        #region Function & Procedure

        private void SetButton(bool baru, bool simpan, bool hapus, bool batal)
        {
            buttonBaru.Enabled = baru;
            buttonSimpan.Enabled = simpan;
            buttonHapus.Enabled = hapus;
            buttonBatal.Enabled = batal;
        }

        private void SetForm(bool pinjam, bool panel)
        {
            textBoxIDPeminjaman.Enabled = pinjam;
            buttonBrowsePeminjaman.Enabled = pinjam;
            panelData.Enabled = panel;
        }

        #endregion

        #region Menu Utama

        private void buttonBaru_Click(object sender, EventArgs e)
        {
            lib.ClearTextBox(arrayTextbox);
            dateTimePickerTanggalPeminjaman.Value = lib.GetDate();
            SetForm(false, true);
            SetButton(false, true, false, true);
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Peminjaman_Buku "+
                    "values(@id_anggota,@id_buku,GETDATE(),0,null)", lib._SqlConnection);
                cmd.Parameters.AddWithValue("@id_anggota", textBoxIDMember.Text);
                cmd.Parameters.AddWithValue("@id_buku", textBoxIDBuku.Text);
                cmd.ExecuteNonQuery();
                lib.PesanInformasi("Data peminjaman sudah disimpan");
                buttonBatal_Click(null, null);
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
                    buttonBatal_Click(null, null);
                }
                catch (Exception ex)
                {
                    lib.PesanError(ex.Message);
                }
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            lib.ClearTextBox(arrayTextbox);
            SetForm(true, false);
            SetButton(true, false, false, false);
        }

        #endregion

        #region Event

        private void textBoxIDPeminjaman_Leave(object sender, EventArgs e)
        {
            if (!textBoxIDPeminjaman.Text.Trim().Equals(""))
            {
                DataRow row = lib.GetDataPeminjaman(textBoxIDPeminjaman.Text);
                if (row != null)
                {
                    //sudah ada peminjaman fill data
                    textBoxIDMember.Text = row["id_anggota"].ToString();
                    textBoxIDBuku.Text = row["id_buku"].ToString();
                    dateTimePickerTanggalPeminjaman.Value = Convert.ToDateTime(row["tanggal_pinjam"]);
                    SetButton(false, false, true, true);
                    textBoxIDMember_Leave(null, null);
                    textBoxIDBuku_Leave(null, null);
                }
            }
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

        #endregion
    }
}

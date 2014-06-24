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
    public partial class FormPengembalian : Form
    {
        TextBox[] arrayTextbox;
        SqlTransaction _SqlTransaction;
        List<int> listIDPeminjaman = new List<int>();

        public FormPengembalian()
        {
            InitializeComponent();
            arrayTextbox = new TextBox[] { textBoxIDMember, textBoxNamaMember };
            buttonBatal_Click(null, null);
        }

        #region Browse

        private void buttonBrowseMember_Click(object sender, EventArgs e)
        {
            lib.BrowseMember(textBoxIDMember as Control);
            textBoxIDMember_Leave(null, null);
        }

        private void buttonBrowsePeminjaman_Click(object sender, EventArgs e)
        {
            FormBrowse browse = new FormBrowse("Cari Peminjaman",
                "select a.id, b.nama as [Nama Peminjam], c.judul as [Judul Buku], " +
                "a.tanggal_pinjam as [Tanggal Peminjaman], a.sudah_kembali as [Status Kembali] " +
                "from peminjaman_buku a " +
                "inner join anggota b on a.id_anggota=b.id " +
                "inner join buku c on a.id_buku=c.id " +
                "where a.id_anggota=" + textBoxIDMember.Text,
                "Nama Peminjam", "Nama", (sd, ev) =>
                {
                    DataGridViewRow row = (sd as DataGridView).Rows[ev.RowIndex];
                    int id_pinjam = Convert.ToInt32(row.Cells["id"].Value);
                    if (listIDPeminjaman.Select(x => x == id_pinjam).ToList().Count == 0)
                    {
                        listIDPeminjaman.Add(id_pinjam);
                        dataGridViewDataPeminjaman.Rows.Add(new object[] { row.Cells["id"].Value,
                        row.Cells["judul buku"].Value, row.Cells["tanggal peminjaman"].Value });
                    }
                    else
                    {
                        lib.PesanInformasi("Data peminjaman ini sudah ditambahkan");
                    }
                });
            browse.ShowDialog();
            browse.Dispose();
        }

        #endregion

        #region Function & Procedure

        private void SetButton(bool baru, bool simpan, bool batal)
        {
            buttonBaru.Enabled = baru;
            buttonSimpan.Enabled = simpan;
            buttonBatal.Enabled = batal;
        }

        private void SetForm(bool kembali, bool groupBox)
        {
            textBoxIDMember.Enabled = kembali;
            buttonBrowseMember.Enabled = kembali;
            groupBoxDataPeminjaman.Enabled = groupBox;
        }

        #endregion

        #region Menu Utama

        private void buttonHapusGrid_Click(object sender, EventArgs e)
        {
            if (dataGridViewDataPeminjaman.RowCount > 0 && dataGridViewDataPeminjaman.SelectedRows != null)
            {
                dataGridViewDataPeminjaman.Rows.Remove(dataGridViewDataPeminjaman.SelectedRows[0]);
            }
        }

        private void buttonBaru_Click(object sender, EventArgs e)
        {
            lib.ClearTextBox(arrayTextbox);
            dataGridViewDataPeminjaman.Rows.Clear();
            listIDPeminjaman.Clear();
            SetForm(true, false);
            SetButton(false, true, true);
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (lib.Pertanyaan("Simpan data pengembalian buku ini?") == DialogResult.Yes)
            {
                _SqlTransaction = lib._SqlConnection.BeginTransaction(IsolationLevel.RepeatableRead);
                try
                {
                    SqlCommand cmd = new SqlCommand("", lib._SqlConnection, _SqlTransaction);
                    cmd.Parameters.AddWithValue("@id", 0);
                    foreach (DataGridViewRow row in dataGridViewDataPeminjaman.Rows)
                    {
                        cmd.Parameters["@id"].Value = row.Cells["id"].Value;
                        cmd.CommandText = "update Peminjaman_Buku set sudah_kembali=1, "+
                            "tanggal_kembali=GETDATE() where id=@id";
                        cmd.ExecuteNonQuery();
                    }
                    _SqlTransaction.Commit();
                    lib.PesanInformasi("Data pengembalian sudah tersimpan");
                    buttonBatal_Click(null, null);
                }
                catch (Exception ex)
                {
                    _SqlTransaction.Rollback();
                    lib.PesanError(ex.Message);
                }
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            lib.ClearTextBox(arrayTextbox);
            dataGridViewDataPeminjaman.Rows.Clear();
            SetForm(false, false);
            SetButton(true, false, false);
        }

        #endregion

        #region Event

        private void textBoxIDMember_Leave(object sender, EventArgs e)
        {
            if (!textBoxIDMember.Text.Trim().Equals(""))
            {
                DataRow row = lib.GetDataAnggota(textBoxIDMember.Text);
                if (row != null)
                {
                    textBoxNamaMember.Text = row["nama"].ToString();
                    SetForm(false, true);
                }
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TugasFramework.Library
{
    public class LibGlobal
    {
        /// <summary>
        /// ConnectionString ke database
        /// </summary>
        private static string _SqlConnectionString = "Data Source = (local); Initial Catalog = Library; Integrated Security = True";
        //private static string _SqlConnectionString = @"Data Source = ONG\SQLEXPRESS; Initial Catalog = Library; Integrated Security = True";
        /// <summary>
        /// Koneksi SQL ke database
        /// </summary>
        public static SqlConnection _SqlConnection = new SqlConnection(_SqlConnectionString);
        /// <summary>
        /// KeyEventHandler enter jadi tab
        /// </summary>
        public static KeyEventHandler enterAsTab = (s, e) =>
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        };
        /// <summary>
        /// KeyPressEventHandler enter supaya tidak ada sound beep
        /// </summary>
        public static KeyPressEventHandler disableEnterErrorSound = (s, e) =>
        {
            if (e.KeyChar == (char)Keys.Enter) e.Handled = true;
        };

        #region MessageBox

        /// <summary>
        /// MessageBox untuk informasi
        /// </summary>
        /// <param name="pesan"></param>
        /// <returns></returns>
        public static DialogResult PesanInformasi(string pesan)
        {
            return MessageBox.Show(pesan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// MessageBox untuk warning
        /// </summary>
        /// <param name="pesan"></param>
        /// <returns></returns>
        public static DialogResult PesanPeringatan(string pesan)
        {
            return MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// MessageBox untuk error
        /// </summary>
        /// <param name="pesan"></param>
        /// <returns></returns>
        public static DialogResult PesanError(string pesan)
        {
            return MessageBox.Show(pesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// MessageBox untuk pertanyaan
        /// </summary>
        /// <param name="pesan"></param>
        /// <returns></returns>
        public static DialogResult Pertanyaan(string pesan)
        {
            return MessageBox.Show(pesan, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion


        /// <summary>
        /// Original by : Yudi Umar (091111748), edited
        /// </summary>
        #region SQL

        /// <summary>
        /// Buka koneksi ke database, atau koneksi ulang
        /// </summary>
        /// <param name="connection"></param>
        public static void BukaKoneksi()
        {
            try
            {
                if (_SqlConnection.State != ConnectionState.Open)
                {
                    _SqlConnection.Open();
                }
                else if (_SqlConnection.State == ConnectionState.Broken)
                {
                    _SqlConnection.Close();
                    _SqlConnection.Open();
                }
            }
            catch (Exception e)
            {
                PesanError(e.Message);
                Application.ExitThread();
            }
        }

        /// <summary>
        /// Tutup koneksi ke database
        /// </summary>
        /// <param name="connection"></param>
        public static void TutupKoneksi()
        {
            if (_SqlConnection.State != ConnectionState.Closed)
            {
                _SqlConnection.Close();
            }
        }

        public static DateTime GetDate()
        {
            return Convert.ToDateTime(GetObject("select GETDATE()"));
        }

        /// <summary>
        /// Ambil data DB dalam tabel
        /// </summary>
        /// <param name="da"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(SqlDataAdapter da)
        {
            try
            {
                DataTable result = new DataTable();
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                PesanError(ex.Message);
                return new DataTable();
            }
        }

        /// <summary>
        /// Ambil data DB dalam tabel
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(SqlCommand cmd)
        {
            return GetDataTable(new SqlDataAdapter(cmd));
        }

        /// <summary>
        /// Ambil data DB dalam tabel, dengan koneksi default
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            return GetDataTable(new SqlDataAdapter(sql, _SqlConnection));
        }

        /// <summary>
        /// Ambil data DB dalam row, jika tidak ada data, return null
        /// </summary>
        /// <param name="da"></param>
        /// <returns></returns>
        public static DataRow GetDataRow(SqlDataAdapter da)
        {
            DataTable table = GetDataTable(da);
            return (table.Rows.Count > 0) ? table.Rows[0] : null;
        }

        /// <summary>
        /// Ambil data DB dalam row, jika tidak ada data, return null
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static DataRow GetDataRow(SqlCommand cmd)
        {
            return GetDataRow(new SqlDataAdapter(cmd));
        }

        /// <summary>
        /// Ambil data DB dalam row, dengan koneksi default, jika tidak ada data, return null
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataRow GetDataRow(string sql)
        {
            return GetDataRow(new SqlDataAdapter(sql, _SqlConnection));
        }

        /// <summary>
        /// Ambil data DB baris 1 kolom 1, jika tidak ada data, return null
        /// </summary>
        /// <param name="da"></param>
        /// <returns></returns>
        public static object GetObject(SqlDataAdapter da)
        {
            DataRow row = GetDataRow(da);
            return (row != null) ? row[0] : null;
        }

        /// <summary>
        /// Ambil data DB baris 1 kolom 1, jika tidak ada data, return null
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static object GetObject(SqlCommand cmd)
        {
            return GetObject(new SqlDataAdapter(cmd));
        }

        /// <summary>
        /// Ambil data DB baris 1 kolom 1, dengan koneksi default, jika tidak ada data, return null
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetObject(string sql)
        {
            return GetObject(new SqlDataAdapter(sql, _SqlConnection));
        }

        #endregion

        #region Kriptografi

        /// <summary>
        /// SHA-1 dari string
        /// </summary>
        /// <param name="_string"></param>
        /// <returns></returns>
        public static string GetSHA1(string _string)
        {
            SHA1 _sha1 = SHA1.Create();
            byte[] _input = Encoding.ASCII.GetBytes(_string);
            byte[] _hash = _sha1.ComputeHash(_input);

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < _hash.Length; i++)
            {
                output.Append(_hash[i].ToString("X2"));
            }
            return output.ToString();
        }

        #endregion

        #region Form Control

        /// <summary>
        /// Untuk bersihkan text di textbox
        /// </summary>
        /// <param name="arrayTextBox"></param>
        public static void ClearTextBox(TextBox[] arrayTextBox)
        {
            foreach (TextBox textbox in arrayTextBox)
            {
                textbox.Clear();
            }
        }
        
        /// <summary>
        /// Untuk reset selection index combobox ke 0
        /// </summary>
        /// <param name="arrayComboBox"></param>
        public static void ResetComboBox(ComboBox[] arrayComboBox)
        {
            foreach (ComboBox combobox in arrayComboBox)
            {
                if (combobox.Items.Count > 0)
                {
                    combobox.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// ? dipake / g
        /// </summary>
        /// <param name="arrayTextBox"></param>
        /// <returns></returns>
        public static bool CheckTextBoxFilled(TextBox[] arrayTextBox)
        {
            bool result = true;
            foreach (TextBox textbox in arrayTextBox)
            {
                if (textbox.Text.Equals(""))
                {
                    result = false;
                }
            }
            return result;
        }

        #endregion

        #region Browse

        public static void BrowseMember(Control controlID)
        {
            FormBrowse browse = new FormBrowse("Cari Member",
                "select id as [Member ID], Nama from Anggota",
                "Nama Member", "Nama", (sd, ev) =>
                {
                    DataGridViewRow row = (sd as DataGridView).Rows[ev.RowIndex];
                    controlID.Text = row.Cells["Member ID"].Value.ToString();
                });
            browse.ShowDialog();
            browse.Dispose();
        }

        public static void BrowseBuku(Control controlID)
        {
            FormBrowse browse = new FormBrowse("Cari Buku",
                "select * from Buku",
                "Judul Buku", "Judul", (sd, ev) =>
                {
                    DataGridViewRow row = (sd as DataGridView).Rows[ev.RowIndex];
                    controlID.Text = row.Cells["id"].Value.ToString();
                });
            browse.ShowDialog();
            browse.Dispose();
        }

        public static void BrowsePeminjaman(Control controlID)
        {
            FormBrowse browse = new FormBrowse("Cari Peminjaman",
                "select a.id, b.nama as [Nama Peminjam], c.judul as [Judul Buku], "+
                "a.tanggal_pinjam as [Tanggal Peminjaman], a.sudah_kembali as [Status Kembali] "+
                "from peminjaman_buku a "+
                "inner join anggota b on a.id_anggota=b.id " +
                "inner join buku c on a.id_buku=c.id",
                "Nama Peminjam", "Nama", (sd, ev) =>
                {
                    DataGridViewRow row = (sd as DataGridView).Rows[ev.RowIndex];
                    controlID.Text = row.Cells["id"].Value.ToString();
                });
            browse.ShowDialog();
            browse.Dispose();
        }

        #endregion

        public static DataRow GetDataAnggota(string IDAnggota)
        {
            SqlCommand cmd = new SqlCommand("select * from Anggota where ID=@id", _SqlConnection);
            cmd.Parameters.AddWithValue("@id", IDAnggota);
            return GetDataRow(cmd);
        }

        public static DataRow GetDataBuku(string IDBuku)
        {
            SqlCommand cmd = new SqlCommand("select * from Buku where ID=@id", _SqlConnection);
            cmd.Parameters.AddWithValue("@id", IDBuku);
            return GetDataRow(cmd);
        }

        public static DataRow GetDataPeminjaman(string IDPeminjaman)
        {
            SqlCommand cmd = new SqlCommand("select a.*, b.id as id_anggota, c.id as id_buku " +
                                            "from peminjaman_buku a " +
                                            "inner join anggota b on a.id_anggota=b.id " +
                                            "inner join buku c on a.id_buku=c.id", _SqlConnection);
            cmd.Parameters.AddWithValue("@id", IDPeminjaman);
            return GetDataRow(cmd);
        }
    }

    public static class LibExtensions
    {
    }
}

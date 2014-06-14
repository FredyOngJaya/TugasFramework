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
        /// Ambil data DB dalam tabel
        /// </summary>
        /// <param name="da"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(SqlDataAdapter da)
        {
            DataTable result = new DataTable();
            da.Fill(result);
            return result;
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
    }

    public static class LibExtensions
    {
        /// <summary>
        /// Buka koneksi ke database, atau koneksi ulang
        /// </summary>
        /// <param name="connection"></param>
        public static void BukaKoneksi(this SqlConnection connection)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                LibGlobal.PesanError(e.Message);
            }
        }

        /// <summary>
        /// Tutup koneksi ke database
        /// </summary>
        /// <param name="connection"></param>
        public static void TutupKoneksi(this SqlConnection connection)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}

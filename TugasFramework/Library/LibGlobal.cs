using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TugasFramework.Library
{
    public class LibGlobal
    {
        /// <summary>
        /// ConnectionString ke database
        /// </summary>
        private static string _SqlConnectionString = "Data Source = (local); Initial Catalog = db_name; Integrated Security = True";
        /// <summary>
        /// Koneksi SQL ke database
        /// </summary>
        public static SqlConnection _SqlConnection = new SqlConnection(_SqlConnectionString);

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
        public static DialogResult PesanWarning(string pesan)
        {
            return MessageBox.Show(pesan, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
    }

    public static class LibExtensions
    {
        /// <summary>
        /// Buka koneksi database
        /// </summary>
        /// <param name="connection"></param>
        public static void OpenConnection(this SqlConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Tutup koneksi database
        /// </summary>
        /// <param name="connection"></param>
        public static void CloseConnection(this SqlConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}

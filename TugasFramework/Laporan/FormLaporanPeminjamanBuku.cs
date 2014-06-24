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

namespace TugasFramework.Laporan
{
    public partial class FormLaporanPeminjamanBuku : Form
    {
        DataSetLaporan ds = new DataSetLaporan();

        public FormLaporanPeminjamanBuku()
        {
            InitializeComponent();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string sql = "select b.nama, c.judul, a.tanggal_pinjam, " +
                "(case when a.sudah_kembali=1 then 'Sudah dikembalikan' " +
                "else 'Belum dikembalikan' end) as status_pinjam, " +
                "a.tanggal_kembali from Peminjaman_Buku a " +
                "inner join Anggota b on a.id_anggota=b.id " +
                "inner join Buku c on a.id_buku=c.id";
            SqlCommand cmd = new SqlCommand(sql, lib._SqlConnection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.Peminjaman);
            FormPreviewCrystalReport preview = new FormPreviewCrystalReport("Laporan Peminjaman",
                new CrystalReportLaporanPeminjaman(), ds.Peminjaman);
            preview.ShowDialog();
            preview.Dispose();
        }
    }
}

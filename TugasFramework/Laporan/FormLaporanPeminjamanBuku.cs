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
                "inner join Buku c on a.id_buku=c.id " +
                "where a.tanggal_pinjam >= @tanggal_awal and a.tanggal_pinjam < @tanggal_akhir";
            SqlCommand cmd = new SqlCommand(sql, lib._SqlConnection);
            cmd.Parameters.AddWithValue("@tanggal_awal", dateTimePickerTanggalAwal.Value.Date);
            cmd.Parameters.AddWithValue("@tanggal_akhir", dateTimePickerTanggalAkhir.Value.Date.AddDays(1));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds.Peminjaman.Rows.Clear();
            da.Fill(ds.Peminjaman);
            FormPreviewCrystalReport preview = new FormPreviewCrystalReport("Laporan Peminjaman",
                new CrystalReportLaporanPeminjaman(), ds.Peminjaman);
            preview.ShowDialog();
            preview.Dispose();
        }
    }
}

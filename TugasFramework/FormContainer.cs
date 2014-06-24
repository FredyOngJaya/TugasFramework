using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

using TugasFramework.Library;
using lib = TugasFramework.Library.LibGlobal;

namespace TugasFramework
{
    public partial class FormContainer : Form
    {
        private Master.FormAnggota anggota;
        private Master.FormBuku buku;
        private Master.FormPengarang pengarang;
        private Transaksi.FormPeminjaman peminjaman;
        private Transaksi.FormPengembalian pengembalian;
        private Laporan.FormLaporanPeminjamanBuku laporanPeminjaman;
        private Game.Form2048 Game2048;
        private Form1 formTest;

        public bool isTerminated { get; private set; }

        public FormContainer()
        {
            InitializeComponent();
            lib.BukaKoneksi();
            isTerminated = false;
            FormLogin loginFirst = new FormLogin();
            loginFirst.ShowDialog();
            if (!loginFirst.loginSukses)
            {
                isTerminated = true;
                lib.TutupKoneksi();
                return;
            }
            this.menuStripLibrary.Renderer = new Library.LibRender();
        }

        private void FormContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            lib.TutupKoneksi();
        }

        private void ShowForm<T>(ref T newForm, bool showDialogMode)
        {
            try
            {
                if (newForm == null || !(newForm as Form).IsHandleCreated)
                {
                    Type t = typeof(T);
                    Assembly a = Assembly.GetAssembly(t);
                    newForm = (T)Convert.ChangeType(a.CreateInstance(t.FullName), t);
                }
                Form form = newForm as Form;
                if (showDialogMode)
                {
                    form.ShowDialog();
                }
                else
                {
                    form.KeyPreview = true;
                    form.KeyDown += lib.enterAsTab;
                    form.KeyPress += lib.disableEnterErrorSound;
                    form.MdiParent = this;
                    form.Show();
                    form.Focus();
                }
            }
            catch (TargetInvocationException ex)
            {
                lib.PesanError(ex.Message);
            }
            catch (Exception ex)
            {
                lib.PesanError(ex.Message);
            }
        }

        private void ShowForm<T>(ref T newForm)
        {
            ShowForm(ref newForm, false);
        }

        #region Master

        private void anggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref anggota);
        }

        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref buku);
        }

        private void pengarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref pengarang);
        }

        #endregion

        #region Transaksi

        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref peminjaman);
        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref pengembalian);
        }

        #endregion

        #region Game

        private void game2048ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref Game2048, true);
        }

        #endregion

        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref formTest);
        }

        private void laporanPeminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref laporanPeminjaman);
        }
    }
}

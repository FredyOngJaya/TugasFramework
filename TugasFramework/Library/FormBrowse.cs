using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace TugasFramework.Library
{
    public partial class FormBrowse : Form
    {
        private DataView dataViewSQL;
        private string namaKolomFilter;

        /// <summary>
        /// Form untuk browse
        /// </summary>
        /// <param name="width">Lebar</param>
        /// <param name="height">Tinggi</param>
        /// <param name="namaForm">Judul form</param>
        /// <param name="sqlQuerySelect">SQL query select</param>
        /// <param name="namaLabelCari">Text label cari</param>
        /// <param name="namaKolomUntukFilter">Nama kolom filter datagrid</param>
        /// <param name="kolomHidden">Nama kolom hidden</param>
        /// <param name="cellContentDoubleClickEvent">Event doubleclick cell grid</param>
        public FormBrowse(int width, int height, string namaForm, string sqlQuerySelect,
                            string namaLabelCari, string namaKolomUntukFilter,
                            string[] kolomHidden, DataGridViewCellEventHandler cellContentDoubleClickEvent)
        {
            InitializeComponent();

            FillData(width, height, namaForm, sqlQuerySelect, namaLabelCari,
                    namaKolomUntukFilter, kolomHidden, cellContentDoubleClickEvent);
        }

        /// <summary>
        /// Form untuk browse
        /// </summary>
        /// <param name="width">Lebar</param>
        /// <param name="height">Tinggi</param>
        /// <param name="namaForm">Judul form</param>
        /// <param name="sqlQuerySelect">SQL query select</param>
        /// <param name="namaLabelCari">Text label cari</param>
        /// <param name="namaKolomUntukFilter">Nama kolom filter datagrid</param>
        /// <param name="cellContentDoubleClickEvent">Event doubleclick cell grid</param>
        public FormBrowse(int width, int height, string namaForm, string sqlQuerySelect,
                            string namaLabelCari, string namaKolomUntukFilter,
                            DataGridViewCellEventHandler cellContentDoubleClickEvent)
        {
            InitializeComponent();

            FillData(width, height, namaForm, sqlQuerySelect, namaLabelCari,
                    namaKolomUntukFilter, new string[] { }, cellContentDoubleClickEvent);
        }

        /// <summary>
        /// Form untuk browse, width 800, height 450
        /// </summary>
        /// <param name="namaForm">Judul form</param>
        /// <param name="sqlQuerySelect">SQL query select</param>
        /// <param name="namaLabelCari">Text label cari</param>
        /// <param name="namaKolomUntukFilter">Nama kolom filter datagrid</param>
        /// <param name="kolomHidden">Nama kolom hidden</param>
        /// <param name="cellContentDoubleClickEvent">Event doubleclick cell grid</param>
        public FormBrowse(string namaForm, string sqlQuerySelect,
                            string namaLabelCari, string namaKolomUntukFilter,
                            string[] kolomHidden, DataGridViewCellEventHandler cellContentDoubleClickEvent)
        {
            InitializeComponent();

            FillData(800, 450, namaForm, sqlQuerySelect, namaLabelCari,
                    namaKolomUntukFilter, kolomHidden, cellContentDoubleClickEvent);
        }

        /// <summary>
        /// Form untuk browse, width 800, height 450
        /// </summary>
        /// <param name="namaForm">Judul form</param>
        /// <param name="sqlQuerySelect">SQL query select</param>
        /// <param name="namaLabelCari">Text label cari</param>
        /// <param name="namaKolomUntukFilter">Nama kolom filter datagrid</param>
        /// <param name="cellContentDoubleClickEvent">Event doubleclick cell grid</param>
        public FormBrowse(string namaForm, string sqlQuerySelect,
                            string namaLabelCari, string namaKolomUntukFilter,
                            DataGridViewCellEventHandler cellContentDoubleClickEvent)
        {
            InitializeComponent();

            FillData(800, 450, namaForm, sqlQuerySelect, namaLabelCari,
                    namaKolomUntukFilter, new string[] { }, cellContentDoubleClickEvent);
        }

        private void FillData(int width, int height, string namaForm, string sqlQuerySelect,
                            string namaLabelCari, string namaKolomUntukFilter,
                            string[] kolomHidden, DataGridViewCellEventHandler cellContentDoubleClickEvent)
        {
            this.Width = width;
            this.Height = height;
            this.Text = namaForm;
            this.labelCari.Text = namaLabelCari;
            this.dataGridViewData.CellDoubleClick += (cellContentDoubleClickEvent + new DataGridViewCellEventHandler((s, e) => { this.Close(); }));

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (char c in namaKolomUntukFilter)
            {
                if (c == ']' || c == '\\')
                {
                    sb.Append('\\');
                }
                sb.Append(c);
            }
            sb.Append(']');
            this.namaKolomFilter = sb.ToString();

            LibGlobal.BukaKoneksi();
            this.dataViewSQL = LibGlobal.GetDataTable(sqlQuerySelect).DefaultView;
            this.dataGridViewData.DataSource = this.dataViewSQL;

            foreach (string namaKolom in kolomHidden)
            {
                this.dataGridViewData.Columns[namaKolom].Visible = false;
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxCari.Text;
            StringBuilder sb = new StringBuilder();
            foreach (char c in filter)
            {
                if (c == '*' || c == '%' || c == '[' || c == ']')
                {
                    sb.Append('[' + c + ']');
                }
                else if (c == '\'')
                {
                    sb.Append("''");
                }
                else
                {
                    sb.Append(c);
                }
            }
            this.dataViewSQL.RowFilter = namaKolomFilter + " like '%" + sb.ToString() + "%'";
        }
    }
}

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
        public DataGridViewRow result { get; private set; }
        //private namaKolom

        public FormBrowse(int width, int height, string namaForm, string sql, 
                            string namaLabelCari, string namaKolomFilter, string[] kolomHidden)
        {
            InitializeComponent();

            this.Width = width;
            this.Height = height;
            this.Text = namaForm;
            this.labelCari.Text = namaLabelCari;
        }
    }
}

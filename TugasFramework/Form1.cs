using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TugasFramework.Library;
using lib = TugasFramework.Library.LibGlobal;

namespace TugasFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cara pake FormBrowse
            //FormBrowse browse = new FormBrowse("NAMA FORM TEST",
            //    "select * from anggota", "LABEL CARI", @"NAMA", new string[] { "id" },
            //    (sd, ev) =>
            //    {
            //        DataGridViewRow row = (sd as DataGridView).Rows[ev.RowIndex];
            //        textBox1.Text = row.Cells["id"].Value.ToString();
            //        textBox2.Text = row.Cells["nama"].Value.ToString();
            //    });
            //browse.ShowDialog();
            //browse.Dispose();
            lib.BrowseMember(textBox1 as Control);
        }
    }
}

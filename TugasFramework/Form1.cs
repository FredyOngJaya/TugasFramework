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
            lib._SqlConnection.BukaKoneksi();
            lib.PesanError("ERROR");
            lib.PesanInformasi("INFO");
            lib.PesanPeringatan("WARNING");
            lib.Pertanyaan("ARE U SURE");
        }
    }
}

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
    public partial class FormLogin : Form
    {
        public bool loginSukses { get; set; }

        public FormLogin()
        {
            InitializeComponent();

            loginSukses = false;
            textBoxUsername.KeyDown += lib.enterAsTab;
            textBoxPassword.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) buttonMasuk.PerformClick(); };
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim().Length == 0)
                lib.PesanInformasi("Masukkan username");
            else if (textBoxPassword.Text.Length == 0)
                lib.PesanInformasi("Masukkan password");
            else
            {
                try
                {
                    DataRow login = lib.GetDataRow("select * from pengguna where username='" + textBoxUsername.Text.Replace("'", "''") +
                                                    "' and fingerprint='" + lib.GetSHA1(textBoxPassword.Text) + "'");
                    if (login != null)
                    {
                        loginSukses = true;
                        this.Close();
                    }
                    else
                    {
                        lib.PesanError("Username atau password salah");
                    }
                }
                catch (Exception ex)
                {
                    lib.PesanError(ex.Message);
                }
            }
        }
    }
}

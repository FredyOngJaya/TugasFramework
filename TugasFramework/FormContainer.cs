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
        private Game.Form2048 Game2048;
        private Form1 formTest;
        public bool isTerminated { get; private set; }

        public FormContainer()
        {
            InitializeComponent();
            lib._SqlConnection.BukaKoneksi();
            isTerminated = false;
            FormLogin loginFirst = new FormLogin();
            this.Hide();
            loginFirst.ShowDialog();
            if (!loginFirst.loginSukses)
            {
                isTerminated = true;
            }
            this.menuStripLibrary.Renderer = new Library.LibRender();
        }

        private void FormContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            lib._SqlConnection.TutupKoneksi();
        }

        private void ShowForm<T>(ref T newForm, bool showDialogMode)
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
                form.MdiParent = this;
                form.Show();
                form.Focus();
            }
        }

        private void ShowForm<T>(ref T newForm)
        {
            ShowForm(ref newForm, false);
        }

        private void game2048ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref Game2048, true);
        }

        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref formTest);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace TugasFramework
{
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
            this.menuStripLibrary.Renderer = new Library.LibRender();
            this.KeyDown += (s, e) => { if (this.ActiveMdiChild != null) return; };
            this.KeyDown += new KeyEventHandler(FormContainer_KeyDown);
        }

        void FormContainer_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private Game.Form2048 Game2048;
        private Form1 formTest;

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

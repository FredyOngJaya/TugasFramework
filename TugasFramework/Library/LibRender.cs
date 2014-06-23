using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TugasFramework.Library
{
    /// <summary>
    /// Original by : Ade Maulana (091112719)
    /// </summary>
    class LibRender : ToolStripProfessionalRenderer
    {
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            base.OnRenderToolStripBackground(e);
            // msdn 000000, hover #00bcf2
            // VS2010-2012 violet 67217a
            // hacker cup green 26B061
            e.ToolStrip.BackColor = Color.FromArgb(0, 0, 0);
            e.ToolStrip.ForeColor = Color.White;
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                //e.Graphics.FillRectangle(Brushes.LimeGreen, e.Item.ContentRectangle);
                //e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0x00, 0xbc, 0xf2)), e.Item.ContentRectangle);
            }
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(Brushes.LimeGreen, e.Item.ContentRectangle);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            if (e.Item.Selected)
            {
                e.Item.ForeColor = Color.FromArgb(0x00, 0xbc, 0xf2);
            }
            else
            {
                e.Item.ForeColor = Color.FromArgb(0xff, 0xff, 0xff);
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace TugasFramework
{
    class CustomButton : Button
    {
        public CustomButton()
        {
            this.BackColor = Color.Silver;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            this.ForeColor = Color.White;
        }
    }
}

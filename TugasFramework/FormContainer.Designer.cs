namespace TugasFramework
{
    partial class FormContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripLibrary = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // menuStripLibrary
            // 
            this.menuStripLibrary.Location = new System.Drawing.Point(0, 0);
            this.menuStripLibrary.Name = "menuStripLibrary";
            this.menuStripLibrary.Size = new System.Drawing.Size(630, 24);
            this.menuStripLibrary.TabIndex = 0;
            this.menuStripLibrary.Text = "menuStrip1";
            // 
            // FormContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(630, 401);
            this.Controls.Add(this.menuStripLibrary);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripLibrary;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormContainer";
            this.ShowIcon = false;
            this.Text = "Framework";
            this.Load += new System.EventHandler(this.FormContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripLibrary;
    }
}
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
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.game2048ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripLibrary
            // 
            this.menuStripLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.testingToolStripMenuItem});
            this.menuStripLibrary.Location = new System.Drawing.Point(0, 0);
            this.menuStripLibrary.Name = "menuStripLibrary";
            this.menuStripLibrary.Size = new System.Drawing.Size(630, 24);
            this.menuStripLibrary.TabIndex = 0;
            this.menuStripLibrary.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peminjamanToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.game2048ToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // game2048ToolStripMenuItem
            // 
            this.game2048ToolStripMenuItem.Name = "game2048ToolStripMenuItem";
            this.game2048ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.game2048ToolStripMenuItem.Text = "Game 2048";
            this.game2048ToolStripMenuItem.Click += new System.EventHandler(this.game2048ToolStripMenuItem_Click);
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.testingToolStripMenuItem.Text = "testing";
            this.testingToolStripMenuItem.Click += new System.EventHandler(this.testingToolStripMenuItem_Click);
            // 
            // peminjamanToolStripMenuItem
            // 
            this.peminjamanToolStripMenuItem.Name = "peminjamanToolStripMenuItem";
            this.peminjamanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.peminjamanToolStripMenuItem.Text = "Peminjaman";
            this.peminjamanToolStripMenuItem.Click += new System.EventHandler(this.peminjamanToolStripMenuItem_Click);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContainer_FormClosing);
            this.menuStripLibrary.ResumeLayout(false);
            this.menuStripLibrary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripLibrary;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem game2048ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanToolStripMenuItem;
    }
}
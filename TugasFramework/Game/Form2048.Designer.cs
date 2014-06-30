namespace TugasFramework.Game
{
    partial class Form2048
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
            this.labelScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelScore = new System.Windows.Forms.Panel();
            this.panelBest = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBestScore = new System.Windows.Forms.Label();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.buttonTryAgain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label01 = new System.Windows.Forms.Label();
            this.label00 = new System.Windows.Forms.Label();
            this.panelWin = new System.Windows.Forms.Panel();
            this.buttonKeepGoing = new System.Windows.Forms.Button();
            this.buttonTryAgainWin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelScore.SuspendLayout();
            this.panelBest.SuspendLayout();
            this.panelGameOver.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.panelWin.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScore.Location = new System.Drawing.Point(0, 31);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(85, 25);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "SCORE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 60);
            this.label5.TabIndex = 6;
            this.label5.Text = "2048";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelScore
            // 
            this.panelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.panelScore.Controls.Add(this.label4);
            this.panelScore.Controls.Add(this.labelScore);
            this.panelScore.Location = new System.Drawing.Point(154, 9);
            this.panelScore.Name = "panelScore";
            this.panelScore.Size = new System.Drawing.Size(85, 60);
            this.panelScore.TabIndex = 7;
            // 
            // panelBest
            // 
            this.panelBest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.panelBest.Controls.Add(this.label1);
            this.panelBest.Controls.Add(this.labelBestScore);
            this.panelBest.Location = new System.Drawing.Point(245, 9);
            this.panelBest.Name = "panelBest";
            this.panelBest.Size = new System.Drawing.Size(85, 60);
            this.panelBest.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "BEST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBestScore
            // 
            this.labelBestScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBestScore.Location = new System.Drawing.Point(0, 31);
            this.labelBestScore.Name = "labelBestScore";
            this.labelBestScore.Size = new System.Drawing.Size(85, 25);
            this.labelBestScore.TabIndex = 5;
            this.labelBestScore.Text = "0";
            this.labelBestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGameOver
            // 
            this.panelGameOver.Controls.Add(this.buttonTryAgain);
            this.panelGameOver.Controls.Add(this.label3);
            this.panelGameOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameOver.Location = new System.Drawing.Point(0, 0);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(340, 338);
            this.panelGameOver.TabIndex = 8;
            // 
            // buttonTryAgain
            // 
            this.buttonTryAgain.Location = new System.Drawing.Point(115, 150);
            this.buttonTryAgain.Name = "buttonTryAgain";
            this.buttonTryAgain.Size = new System.Drawing.Size(104, 35);
            this.buttonTryAgain.TabIndex = 1;
            this.buttonTryAgain.Text = "Try Again";
            this.buttonTryAgain.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 49);
            this.label3.TabIndex = 0;
            this.label3.Text = "Game Over!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.label33);
            this.panelGrid.Controls.Add(this.label32);
            this.panelGrid.Controls.Add(this.label31);
            this.panelGrid.Controls.Add(this.label30);
            this.panelGrid.Controls.Add(this.label23);
            this.panelGrid.Controls.Add(this.label22);
            this.panelGrid.Controls.Add(this.label21);
            this.panelGrid.Controls.Add(this.label20);
            this.panelGrid.Controls.Add(this.label13);
            this.panelGrid.Controls.Add(this.label12);
            this.panelGrid.Controls.Add(this.label11);
            this.panelGrid.Controls.Add(this.label10);
            this.panelGrid.Controls.Add(this.label03);
            this.panelGrid.Controls.Add(this.label02);
            this.panelGrid.Controls.Add(this.label01);
            this.panelGrid.Controls.Add(this.label00);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(340, 338);
            this.panelGrid.TabIndex = 9;
            // 
            // label33
            // 
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label33.Location = new System.Drawing.Point(255, 252);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(75, 75);
            this.label33.TabIndex = 1;
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label32.Location = new System.Drawing.Point(255, 171);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(75, 75);
            this.label32.TabIndex = 1;
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label31.Location = new System.Drawing.Point(255, 90);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(75, 75);
            this.label31.TabIndex = 1;
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label30.Location = new System.Drawing.Point(255, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 75);
            this.label30.TabIndex = 1;
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label23.Location = new System.Drawing.Point(174, 252);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 75);
            this.label23.TabIndex = 1;
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Location = new System.Drawing.Point(174, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 75);
            this.label22.TabIndex = 1;
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Location = new System.Drawing.Point(174, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 75);
            this.label21.TabIndex = 1;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Location = new System.Drawing.Point(174, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 75);
            this.label20.TabIndex = 1;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Location = new System.Drawing.Point(93, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 75);
            this.label13.TabIndex = 1;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(93, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 75);
            this.label12.TabIndex = 1;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(93, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 75);
            this.label11.TabIndex = 1;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(93, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 75);
            this.label10.TabIndex = 1;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label03
            // 
            this.label03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label03.Location = new System.Drawing.Point(12, 252);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(75, 75);
            this.label03.TabIndex = 1;
            this.label03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label02
            // 
            this.label02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label02.Location = new System.Drawing.Point(12, 171);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(75, 75);
            this.label02.TabIndex = 1;
            this.label02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label01
            // 
            this.label01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label01.Location = new System.Drawing.Point(12, 90);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(75, 75);
            this.label01.TabIndex = 1;
            this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label00
            // 
            this.label00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label00.Location = new System.Drawing.Point(12, 9);
            this.label00.Name = "label00";
            this.label00.Size = new System.Drawing.Size(75, 75);
            this.label00.TabIndex = 1;
            this.label00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWin
            // 
            this.panelWin.Controls.Add(this.buttonKeepGoing);
            this.panelWin.Controls.Add(this.buttonTryAgainWin);
            this.panelWin.Controls.Add(this.label6);
            this.panelWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWin.Location = new System.Drawing.Point(0, 0);
            this.panelWin.Name = "panelWin";
            this.panelWin.Size = new System.Drawing.Size(340, 338);
            this.panelWin.TabIndex = 10;
            // 
            // buttonKeepGoing
            // 
            this.buttonKeepGoing.Location = new System.Drawing.Point(22, 150);
            this.buttonKeepGoing.Name = "buttonKeepGoing";
            this.buttonKeepGoing.Size = new System.Drawing.Size(130, 35);
            this.buttonKeepGoing.TabIndex = 2;
            this.buttonKeepGoing.Text = "Keep Going";
            this.buttonKeepGoing.UseVisualStyleBackColor = true;
            this.buttonKeepGoing.Click += new System.EventHandler(this.buttonKeepGoing_Click);
            // 
            // buttonTryAgainWin
            // 
            this.buttonTryAgainWin.Location = new System.Drawing.Point(205, 150);
            this.buttonTryAgainWin.Name = "buttonTryAgainWin";
            this.buttonTryAgainWin.Size = new System.Drawing.Size(104, 35);
            this.buttonTryAgainWin.TabIndex = 1;
            this.buttonTryAgainWin.Text = "Try Again";
            this.buttonTryAgainWin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 49);
            this.label6.TabIndex = 0;
            this.label6.Text = "You Win!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonRestart);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.panelBest);
            this.splitContainer1.Panel1.Controls.Add(this.panelScore);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelGrid);
            this.splitContainer1.Panel2.Controls.Add(this.panelGameOver);
            this.splitContainer1.Panel2.Controls.Add(this.panelWin);
            this.splitContainer1.Size = new System.Drawing.Size(340, 445);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 11;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.ForeColor = System.Drawing.Color.White;
            this.buttonRestart.Location = new System.Drawing.Point(254, 75);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(76, 25);
            this.buttonRestart.TabIndex = 9;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.label7.Location = new System.Drawing.Point(12, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Join the numbers and get to the 2048 tile!";
            // 
            // Form2048
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(340, 445);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 479);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(348, 479);
            this.Name = "Form2048";
            this.ShowIcon = false;
            this.Text = "2048";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2048_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2048_FormClosing);
            this.panelScore.ResumeLayout(false);
            this.panelBest.ResumeLayout(false);
            this.panelGameOver.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.panelWin.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelScore;
        private System.Windows.Forms.Panel panelBest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBestScore;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Button buttonTryAgain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelWin;
        private System.Windows.Forms.Button buttonKeepGoing;
        private System.Windows.Forms.Button buttonTryAgainWin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label label00;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label label01;

    }
}
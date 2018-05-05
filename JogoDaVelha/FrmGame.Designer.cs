namespace JogoDaVelha {
    partial class FrmGame {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlayer1_Wins = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPlayer2_Wins = new System.Windows.Forms.Label();
            this.PanelBoard = new System.Windows.Forms.Panel();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl00 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.LblArrowP1 = new System.Windows.Forms.Label();
            this.LblArrowP2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer1.Location = new System.Drawing.Point(12, 18);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(180, 24);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "x";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblPlayer1_Wins);
            this.panel1.Location = new System.Drawing.Point(198, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 31);
            this.panel1.TabIndex = 5;
            // 
            // lblPlayer1_Wins
            // 
            this.lblPlayer1_Wins.AutoSize = true;
            this.lblPlayer1_Wins.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1_Wins.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer1_Wins.Location = new System.Drawing.Point(6, 5);
            this.lblPlayer1_Wins.Name = "lblPlayer1_Wins";
            this.lblPlayer1_Wins.Size = new System.Drawing.Size(43, 21);
            this.lblPlayer1_Wins.TabIndex = 9;
            this.lblPlayer1_Wins.Text = "100";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer2.Location = new System.Drawing.Point(456, 18);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(180, 24);
            this.lblPlayer2.TabIndex = 6;
            this.lblPlayer2.Text = "y";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(313, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "vs";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.lblPlayer2_Wins);
            this.panel2.Location = new System.Drawing.Point(396, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 31);
            this.panel2.TabIndex = 6;
            // 
            // lblPlayer2_Wins
            // 
            this.lblPlayer2_Wins.AutoSize = true;
            this.lblPlayer2_Wins.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2_Wins.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer2_Wins.Location = new System.Drawing.Point(6, 5);
            this.lblPlayer2_Wins.Name = "lblPlayer2_Wins";
            this.lblPlayer2_Wins.Size = new System.Drawing.Size(43, 21);
            this.lblPlayer2_Wins.TabIndex = 9;
            this.lblPlayer2_Wins.Text = "100";
            // 
            // PanelBoard
            // 
            this.PanelBoard.BackColor = System.Drawing.SystemColors.Control;
            this.PanelBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelBoard.BackgroundImage")));
            this.PanelBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelBoard.Controls.Add(this.lbl21);
            this.PanelBoard.Controls.Add(this.lbl20);
            this.PanelBoard.Controls.Add(this.lbl12);
            this.PanelBoard.Controls.Add(this.lbl10);
            this.PanelBoard.Controls.Add(this.lbl02);
            this.PanelBoard.Controls.Add(this.lbl01);
            this.PanelBoard.Controls.Add(this.lbl22);
            this.PanelBoard.Controls.Add(this.lbl11);
            this.PanelBoard.Controls.Add(this.lbl00);
            this.PanelBoard.Location = new System.Drawing.Point(196, 75);
            this.PanelBoard.Name = "PanelBoard";
            this.PanelBoard.Size = new System.Drawing.Size(256, 256);
            this.PanelBoard.TabIndex = 8;
            // 
            // lbl21
            // 
            this.lbl21.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl21.ForeColor = System.Drawing.Color.Black;
            this.lbl21.Location = new System.Drawing.Point(93, 172);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(67, 70);
            this.lbl21.TabIndex = 17;
            this.lbl21.Click += new System.EventHandler(this.lbl21_Click);
            // 
            // lbl20
            // 
            this.lbl20.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.ForeColor = System.Drawing.Color.Black;
            this.lbl20.Location = new System.Drawing.Point(12, 172);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(67, 70);
            this.lbl20.TabIndex = 16;
            this.lbl20.Click += new System.EventHandler(this.lbl20_Click);
            // 
            // lbl12
            // 
            this.lbl12.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.Black;
            this.lbl12.Location = new System.Drawing.Point(172, 93);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(67, 70);
            this.lbl12.TabIndex = 15;
            this.lbl12.Click += new System.EventHandler(this.lbl12_Click);
            // 
            // lbl10
            // 
            this.lbl10.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.Color.Black;
            this.lbl10.Location = new System.Drawing.Point(12, 93);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(67, 70);
            this.lbl10.TabIndex = 14;
            this.lbl10.Click += new System.EventHandler(this.lbl10_Click);
            // 
            // lbl02
            // 
            this.lbl02.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.ForeColor = System.Drawing.Color.Black;
            this.lbl02.Location = new System.Drawing.Point(172, 12);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(67, 70);
            this.lbl02.TabIndex = 13;
            this.lbl02.Click += new System.EventHandler(this.lbl02_Click);
            // 
            // lbl01
            // 
            this.lbl01.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.ForeColor = System.Drawing.Color.Black;
            this.lbl01.Location = new System.Drawing.Point(93, 12);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(67, 70);
            this.lbl01.TabIndex = 12;
            this.lbl01.Click += new System.EventHandler(this.lbl01_Click);
            // 
            // lbl22
            // 
            this.lbl22.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl22.ForeColor = System.Drawing.Color.Black;
            this.lbl22.Location = new System.Drawing.Point(172, 172);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(67, 70);
            this.lbl22.TabIndex = 11;
            this.lbl22.Click += new System.EventHandler(this.lbl22_Click);
            // 
            // lbl11
            // 
            this.lbl11.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.ForeColor = System.Drawing.Color.Black;
            this.lbl11.Location = new System.Drawing.Point(93, 93);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(67, 70);
            this.lbl11.TabIndex = 11;
            this.lbl11.Click += new System.EventHandler(this.lbl11_Click);
            // 
            // lbl00
            // 
            this.lbl00.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl00.ForeColor = System.Drawing.Color.Black;
            this.lbl00.Location = new System.Drawing.Point(12, 12);
            this.lbl00.Name = "lbl00";
            this.lbl00.Size = new System.Drawing.Size(67, 70);
            this.lbl00.TabIndex = 10;
            this.lbl00.Click += new System.EventHandler(this.lbl00_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(198, 358);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(254, 24);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblArrowP1
            // 
            this.LblArrowP1.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArrowP1.ForeColor = System.Drawing.Color.Black;
            this.LblArrowP1.Location = new System.Drawing.Point(12, 42);
            this.LblArrowP1.Name = "LblArrowP1";
            this.LblArrowP1.Size = new System.Drawing.Size(180, 31);
            this.LblArrowP1.TabIndex = 10;
            this.LblArrowP1.Text = "↑";
            // 
            // LblArrowP2
            // 
            this.LblArrowP2.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArrowP2.ForeColor = System.Drawing.Color.Black;
            this.LblArrowP2.Location = new System.Drawing.Point(456, 42);
            this.LblArrowP2.Name = "LblArrowP2";
            this.LblArrowP2.Size = new System.Drawing.Size(180, 31);
            this.LblArrowP2.TabIndex = 11;
            this.LblArrowP2.Text = "↑";
            this.LblArrowP2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(648, 405);
            this.Controls.Add(this.LblArrowP2);
            this.Controls.Add(this.LblArrowP1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.PanelBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGame_FormClosed);
            this.Shown += new System.EventHandler(this.FrmGame_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPlayer1_Wins;
        private System.Windows.Forms.Label lblPlayer2_Wins;
        private System.Windows.Forms.Panel PanelBoard;
        private System.Windows.Forms.Label lbl00;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lbl22;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label LblArrowP1;
        private System.Windows.Forms.Label LblArrowP2;
    }
}
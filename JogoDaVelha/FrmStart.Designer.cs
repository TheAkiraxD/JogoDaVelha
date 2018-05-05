namespace JogoDaVelha {
    partial class FrmStart {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAgainstIA = new System.Windows.Forms.Label();
            this.lblTwoPlayers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(70, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(413, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Jogo da Velha";
            // 
            // lblAgainstIA
            // 
            this.lblAgainstIA.AutoSize = true;
            this.lblAgainstIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgainstIA.Font = new System.Drawing.Font("Lucida Handwriting", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgainstIA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAgainstIA.Location = new System.Drawing.Point(107, 138);
            this.lblAgainstIA.Name = "lblAgainstIA";
            this.lblAgainstIA.Size = new System.Drawing.Size(317, 40);
            this.lblAgainstIA.TabIndex = 1;
            this.lblAgainstIA.Text = "• Jogar contra IA";
            this.lblAgainstIA.Click += new System.EventHandler(this.lblAgainstIA_Click);
            this.lblAgainstIA.MouseEnter += new System.EventHandler(this.lblAgainstIA_MouseEnter);
            this.lblAgainstIA.MouseLeave += new System.EventHandler(this.lblAgainstIA_MouseLeave);
            // 
            // lblTwoPlayers
            // 
            this.lblTwoPlayers.AutoSize = true;
            this.lblTwoPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTwoPlayers.Font = new System.Drawing.Font("Lucida Handwriting", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoPlayers.ForeColor = System.Drawing.Color.Purple;
            this.lblTwoPlayers.Location = new System.Drawing.Point(107, 200);
            this.lblTwoPlayers.Name = "lblTwoPlayers";
            this.lblTwoPlayers.Size = new System.Drawing.Size(294, 40);
            this.lblTwoPlayers.TabIndex = 2;
            this.lblTwoPlayers.Text = "• Dois jogadores";
            this.lblTwoPlayers.Click += new System.EventHandler(this.lblTwoPlayers_Click);
            this.lblTwoPlayers.MouseEnter += new System.EventHandler(this.lblTwoPlayers_MouseEnter);
            this.lblTwoPlayers.MouseLeave += new System.EventHandler(this.lblTwoPlayers_MouseLeave);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(540, 339);
            this.Controls.Add(this.lblTwoPlayers);
            this.Controls.Add(this.lblAgainstIA);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmStart";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStart_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAgainstIA;
        private System.Windows.Forms.Label lblTwoPlayers;
    }
}


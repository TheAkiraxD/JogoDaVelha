using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha {
    public partial class FrmStart : Form {
        int GameModes;

        public FrmStart() {
            InitializeComponent();
        }

        private void lblAgainstIA_MouseEnter(object sender, EventArgs e) {
            lblAgainstIA.ForeColor = Color.FromArgb(34, 34, 216);
            lblAgainstIA.Font = new Font(lblAgainstIA.Font.Name, 23);
        }

        private void lblAgainstIA_MouseLeave(object sender, EventArgs e) {
            lblAgainstIA.ForeColor = Color.FromArgb(25, 25, 112);
            lblAgainstIA.Font = new Font(lblAgainstIA.Font.Name, 22);
        }

        private void lblTwoPlayers_MouseEnter(object sender, EventArgs e) {
            lblTwoPlayers.ForeColor = Color.FromArgb(210, 38, 210);
            lblTwoPlayers.Font = new Font(lblTwoPlayers.Font.Name, 23);
        }

        private void lblTwoPlayers_MouseLeave(object sender, EventArgs e) {
            lblTwoPlayers.ForeColor = Color.FromArgb(128, 0, 128);
            lblTwoPlayers.Font = new Font(lblTwoPlayers.Font.Name, 22);
        }

        private void lblAgainstIA_Click(object sender, EventArgs e) {
            GameModes = 1;
            new FrmSelect1().Show();
            Hide();
        }

        private void lblTwoPlayers_Click(object sender, EventArgs e) {
            GameModes = 2;
            new FrmSelect2().Show();
            Hide();
        }

        private void FrmStart_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha {
    public partial class FrmSelect1 : Form {

        public FrmSelect1() {
            InitializeComponent();
        }

        string Player1Name;
        char Player1Mark;

        private void lblMarkPlayer1_Click(object sender, EventArgs e) {
            if (lblMarkPlayer1.Text == "X") {
                lblMarkPlayer1.Text = "O";
                lblMarkPlayer1.ForeColor = Color.Purple;
                TBoxPlayer1.ForeColor = Color.Purple;
            } else {
                lblMarkPlayer1.Text = "X";
                lblMarkPlayer1.ForeColor = Color.DarkBlue;
                TBoxPlayer1.ForeColor = Color.DarkBlue;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            new FrmStart().Show();
            Close();
        }

        private void BtnStart_Click(object sender, EventArgs e) {
            if (TBoxPlayer1.Text != "") {
                Player1Name = TBoxPlayer1.Text;
                Player1Mark = lblMarkPlayer1.Text[0];

                FrmGame frm = new FrmGame();
                frm.ApplyGameMode(1);
                frm.Player1Info(Player1Name, Player1Mark);
                frm.Show();
                Hide();
            }
        }

        private void FrmSelect1_FormClosed(object sender, FormClosedEventArgs e) {
            new FrmStart().Show();
        }
    }
}

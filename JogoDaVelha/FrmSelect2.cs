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
    public partial class FrmSelect2 : Form {
        public FrmSelect2() {
            InitializeComponent();
        }

        string Player1Name;
        char Player1Mark;

        string Player2Name;
        char Player2Mark;

        private void lblMarkPlayer1_Click(object sender, EventArgs e) {
            string LBL1text = lblMarkPlayer1.Text;
            string LBL2text = lblMarkPlayer2.Text;
            Color LBL1Color = TBoxPlayer1.ForeColor;
            Color LBL2Color = TBoxPlayer2.ForeColor;

            lblMarkPlayer1.Text = LBL2text;
            lblMarkPlayer1.ForeColor = LBL2Color;
            TBoxPlayer1.ForeColor = LBL2Color;

            lblMarkPlayer2.Text = LBL1text;
            lblMarkPlayer2.ForeColor = LBL1Color;
            TBoxPlayer2.ForeColor = LBL1Color;

        }

        private void BtnBack_Click(object sender, EventArgs e) {
            new FrmStart().Show();
            Close();
        }

        private void BtnStart_Click(object sender, EventArgs e) {
            if (TBoxPlayer1.Text != "" && TBoxPlayer2.Text != "") {
                Player1Name = TBoxPlayer1.Text;
                Player1Mark = lblMarkPlayer1.Text[0];
                Player2Name = TBoxPlayer2.Text;
                Player2Mark = lblMarkPlayer2.Text[0];

                FrmGame frm = new FrmGame();
                frm.ApplyGameMode(2);
                frm.Player1Info(Player1Name, Player1Mark);
                frm.Player2Info(Player2Name, Player2Mark);
                frm.Show();
                Hide();
            }
        }

        private void FrmSelect2_FormClosed(object sender, FormClosedEventArgs e) {
            new FrmStart().Show();
        }

        private void lblMarkPlayer2_Click(object sender, EventArgs e) {
            string LBL1text = lblMarkPlayer1.Text;
            string LBL2text = lblMarkPlayer2.Text;
            Color LBL1Color = TBoxPlayer1.ForeColor;
            Color LBL2Color = TBoxPlayer2.ForeColor;

            lblMarkPlayer1.Text = LBL2text;
            lblMarkPlayer1.ForeColor = LBL2Color;
            TBoxPlayer1.ForeColor = LBL2Color;

            lblMarkPlayer2.Text = LBL1text;
            lblMarkPlayer2.ForeColor = LBL1Color;
            TBoxPlayer2.ForeColor = LBL1Color;
        }
    }
}

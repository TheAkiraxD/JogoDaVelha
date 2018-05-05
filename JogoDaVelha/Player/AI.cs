using JogoDaVelha_Board;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JogoDaVelha {
    class AI : Player{

        public AI(char Mark) {
            this.Mark = Mark;
            SetName();
        }

        public Position Play(Board board) {
            Random rnd = new Random();
            int Row = rnd.Next(board.Rows);
            int Col = rnd.Next(board.Cols);
            return new Position(Row, Col);
        }

        public void SetName() {
            int x = 0;
            string[] AllTheNames = Enum.GetNames(typeof(Names));
            foreach (string n in AllTheNames) {
                x++;
            }
            Random rnd = new Random();
            int IntName = rnd.Next(x);

            Names z = (Names)IntName;
            Name = z.ToString();
        }

        public override void Won() {
            Games++;
            Wins++;
        }

        public override void Lost() {
            Games++;
        }

        public override Color GetPlayerColor() {
            if (Mark == 'X') {
                return Color.DarkBlue;
            } else {
                return Color.Purple;
            }
        }
    }
}

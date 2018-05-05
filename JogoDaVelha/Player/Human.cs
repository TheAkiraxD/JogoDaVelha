using JogoDaVelha_Board;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha {
    class Human : Player{

        public Human(string Name, char Mark) {
            this.Name = Name;
            this.Mark = Mark;
        }

        public Position Play(Label label, Board board) {
            for(int x = 0; x < board.Rows; x++) {
                for(int y = 0; y < board.Cols; y++) {
                    if(label == board.LabelsPosition[x, y]) {
                        return new Position(x,y);
                    }
                }
            }
            return null;


        }

        public void SetName(string Name) {
            this.Name = Name;
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

using JogoDaVelha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha_Board {
    class Board {
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public Label[,] LabelsPosition { get; set; }
        public char[,] MarksPosition { get; set; }

        public Board(int Rows, int Cols, List<Label> Labels) {
            this.Rows = Rows;
            this.Cols = Cols;
            LabelsPosition = new Label[Rows, Cols];
            MarksPosition = new char[Rows, Cols];

            //Erro - Linhas e colunas podem não estar de acordo com a lista passada.
            int z = 0;

            for(int x = 0; x < Rows; x++) {
                for (int y = 0; y < Cols; y++) {
                    LabelsPosition[x, y] = Labels[z];
                    z++;
                }
            }
        }

        public void Mark(Player CurrentPlayer, Label label) {
            for (int x = 0; x < Rows; x++) {
                for (int y = 0; y < Cols; y++) {
                    if(LabelsPosition[x,y] == label) {
                        Position p = new Position(x, y);
                        if (isFreePosition(p)) {
                            MarksPosition[x, y] = CurrentPlayer.Mark;
                            LabelsPosition[x, y].ForeColor = CurrentPlayer.GetPlayerColor();
                            break;
                        }
                    }
                }
            }
            //Erro - label n encontrado
        }

        public void Mark(Player CurrentPlayer, Position p) {
            if (isFreePosition(p)) {
                MarksPosition[p.Row, p.Col] = CurrentPlayer.Mark;
                LabelsPosition[p.Row, p.Col].ForeColor = CurrentPlayer.GetPlayerColor();
            }
            //Erro - position n encontrado
        }

        public void Reset() {
            for(int x = 0; x < Rows; x++) {
                for(int y = 0; y < Cols; y++) {
                    MarksPosition[x, y] = '\0';
                }
            }
        }

        public bool isFreePosition(Position p) {
            //Erro - Posição passada pode não existir
            return MarksPosition[p.Row, p.Col] != '\0' ? false : true;
        }

    }
}

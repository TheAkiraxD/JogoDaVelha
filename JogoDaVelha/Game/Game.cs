using JogoDaVelha;
using JogoDaVelha_Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha_Game {
    class Game {
        public bool Finished { get; set; }
        public Player[] Players { get; set; }
        public Player CurrentPlayer { get; set; }
        public Board board { get; set; }
        private FrmGame Frm;

        public Game(Player Player1, Player Player2, Board board, FrmGame Frm) {
            Finished = false;
            Players = new Player[2];
            Players[0] = Player1;
            Players[1] = Player2;
            this.board = board;
            this.Frm = Frm;
        }

        public void ChangeCurrentPlayer() {
            CurrentPlayer = CurrentPlayer == Players[0] ? Players[1] : Players[0];
        }

        public void Start() {
            CurrentPlayer = GetCurrentPlayer(Players[0], Players[1]);
            Finished = false;
        }

        public void Reset() {
            board.Reset();
            Screen.ResetBoard(this, Frm);
        }

        public void EndMatch() {
            if (isFinished()) {
                CurrentPlayer.Won();
                Screen.Winner(MatchWinner(), CurrentPlayer, this, Frm);

                if(CurrentPlayer == Players[0]) {
                    Players[1].Lost();
                } else {
                    Players[0].Lost();
                }
            } else if(isDraw()) {
                Players[0].Lost();
                Players[1].Lost();

                Screen.Draw(this, Frm);
            }
            Finished = true;
        }

        public bool isDraw() {
            for (int x = 0; x < board.Rows; x++) {
                for (int y = 0; y < board.Cols; y++) {
                    if (board.MarksPosition[x, y] == '\0') {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool isFinished() {
            return MatchWinner() == "" ? false : true;
        }

        public void LoadReadings() {
            Screen.LoadHeadings(this, Frm);
        }

        public void UpdateBoard() {
            Screen.UpdateBoard(this, Frm);
        }

        public void UpdateScore() {
            Screen.UpdateScore(this, Frm);
        }

        private string MatchWinner() {
            char[] Horizontal = new char[3];
            char[] Vertical = new char[3];
            char[] Diag1 = new char[3];
            char[] Diag2 = new char[3];

            int x = 0;
            int y = 0;

            for (x = 0; x < board.Rows; x++) {
                for (y = 0; y < board.Cols; y++) {
                    Horizontal[y] = board.MarksPosition[x, y];
                    Vertical[y] = board.MarksPosition[y, x];

                    if (x == y) {
                        Diag1[x] = board.MarksPosition[x, y];
                    }

                    if (y == (board.Cols - 1 - x)) {
                        Diag2[x] = board.MarksPosition[x, y];
                    }
                }

                if (VerifyWinnerArray(Horizontal)) {
                    return ("Horizontal" + (x + 1));
                }
                if (VerifyWinnerArray(Vertical)) {
                    return ("Vertical" + (x + 1));
                }
            }

            if (VerifyWinnerArray(Diag1)) {
                return "Diagonal1";
            }
            if (VerifyWinnerArray(Diag2)) {
                return "Diagonal2";
            }


            return "";
        }
        private Player GetCurrentPlayer(Player p1, Player p2) {
            return p1.Mark == 'X' ? p1 : p2;
        }
        private bool VerifyWinnerArray(char[] array) {
            char x = '\0';
            foreach (char z in array) {
                if (z == '\0') {
                    return false;
                }
                if (x == '\0') {
                    x = z;
                } else if (x != z) {
                    return false;
                }
            }
            return true;
        }

    }
}
    
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoDaVelha;

namespace JogoDaVelha_Game {
    static class Screen {

        public static void LoadHeadings(Game game, FrmGame Frm) {
            Player p1 = game.Players[0];
            Player p2 = game.Players[1];

            string NameP1 = p1.Name;
            Color ColorP1 = p1.GetPlayerColor();

            string NameP2 = p2.Name;
            Color ColorP2 = p2.GetPlayerColor();

            Frm.LblPlayer1_update(NameP1, ColorP1);
            Frm.LblPlayer2_update(NameP2, ColorP2);
            Frm.LblPlayer1Wins_updateText(p1.Wins);
            Frm.LblPlayer2Wins_updateText(p2.Wins);
            Frm.LblPlayer1Wins_updateColor(ColorP1);
            Frm.LblPlayer2Wins_updateColor(ColorP2);

            Frm.LblMessage_update("", Color.Black);
            Frm.LblMessage_hide();
        }

        public static void UpdateScore(Game game, FrmGame Frm) {
            Player p1 = game.Players[0];
            Player p2 = game.Players[1];

            Color ColorP1 = p1.GetPlayerColor();
            Color ColorP2 = p2.GetPlayerColor();

            Frm.LblPlayer1Wins_updateColor(ColorP1);
            Frm.LblPlayer1Wins_updateText(p1.Wins);
            Frm.LblPlayer2Wins_updateColor(ColorP2);
            Frm.LblPlayer2Wins_updateText(p2.Wins);
        }

        public static void UpdateBoard(Game game, FrmGame Frm) {
            for (int x = 0; x < game.board.Rows; x++) {
                for (int y = 0; y < game.board.Cols; y++) {
                    if (game.board.MarksPosition[x, y] != '\0') {
                        game.board.LabelsPosition[x, y].Text = game.board.MarksPosition[x, y].ToString();
                    } else {
                        game.board.LabelsPosition[x, y].Text = "";
                        game.board.LabelsPosition[x, y].ForeColor = Color.Black;
                    }
                }
            }
            Frm.LblArrowP1_update(game.Players[0].GetPlayerColor());
            Frm.LblArrowP2_update(game.Players[1].GetPlayerColor());

            if (game.CurrentPlayer == game.Players[0]) {
                Frm.LblArrowP1_show();
                Frm.LblArrowP2_hide();
            } else {
                Frm.LblArrowP2_show();
                Frm.LblArrowP1_hide();
            }

        }

        public static void ResetBoard(Game game, FrmGame Frm) {
            for(int x = 0; x < game.board.Rows; x++) {
                for (int y = 0; y < game.board.Cols; y++) {
                    game.board.LabelsPosition[x, y].ForeColor = Color.Black;
                    game.board.LabelsPosition[x, y].Font = new Font(game.board.LabelsPosition[x, y].Font, FontStyle.Regular);
                }
            }
            Frm.LblArrowP1_hide();
            Frm.LblArrowP2_hide();
            Frm.LblMessage_hide();
        }

        public static void Winner(string GameWinnerPosition, Player player, Game game, FrmGame Frm) {

            switch (GameWinnerPosition) {
                case "Horizontal1":
                    HorizontalBold(0, game);
                    break;
                case "Horizontal2":
                    HorizontalBold(1, game);
                    break;
                case "Horizontal3":
                    HorizontalBold(2, game);
                    break;
                case "Vertical1":
                    VerticalBold(0, game);
                    break;
                case "Vertical2":
                    VerticalBold(1, game);
                    break;
                case "Vertical3":
                    VerticalBold(2, game);
                    break;
                case "Diagonal1":
                    Diagonal1Bold(game);
                    break;
                case "Diagonal2":
                    Diagonal2Bold(game);
                    break;
            }

            string message = player.Mark.ToString() + " é o vencedor";
            Frm.LblMessage_update(message, player.GetPlayerColor());
            Frm.LblMessage_show();

            Frm.LblArrowP1_hide();
            Frm.LblArrowP2_hide();
        }

        public static void Draw(Game game, FrmGame Frm) {
            string message = "Empate!";
            Frm.LblMessage_update(message, Color.Black);
            Frm.LblMessage_show();
            Frm.LblArrowP1_hide();
            Frm.LblArrowP2_hide();

        }

        private static void HorizontalBold(int z, Game game) {
            for (int x = 0; x < game.board.Rows; x++) {
                for (int y = 0; y < game.board.Cols; y++) {
                    if (x == z) {
                        game.board.LabelsPosition[x, y].Font = new Font(game.board.LabelsPosition[x, y].Font, FontStyle.Bold);
                    }
                }
            }
        }

        private static void VerticalBold(int z, Game game) {
            for (int x = 0; x < game.board.Rows; x++) {
                for (int y = 0; y < game.board.Cols; y++) {
                    if (y == z) {
                        game.board.LabelsPosition[x, y].Font = new Font(game.board.LabelsPosition[x, y].Font, FontStyle.Bold);
                    }
                }
            }
        }

        private static void Diagonal1Bold(Game game) {
            for (int x = 0; x < game.board.Rows; x++) {
                for (int y = 0; y < game.board.Cols; y++) {
                    if (x == y) {
                        game.board.LabelsPosition[x, y].Font = new Font(game.board.LabelsPosition[x, y].Font, FontStyle.Bold);
                    }
                }
            }
        }

        private static void Diagonal2Bold(Game game) {
            for (int x = 0; x < game.board.Rows; x++) {
                for (int y = 0; y < game.board.Cols; y++) {
                    if (y == (game.board.Cols - 1 - x)) {
                        game.board.LabelsPosition[x, y].Font = new Font(game.board.LabelsPosition[x, y].Font, FontStyle.Bold);
                    }
                }
            }
        }

    }
}

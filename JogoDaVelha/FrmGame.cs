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
using JogoDaVelha;
using JogoDaVelha_Board;
using JogoDaVelha_Game;

namespace JogoDaVelha {
    public partial class FrmGame : Form {
        int GameMode;
        string Player1Name;
        string Player2Name;
        char Player1Mark;
        char Player2Mark;


        private static ManualResetEvent _continue = new ManualResetEvent(false);

        bool AITurn = false;
        Label clicked = null;

        bool Ended = false;
        bool MatchEnded = false;

        public void ApplyGameMode(int x) {
            GameMode = x;
        }

        public void ChangeClicked(Label clicked) {
            this.clicked = clicked;
        }

        public void Player1Info(string Name, char Mark) {
            Player1Name = Name;
            Player1Mark = Mark;

            if (Player1Mark == 'X') {
                Player2Mark = 'O';
            } else {
                Player2Mark = 'X';
            }
        }
        public void Player2Info(string Name, char Mark) {
            Player2Name = Name;
            Player2Mark = Mark;
        }

        public void LblPlayer1_update(string text, Color color) {
            lblPlayer1.Text = text;
            lblPlayer1.ForeColor = color;
        }
        public void LblPlayer2_update(string text, Color color) {
            lblPlayer2.Text = text;
            lblPlayer2.ForeColor = color;
        }
        public void LblPlayer1Wins_updateText(int Wins) {
            lblPlayer1_Wins.Text = Wins.ToString();
        }
        public void LblPlayer2Wins_updateText(int Wins) {
            lblPlayer2_Wins.Text = Wins.ToString();
        }
        public void LblPlayer1Wins_updateColor(Color color) {
            lblPlayer1_Wins.ForeColor = color;
        }
        public void LblPlayer2Wins_updateColor(Color color) {
            lblPlayer2_Wins.ForeColor = color;
        }
        public void LblMessage_update(string text, Color color) {
            lblMessage.Text = text;
            lblMessage.ForeColor = color;
        }
        public void LblArrowP1_update(Color color) {
            LblArrowP1.ForeColor = color;
        }
        public void LblArrowP2_update(Color color) {
            LblArrowP2.ForeColor = color;
        }
        public void LblMessage_hide() {
            lblMessage.Hide();
        }
        public void LblMessage_show() {
            lblMessage.Show();
        }
        public void LblArrowP1_hide() {
            LblArrowP1.Hide();
        }
        public void LblArrowP2_hide() {
            LblArrowP2.Hide();
        }
        public void LblArrowP1_show() {
            LblArrowP1.Show();
        }
        public void LblArrowP2_show() {
            LblArrowP2.Show();
        }

        public FrmGame() {
            InitializeComponent();
        }

        private void FrmGame_Shown(object sender, EventArgs e) {
            List<Label> Labels = new List<Label>();

            Labels.Add(lbl00);
            Labels.Add(lbl01);
            Labels.Add(lbl02);
            Labels.Add(lbl10);
            Labels.Add(lbl11);
            Labels.Add(lbl12);
            Labels.Add(lbl20);
            Labels.Add(lbl21);
            Labels.Add(lbl22);

            if (GameMode == 1) {
                Board board = new Board(3, 3, Labels);
                Human player1 = new Human(Player1Name, Player1Mark);
                AI player2 = new AI(Player2Mark);
                Game game = new Game(player1, player2, board, this);

                game.LoadReadings();
                game.UpdateBoard();
                game.Start();
                game.UpdateBoard();

                RunGameMode1(game, player1, player2); 

            } else {
                Board board = new Board(3, 3, Labels);
                Human player1 = new Human(Player1Name, Player1Mark);
                Human player2 = new Human(Player2Name, Player2Mark);
                Game game = new Game(player1, player2, board, this);

                game.LoadReadings();
                game.UpdateBoard();
                game.Start();
                game.UpdateBoard();

                RunGameMode2(game, player1, player2);
            }
        }

        private void RunGameMode2(Game game, Human player1, Human player2) {
            object _lock = new object();
            Task t = Task.Run(() => {
                while (!Ended) {
                    if (!game.Finished) {
                        while (true) {

                            _continue.WaitOne();
                            _continue.Reset();

                            while (clicked == null) {
                                _continue.Reset();
                                _continue.WaitOne();
                            }
                            Human CPlayer = (Human)game.CurrentPlayer;
                            Position Human_Play = CPlayer.Play(clicked, game.board);

                            if (game.board.isFreePosition(Human_Play)) {
                                game.board.Mark(game.CurrentPlayer, Human_Play);
                                lock (_lock) {
                                    Invoke(new Action(() => {
                                        game.UpdateBoard();
                                    }));
                                }
                                _continue.Reset();
                                break;
                            }
                        }

                        clicked = null;

                        if (!game.isFinished() && !game.isDraw()) {
                            game.ChangeCurrentPlayer();
                            lock (_lock) {
                                Invoke(new Action(() => {
                                    game.UpdateBoard();
                                }));
                            }
                        } else {
                            lock (_lock) {
                                Invoke(new Action(() => {
                                    game.EndMatch();
                                }));
                            }
                        }
                    } else {
                        MatchEnded = true;
                        _continue.Reset();
                        _continue.WaitOne();
                        MatchEnded = false; ;
                        lock (_lock) {
                            Invoke(new Action(() => {
                                game.Reset();
                                game.UpdateScore();
                                game.UpdateBoard();
                                game.Start();
                                game.UpdateBoard();
                            }));
                        }

                        _continue.Reset();
                    }
                }
            });
        }

        private void RunGameMode1(Game game, Human player1, AI player2) {
            object _lock = new object();
            Task t = Task.Run(() => {
                while (!Ended) {
                    if (!game.Finished) {
                        if (game.CurrentPlayer.GetType().Name == "AI") {
                            AITurn = true;
                            Position AI_Play = player2.Play(game.board);

                            while (!game.board.isFreePosition(AI_Play)) {
                                AI_Play = player2.Play(game.board);
                            }

                            Thread.Sleep(1000);

                            lock (_lock) {
                                Invoke(new Action(() => {
                                    game.board.Mark(game.CurrentPlayer, AI_Play);
                                    game.UpdateBoard();
                                }));
                            }

                            AITurn = false;

                            if (!game.isFinished() && !game.isDraw()) {
                                game.ChangeCurrentPlayer();
                                lock (_lock) {
                                    Invoke(new Action(() => {
                                        game.UpdateBoard();
                                    }));
                                }
                            } else {
                                lock (_lock) {
                                    Invoke(new Action(() => {
                                        game.EndMatch();
                                    }));
                                }
                            }
                        } else {
                            while (true) {

                                _continue.WaitOne();
                                _continue.Reset();
                                while (clicked == null) {
                                    _continue.Reset();
                                    _continue.WaitOne();
                                }

                                Position Human_Play = player1.Play(clicked, game.board);

                                if (game.board.isFreePosition(Human_Play)) {
                                    game.board.Mark(game.CurrentPlayer, Human_Play);
                                    lock (_lock) {
                                        Invoke(new Action(() => {
                                            game.UpdateBoard();
                                        }));
                                    }
                                    _continue.Reset();
                                    break;
                                }
                            }

                            clicked = null;

                            if (!game.isFinished() && !game.isDraw()) {
                                game.ChangeCurrentPlayer();
                                lock (_lock) {
                                    Invoke(new Action(() => {
                                        game.UpdateBoard();
                                    }));
                                }
                            } else {
                                lock (_lock) {
                                    Invoke(new Action(() => {
                                        game.EndMatch();
                                    }));
                                }
                            }
                        }
                    } else {
                        MatchEnded = true;
                        _continue.Reset();
                        _continue.WaitOne();
                        MatchEnded = false; ;
                        lock (_lock) {
                            Invoke(new Action(() => {
                                game.Reset();
                                game.UpdateScore();
                                game.UpdateBoard();
                                game.Start();
                                game.UpdateBoard();
                            }));
                        }
                        
                        _continue.Reset();
                    }
                }
            });

        }

        private void lbl00_Click(object sender, EventArgs e) {

            if (!MatchEnded) {
                if (!AITurn) {
                    clicked = lbl00;
                    _continue.Set();
                }
            } else {
                clicked = null;
                _continue.Set();
            }

        }

        private void lbl01_Click(object sender, EventArgs e) {
            if (!MatchEnded) {
                if (!AITurn) {
                    clicked = lbl01;
                    _continue.Set();
                }
            } else {
                clicked = null;
                _continue.Set();
            }
        }

        private void lbl02_Click(object sender, EventArgs e) {
            if (!MatchEnded) {
                if (!AITurn) {
                    clicked = lbl02;
                    _continue.Set();
                }
            } else {
                clicked = null;
                _continue.Set();
            }
        }

        private void lbl10_Click(object sender, EventArgs e) {
            if (!MatchEnded) {
                if (!AITurn) {
                    clicked = lbl10;
                    _continue.Set();
                }
            } else {
                clicked = null;
                _continue.Set();
            }
        }

        private void lbl11_Click(object sender, EventArgs e) {
            if (!MatchEnded) {
                if (!AITurn) {
                    clicked = lbl11;
                    _continue.Set();
                }
            } else {
                clicked = null;
                _continue.Set();
            }
        }

        private void lbl12_Click(object sender, EventArgs e) {
            if (!MatchEnded) {
                if (!AITurn) {
                    clicked = lbl12;
                    _continue.Set();
                }
            } else {
                clicked = null;
                _continue.Set();
            }
        }

        private void lbl20_Click(object sender, EventArgs e) {
            if (!MatchEnded) {
                if (!AITurn) {
                    clicked = lbl20;
                    _continue.Set();
                }
            } else {
                clicked = null;
                _continue.Set();
            }
        }

        private void lbl21_Click(object sender, EventArgs e) {
            if (!MatchEnded) {
                if (!AITurn) {
                    clicked = lbl21;
                    _continue.Set();
                }
            } else {
                clicked = null;
                _continue.Set();
            }
        }

        private void lbl22_Click(object sender, EventArgs e) {
            if (!MatchEnded) {
                if (!AITurn) {
                    clicked = lbl22;
                    _continue.Set();
                }
            } else {
                clicked = null;
                _continue.Set();
            }
        }

        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}

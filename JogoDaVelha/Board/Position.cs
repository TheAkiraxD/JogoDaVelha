using System;

namespace JogoDaVelha {
    class Position {
        public int Row { get; set; }
        public int Col { get; set; }

        public Position(int Row, int Col) {
            this.Row = Row;
            this.Col = Col;
        }
    }
}

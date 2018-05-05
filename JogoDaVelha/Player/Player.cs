using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha {
    public abstract class Player {
        public string Name;
        public int Wins;
        public int Games;
        public char Mark;

        public abstract void Won();
        public abstract void Lost();
        public abstract Color GetPlayerColor();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    class Knight : IPiece {
        public int Color { get; set; }
        public char Symbol { get; set; }
        public bool IsCaptured { get; set; }
        public int APos { get; set; }
        public int BPos { get; set; }

        public Knight(int theColor, int theAPos, int theBPos) {
            APos = theAPos;
            BPos = theBPos;
            Color = theColor;
            IsCaptured = false;
            Symbol = 'N';
        }

        public bool Move(int toAPos, int toBPos, Board theBoard) {

            return true;
        }
    }
}

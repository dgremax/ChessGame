using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    class King : IPiece {
        public int Color { get; set; }
        public string Symbol { get; set; }
        public bool HasMoved;

        public King(int theColor) {
            Color = theColor;
            Symbol = theColor == 0 ? "BK" : "WK";
            HasMoved = false;
        }

        public bool Move(int fromAPos, int fromBPos, int toAPos, int toBPos, Board theBoard) {

            return true;
        }
    }
}

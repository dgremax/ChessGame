using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    class Bishop : IPiece {
        public int Color { get; set; }
        public string Symbol { get; set; }

        public Bishop(int theColor) {
            Color = theColor;
            Symbol = theColor == 0 ? "BB" : "WB";
        }

        public bool Move(int fromAPos, int fromBPos, int toAPos, int toBPos, Board theBoard) {

            return true;
        }
    }
}

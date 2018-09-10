using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    class Bishop : IPiece {
        public int Color { get; set; }
        public char Symbol { get; set; }

        public Bishop(int theColor) {
            Color = theColor;
            Symbol = 'B';
        }

        public bool Move(int fromAPos, int fromBPos, int toAPos, int toBPos, Board theBoard) {

            return true;
        }
    }
}

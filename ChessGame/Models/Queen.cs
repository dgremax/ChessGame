using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    class Queen : IPiece {
        public int Color { get; set; }
        public char Symbol { get; set; }

        public Queen(int theColor) {
            Color = theColor;
            Symbol = 'Q';
        }

        public bool Move(int fromAPos, int fromBPos, int toAPos, int toBPos, Board theBoard) {

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    class Knight : IPiece {
        public int Color { get; set; }
        public char Symbol { get; set; }

        public Knight(int theColor) {
            Color = theColor;
            Symbol = 'N';
        }

        public bool Move(int fromAPos, int fromBPos, int toAPos, int toBPos, Board theBoard) {
            // | toAPos - APos | + | toBPos - BPos | == 3
            if (Math.Abs(toAPos - fromAPos) + Math.Abs(toBPos - fromBPos) == 3) {
                // Valid move
                if (theBoard.TheBoard[toAPos, toBPos] == null) {              
                    theBoard.TheBoard[fromAPos, fromBPos] = null;

                    // Move piece to this spot
                    theBoard.TheBoard[toAPos, toBPos] = this;

                    return true;
                }
                else if (theBoard.TheBoard[toAPos, toBPos].Color != Color) {                  
                    theBoard.TheBoard[fromAPos, fromBPos] = null;

                    // Landed on enemy piece; capture the piece
                    theBoard.TheBoard[toAPos, toBPos] = this;

                    return true;
                }
                else {
                    // Landed on a friendly piece
                    return false;
                }
            }
            else {
                return false;
            }
        }
    }
}

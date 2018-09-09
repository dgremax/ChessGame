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
            // | toAPos - APos | + | toBPos - BPos | == 3
            if (Math.Abs(toAPos - APos) + Math.Abs(toBPos - BPos) == 3) {
                // Valid move
                if (theBoard.TheBoard[toAPos, toBPos] == null) {
                    // Move piece to this spot
                    //Console.WriteLine("Moved to an empty space.");
                    theBoard.TheBoard[this.APos, this.BPos] = null;

                    // Remove APos and BPos fields?
                    this.APos = toAPos;
                    this.BPos = toBPos;

                    theBoard.TheBoard[toAPos, toBPos] = this;
                    return true;
                }
                else if (theBoard.TheBoard[toAPos, toBPos].Color != Color) {
                    // Landed on enemy piece; capture the piece
                    //Console.WriteLine("Captured an enemy piece.");
                    theBoard.TheBoard[this.APos, this.BPos] = null;

                    // Remove APos and BPos fields?
                    this.APos = toAPos;
                    this.BPos = toBPos;

                    theBoard.TheBoard[toAPos, toBPos] = this;
                    return true;
                }
                else {
                    // Landed on a friendly piece
                    //Console.WriteLine("Landed on a friendly piece.");
                    return false;
                }
            }
            else {
                Console.WriteLine("Math.Abs(" + toAPos + " - " + APos + ") + Math.Abs(" + toBPos + " - " + BPos + ") = " + Math.Abs(toAPos - APos) + Math.Abs(toBPos - BPos));
                return false;
            }
        }
    }
}

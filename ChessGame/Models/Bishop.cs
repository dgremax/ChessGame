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

            Console.WriteLine("this.Color: " + this.Color);
            if(theBoard.TheBoard[toAPos, toBPos] != null)
                Console.WriteLine("theBoard.TheBoard[toAPos,toBPos].Color: " + theBoard.TheBoard[toAPos, toBPos].Color);

            if (toAPos > fromAPos) {
                if (toBPos > fromBPos) {
                    for(int i = fromAPos + 1; i < toAPos + 1; i++) {
                        for (int j = fromBPos + 1; j < toBPos + 1; j++) {
                            if(theBoard.TheBoard[i,j] != null) {
                                if (i == toAPos && j == toBPos && this.Color == theBoard.TheBoard[i, j].Color
                                    || i != toAPos && j != toBPos) {
                                    return false;
                                }
                            }
                        }
                    }
                }
                else {
                    // toBPos < fromBPos
                    for (int i = fromAPos + 1; i < toAPos + 1; i++) {
                        for (int j = fromBPos - 1; j > toBPos - 1; j--) {
                            if (theBoard.TheBoard[i, j] != null) {
                                if (i == toAPos && j == toBPos && this.Color == theBoard.TheBoard[i, j].Color
                                    || i != toAPos && j != toBPos) {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            else {
                // toAPos < fromAPos
                if (toBPos > fromBPos) {
                    for (int i = fromAPos - 1; i > toAPos - 1; i--) {
                        for (int j = fromBPos + 1; j < toBPos + 1; j++) {
                            if (theBoard.TheBoard[i, j] != null) {
                                if (i == toAPos && j == toBPos && this.Color == theBoard.TheBoard[i, j].Color
                                    || i != toAPos && j != toBPos) {
                                    return false;
                                }
                            }
                        }
                    }
                }
                else {
                    // toBPos < fromBPos
                    for (int i = fromAPos - 1; i > toAPos - 1; i--) {
                        for (int j = fromBPos - 1; j > toBPos - 1; j--) {
                            if (theBoard.TheBoard[i, j] != null) {
                                if (i == toAPos && j == toBPos && this.Color == theBoard.TheBoard[i, j].Color
                                    || i != toAPos && j != toBPos) {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }

            theBoard.TheBoard[fromAPos, fromBPos] = null;

            // Landed on enemy piece; capture the piece
            theBoard.TheBoard[toAPos, toBPos] = this;

            return true;
        }
    }
}

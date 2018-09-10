using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    class Rook : IPiece {
        public int Color { get; set; }
        public char Symbol { get; set; }

        public Rook(int theColor) {
            Color = theColor;
            Symbol = 'R';
        }

        public bool Move(int fromAPos, int fromBPos, int toAPos, int toBPos, Board theBoard) {
            int pathPosA = fromAPos, pathPosB = fromBPos;

            if (fromAPos == toAPos || fromBPos == toBPos) {
                // Valid direction - check if path to destination is clear
                if(fromAPos == toAPos) {
                    // Movement is in vertical direction
                    while (theBoard.TheBoard[pathPosA, pathPosB] == null) {

                    }
                }
                else {
                    // Movement is in horizontal direction
                    while (theBoard.TheBoard[pathPosA, pathPosB] == null) {

                    }
                }
                
            }
            
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {

    class Pawn : IPiece {
        public int Color { get; set; }
        public char Symbol { get; set; }
        public bool IsCaptured { get; set; }
        public int APos { get; set; }
        public int BPos { get; set; }

        public Pawn(int theColor, int theAPos, int theBPos) {
            APos = theAPos;
            BPos = theBPos;
            Color = theColor;
            IsCaptured = false;
            Symbol = 'P';
        }

        public bool Move(int toAPos, int toBPos, Board theBoard) {

            if (Color == 0) {
                // BLACK - can only move DOWN

                // Check if move is legal
                if (((toAPos == APos + 1) && toBPos == BPos)
                    || ((toAPos == APos + 1) && toBPos == BPos + 1)
                    || ((toAPos == APos + 1) && toBPos == BPos - 1)
                    || ((toAPos == APos + 2) && toBPos == BPos)) {
                    // check if attack move
                    if(((toAPos == APos + 1) && toBPos == BPos + 1) || ((toAPos == APos + 1) && toBPos == BPos - 1)) {
                        

                    }
                    

                    
                }
                else return false;

            } else {
                // WHITE - can only move UP
            }
            return true;
        }

    }
}

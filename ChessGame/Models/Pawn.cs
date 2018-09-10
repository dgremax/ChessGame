using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    class Pawn : IPiece {
        public int Color { get; set; }
        public char Symbol { get; set; }

        public Pawn(int theColor) {
            Color = theColor;
            Symbol = 'P';
        }

        public bool Move(int fromAPos, int fromBPos, int toAPos, int toBPos, Board theBoard) {

            if (Color == 0) {
                // BLACK - can only move DOWN

                // Check if move is legal
                if (((toAPos == fromAPos + 1) && toBPos == fromBPos)
                    || ((toAPos == fromAPos + 1) && toBPos == fromBPos + 1)
                    || ((toAPos == fromAPos + 1) && toBPos == fromBPos - 1)
                    || ((toAPos == fromAPos + 2) && toBPos == fromBPos)) {
                    // check if attack move
                    if(((toAPos == fromAPos + 1) && toBPos == fromBPos + 1) 
                        || ((toAPos == fromAPos + 1) && toBPos == fromBPos - 1)) {

                        

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

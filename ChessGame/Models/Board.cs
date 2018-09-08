using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    class Board {
        public IPiece[,] TheBoard;
        private int TheDim;

        public Board (int theDim) {
            TheDim = theDim;
            TheBoard = new IPiece[theDim, theDim];
            PopulateBoard();
        }

        void PopulateBoard() {
            for(int i = 0; i < TheDim; i++) {
                if(i == 1 || i == TheDim - 2) {
                    // Add pawns
                    for (int j = 0; j < TheDim; j++) {
                        if(i == 1) {
                            // Add black pawns
                            TheBoard[i,j] = new Pawn(0,i,j);
                        }
                        else {
                            // Add white pawns
                            TheBoard[i,j] = new Pawn(1,i,j);
                        }
                    }
                }
                else if (i == 0 || i == TheDim - 1) {
                    // Add other pieces
                    for (int j = 0; j < TheDim; j++) {
                        if(i == 0) {
                            // Add black pieces
                            if(j == 0 || j == 7) {
                                // Add rook
                                TheBoard[i, j] = new Rook(0, i, j);
                            }
                            else if (j == 1 || j == 6) {
                                // Add knight
                                TheBoard[i, j] = new Knight(0, i, j);
                            }
                            else if (j == 2 || j == 5) {
                                // Add bishop
                                TheBoard[i, j] = new Bishop(0, i, j);
                            }
                            else if (j == 3) {
                                // Add queen
                                TheBoard[i, j] = new Queen(0, i, j);
                            }
                            else {
                                // Add king
                                TheBoard[i, j] = new King(0, i, j);
                            }
                        }
                        else {
                            // Add white pieces
                            if (j == 0 || j == 7) {
                                // Add rook
                                TheBoard[i, j] = new Rook(1, i, j);
                            }
                            else if (j == 1 || j == 6) {
                                // Add knight
                                TheBoard[i, j] = new Knight(1, i, j);
                            }
                            else if (j == 2 || j == 5) {
                                // Add bishop
                                TheBoard[i, j] = new Bishop(1, i, j);
                            }
                            else if (j == 3) {
                                // Add queen
                                TheBoard[i, j] = new Queen(1, i, j);
                            }
                            else {
                                // Add king
                                TheBoard[i, j] = new King(1, i, j);
                            }
                        }
                    }
                }

            }
        }

        public void PrintBoard() {
            for(int i = 0; i < TheDim; i++) {
                for(int j = 0; j < TheDim; j++) {
                    if (TheBoard[i, j] == null) Console.Write('-');
                    else Console.Write(TheBoard[i,j].Symbol);
                }
                Console.WriteLine();
            }
        }

    }

}

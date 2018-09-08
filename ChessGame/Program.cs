using ChessGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame {
    class Program {
        static void Main(string[] args) {

            Board theBoard = new Board(8);
            // Color, ACoord, BCoord
            //Pawn aPawn = new Pawn(0, 1, 0);
            //if (aPawn.Move(2, 0, theBoard)) Console.WriteLine("The move was legal!");
            //else Console.WriteLine("The move was illegal!");

            theBoard.PrintBoard();


            Console.ReadKey();
        }
    }
}

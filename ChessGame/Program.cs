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
            IPiece selectedPiece = null;
            int fromAPos = -1, fromBPos = -1, toAPos = -1, toBPos = -1;

            string[] userInput;

            theBoard.PrintBoard();
            Console.WriteLine();

            while (true) {
                while(fromAPos < 0 || fromAPos > 7 || fromBPos < 0 || fromBPos > 7
                    || toAPos < 0 || toAPos > 7 || toBPos < 0 || toBPos > 7) {

                    Console.Write("From <A,B>: ");
                    userInput = Console.ReadLine().Split(',');
                    fromAPos = Convert.ToInt32(userInput[0]);
                    fromBPos = Convert.ToInt32(userInput[1]);

                    Console.Write("To <A,B>: ");
                    userInput = Console.ReadLine().Split(',');
                    toAPos = Convert.ToInt32(userInput[0]);
                    toBPos = Convert.ToInt32(userInput[1]);

                    //Console.Write("A src: ");
                    //fromAPos = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("B src: ");
                    //fromBPos = Convert.ToInt32(Console.ReadLine());

                    //Console.Write("A dest: ");
                    //toAPos = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("B dest: ");
                    //toBPos = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine("Values:\nfromAPos: " + fromAPos + ", fromBPos: " + fromBPos + "\ntoAPos: " + toAPos + ", toBPos: " + toBPos);
                }

                // Select the piece from the board
                selectedPiece = theBoard.TheBoard[fromAPos, fromBPos];
                if(selectedPiece == null) {
                    Console.WriteLine("A piece at those co-ords doesn't exist!");
                    fromAPos = -1;
                    continue;
                }

                // Pass input to function
                if (!selectedPiece.Move(fromAPos, fromBPos, toAPos, toBPos, theBoard)) {
                    Console.WriteLine("Invalid move!") ;
                }

                theBoard.PrintBoard();

                // Reset input vars
                fromAPos = -1;
            }
        }
    }
}

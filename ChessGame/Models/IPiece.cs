using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    interface IPiece {
        int Color { get; set; }
        string Symbol { get; set; }

        bool Move(int fromAPos, int fromBPos, int toAPos, int toBPos, Board theBoard);
    }
}

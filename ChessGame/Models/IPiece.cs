using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    interface IPiece {
        int Color { get; set; }
        char Symbol { get; set; }
        bool IsCaptured { get; set; }
        int APos { get; set; }
        int BPos { get; set; }

        bool Move(int toAPos, int toBPos, Board theBoard);
    }
}

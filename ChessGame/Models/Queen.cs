﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Models {
    class Queen : IPiece {
        public int Color { get; set; }
        public char Symbol { get; set; }
        public bool IsCaptured { get; set; }
        public int APos { get; set; }
        public int BPos { get; set; }

        public Queen(int theColor, int theAPos, int theBPos) {
            APos = theAPos;
            BPos = theBPos;
            Color = theColor;
            IsCaptured = false;
            Symbol = 'Q';
        }

        public bool Move(int toAPos, int toBPos, Board theBoard) {

            return true;
        }
    }
}

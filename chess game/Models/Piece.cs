using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_game.Models
{
    public class Piece
    {
        public string title { get; set; } = string.Empty;

        public (int x, int y) location { get; set; }
    }
}

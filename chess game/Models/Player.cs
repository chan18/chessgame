using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_game.Models
{
    public class Player
    {
        public int id { get; set; }
        public Piece piece { get; set; } = new();

        public bool turn { get; set; }


    }
}

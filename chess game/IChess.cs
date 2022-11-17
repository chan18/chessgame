using chess_game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_game
{
    public interface IChess
    {
        void InitGame(int boardSize);
        void Move(Player player);
    }
}

using chess_game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_game
{
    public interface IValidation
    {
        Task<bool> ValidatePlayerTurn(Player player);
        Task<bool> ValidateDiagonally(Player player);
        Task<bool> ValidateClearPath(Player player);
    }
}

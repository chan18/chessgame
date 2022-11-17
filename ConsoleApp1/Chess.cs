using chess_game;
using chess_game.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ChessGame : IChess,IValidation
    {
        private const int Playersize = 2;
        private const int BoardSize = 4;

        private readonly Player[] players;
        private readonly Piece blackBishop;
        private readonly Piece whtieBishop;

        private int[,] board;
        
        public ChessGame()
        {
            this.blackBishop = new() { title = "bishop", location = (1,1)};
            this.whtieBishop = new() { title = "bishop", location = (3,3) };

            this.players = new Player[Playersize] {
                                new() { id = 1, turn = true, piece = blackBishop },
                                new() { id = 2, turn = false, piece = whtieBishop },
                            };
        }

        public void InitGame(int boardSize)
        {

            for (int i = 0; i <= boardSize; i++)
            {
                for (int j = 0; j <= boardSize; j++)
                {
                    board[i, j] = j;
                }   
            }
        }

        public void InitGame()
        {
            throw new NotImplementedException();
        }

        public async void Move(Player player)
        {
            await ValidatePlayerTurn(player);
            await ValidateDiagonally(player);
        }

        public Task<bool> ValidateClearPath(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateDiagonally(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidatePlayerTurn(Player player)
        {
          if(player is { } && player.turn )
          {
                player.turn = false;
                players.Where(x => x.id != player.id).FirstOrDefault().turn = true;

                return true;
          }
          else
          {
                throw new Exception();
          }
        }
    }
}

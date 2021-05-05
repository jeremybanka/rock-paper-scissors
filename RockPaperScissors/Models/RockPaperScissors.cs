using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class Game
  {
    public static string PlayLongform(string move0, string move1)
    {
      return move0 switch
      {
        "rock" => move1 switch
        {
          "rock" => "Draw!",
          "paper" => "Player 1 Wins!",
          "scissors" => "Player 0 Wins!",
          _ => throw new ArgumentException("Player 1 made an invalid move!"),
        },
        "paper" => move1 switch
        {
          "rock" => "Player 0 Wins!",
          "paper" => "Draw!",
          "scissors" => "Player 1 Wins!",
          _ => throw new ArgumentException("Player 1 made an invalid move!"),
        },
        "scissors" => move1 switch
        {
          "rock" => "Player 1 Wins!",
          "paper" => "Player 0 Wins!",
          "scissors" => "Draw!",
          _ => throw new ArgumentException("Player 1 made an invalid move!"),
        },
        _ => throw new ArgumentException("Player 0 made an invalid move!"),
      };
    }

    public static int GetIdxOfMove(String[] validMoves, string move)
    {
      int moveIdx = Array.IndexOf(validMoves, move);
      if (moveIdx == -1)
      {
        throw new ArgumentException("A player made an invalid move!");
      }
      return moveIdx;
    }

    public static int WrapAround(int value, int min, int max)
    {
      int range = max - min;
      while (value >= max) value -= range;
      while (value < min) value += range;
      return value;
    }

    public static string Play(string player0move, string player1move)
    {
      String[] validMoves = { "rock", "paper", "scissors" };
      if (player0move == player1move)
      {
        return "Draw!";
      }
      int player0moveIdx = GetIdxOfMove(validMoves, player0move);
      int player1moveIdx = GetIdxOfMove(validMoves, player1move);

      bool player0hasWinningMove = player0moveIdx == WrapAround(player1moveIdx + 1, 0, validMoves.Length);
      if (player0hasWinningMove)
      {
        return "Player 0 Wins!";
      }

      return "foo";
    }
  }
}

// winConditions[move0][move1]

// winConditions {
//   rock: {
//     rock: 0,
//     paper: 1,
//     scissors: -1, 
//   }
//   paper: {
//     rock: 0,
//     paper: 1,
//     scissors: -1, 
//   }
//   scissors: {
//     rock: 0,
//     paper: 1,
//     scissors: -1, 
//   }
// }


//
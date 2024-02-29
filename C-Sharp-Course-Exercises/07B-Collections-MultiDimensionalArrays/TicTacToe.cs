using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07B_Collections_MultiDimensionalArrays
{
    internal class TicTacToe
    {
        public static bool Checker(string[,] board)
        {
            // check horizontally
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // check horizontally
                if ((board[i, 0] == board[i, 1]) && (board[i, 1] == board[i, 2])) {
                    return true;
                }


                // check vertically
                for (int j = 0; j < board.GetLength(1); j++) 
                { 
                    if ((board[0, j] == board[1, j])  && (board[1, j] == board[2, j])) {
                        return true;
                    }
                }
            }

            // check left to right diagonal
            if ((board[0, 0] == board[1,1]) && (board[1,1] == board[2, 2])) return true;
            if ((board[2, 0] == board[1, 1]) && (board[1, 1] == board[2, 0])) return true;

            return false;

        }
    }
}

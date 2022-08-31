using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class BoardPrinter
    {
        public static void Print (bool[,] gameBoard)
        {
            int boardWidth = gameBoard.GetLength(0);
            int boardHeight = gameBoard.GetLength(1);

            StringBuilder s = new StringBuilder();

            for (int y = 0; y<boardHeight;y++)
            {
              for (int x = 0; x<boardWidth; x++)
              {
                    if(gameBoard[x,y])
                    {
                      s.Append("|X|");
                    }
                    else
                     {
                       s.Append("___");
                    }       
             }
                s.Append("\n");
            }
    Console.WriteLine(s.ToString());
}
    }
}


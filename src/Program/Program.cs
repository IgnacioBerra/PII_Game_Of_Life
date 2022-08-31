using System;
using System.Text;


namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool[,] gameBoard = FileReader.Reader("C:\\Users\\Ignacio\\Documents\\Repositorios GIT\\Bacteria VIDA\\PII_Game_Of_Life\\assets\\board.txt");
            Logic Logica = new Logic(gameBoard);

            while (true)
            {
              gameBoard = Logica.Recorrer(gameBoard);
              BoardPrinter.Print(gameBoard);
            } 
       
       
       
        }
    }
}

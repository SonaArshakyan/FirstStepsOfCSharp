using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class ChessBoard
    {
        private int[,] _chessBoard;
        public const int Deminsion = 8;

         public ChessBoard() {

                     
            _chessBoard = new int[Deminsion, Deminsion];
            ChessBoardHorizontalSymbol = "+----";
            ChessBoardVerticalSymbol = "| ";
        }

        public string ChessBoardHorizontalSymbol { get; set; }
        public string ChessBoardVerticalSymbol { get; set; }

        public void DisplayChessboard()
        {                    
            Soldier soldier = new Soldier();
            soldier.PawnsMove();
            var x = soldier.moveX;
            var y = soldier.moveY;
            var name = soldier.elements[0];



           
            //Writting the numbers /Horizontal
            Console.Write("    ");
            for (int i = 1; i <= 8; i++)
            {
              Console.Write("  " + i + "  ");
            }
            Console.WriteLine();
            
            //The circle for Writting Chess desk
            for (int i = 1; i <= Deminsion; i++)
                {
                Console.WriteLine();
                Console.Write("   ");
            for (int k = 1; k <= Deminsion ; k++)
                {
                 Console.Write(ChessBoardHorizontalSymbol); //HorizontalSymbols to Write
                }
                Console.Write("+");
                Console.WriteLine();
                Console.Write(i +"  ");

            for (int k = 1; k <= Deminsion+1; k++)
                {

                    if (k == x && i == y)
                    {
                        Console.Write(ChessBoardVerticalSymbol  + name + " "); 
                    }
                    else
                    Console.Write(ChessBoardVerticalSymbol + "   "); //VerticalSymbols to Write
                }
             }

            //Last HorizontalSymbols
            
            Console.WriteLine();
           
            Console.Write("   ");
            for (int k = 0; k < Deminsion; k++)
            {
                Console.Write(ChessBoardHorizontalSymbol);
            }
            Console.Write("+");

            Console.WriteLine();
            Console.WriteLine();

            //Moving element with asking where the user wanna move

            /*

            soldier.MoveElem();
            var NewDestionationX = soldier.destinationX;
            var NewDestionationY = soldier.destinationY;
            if(NewDestionationX !=0 && NewDestionationY != 0)
            DisplayChesBoardForExistingElement(NewDestionationX, NewDestionationY ,name);

            */

            // Moving Element with using ReadKeys


            int CordinateX = x;
            int CordinateY = y;


            do
            {
                if (CordinateY == 1)
                    break;
                if (Console.ReadKey(true).Key == ConsoleKey.UpArrow)
                    CordinateY--;
                DisplayChesBoardForExistingElement(CordinateX, CordinateY, name);
            }
            while (true);





        }
        public void DisplayChesBoardForExistingElement(int X, int Y , string name)
        {
            Console.Clear();
            Console.Write("    ");
            for (int i = 1; i <= 8; i++)
            {
                Console.Write("  " + i + "  ");
            }
            Console.WriteLine();

            //The circle for Writting Chess desk
            for (int i = 1; i <= Deminsion; i++)
            {
                Console.WriteLine();
                Console.Write("   ");
                for (int k = 1; k <= Deminsion; k++)
                {
                    Console.Write(ChessBoardHorizontalSymbol); //HorizontalSymbols to Write
                }
                Console.Write("+");
                Console.WriteLine();
                Console.Write(i + "  ");

                for (int k = 1; k <= Deminsion + 1; k++)
                {

                    if (k == X && i == Y)
                    {
                        Console.Write(ChessBoardVerticalSymbol + name + " ");
                    }
                    else
                        Console.Write(ChessBoardVerticalSymbol + "   "); //VerticalSymbols to Write
                }
            }

            //Last HorizontalSymbols

            Console.WriteLine();

            Console.Write("   ");
            for (int k = 0; k < Deminsion; k++)
            {
                Console.Write(ChessBoardHorizontalSymbol);
            }
            Console.Write("+");
        }




    }



    
    
}

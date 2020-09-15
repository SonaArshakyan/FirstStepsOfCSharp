using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {


        static void Main(string[] args)
        {

            /* 
             
           // How Work Clone Function
            User user = new User()
            {
                FirstName = "Sevak",
                LastName = "Muradyan"
            };
            Console.WriteLine(user.FirstName + "" + user.LastName);
            //Sevak Muradyan
            User newUser = (User)user.Clone();
            Console.WriteLine(newUser.FirstName + "" + newUser.LastName);
            //Fisrtname Sevak  Lastname Muradyan

             Console.WriteLine();

            var shoe = new Shoe();
            shoe.UserShoe = user;

            Console.WriteLine(shoe.UserShoe.FirstName + " ", shoe.UserShoe.LastName );

            //Sevak 
            var clonShe =(Shoe)shoe.Clone();
            Console.WriteLine(clonShe.UserShoe.FirstName , clonShe.UserShoe.LastName);
            //Fisrtname Sevak             

              */


            /*
            //Task chess

          // ChessBoard chess = new ChessBoard();
          //chess.DisplayChessboard();

            Console.WriteLine();
            Console.WriteLine();
           
            */

            /*

                // Task . we Gonna  guess the number  the the other kept in mind


                  PlayerSecond FirstNum = new PlayerSecond();

                  do
                  {

                      FirstNum.CreateYourGame();
                      Console.WriteLine("The number of Postions that were right  " + FirstNum.MatchPostionCount);
                      Console.WriteLine("The number of Numbers  that were right  " + FirstNum.MatchNumberCount);
                      Console.WriteLine();
                      if (FirstNum.MatchPostionCount == 4 && FirstNum.MatchNumberCount==4 )
                          break;
                  }

                  while (true);
                  // Task : питнашка игра
                  Pitnashka g1 = new Pitnashka();
                  g1.DisplayGame();

         */
            // Task New Chess Game 
            /*

           GameChess g1 = new GameChess();        
          g1.AddFigures(new SoldierElement(new Position { x = 5, y = 5 }, FigureColor.Black, "bs" , -1));
          g1.AddFigures(new SoldierElement(new Position { x = 3, y = 2 }, FigureColor.White, "ws"  , 1));
          g1.AddFigures(new SoldierElement(new Position { x = 7, y = 6 }, FigureColor.Black, "bs" , -1));         
          g1.AddFigures(new HorseElement(new Position { x = 1, y = 3 }, FigureColor.Black, "bh" , -3  ));


        //  g1.DisplayChessGame();
          Console.WriteLine();
          Console.WriteLine(g1.figureLists.Count );

            */

            Pitnashka g1 = new Pitnashka();
            g1.DisplayGame();


        }
    }
}

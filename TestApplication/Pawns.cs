using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public abstract class Pawns
    {
        public List<string> elements;
        protected void  PawnsAdd(string PawnsName)
        {
            elements = new List<string>();
            elements.Add(PawnsName);
         }

        public abstract void PawnsMove();
        public abstract void MoveElem();
       
    }


    public class Soldier: Pawns
    {
        public int destinationX;
        public int destinationY;
        public int[,] SoldierMove ;
        public int moveX;
        public int moveY;

        public Soldier()
        {
            Console.WriteLine("You are going to add the soldier. \nWhat kid of Color You wanna Be your soldier?");
            string pawnS = Console.ReadLine();
            base.PawnsAdd(pawnS);
        }
        public override  void  PawnsMove()

        {

            Console.WriteLine("The x cordinate where yu wanna add Soldier");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if(x <= 0 || x>= 8  )
            {
                Console.WriteLine("InValid Input for X");
               
                
            }
            if (y <= 0 || y >= 8)
            {
                Console.WriteLine("InValid Input for Y");
            }
            moveX = x;
            moveY = y;
          
            SoldierMove = new int[ x, y];



        }

        public override void MoveElem()
        {
            

            Console.WriteLine("Do you wanna Move your Soldier ? Answer yes or no !");
            var answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Input the destinations where you wanna move you Soldier");
                destinationX = Convert.ToInt32(Console.ReadLine());
                destinationY = Convert.ToInt32(Console.ReadLine());


            }
            else if (answer == "no")
            {
                Console.WriteLine("Okay Dear, as you wish.");
            }
            else
                Console.WriteLine("The answer should be yes or no. Try again.");




        }

      

    }
}

   

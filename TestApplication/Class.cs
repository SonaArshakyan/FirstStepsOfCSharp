using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    //Copy Method tests
    public class User : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object Clone()
        {
            User user = new User()
            {
                FirstName = $"FistName: {FirstName}",
                LastName = $"LastName: {LastName}"
            };

            return user;
        }
    }

    public class Shoe : ICloneable
    {
        public User UserShoe { get; set; }
       

        public object Clone()
        {
            Shoe shoe = new Shoe();
            shoe.UserShoe = UserShoe.Clone() as User;
            return shoe;
        }
       








    }


     //Task : Guess The Number


    public class PlayerFirst
    {
        private int _MyPrivateNumber=1234 ;
        private int _firstMark;
        private int _secondMark;
        private int _tirdthMark;
        private int _fourthMark;

        public int[] PlayerFirstArray;
    


        public PlayerFirst()
        {


            int _min = 0;
            int _max = 9;
            Random _rdm = new Random();
            _firstMark = _rdm.Next(_min, _max);
            _secondMark = _rdm.Next(_min, _max);

            if( _secondMark == _firstMark)
            {
                _secondMark = _rdm.Next(_min, _max);
            }

            _tirdthMark = _rdm.Next(_min, _max);
            if(_tirdthMark == _secondMark || _tirdthMark == _firstMark)
            {
                _tirdthMark = _rdm.Next(_min, _max);
            }

            _fourthMark = _rdm.Next(_min, _max);
            if (_fourthMark == _secondMark || _fourthMark == _firstMark || _fourthMark == _firstMark)
            {
                _fourthMark = _rdm.Next(1, _max);

            }

            _MyPrivateNumber = _fourthMark * 1000 + _tirdthMark * 100 + _secondMark * 10 + _firstMark;

          Console.WriteLine(_MyPrivateNumber);


            SeparateMyPrivateNumber(_MyPrivateNumber);

        }

        public void SeparateMyPrivateNumber(int number)
        {
           
             _firstMark = number % 10;
      

            number = number / 10;
          
            _secondMark = number % 10;

            number = number / 10;
         
            _tirdthMark = number % 10;

            number = number / 10;
           
            _fourthMark = number % 10;

            PlayerFirstArray = new int[] { _firstMark, _secondMark, _tirdthMark, _fourthMark };

           
        }

        public int[] ReturnPrivateNumbersArray()
        {
            return PlayerFirstArray;
        }

    }

    public class PlayerSecond:PlayerFirst
    {
        private int __MyNumber;
        private int _firstMark;
        private int _secondMark;
        private int _tirdthMark;
        private int _fourthMark;

        public int[] PlayerSecondArray;


        public int MatchNumberCount = 0;
        public int MatchPostionCount = 0;

        public PlayerSecond()
            
        {
                        
        }

        public void CreateYourGame()
        {
            Console.WriteLine("Enter Your Number !");
            __MyNumber = Convert.ToInt32(Console.ReadLine());
            SeparateSecondNumber(__MyNumber);

        }

        public void SeparateSecondNumber(int number)
        {

            _firstMark = number % 10;
          

            number = number / 10;
        
            _secondMark = number % 10;

            number = number / 10;
         
            _tirdthMark = number % 10;

            number = number / 10;
         
            _fourthMark = number % 10;


            PlayerSecondArray = new int[] { _firstMark, _secondMark, _tirdthMark, _fourthMark };
            CompareNumbers(PlayerSecondArray);


        }




        public void CompareNumbers(int[] PlayerSecondArray)

        {
            MatchNumberCount = 0;
            MatchPostionCount = 0;

            int[] FirstArray = ReturnPrivateNumbersArray();

            for(int i = 0; i< FirstArray.Length; i++)
            {
                for(int j = 0; j< PlayerSecondArray.Length; j++)
                {
                    if (FirstArray[i] == PlayerSecondArray[j])
                    {
                         MatchNumberCount++;
                        if(i == j)
                        {
                            MatchPostionCount++;
                        }
                    }
                       
                    
                }
            }
        }



        public int GetMatchCountPositions() {

          
            return MatchPostionCount;
        }

        


       public int GetMatchCountNumbers()
        {
          
            return MatchNumberCount;
        }

        



    }



    // Task: питнашка игра


    public class Pitnashka:MatrixNumber
    {
        public int coordinateX;
        public int coordinateY;

        private int[,] GameBoard;
        public int SizeOfBoards = 4;


        public Pitnashka()
        {          
            BoardHorizontal = "+-----" ;
            BoardVertical = "|";
        }

        public string BoardHorizontal { get; set; }

        public string BoardVertical { get; set; }

        public void DisplayGame()
        {
           

            for (int i = 0; i< SizeOfBoards ; i++)
            {
                Console.Write("  ");
                for(int j = 0; j< SizeOfBoards ; j++)
                {
                    Console.Write(BoardHorizontal);
                }
                Console.Write("+");
                Console.WriteLine();
                Console.Write("  ");
                for(int m =0; m < SizeOfBoards ; m++)
                
                {                 
 
                    if(CollectionOfNumbers[i, m] <10 )
                    Console.Write( BoardVertical + "  "+ CollectionOfNumbers[i , m] + "  " );
                    else
                    {
                        if (CollectionOfNumbers[i, m] == 16)
                        {
                            coordinateX = i; coordinateY = m;
                            Console.Write(BoardVertical + "     " );

                        }
                        else
                        Console.Write(BoardVertical + "  " + CollectionOfNumbers[i, m] + " ");
                    }
                    

                }
                

                Console.Write(BoardVertical);
                

                Console.WriteLine();

            }
            Console.Write("  ");
            for (int j = 0; j < SizeOfBoards; j++)
            {
                Console.Write(BoardHorizontal );
            }
            Console.Write("+");


            MoveMatrix();

        }




        public void MoveMatrix()
        {
            int temp;
            int currentindex;

            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.UpArrow)
            {

                if (coordinateX <= 3 && coordinateX >= 0)
                {
                    temp = CollectionOfNumbers[coordinateX, coordinateY];
                    currentindex = coordinateX;
                    
                    if(coordinateX == 0) 
                   {
                      
                        Console.Clear();
                        DisplayGame();

                    }
                    else
                    {
                     coordinateX--;
                     CollectionOfNumbers[currentindex, coordinateY] = CollectionOfNumbers[coordinateX, coordinateY];
                     CollectionOfNumbers[coordinateX, coordinateY] = temp;
                        
                    Console.Clear();
                    DisplayGame();
                    }
             

                }
             

            }


            if (keyPressed.Key == ConsoleKey.DownArrow)
            {

                if (coordinateX <= 3 && coordinateX >= 0)
                {
                    temp = CollectionOfNumbers[coordinateX, coordinateY];
                    currentindex = coordinateX;

                    if (coordinateX == 3)
                    {
                        Console.Clear();
                        DisplayGame();

                    }
                    else
                    {
                     coordinateX++;
                     CollectionOfNumbers[currentindex, coordinateY] = CollectionOfNumbers[coordinateX, coordinateY];
                     CollectionOfNumbers[coordinateX, coordinateY] = temp;

                     Console.Clear();
                     DisplayGame();
                    }
             
                }

            }

            if (keyPressed.Key == ConsoleKey.LeftArrow)
            {

                if (coordinateY <= 3 && coordinateY >= 0)
                {
                    temp = CollectionOfNumbers[coordinateX, coordinateY];
                    currentindex = coordinateY;
                    if (coordinateY ==0 )
                    {
                    
                        Console.Clear();
                        DisplayGame();

                    }
                    else
                    {
                    coordinateY--;
                    CollectionOfNumbers[coordinateX, currentindex] = CollectionOfNumbers[coordinateX, coordinateY];
                    CollectionOfNumbers[coordinateX, coordinateY] = temp;

                    Console.Clear();
                    DisplayGame();
                    }

                }

            }

            if (keyPressed.Key == ConsoleKey.RightArrow)
            {

                if (coordinateY <= 3 && coordinateY >= 0)
                {
                    temp = CollectionOfNumbers[coordinateX, coordinateY];
                    currentindex = coordinateY;
                    if(coordinateY == 3)
                    {
                    
                        Console.Clear();
                        DisplayGame();
                    }
                    else
                    {
                    coordinateY++;
                    CollectionOfNumbers[coordinateX, currentindex] = CollectionOfNumbers[coordinateX, coordinateY];
                    CollectionOfNumbers[coordinateX, coordinateY] = temp;

                    Console.Clear();
                    DisplayGame();
                    }

                }

            }

        }

    }

    public class MatrixNumber
    {

        public int[,]  CollectionOfNumbers;


        public MatrixNumber()
        {
            CollectionOfNumbers = new int[4,4];
            AddMatrix();

        }

        public void  AddMatrix()
        {
            Random rnd = new Random();
            int currentNum;
            List<int> MyListArray = new List<int>();
            for(int i = 0; i< 15; i++ )
            {
                do
                {
                    currentNum = rnd.Next(1, 16);
                }
                while (MyListArray.Contains(currentNum));

                MyListArray.Add(currentNum);
            }

            MyListArray.Add(16);

           int[] MyListArrayToConvertMatrix = MyListArray.ToArray();

            Buffer.BlockCopy(MyListArrayToConvertMatrix, 0, CollectionOfNumbers, 0, MyListArrayToConvertMatrix.Length * sizeof(int));

        }

    }





    // Task New Chess

    public class IndexIsNotFreeException : Exception
    {
        public IndexIsNotFreeException(string message)
           : base(message)
        {
        }
    }


    public class GameChess
   {     
       public List<ChessElement> figureLists;
       private  int[,] _gameBoard;
       public const int boards = 8;

       public  GameChess()
       {
            figureLists = new List<ChessElement>();
            _gameBoard = new int[9,9];
            GameBoardVertical = "| ";
            GameBoardHorizontal = "+----";
       }

        public void AddFigures(ChessElement  chessElement)
        {
           
            var LegalPositions = new List<Position>();
            int freePostionX = chessElement.CurrentPosition.x;
            int freePostionY = chessElement.CurrentPosition.y;
            FigureColor color  = chessElement.Color;
            string name = chessElement.Name;
            int weight = chessElement.Weight;

           
            for (int i =  1; i <=  8 ; i++)
            {
                for(int j = 1; j <= 8; j++)
                {
                    if(i == freePostionY && j == freePostionX)
                     if(_gameBoard[i ,j] == weight)
                        {
                  throw new IndexIsNotFreeException(string.Format("Unable to add a new element in  index {0} and {1}", j , i));
                        }
                    else
                        {
                            _gameBoard[i, j] = weight;
                        figureLists.Add(chessElement);
                        LegalPositions =  chessElement.GetAvelablePositions();
                            
                        }
                 }
            }                             

            DisplayChessGame(LegalPositions );

        }

        public string GameBoardVertical { get; set; }

        public string  GameBoardHorizontal { get; set; }


        public void DisplayChessGame(List<Position> LegalPositions)
            {

            Console.Clear();

            //First we gonna write the numbers horizontal
            Console.Write("    ");
            for (int i = 1; i <= 8; i++)
            {
                Console.Write("  " + i + "  ");
            }
            Console.WriteLine();

            //We gonna write  the Chess Desk
            for (int row = 1; row <= boards; row++)
            {
                Console.WriteLine();
                Console.Write("   ");
                for (int k = 1; k <= boards; k++)
                {
                 Console.Write(GameBoardHorizontal); //HorizontalSymbols to Write
                }
                Console.Write("+");
                Console.WriteLine();
                Console.Write(row + "  ");

                for (int col = 1; col <= boards ; col++)
                {
                   if(figureLists.Count != 0)
                   {
                     if ( _gameBoard[ col , row ] == 1)
                        {
                           var ListOFCorrespondingX = figureLists.FindAll(x => x.CurrentPosition.x == row);
                           var SpecificElement = ListOFCorrespondingX.Find(y => y.CurrentPosition.y == col);
                            Console.Write(GameBoardVertical  + SpecificElement.Name+ " " );                            
                          }
                       else if (_gameBoard[col, row] == -1)
                        {
                            var ListOFCorrespondingX = figureLists.FindAll(x => x.CurrentPosition.x == row);
                            var SpecificElement = ListOFCorrespondingX.Find(y => y.CurrentPosition.y == col);
                            Console.Write(GameBoardVertical + SpecificElement.Name + " ");
                        }
                       else if (_gameBoard[col, row] == 3)
                        {
                            var ListOFCorrespondingX = figureLists.FindAll(x => x.CurrentPosition.x == row);
                            var SpecificElement = ListOFCorrespondingX.Find(y => y.CurrentPosition.y == col);
                            Console.Write(GameBoardVertical + SpecificElement.Name + " ");
                        }
                        else if (_gameBoard[col, row] == -3)
                        {
                            var ListOFCorrespondingX = figureLists.FindAll(x => x.CurrentPosition.x == row);
                            var SpecificElement = ListOFCorrespondingX.Find(y => y.CurrentPosition.y == col);
                            Console.Write(GameBoardVertical + SpecificElement.Name + " ");
                        }

                        else
                        {
                            var PositionToShow = LegalPositions.FindAll(ColY => ColY.y == col);
                                
                            var PositionToShowPair = PositionToShow.Find(RowX => RowX.x == row);

                           if(PositionToShowPair.x == row && PositionToShowPair.y == col)
                            Console.Write(GameBoardVertical + "*"+ "  ");


                            else
                                Console.Write(GameBoardVertical + "   ");

                        }


      
                    }


                 else                                     
                 Console.Write(GameBoardVertical  + "   ");

                }
                Console.Write(GameBoardVertical);
                
            }

             //Last HorizontalSymbols

              Console.WriteLine();

              Console.Write("   ");
              for (int k = 0; k < boards; k++)
              {
               Console.Write(GameBoardHorizontal);
              }
              Console.Write("+");

              Console.WriteLine();
              Console.WriteLine();



          
            ChessElement horse = figureLists[figureLists.Count - 1];
            Console.WriteLine(horse.Name + " "+ horse.Weight + " " + _gameBoard[horse.CurrentPosition.y, horse.CurrentPosition.x]);
            
          
           ShowHorseRoad( horse);
                       
           
            

        }

        public void ShowHorseRoad( ChessElement horse)
        {           
            int directedX = Convert.ToInt32(Console.ReadLine());
            int directedY = Convert.ToInt32(Console.ReadLine());
            AddFigures(new HorseElement(new Position { x = directedX, y = directedY }, horse.Color, horse.Name, horse.Weight));
        }




    }
    



    public struct Position
    {
       public int x;
        public int y;
    }

    public enum FigureColor { White , Black}

    public abstract class ChessElement
    {
        public int Weight;
        public string Name;
        public Position CurrentPosition;
        public FigureColor Color;

        public abstract List<Position> GetAvelablePositions();

         public ChessElement( int coordinateX, int  coordinateY , FigureColor color , string name , int weight )
         {
            CurrentPosition.x = coordinateX;
            CurrentPosition.y = coordinateY;
            Color = color;
            Name = name;
            Weight = weight;
            
         }
 
        public ChessElement (Position position , FigureColor color , string name , int weight )
        {
            CurrentPosition = position;
            Color = color;
            Name = name;
            Weight = weight;

        }

        
    }



    public class SoldierElement : ChessElement
    {
   
        public SoldierElement(Position position , FigureColor color , string name , int weight ) : base(position , color , name , weight )
        {

        }
 

        public SoldierElement(int coordinateX, int coordinateY , FigureColor color , string name , int weight  ) : base(coordinateX, coordinateY, color , name , weight )
        {

        }


        public override List<Position> GetAvelablePositions() 
        {
            List<Position> LegalPositions = new List<Position>();
            Position NewPosition; 

            if(Color  == FigureColor.White )
            {
                
                if(CurrentPosition.x -1 >=  0)
                {
                    LegalPositions.Add(new Position { x = CurrentPosition.x - 1 , y = CurrentPosition.y });
                }
            }
            else
                 if (CurrentPosition.x + 1 <= 8)
            {
                LegalPositions.Add(new Position { x = CurrentPosition.x +1, y = CurrentPosition.y });
            }



            return LegalPositions;
        
        }


    }


    public class HorseElement : ChessElement
    {

        public HorseElement(Position positon, FigureColor color, string name , int weight) : base(positon, color, name , weight)
        {

        }

        public HorseElement(int coordinateX, int coordinateY, FigureColor color, string name , int weight) : base(coordinateX, coordinateY, color, name , weight)
        {

        }

        public override List<Position> GetAvelablePositions()
        {
            List< Position> LegalPositions = new List<Position>();
            Position NewPosition;

            if (CurrentPosition.x - 2 >= 1 && CurrentPosition.y + 1 <= 8)
            {
                LegalPositions.Add(new Position { x = CurrentPosition.x - 2, y = CurrentPosition.y + 1 });
            }
            if (CurrentPosition.x - 2 >= 1 && CurrentPosition.y - 1 >= 1)
            {
                LegalPositions.Add(new Position { x = CurrentPosition.x - 2, y = CurrentPosition.y - 1 });

            }
           if (CurrentPosition.x + 2 <= 8 && CurrentPosition.y + 1 <= 8)
            {
                LegalPositions.Add(new Position { x = CurrentPosition.x + 2, y = CurrentPosition.y + 1 });
            }
            if (CurrentPosition.x + 2 <= 8 && CurrentPosition.y - 1 <= 8)
            {
                LegalPositions.Add(new Position { x = CurrentPosition.x + 2, y = CurrentPosition.y - 1 });

            }
            if (CurrentPosition.x + 1 <= 8 && CurrentPosition.y - 2 >= 1)
            {
                LegalPositions.Add(new Position { x = CurrentPosition.x + 1, y = CurrentPosition.y - 2 });
            }
             if (CurrentPosition.x + 1 <= 8 && CurrentPosition.y + 2 >= 1)
            {
                LegalPositions.Add(new Position { x = CurrentPosition.x + 1, y = CurrentPosition.y + 2 });

            }

            if (CurrentPosition.x - 1 <= 8 && CurrentPosition.y - 2 >= 1)
            {
                LegalPositions.Add(new Position { x = CurrentPosition.x - 1, y = CurrentPosition.y  - 2 });

            }
            if (CurrentPosition.x - 1 <= 8 && CurrentPosition.y + 2 >= 1)
            {
                LegalPositions.Add(new Position { x = CurrentPosition.x - 1, y = CurrentPosition.y + 2 });

            }


            return LegalPositions;


        } 






    }





}

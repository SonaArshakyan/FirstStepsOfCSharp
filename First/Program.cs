using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace First
{
    class Program
    {
        //overloads and generic types
        static void Create<T>(T x)
        {

        }
        static void Create(Son x)
        {

        }
        static void Create(Daughter x)
        {

        }


        static void Main(string[] args)

        {



            /*
				Son son2 = new Son();
				Daughter daughter2 = new Daughter();

				Create(son2);
				Create(daughter2);




				// working with integers 

				int a = 12;
				int b = a;			
				a = 10;

				// working with classes
				MyInt my = new MyInt();
				my.Count = 4;		
				MyInt myToo = my;
				my.Count = 15;


				//working with classes(inheritance)

				Parent son = new Son();
				son.Child();
				son.PorpertyStudy = false; 
				Person daughter = new Daughter(2 , true , false , "female" , 18 );
				Person mom = new Daughter();
				daughter.Child();
				daughter.PorpertyStudy = true;

				Son son1 = new Son();
				son1.SonOwn();
				son1.Child();



			//working with format 
				var c =(float)a / b;
				Console.WriteLine(c.ToString("F4"));


			//Worker with arrays

				for(int i = 1; i<= 5; i++)
				{
					for(int j = i; j< 5; j++)
					{
						Console.Write("  ");
					}
					for(int k = 1; k <= 2*i - 1; k++)
					{
						Console.Write("*" + " ");
					}
					Console.WriteLine();
				}

				for (int i = 0; i < 8; i++)
					Console.WriteLine(new String('#', i + 1).PadLeft(8, ' '));


				//working with string

				string Message1 = "hallo , it is my first string ";
				string Message2 = " hallo , it is my second string ";
				Console.WriteLine(String.Compare(Message1, Message2) + " it is less than 0 because Message1 is precedes Message2");
				string Message3 = " and  ";
				Console.WriteLine(String.Concat(Message1 , Message3 , Message2));
				Console.WriteLine(Message2);


				//using string array and then concat them soooooooo

				string[] stringarray = { "Sona ", "Narine ", "Marine " , "these are girls names"};
				Console.WriteLine("The resurlt of Concat is" );
				Console.WriteLine(String.Concat(stringarray));


				// mesage1 contains message2 or not

				if (Message1.Contains(Message2))
				{
					Console.WriteLine("{0} string contains {1} string ", Message1, Message2);
				}
				else
					Console.WriteLine("{0} string doesnt contain {1} string ", Message1, Message2);

		

	
// task => chnage  24 hours format to 12 hours format . We enter time like 07:05:45PM and the answer should be 19:05:45
		string StringHour = Console.ReadLine();
		string result =  timeConversion(StringHour);
		Console.WriteLine(result);





// task => Grading Students . 


			int gradeCount = Convert.ToInt32(Console.ReadLine());
			List<int> gradeLists = new List<int>();

			for(int i = 0; i < gradeCount ; i++)
			{
				int gradeitem  = Convert.ToInt32(Console.ReadLine());
				gradeLists.Add(gradeitem);
			}
			List<int> resultList = ShowGrades(gradeLists);
			foreach(int c in resultList)
			{
				Console.WriteLine(c);
			}



// task => Apple  and Orange 

			string[] st = Console.ReadLine().Split();
			int s = Convert.ToInt32(st[0]);
			int t = Convert.ToInt32(st[1]);
		

			string[] mn = Console.ReadLine().Split();
			int m = Convert.ToInt32(mn[0]);
			int n = Convert.ToInt32(mn[1]);
			string[] ab = Console.ReadLine().Split();
			int a = Convert.ToInt32(ab[0]);
			int b = Convert.ToInt32(ab[1]);

			//question why  we need Temp ?
			int[] apples = Array.ConvertAll(Console.ReadLine().Split(), applesTemp => Convert.ToInt32(applesTemp));

			int[] oranges = Array.ConvertAll(Console.ReadLine().Split(), orangesTemp => Convert.ToInt32(orangesTemp));

			countApplesAndOranges(s, t, a, b, apples, oranges);

 
//task Kangaroo

			string[] x1V1X2V2 = Console.ReadLine().Split();

			int x1 = Convert.ToInt32(x1V1X2V2[0]);

			int v1 = Convert.ToInt32(x1V1X2V2[1]);

			int x2 = Convert.ToInt32(x1V1X2V2[2]);

			int v2 = Convert.ToInt32(x1V1X2V2[3]);

			if (kangaroo(x1, v1, x2, v2) == true)
				Console.WriteLine("Yes");
			else Console.WriteLine("No");



            //Working with classes , struck, steak, heap , boxing and unboxing 

            string a = "aaaa";
            //StringBuilder  can change the string content byut string doesnt change it after Get Function 
            //GetString(a);
            //Console.WriteLine(a);

            StringBuilder an = new StringBuilder("lallalal");
            //GetStringBuilder(an);
            //Console.WriteLine(an);




            MyInt2 Myint = new MyInt2();
            Myint.Go = 2;

            Console.WriteLine();

            MyInt2 Myint2 = new MyInt2();

            //Myint2.CallStruck("I wanna have name , Name me pleaseeeeee");

            MyInt2 changeints = new MyShortInt2();
            //ChangeMyInt(changeints);


            Woman Ann = new Woman();
            Ann.age = 12;
            Ann.name = "Anna";
            //Ann.Leftshoe = new Shoes();
            Ann.LeftShoe = new Shoes();
            Ann.RightShoe = new Shoes();
            Ann.LeftShoe.Color = Ann.RightShoe.Color = "Yellow";
            Woman Mary = Ann.CopyWomen();
           // Console.WriteLine(Ann.ToString());
            //Console.WriteLine(Mary.ToString());



            //The task is to find if there is not corresponding ) for ( . 
            //Solution . The Match() function 
            //1. We declare count that will show us the result
            //2. if the current char item is ( so the count ++
            //3. else if the current element is ) the count --
            // if the count  < 0 means that there were more ) than expected 
            // id the count >1 it will be ment that there were more ( in text 
            

            string text = "Lorem Ipsum is simply ( dummy ( text of the  printing and typesetting industry ). Lorem Ipsum ( has been the industry's standard dummy text ever since the 1500s," +
                " ( when an unknown printer )" +
               "  (took a galley ( of type and scrambled it to make a type specimen ) book. It has survived not only five centuries, but also the leap into electronic typesetting, " +
               "  remaining essentially unchanged.  It was popularised ( in " +
                "the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions" +
                " of Lorem Ipsum.";


                 //Console.WriteLine(Match(text));
                // MatchSentence(text);
               //Second way to separate the string to sentences
              //Separate(text);
             //FindMissingbracket(text);
            // FindingMissingBracketInText( text);


            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int dec = 0;
            if(a > b)
            {
                dec = a - b;
                a = a - dec;
                b = b + dec;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }

            else if( a < b)
            {
                dec = b - a;
                a = a + dec;
                b = b - dec;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }

             ConvertString(textToChange);
          
            textToChange =  textToChange.Replace("Hallo", "Hallo :)");           
            textToChange = textToChange.Replace("By", "From");
            Console.WriteLine(textToChange);

         
            string textToChange = "It Hallo "+"lorem ipsum' Hallo World sometimes By accident, Hallo sometimes on purpose" +
                                    " injected humour and the like.lalalla.";

            AddingSmileToHallo(textToChange);




            //  Task Christmast Tree

            int heightOfTree = Convert.ToInt32(Console.ReadLine());

             //  DrawChristmastTreeSecond(heightOfTree);
            //  DrawThirdthTree(heightOfTree);
           // christmastTree(heightOfTree);                    
          //  TreeWithOnecircle( heightOfTree );
            //  TreeWithOneCircleSecond(heightOfTree);
           //  repeatMark(heightOfTree);
          //    repeatMarkSecond(heightOfTree);


           Stopwatch sw = new Stopwatch();
            sw.Start();
           
            sw.Stop();
           //Console.WriteLine("Time Taken-->{0}", sw.ElapsedMilliseconds);



         


            // Working With classes , Direved classes and Base Classes



            Family Ashot = new Father();
            Ashot.Memeber();
            Ashot.AddChild = 5;
            Console.WriteLine("Hey i  already have  "+ Ashot.AddChild + "  children");

            Father Stepan = new Father();
            Stepan.CreateFamilyForFather(5,2,1,true);

      

            // Tasks of HackerRank 
            //Inheritance

            //Fiirst Line of input
            string[] input = Console.ReadLine().Split();
            string firstname = input[0];
            string lastname = input[1];
            int id = Convert.ToInt32(input[2]);
            //SecondLine of Input 
            int numScores = Convert.ToInt32(Console.ReadLine());
            input = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
               scores[i] = Convert.ToInt32(input[i]);
            }
            Student s = new Student(firstname, lastname, id, scores);
            s.printPerson();
           Console.WriteLine("Grade: " + s.Calculate() + "\n");
 



            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();




            //2D Arrays 

            int[][] arr = new int[6][];
            for(int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int[] sum = new int[16];
            int h = 0;
        
            for (int  i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum[h] = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                    + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1]
                    + arr[i + 2][j + 2];
                    h++;
                }
            }
            Array.Sort(sum);
            Console.WriteLine(sum[15]);



            //Dictionaries and Maps



            Dictionary<string, int> myDic = new  Dictionary<string, int>();
            int n = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[n];
            int phone;
            string name;
            for(int i = 0; i< n; i++)
            {
                 names = Console.ReadLine().Split();
                name = names[0];
                phone = Convert.ToInt32(names[1]);
                myDic.Add(name, phone);
            }

         string[] checkname = new string[n];
         for( int j = 0; j< n; j++)
         {
              checkname[j] =  Console.ReadLine();
                
         }


         for(int i = 0; i< checkname.Length; i++)
            {
                KeyValuePair<string, int> kvp;
                if (myDic.ContainsKey(checkname[i]))
                {
                    int key = myDic[checkname[i]];

                    Console.WriteLine("{0} = {1}",  checkname[i] , key );
                }
                else Console.WriteLine("Not Found");

            }

         


            //Working with delegate

            DelegateToDeclear DCall = new DelegateToDeclear();
            DCall.DelFunction();
            DCall.DelFunction2(FunctionsToCallClass.SayHallo);
            DCall.DelFunction2(delegate (string s) { Console.WriteLine(s); });
            DCall.DelFunction2((s) => { Console.WriteLine("Lambda Expression. Working with Delegate Types "); });
          



            //Working with Exceptions/Calculator class with a single method

            Calculator myCalculator = new Calculator();
             int T = Int32.Parse(Console.ReadLine());
            while(T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int result = myCalculator.Power(n, p);
                    Console.WriteLine(result);

                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.WriteLine("Nothing can stop me");//Finally work Always. if the exceptions will be thrown or not . it doesnt matter.
                }


            }
       

            //Quseus and stacks (HackerRank)

            string palidromString = Console.ReadLine();
            Solution obj = new Solution();
            foreach (char c in palidromString)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }
            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < palidromString.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", palidromString);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", palidromString);
            }
    
             //TaskS of HackerRank  /String Tasks
            //Super Reduced String
           string stringToReduce = Console.ReadLine();
           string result = superReducedString(stringToReduce);
           Console.WriteLine(result);
                  

            //TaskS of HackerRank /  CamelCase
            string s = Console.ReadLine();
            int  result = camelcase(s);
            Console.WriteLine(result);
         

            //TaskS of HackerRank /  Sherlock and the Valid String
             string s = Console.ReadLine();
             string result = isValid(s);
            Console.WriteLine(result);

            //HackerRank/Working with  Interfaces

            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new CalculatorI();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmet  " + sum);
            Console.ReadLine();                         
 
            //HackerRank Tasks /Funny String

             int q = Convert.ToInt32(Console.ReadLine());

                for (int qItr = 0; qItr < q; qItr++)
                {
                    string s = Console.ReadLine();

                    string result = funny(s);

                Console.WriteLine(result);
                }
        
            //HackerRank Tasks/ Game of Stones

            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i< n; i++)
            {
                int testnum = Convert.ToInt32(Console.ReadLine());
                string result = gameOfStones(testnum);
                Console.WriteLine(result);
            }

    
            // HackerRank Tasks /Alice and Bob's Silly Game

            int g = Convert.ToInt32(Console.ReadLine());

            for (int gItr = 0; gItr < g; gItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                string result = sillyGame(n);

                Console.WriteLine(result);
            }
            
            //HackerRank
            try
            {

                int numVal = Int32.Parse(Console.ReadLine());           
                Console.WriteLine(numVal);
            }
            catch 
            {
                Console.WriteLine("Bad String");
            }

    */





            

           


        }






        //ChirstmastTree

        //ChristmastTree with one circle without string .

        static void repeatMarkSecond(int height)
        {
            for(int i = 1 ; i<= height; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat(" ",height-i)) + string.Concat(Enumerable.Repeat("*", i )));

            }
        }
        static void repeatMark(int height)
        {
            for(int i = 1; i<= height; i++)
            {
               Console.WriteLine(string.Concat(Enumerable.Repeat("*", i)));
            }
        }
        static void TreeWithOneCircleSecond(int height)
        {
            for(int i = 1; i<= height; i++)
            {
                Console.WriteLine( new string(' ' , height-i) +  new string('*' , i)  );
                

            }
        }
        static void TreeWithOnecircle( int height  )
        {
                
            for (int i = 1; i <= height; i++)
                {
                    Console.WriteLine( new string ('*' , i));                                     
            }
          


             
            
        }

        //ChristmasTree with one circle .Using string
        static void christmastTree(int height)
        {
            string draw = " ";

            for(int i = 1; i <= height; i++)
            {
                draw = draw.Insert(i , "*");
                Console.WriteLine(draw);
                //Console.WriteLine();
            }
        }

        static void TreeStringB(int height)
        {
            StringBuilder draw = new StringBuilder();

            for (int i = 1; i <= height; i++)
            {
                draw = draw.Append("*");
                Console.WriteLine(draw);
                //Console.WriteLine();
            }
        }

        //ChristmastTree with two and more  circles. 
        static void DrawThirdthTree(int height)
        {
            for (int i = height; i >= 1; i--)
            {

                 for (int j = height - i ; j >= 1; j=j-1)
                {
                    Console.Write(" ");
                }

                for (int j = i; j >= 1; j--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
    
            }
        }
        static void DrawChristmastTreeSecond(int height)
        {
            for(int i = 1; i <= height; i++ )
            {
                for(int j = 1 ; j <= height-i ; j++)
                {
                    Console.Write(" ");

                }
                for (int j = 1; j < i + 1; j++)

                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }

        static void DrawChristmastTree(int height)
        {


            for(int i = 1; i <= height; i++)
            {

           for(int j = 1; j < i+1  ; j++)

                {
                    Console.Write("*");
                  
                }
                Console.WriteLine();
            }


        }


   // IF after hallo word there is world word so dont change Hallo else change Hallo to Hallo:)
     static void AddingSmileToHallo(string text)
             {
            int indexOfHallo = text.IndexOf("Hallo");

            int count = text.Length;
         

            do {

                if (text.IndexOf("Hallo", indexOfHallo, count - indexOfHallo) != -1)
                {        
                    if (text.IndexOf("World", indexOfHallo, 11 ) != -1)
                    {
                        string getNextHallo = text.Substring(indexOfHallo + 7);
                        indexOfHallo = indexOfHallo + 7 + getNextHallo.IndexOf("Hallo");
                    }
                    else
                    {
                    text = text.Insert(indexOfHallo + 5, ")");
                    string getNextHallo = text.Substring(indexOfHallo + 7);
                    indexOfHallo = indexOfHallo + 7 + getNextHallo.IndexOf("Hallo");
                    }              
                }

                else
                    indexOfHallo = indexOfHallo + 1;
                                                              
            } 
            while (count-indexOfHallo >0);

            Console.WriteLine(text);


        }

     //Change the string the following way => after all Hallo words add smile :) , and replace all BY words with From;
     static void ConvertString(string text)
        {
            List<string> wordsofText = new List<string>();
            string[] words = text.Split(' ');
            string smile = "Hallo:)";
            string Hallo = "Hallo";
            foreach( var word in words)
            {
                if(word == Hallo)
                {                
                    wordsofText.Add(smile);
                }
                else 
                    if(word == "By")

                     wordsofText.Add("From");

                else

                    wordsofText.Add(word);
           
            }

            string combindedString = string.Join(" ", wordsofText);
            Console.WriteLine(combindedString);
            

        }

     //Using Collections for Brackets task

      static void FindingMissingBracketInText(string text)
        {
         SortedList<int, char>  BracketCollections = new SortedList<int, char>();
            int startIndexofSentence = 0;
            int lastIndexofSentence = 0;
            do
            {
                lastIndexofSentence = text.IndexOf(".", startIndexofSentence);
                if(lastIndexofSentence > 0)
                {
                    for( int i = startIndexofSentence; i<lastIndexofSentence; i++)
                    {
                        if(text[i] == '(')
                        {
                            BracketCollections.Add(i, '(');
                        }
                        if (text[i] == ')')
                        {
                            BracketCollections.RemoveAt(BracketCollections.Count - 1);
                        }
                    }
                    if (BracketCollections.Count != 0) {
                  
                        foreach(KeyValuePair<int, char> element in BracketCollections)
                        {
                        Console.WriteLine("The index of ( you are missing to close is " + " " +  element.Key + " ");

                        }
                       
                        break;
                    }
                    else
                    {
                        startIndexofSentence = startIndexofSentence + lastIndexofSentence;
                    }
                  
                }
            }
            while (lastIndexofSentence > 0);
         

        }
     //This function is to find the missing ) for each sentence and write its index. 

      static void FindTheIndexofMissing(string text , ref int  countRow)
        {
            countRow++;
            int indexOfMissing = 0;
            int count = 0;
            foreach(var c in text)
            {

               if( c == '(')
                {
                    count++;
                    indexOfMissing = text.IndexOf(c);
                }
               if(c == ')')
                {
                    count--;                    
                }
            }

            if (count < 0 || count >= 1)
            {
                Console.WriteLine("The index of ( you are missing to close is " + " " + indexOfMissing + " " + "in "+ countRow +" row");
            }
            
                    

        }

     //This function is to find the missing ) in text when it first meet the ( that doesnt have closing bracket .
     static void FindMissingbracket(string text)
        {
            int position = 0;
            int start = 0;
            int count = 0;
            int indexOfBracket = 0;
            do
            {
                position = text.IndexOf(".", start);
                if(position >= 0) {
                    
                  for( int i = start ; i < position; i++)
                    {
                        if(text[i] == '(')
                        {
                            count++;
                            indexOfBracket = i;
                        }
                        if (text[i] == ')')
                        {
                            count--;
                        }
                    }
                    if (count < 0 || count >= 1)
                    {

                        Console.WriteLine("The index of ( you are missing to close is " + " " + indexOfBracket);
                        break;
                    }
                    else start = start + position + 1;

                }
            }
            while (position > 0);
        }

      // separate the string to sentences the easiest( second ) Way
      static void Separate(string text)
        {

            var sentences = new List<String>();
            int position = 0;
            int start = 0;
         
            do
            {
                position = text.IndexOf('.', start);
                if (position >= 0)
                {
                    sentences.Add(text.Substring(start, position - start + 1).Trim());
                    start = position + 1;
                }
            } while (position > 0);

      
            foreach (var sentence in sentences)
                Console.WriteLine(sentence);


        }

     // separate the string to sentences
      static void MatchSentence(string text)
        {
            String pattern = @"\. ";
            
            String[] elements = System.Text.RegularExpressions.Regex.Split(text, pattern);
             int  countRow = 0;
            foreach (string element in elements)
            {

                //Console.WriteLine(element);
                //Console.WriteLine(Match(element));              
                FindTheIndexofMissing(element , ref countRow);

            }
        }

     //Finding missing ( in text 
       static string Match(string text)
        {
            int count = 0;
         foreach(char c in text)
            {
                if (c =='(')
                {
                    count = count + 1;
                }
                if( c == ')')
                {
                    count = count - 1;
                }

            }
            if (count < 0 || count >= 1)
            {
                return " You are missing smth";
            }
            else 
                return "All is okay ";
        }





        //Tasks from HakerRank Account
        static void ChangeMyInt(MyInt2 ShortItem2)
        {
            Console.WriteLine(ShortItem2);
            MyInt2 parentitem = new MyInt2();
            parentitem.SwitchMyShortInts(ref ShortItem2);
            Console.WriteLine(ShortItem2);

        }
        public static void GetStringBuilder(StringBuilder n)
        {
            Console.WriteLine(n);
            n.Append("tralala");
            Console.WriteLine(n);
        }
        public static void GetString(string n)
        {
            Console.WriteLine(n);
            n = "bbbb";
            Console.WriteLine(n);
        }
        static string timeConversion(string s)
        {
            string StringToNewString, ChangeString;
            int StringToInt;

            //remove the specific chars
            ChangeString = s.Replace(":", "");

            //remove am  , pm 
            char AmPm = ChangeString[6];

            if (AmPm == 'a' || AmPm == 'A')
            {
                StringToNewString = ChangeString.Remove(2, 6);
                StringToInt = Int32.Parse(StringToNewString);
                if (StringToInt < 12)
                {
                    if (StringToInt != 11 || StringToInt != 10)
                    {

                        StringToNewString = Convert.ToString(StringToInt);
                        StringToNewString = String.Concat("0", StringToNewString);
                    }
                    else
                        StringToNewString = Convert.ToString(StringToInt);
                }
                else StringToNewString = "00";
            }
            else
            {
                //get the two beggining chars in new string  to convert it
                StringToNewString = ChangeString.Remove(2, 6);
                //convert  to int and plus 12
                StringToInt = Int32.Parse(StringToNewString);
                if (StringToInt < 12)
                {
                    StringToInt = StringToInt + 12;
                    //convert it back to string 
                    StringToNewString = Convert.ToString(StringToInt);

                }
                else StringToNewString = "12";
            }

            // replace new string  to the old string
            s = s.Remove(0, 2);
            s = s.Remove(6, 2);
            s = String.Concat(StringToNewString, s);


            return s;
        }
        static List<int> ShowGrades(List<int> gradeList)
        {
            List<int> NewGradeList = new List<int>();
            foreach (int c in gradeList)
            {
                if (c < 38)
                {
                    NewGradeList.Add(c);

                }
                else if (c >= 38 && c < 95)
                {
                    int markGrade = c % 10;
                    if (markGrade != 0 || markGrade != 5)
                    {
                        int checkgrade = c % 5;
                        int newgrade = c + (5 - checkgrade);
                        if (newgrade - c < 3)
                        {
                            NewGradeList.Add(newgrade);
                        }
                        else
                        {
                            NewGradeList.Add(c);
                        }
                    }

                }

                else if (c >= 95)
                {
                    NewGradeList.Add(c);
                }


            }

            return NewGradeList;

        }
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {


            int countapples = 0;
            int countoranges = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                if ((apples[i] + a) >= s && (apples[i] + a) <= t)
                {
                    countapples++;

                }

            }
            for (int i = 0; i < oranges.Length; i++)
            {
                if ((oranges[i] + b) >= s && (oranges[i] + b) <= t)
                {
                    countoranges++;

                }

            }

            Console.WriteLine(countapples);
            Console.WriteLine(countoranges);


        }
        static bool kangaroo(int x1, int v1, int x2, int v2)
        {
 
            if (v2 >= v1 & x2 > x1 || v2 <= v1 & x2 < x1)
            {
                return false;
            }
            else if (((v1 != v2) && ((x2 - x1) % (v1 - v2)) == 0))
            {
                return true;     
              }

            else return false;



        }
        static string superReducedString(string s)
        {                  
            for(int i = 1; i < s.Length; )
            { 
                if (s[i] == s[i - 1])
                {
                    s = s.Remove(i-1 , 2);
                    i = 1 ;
                }
                else i++;
                  }
          if (s.Length == 0) return "Empty String";
            else
            return s;
         
        }
        static int camelcase(string s) 
        {    int countWords = 0;       
           for(int i = 1; i< s.Length; i++)
            {
                char c = s[i];
                if(char.IsUpper(c))
                {
                    countWords = countWords +1 ;
                }
            }
            return countWords + 1 ;
        }
        static string isValid(string s)
        {
          // This Task still need to be verify
           int countEqualNums = 0;
           int differNum = 0;
            List<int> CountCharsApearance = new List<int>();
            for(int i = 0; i < s.Length; i++)
            {
              CountCharsApearance.Add(s.Split(s[i]).Length - 1);
              if(i != s.Length - 1)
                {
                if (s[i] == s[i  + 1])
                {
                   s =  s.Remove(i, 1);
                }
              }
            }
            int count = CountCharsApearance.Count;
            CountCharsApearance.Sort();
    
            for(int i = 1; i<= CountCharsApearance.Count-1; i++)
            {

                if(CountCharsApearance[i] == CountCharsApearance[i - 1])
                    {  countEqualNums = countEqualNums + 1;
                       }
                 else
                    {
                      if(CountCharsApearance[i] == CountCharsApearance[i-1] + 1)
                        {
                            differNum = differNum + 1;
                            CountCharsApearance.RemoveAt(i);
                            i = i-1;
                        
                        } 
                    }

                             
            }

            /*

            for(int i = 0; i< CountCharsApearance.Count; i++)
            {
                Console.WriteLine(CountCharsApearance[i]);

            }
            */

            Console.WriteLine(countEqualNums + "  Equal");
            Console.WriteLine(differNum + "  Different");


            if (countEqualNums == count - 1 )
                return "yes";
          else if (countEqualNums == count - 2 && differNum == 1)
                return "yes";
            else if(differNum > 2 && countEqualNums==0)
                return "yes";

            else
                return "No";

                    
        }
        static string funny(string s)
        {   

            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            byte[] asciiBytesReverse = Encoding.ASCII.GetBytes(charArray);

            for(int i = 0; i< s.Length-1; i++)
            {
                if (Math.Abs(asciiBytes[i + 1] - asciiBytes[i]) == (Math.Abs(asciiBytesReverse[i + 1] - asciiBytesReverse[i])))
                {
                 continue;
                }
                else
                    return "Not Funny";
             /*
              Console.WriteLine(asciiBytes[i + 1] - asciiBytes[i]);
              Console.WriteLine(Math.Abs(asciiBytesReverse[i + 1] - asciiBytesReverse[i]));
             */
            }
              
         return " Funny";
        }
        static string gameOfStones(int n)
        {
            if( n % 7 == 1 || n % 7 == 0)return "Second";
            else return "First";
            
        }
        static string sillyGame(int n)
        {
            // This Task still need to be verify
            int count = 0;
            List<int> GameArray = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                GameArray.Add(i);
            }

            for (int i = 1; i <= n; i++)
            {
                if (isPrime(i))
                {                  
                    count++;
                }
            }

            if (count % 2 == 0) return "Alice";
            else return "Bob";


        }
        static bool isPrime(int n)
        {
            int m = n / 2;
            int flag = 0;
            for (int i = 2; i <= m; i++)
            { if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                return true;
            else return false;

        }







    }






}

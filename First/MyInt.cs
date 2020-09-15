using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class MyInt
    {
        private bool _stateChanged = false;

        private int _count;

        public int Count
        {
            get { return _count; }
            set
            {
                if (this._count < 0)
                {
                    _stateChanged = true;
                    _count = 0;
                }
                _count = value;
            }
        }


        public static int Counter;

        public MyInt()
        {
            _count = -1;
        }

        public MyInt(int count) : this()
        {
            _count = count;


        }
    }
    public class Person
    {

        protected int _age;
        protected bool _study;
        protected bool _work;
        protected bool _married;
        protected string _gender;
        protected int _children;

        public Person()
        {
            _age = 12;
            _children = 0;
            _married = false;
            _gender = "other";
            _work = true;
            _study = false;
            Console.WriteLine("Hi i am a new Person object");

        }

        public Person(int child, bool marry, bool job, string gender, int age)
        {
            _age = age;
            _children = child;
            _married = marry;
            _gender = gender;
            _work = job;


        }


        public virtual void Child()
        {
            Console.WriteLine("I am good Father ");

        }

        public bool PorpertyStudy
        {
            get { return _study; Console.WriteLine("i dont study"); }
            set
            {
                _study = value;
                if (value)
                    Console.WriteLine("Yes, I am a student  ");
                else
                    Console.WriteLine("No. I dont wanna study  ");

            }
        }

    }
    public class Parent : Person
    {
        protected int countSon;


        public Parent(int count)
        {
            this.countSon = 1;
            //Console.WriteLine("Parent Construtor Call");
        }
        public Parent()
        {
            this.countSon = 0;
        }

    }
    public class Son : Parent
    {
        public Son(int count) : base(count)
        {
            Console.WriteLine("Son contrusctor Call");
        }

        public Son() : base(0)
        { }

        public override void Child()
        {

            Console.WriteLine("I am my Dads son ");

        }
        public void SonOwn()
        {
            Console.WriteLine("This is my own method");
        }
    }
    public class Daughter : Person
    {

        public Daughter(int child, bool marry, bool job, string gender, int age) : base(child, marry, job, gender, age)
        {
            Console.WriteLine("Daughter constructor call");
        }
        public Daughter() { }

        public override void Child()
        {
            Console.WriteLine("I am my brothers sister ");
        }
    }


    // working with steack and heap 

    public class MyInt2
    {

        private int _num = 0;
        public int AddFive(int Pvalue)
        {
            int result;
            result = Pvalue + 5;
            return result;

        }
        public int Go
        {
            get { return _num; }
            set
            {
                int result = AddFive(_num + value);
                Console.WriteLine(result.ToString());
            }
        }
        //call the stck to name our numbers 

        public void CallStruck(string NameVal)
        {
            MyStruck name = new MyStruck(NameVal);
            Console.WriteLine(name.title);
            NameMystruck(ref name);
            Console.WriteLine("<" + name.title + ">" + " Woooow ,  what an awesome name .");

        }
        protected virtual string NameMystruck(ref MyStruck x)
        {
            x.title = Console.ReadLine();
            return x.title;

        }


        public void SwitchMyShortInts(ref MyInt2 ObjectInt)
        {

            ObjectInt = new MyShortInt3();
        }
    }
    public struct MyStruck
    {
        public string title;
        public MyStruck(string name)
        {
            title = name;
        }

    }

    public class MyShortInt2 : MyInt2
    {

    }

    public class MyShortInt3 : MyInt2
    {

    }


    public class Woman
    {

        public string name;
        public int age;
        public Shoes LeftShoe;
        public Shoes RightShoe;


        public Woman CopyWomen()
        {
            Woman lady = new Woman();
            lady.name = name;
            lady.age = age;
            lady.LeftShoe = new Shoes();
            lady.RightShoe = new Shoes();
            lady.LeftShoe.Color = (LeftShoe.Clone() as Shoes)?.Color;
            lady.RightShoe.Color = RightShoe.Clone() as string;
            return lady;

        }
        public override string ToString()
        {
            return (name + " : Heeey, I have a " + RightShoe.Color + " shoe on my right foot, and a " + LeftShoe.Color + " on my left foot.");
        }

    }
    public class Shoes : ICloneable
    {
        public string Color;
        public object Clone()
        {
            Shoes newShoes = new Shoes();
            newShoes.Color = Color.Clone() as string;
            return newShoes;
        }

    }



    // Base Classes , direved Classes 

    public class Family
    {
        private int _memebers;
        private int _femaleCount;
        private int _maleCount;
        private bool _married;
        public Family()
        {
            _memebers = 0;
            _femaleCount = 0;
            _maleCount = 0;
            _married = false;
            Console.WriteLine("Hi, I am the constructor of Family Base class!");
        }

        public int AddChild { get { return _memebers; } set { if (value > 0) _memebers = value; } }

        protected void CreateFamily(int memebers, int femalecount, int malecount, bool married)
        {
            _memebers = memebers;
            _femaleCount = femalecount;
            _maleCount = malecount;
            _married = married;
            Console.WriteLine("Congratulations !! Now you have Family!");
            Console.WriteLine("Your Family consist of  " + _memebers + " members.There is " + _femaleCount + "  Females , " + _maleCount + "  Males" + "and finally you are " + _married);
        }
        public virtual void Memeber()
        {
            Console.WriteLine("This Method is for Family memebers.");
        }

    }
    public class Father : Family
    {
        public Father()
        {
            Console.WriteLine("Hi, I am Father derived class constructor!");
        }

        public override void Memeber()
        {

            base.Memeber();
            Console.WriteLine("Hi, i am The Father");
        }

        public void CreateFamilyForFather(int member, int femalecount, int malecount, bool married)
        {


            base.CreateFamily(member, femalecount, malecount, married);


        }



    }
    public class FatherSon : Family
    {
        public FatherSon()
        {
            Console.WriteLine("Hi, I am  ther derived class from my Father class");
        }
        public override void Memeber()
        {
            base.Memeber();

            Console.WriteLine("Hi , i am the Son ");
        }
    }




    //Inheritance Hackerrank 
    public class Persons
    {
        protected string firstname;
        protected string lastname;
        protected int id;

        public Persons(string name, string fname, int idi)
        {
            firstname = name;
            lastname = fname;
            id = idi;
        }
        public Persons() { }
        public void printPerson()
        {
            Console.WriteLine(firstname + " " + lastname + " " + id);
        }




    }
    public class Student : Persons
    {
        private int[] testScores;

        public Student(string name, string lastname, int id, int[] scores) : base(name, lastname, id)
        {
            testScores = scores;


        }
        public string Calculate()
        {

            int sum = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
                sum = sum + testScores[i];
            }
            sum = sum / testScores.Length;


            if (sum <= 100 && sum >= 90)

                return "O";
            if (sum < 90 && sum >= 80)

                return "E";
            if (sum < 80 && sum >= 70)

                return "A";
            if (sum < 70 && sum >= 55)

                return "P";
            if (sum < 55 && sum >= 40)

                return "D";
            if (sum < 40)

                return "T";

            return "ss";


        }




    }
    public abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();

    }
    public class MyBook : Book
    {
        protected int price;
        public MyBook(string title, string author, int priceI) : base(title, author)
        {
            price = priceI;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + base.title);
            Console.WriteLine("Author: " + base.author);
            Console.WriteLine("Price: " + price);


        }


    }


    //Delagate 
    public delegate void DelegateSignatureExample(string FunctionParam);
    public class DelegateToDeclear
    {

        public void DelFunction()
        {
            FunctionsToCallClass obj1 = new FunctionsToCallClass();

            DelegateSignatureExample DExample1 = new DelegateSignatureExample(FunctionsToCallClass.SayHallo);
            DExample1("Hallo) I am your First delegate");


            DelegateSignatureExample DExample2 = new DelegateSignatureExample(obj1.SayHalloNoStatic);
            DExample2("Heyyy, Dont Forget Me. I am not static method and you Second Delagate"); // we call delegate
            DExample2 += FunctionsToCallClass.SayHallo;
            // DExample2("Hey , How Are You ?");

        }

        public void DelFunction2(DelegateSignatureExample DCall)
        {
            DCall("Hallo . I am Another Way To Use delegate . ");
        }

    }
    public class FunctionsToCallClass
    {
        public static void SayHallo(string ParamS)
        {
            Console.WriteLine(ParamS + "  Func1");
        }
        public void SayHalloNoStatic(string Param)
        {
            Console.WriteLine(Param + "   Func2");
        }
    }

    //Exception
    public class Calculator
    {
        public int Power(int n, int p)
        {
            int S = 1;
            if (n < 0 || p < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
            else
            {
                for (int i = 1; i <= p; i++)
                {
                    S = S * n;
                }
            }
            return S;
        }

    }

    // Stacks and queuses
    public class Solution
    {
        public Queue<char> myQueue = new Queue<char>();
        public Stack<char> myStacky = new Stack<char>();

        public void pushCharacter(char c)
        {
            myStacky.Push(c);
        }
        public void enqueueCharacter(char c)
        {
            myQueue.Enqueue(c);
        }

        public char popCharacter()
        {
            return myStacky.Pop();
        }
        public char dequeueCharacter()
        {
            return myQueue.Dequeue();
        }

    }

    //Interfaces 

    public interface AdvancedArithmetic
    {
        int   divisorSum(int n);
    }
    public class CalculatorI : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            for(int i = 1; i<= n/2; i++)
            {
                if (n % i == 0)
                    sum = sum + i;
            }

            return sum +n;
        }
    }


    //Task/ Linked List


    public class Node
    {
        //properties
        //the referance
        Node next;
        int data;

        //methods
        //constructors
        public Node( int newData)
        {
            next = null;
            data = newData;
        }

        public Node(int newData, Node nodeNext)
        {
            data = newData;
            next = nodeNext;
        }

        //getters and setters
        public int Getdata() {  return data;  }

        public Node GetNextNode() {  return next;  }

        public void Setdata(int value )
        {  data = value;  }


        public void SetNext(Node newNode)
        {
            next = newNode;
        }
    }


    public class LinkedList
    {
        //properties
        Node head;
        int count;

        //constructors
        public LinkedList(Node NewNode)
        {
            head = NewNode;
            count = 1;
        }
            
        //methods
        //add
        public void Add(int newData)
        {
            Node temp = new Node(newData);
            Node curennt = head;
            while(curennt.GetNextNode() != null)
            {
                curennt = curennt.GetNextNode();
            }
            curennt.SetNext(temp);
            count++;
        }


        //get
        //remove
        //size
        //empty

    }























}

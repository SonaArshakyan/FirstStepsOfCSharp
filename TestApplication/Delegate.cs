using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{

    //creating delegate . this call the function 

    public delegate void Caller(string val);

    //syntax

    public class DelegateExample
    {
        //how to use delegate  , initilize
        public static void CallSample()
        {
            //class Caller : System.Multicast:Delegate  / where it comes from.

            /*

            MyClass obj = new MyClass();
            Caller dCall = new Caller(MyClass.StaticCallMe);
            dCall += obj.CallMe;
            dCall += obj.CallMe;
            dCall -= obj.CallMe;

            //how to call the delgrate 
            dCall(5);

        
            MyClass obj = new MyClass();
            Caller dCall = null;
            dCall += obj.CallMe;          
            dCall(5);
          // dacall.Invoke(5) ; the way to call the delegate. it call the all functions that contain the delegate  in invoke list
            */
        }

        public static void FunctiinDelegateUse(Caller D)
        {
            D("stringD");
        }


    }

    public class MyClass
    {

        static void Main1()
        {
            DelegateExample.FunctiinDelegateUse(FunctionToCall);
            DelegateExample.FunctiinDelegateUse(delegate (string s) { Console.WriteLine(s); }); //this function doesnt have name 
            DelegateExample.FunctiinDelegateUse((s) => { Console.WriteLine(s); });  // lambda Expression 

        }

        public static void FunctionToCall(string Param)
        {
            Console.WriteLine(Param);
        }





        public void CallMe(int count)
        {
            Console.WriteLine(" No static function " + count);
        }
        public static void StaticCallMe(int count)
        {
            Console.WriteLine(" Static function " + count);

        }

    }

}

//Write a program.
//In the  base class is declared   as  public integer variable "k" and declared   constructor with one integer  parameter, which is use to initialize the k variable.In the class declared as public method by name f(int d) { }
//with one integer parameter, and which has been declared and initialized String type array with 10 values.In method f() need find the values of array, that length are bigger "k" parameter and print these values.In inherited class  is declared int k variable, which initialized by constructor of derived class, and inside of this class declared method by name show() { }
//that prints sum of k variable from base class and variable with the same name of inherited class.

using System;

namespace fourteen
{
    //base class
    class BaseClass{
        public int k;
        //constructor
        public BaseClass(int firstArg)
        {
            //initializing k by firstArg
            this.k = firstArg;
        }
        public void f(int d){ 
            //empty
            string[] items = new string[10]{
                "one","two","three","four","five","six","seven","eight","nine","ten"
            };

            for (int i = 0; i < 10; i++){
                if(i > d){
                    Console.WriteLine(items[i]);
                }
            }

        }
    }


    //program class
    class MainClass
    {
        public static void Main(string[] args)
        {
            //MainClass answer = new MainClass(10);
            //Console.WriteLine(answer.k);
            Console.WriteLine("Hello World!");
        }
    }
}

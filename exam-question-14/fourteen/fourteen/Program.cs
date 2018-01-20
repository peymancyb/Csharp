//Write a program.
//In the  base class is declared   as  public integer variable "k" and declared   constructor with one integer  parameter, which is use to initialize the k variable.In the class declared as public method by name f(int d) { }
//with one integer parameter, and which has been declared and initialized String type array with 10 values.In method f() need find the values of array, that length are bigger "k" parameter and print these values.In inherited class  is declared int k variable, which initialized by constructor of derived class, and inside of this class declared method by name show() { }
//that prints sum of k variable from base class and variable with the same name of inherited class.


//can not understand this part of the question!!!
//***that prints sum of k variable from base class and variable with the same name of inherited class.***

using System;

namespace fourteen
{
    //base class
    public class BaseClass{
        public int k;
        //constructor
        public BaseClass(int firstArg)
        {
            //initializing k by firstArg
            k = firstArg;
        }
        public void f(int d){ 
            //empty
            string[] items = new string[10]{
                "one","two","three","four","five","six","seven","eight","nine","ten"
            };
            if(d>10 || d<0){
                Console.WriteLine("not correct index!");
            }else{
            for (int i = d; i > this.k; i++)
                {
                    Console.WriteLine(items[i]);
                }
            }
        }
    }

    public class DerivedClass: BaseClass {
        //constructor
        //public int num;
        public DerivedClass(int num):base(firstArg:num){
            //empty
        }
        public void show(){
            Console.WriteLine("sum of base class");
        }
 
    }


    //program class
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //set k to 0
            DerivedClass ob = new DerivedClass(1);
            ob.f(9);
            ob.show();
        }
    }
}

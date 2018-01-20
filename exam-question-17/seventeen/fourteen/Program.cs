//Write a program.In class A need to declare method by name  public void f() { }.
//Inside of this method need declare string type of array with 5 values and initialized
//by  inserting family name and name of 5 students.Also declare in method another integer type array 
//with 5 elements, that contain information about the absents of each students from class. 
//All these values of both array need to enter from keyboard.Print the names of the students,
//whose the absents is larger that  int k number, which initialized by constructor  of A class.


using System;

namespace seventeen
{
    //base class
    public class A{
        public int k;
        public A(int num){
            k = num;
        }
        public void f(){
            //string type of array
            string[] arr = new string[5];
            //integer type of array
            int[] intArr = new int[5];

            Console.WriteLine("enter 5 students name : ");
            for (int i = 0; i < 5; i++){
                Console.Write(i+") ");
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("number of Absent of each students : ");
            for (int i = 0; i < 5; i++)
            {
                string userValue = Console.ReadLine();
                int userInt;
                //check if its number of not!
                if (int.TryParse(userValue, out userInt))
                {
                    intArr[i]=userInt;
                }
            }

            Console.WriteLine("===================");

            if(k>5 || k<0){
                Console.WriteLine("index is not in the range!");
            }else{
                for (int i = k; i < 5; i++)
                {
                    Console.WriteLine("Full name: " + arr[i] + " Absents: " + intArr[i]);
                }
            }

        }
    }

    //program class
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter minimum number of the absents:");
            int n;
            string num;

            num = Console.ReadLine();
            if(Int32.TryParse(num, out n)){
                A obj = new A(n);
                obj.f();
            }else{
                Console.WriteLine("enter a number please!");
            }
        }
    }
}

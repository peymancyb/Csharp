using System;

namespace calculator
{
    class Calculator{
      
        public void operation(){
            Console.WriteLine("*** Calculator ***");
		}
      
        public void CalCulate(int num1 , int num2 , int operate){
            int num3;
            switch(operate){
                case 1:
                    num3 = num1 + num2;
					Console.WriteLine(num3);
					break;

				case 2:
                    num3 = num1 * num2;
					Console.WriteLine(num3);
					break;

				case 3:
					num3 = num1 / num2;
					Console.WriteLine(num3);
					break;

				case 4:
					num3 = num1 - num2;
                    Console.WriteLine(num3);
					break;
				default:
                    break;
            }
        }
    }

    class MainClass
    {

        public static void Main(string[] args)
        {
			Console.WriteLine("Hello World!");

			Calculator ob = new Calculator();
            ob.operation();
            int a, b, c;


            Console.WriteLine("Enter your first number: ");
			a = int.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is: "+a);


			Console.WriteLine("Enter your second number: ");
			b = int.Parse(Console.ReadLine());
			Console.WriteLine("Your second number is: " + b);

            Console.WriteLine("Enter from following basic operations: \n 1)sumation \n 2)multiplication \n 3)divison \n 4)Subtraction ");
			c = int.Parse(Console.ReadLine());

  			Console.WriteLine();
			ob.CalCulate(a, b ,c);
        }
    }
}

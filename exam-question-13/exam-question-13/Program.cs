using System;

namespace examquestion13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] randomNum = new int[20];
            Random RandomNumber = new Random();

            for (int i = 0; i < 20; i++)
            {
                randomNum[i] = RandomNumber.Next(1, 20);
            }
            foreach (int j in randomNum)
            {
                Console.WriteLine(" Number:{0}", j);
            }
            //int count = 1;
            for (int i = 0; i < 20; i++){
                int numberOfRepetition = 0;
                for (int j = i + 1; j < 20; j++)
                {
                    if (randomNum[i] == randomNum[j])
                    {
                        numberOfRepetition++;
                    }
                }
                if(numberOfRepetition!=0 && numberOfRepetition>2){
                    Console.Write("number is:" + randomNum[i]);
                    Console.Write("         repeated:" + numberOfRepetition);
                    Console.WriteLine();
                }
            }
        }
    }
}

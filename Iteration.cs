using System;
using System.Globalization;
class IterationStatement
{
    static void Main()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnForLoop();
        iterationStatement.CheckEvenOdd();
        iterationStatement.LearnWhileLoop();


    }
    void LearnForLoop()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("I am a handsome guy  " + i);
        }
    }
    void CheckEvenOdd()
    {

        int[] numbers = { 34, 45, 67, 765, 40, 678, 98, 97 };
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }
    }

    void LearnWhileLoop()
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine("I am a handsome guy " + i);
            i++;
        }
    }

}

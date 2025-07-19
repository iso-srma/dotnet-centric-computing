using System;
using System.ComponentModel;
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
        Char conform = "y";
        while (conform == 'y')

        {
            Console.WriteLine("I am a handsome guy");
            Console.WriteLine("Do you want to continue? (y/n)");
            conform = Console.ReadKey().KeyChar;
            Console.WriteLine(); // To move to the next line after key press
            conform = char.ToLower(conform, CultureInfo.InvariantCulture);
            if (conform != 'y' && conform != 'n')       
        }
    }


}

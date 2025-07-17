using System;

class SelectionStatement
{
    static void Main()
    {
        SelectionStatement ss = new SelectionStatement(); // fixed typo: "newSelectionStatement" → "new SelectionStatement"
        ss.LearnIfElse();
    }

    void LearnIfElse()
    {
        Console.WriteLine("Enter a number between 1 and 100:");

        string input = Console.ReadLine();

        
        byte x = byte.Parse(input);

        if (x == 35)
        {
            Console.WriteLine("I am inside if statement");
        }
        else
        {
            Console.WriteLine("You didn't enter 35");
        }
    }
}

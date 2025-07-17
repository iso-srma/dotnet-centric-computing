using System;

class SelectionStatement
{
    static void Main32()
    {
        SelectionStatement ss = new SelectionStatement();
        ss.LearnIfElse();
        ss.LearnSwitch();
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
        else if (x < 35)
        {
            Console.WriteLine("You entered a number less than 35");
        }

        else
        {
            Console.WriteLine("You didn't enter 35");
        }
    }

void LearnSwitch()
{
    char option = 'y';

    switch (option)
    {
        case 'n':
            Console.WriteLine("You selected no option");
            break;

        case 'y':
            Console.WriteLine("You selected yes option");
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

}

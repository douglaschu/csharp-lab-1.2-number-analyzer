Console.WriteLine("Welcome to the Number Analyzer.");

Console.WriteLine($"\nPlease enter an integer between 1 and 100.");
int integer = int.Parse(Console.ReadLine());

bool runProgram = true;
while (runProgram)
{
    if (integer is int && integer > 0 && integer <= 100)
    {  
        //if even
        if (integer % 2 == 0)
        {
            if (integer >= 2 && integer <= 24)
            {
                Console.WriteLine($"\n{integer} is even and less than 25.");
            }
            else if (integer > 60)
            {
                Console.WriteLine($"\n{integer} is even and greater than 60.");
            }
            else if (integer >= 25 && integer <= 60)
            {
                Console.WriteLine($"\n{integer} is even and between 26 and 60 inclusive.");
            }
        }
        //if odd
        else 
        {
            if (integer < 60)
            {
                Console.WriteLine($"\n{integer} is odd and less than 60.");
            }
            else if (integer > 60)
            {
                Console.WriteLine($"\n{integer} is odd and greater than 60.");
            }
        }
    } else {
        Console.WriteLine("Invalid input.\nPlease enter an integer between 1 and 100.\n");
    }
        

        //While loop: Ask to run again or exit
        Console.WriteLine("Would you like to enter another number? y/n");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "n")
        {
            Console.WriteLine("Goodbye.");
            runProgram = false;
        break;
        } else if (choice == "y")
        {
            runProgram = true;
            break;
        }
        

} //end of while loop


//to keep terminal from closing when program runs on mac
Console.ReadLine();
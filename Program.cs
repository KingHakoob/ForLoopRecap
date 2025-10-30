Console.Clear();

string input = "";

do
{
    Console.WriteLine("Which For Loop would you like to see?");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("1.) Basic for loop (incrementing)");
    Console.WriteLine("2.) Basic for loop SLOWED");
    Console.WriteLine("3.) Basic for loop Detailed");
    Console.WriteLine("4.) For loop counting up to 10");
    Console.WriteLine("5.) For loop counting down from 10 (decrementing)");
    Console.WriteLine("6.) For loop iterating through a String");
    Console.WriteLine("7.) For loop iterating through an Array");
    Console.WriteLine("8.) Nested for loop");
    Console.WriteLine("9.) For loop iterating through an Array Detailed");
    Console.WriteLine("10.) For loop iterating through an Array Visual");
    Console.WriteLine();
    Console.WriteLine("Last Minute Additions");
    Console.WriteLine("11.) For Loop Incrementing by 5");
    Console.WriteLine("12.) Nested for loop - Grid Visual");

    Console.WriteLine("");

    input = Console.ReadLine();

    Console.WriteLine("\n**********\n");

    bool validResponse = int.TryParse(input, out int uc); // user choice

    if (!validResponse) uc = -1;

    switch (uc)
    {
        case 1:
            BasicForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 2:
            BasicForLoopSLOWED();
            Console.WriteLine("\n**********\n");
            break;
        case 3:
            BasicForLoopDetailed();
            Console.WriteLine("\n**********\n");
            break;
        case 4:
            CountUpForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 5:
            CountDownForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 6:
            StringIterationForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 7:
            ArrayIterationForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 8:
            NestedForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 9:
            ArrayIterationForLoopDetailed();
            Console.WriteLine("\n**********\n");
            break;
        case 10:
            ArrayIterationForLoopVisual();
            Console.WriteLine("\n**********\n");
            break;
        case 11:
            StepForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 12:
            NestedGridForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case -1:
        default:
            input = "exit";
            Console.WriteLine("Exiting program");
            break;
    }

} while (input != "exit");

static void BasicForLoop()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("i: " + i);
    }
}

static void BasicForLoopSLOWED()
{
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(500);
        Console.WriteLine("i: " + i);
    }
}

static void BasicForLoopDetailed()
{
    // Just a for loop with some extra Console WriteLines
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"The value of i: {i}");
        Thread.Sleep(300);
        Console.WriteLine($"Checking the condition for the next iteration: {i + 1} < 10 = {i + 1 < 10}");
        Thread.Sleep(300);

        if (i + 1 < 10)
        {
            Console.WriteLine("Continuing...");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine("End of loop");
            Thread.Sleep(2000);
        }
        Console.WriteLine("");
    }
}

static void CountUpForLoop()
{
      // Could also be: count < 11
    for (int count = 1; count <= 10; count++)
    {
        Console.WriteLine("Count: " + count);
    }
}

static void CountDownForLoop()
{
    for (int countDown = 10; countDown > 0; countDown--)
    {
        Console.WriteLine("Count Down: " + countDown);
    }
}

static void StringIterationForLoop()
{
    string word = "abcdefghijklmnopqrstuvwxyz";

    Console.WriteLine("string = \"" + word + "\";");

    for (int i = 0; i < word.Length; i++)
    {
        Console.WriteLine("Letter by letter: " + word[i]);
    }
}

static void ArrayIterationForLoop()
{
    string[] letters = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j"];
    Console.WriteLine("  array = [ \"a\", \"b\", \"c\", \"d\", \"e\", \"f\", \"g\", \"h\", \"i\", \"j\" ]");
    Console.WriteLine("indexes = [  0,   1,   2,   3,   4,   5,   6,   7,   8,   9 ]");

    Console.WriteLine("");

    for (int i = 0; i < letters.Length; i++)
    {
        Console.WriteLine("Letters[" + i + "]: " + letters[i]);
    }
}

static void NestedForLoop()
{
    // Lets count to ten, three times

    for (int i = 1; i < 4; i++) // For every iteration of this loop,
    {
        Console.WriteLine("First loop i: " + i);


        for (int j = 0; j < 10; j++) // this loop will run 10 times
        {
            Console.WriteLine(" j: " + j);
        }

        Console.WriteLine("");
    }
}

static void ArrayIterationForLoopDetailed()
{
    string[] letters = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j"];
    Console.WriteLine("  array = [ \"a\", \"b\", \"c\", \"d\", \"e\", \"f\", \"g\", \"h\", \"i\", \"j\" ]");
    Console.WriteLine("indexes = [  0,   1,   2,   3,   4,   5,   6,   7,   8,   9 ]");

    Console.WriteLine("");

    // Just a for loop with some extra Console WriteLines
    for (int i = 0; i < letters.Length; i++)
    {
        Console.WriteLine($"The current value of i: {i}");
        Console.WriteLine($"The current letter is: {letters[i]}");
        Thread.Sleep(300);
        Console.WriteLine($"Checking the condition for the next iteration: {i + 1} < {letters.Length} = {i + 1 < letters.Length}");
        Thread.Sleep(300);

        // Checking the condition of the for loops next iteration
        if (i + 1 < letters.Length)
        {
            Console.WriteLine("Continuing...");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine("End of loop");
            Thread.Sleep(2000);
        }
        Console.WriteLine("");
    }
}

static void ArrayIterationForLoopVisual()
{
    string[] letters = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j"];

    for (int i = 0; i < letters.Length; i++)
    {
        Console.Write("  array = [ ");
        // Loop is here to display the array of letters (but it is also iterating through them)
        for (int j = 0; j < letters.Length; j++)
        {
            if (j == letters.Length - 1)
            {
                if(i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\"*" + letters[j] + "*\" ];");
                    Console.ResetColor();
                }
                else Console.WriteLine("\"" + letters[j] + "\" ];");
            }
            else
            {
                if(i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\"*" + letters[j] + "*\", ");
                    Console.ResetColor();
                }
                else Console.Write("\"" + letters[j] + "\", ");
                
            }
        }
        Thread.Sleep(300);
        
        Console.Write("indexes = [ ");
        // Loop is here to display the array of indexes/values of j (but it is also iterating through them)
        for (int j = 0; j < letters.Length; j++)
        {
            if (j == letters.Length - 1)
            {
                if(i == j) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" *" + j + "*  ];");
                    Console.ResetColor();
                }
                else Console.WriteLine(" " + j + "  ];");
            }
            else
            {
                if(i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" *" + j + "*,  ");
                    Console.ResetColor();
                }
                else Console.Write(" " + j + ",  ");
                
            }
        }
        Thread.Sleep(300);

        // Checking the condition of the for loops next iteration
        if (i + 1 < letters.Length)
        {
            Console.WriteLine("Continuing...");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine("End of loop");
            Thread.Sleep(2000);
        }
        Console.WriteLine("");
    }
}

void StepForLoop()
{
    for (int i = 0; i <= 20; i += 5)
    {
        Console.WriteLine("i: " + i);
    }
}

void NestedGridForLoop()
{
    for (int i = 1; i <= 3; i++)
    {
        Console.Write("Row " + i + ": ");
        for (int j = 1; j <= 5; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}
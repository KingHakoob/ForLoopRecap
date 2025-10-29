Console.Clear();

string input = "";

do
{
    Console.WriteLine("Which For Loop would you like to see?");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("1.) Basic for loop (incrementing)");
    Console.WriteLine("2.) For loop counting up to 10");
    Console.WriteLine("3.) For loop counting down from 10 (decrementing)");
    Console.WriteLine("5.) For loop iterating through a String");
    Console.WriteLine("4.) For loop iterating through an Array");
    Console.WriteLine("6.) Nested for loop");
    Console.WriteLine("7.) Basic for loop SLOWED");
    Console.WriteLine("8.) Basic for loop Detailed");

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
            CountUpForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 3:
            CountDownForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 4:
            StringIterationForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 5:
            ArrayIterationForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 6:
            NestedForLoop();
            Console.WriteLine("\n**********\n");
            break;
        case 7:
            BasicForLoopSLOWED();
            Console.WriteLine("\n**********\n");
            break;
        case 8:
            BasicForLoopDetailed();
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

static void CountUpForLoop()
{
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

    Console.Write("array = [");
    // Loop is just here to display the array (but it is also iterating through them)
    for (int i = 0; i < letters.Length; i++)
    {
        if(i == letters.Length - 1) Console.WriteLine("\"" + letters[i] + "\" ];");
        else Console.Write("\"" + letters[i] + "\", ");
    }

    Console.WriteLine("");

    for (int i = 0; i < letters.Length; i++)
    {
        Console.WriteLine("Letters[" + i + "]: " + letters[i]);
    }
}

static void NestedForLoop()
{
    for (int i = 1; i < 4; i++)
    {
        Console.WriteLine("i: " + i);

        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine(" j: " + j);
        }

        Console.WriteLine("");
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
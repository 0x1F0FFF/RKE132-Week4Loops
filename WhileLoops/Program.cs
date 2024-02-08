Random rnd = new Random();

int cpuRandom;
bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make as guess, Enter a number 1 - 3: ");
    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Oops... Try again!");
    }
}


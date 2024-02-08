int sum = 0;

for (int i=1; i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum += i;
    Console.WriteLine($"After adding: {sum}");
}

Console.WriteLine($"Final total: {sum}");
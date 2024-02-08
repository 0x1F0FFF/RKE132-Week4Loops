Random rnd = new Random();

int myRandomNum = 0;
//int myRandomNum = rnd.Next(0, 11); // start ja lõpp punkt (11 ei kasuta, 10 max)
int randomSum = 0;

for (int i=0; i < 10; i++)
{
    myRandomNum = rnd.Next(0, 1001);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine(myRandomNum);
}

Console.WriteLine($"Total sum: {randomSum}");

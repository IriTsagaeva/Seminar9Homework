int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}


Console.WriteLine("Please, enter your number");
bool myFirstNumberConverted = Int32.TryParse(Console.ReadLine(), out int myFirstNumber);
Console.WriteLine("Please, enter your second number");
bool mySecondNumberConverted = Int32.TryParse(Console.ReadLine(), out int mySecondNumber);
if (mySecondNumberConverted && myFirstNumberConverted)
{
    if (myFirstNumber < 0 || mySecondNumber < 0)
    {
        Console.WriteLine("Incorrect numbers!!! Please, enter numbers > 0");
    }
    else
    {
        Console.WriteLine(Ackerman(myFirstNumber, mySecondNumber));
    }
}
else
{
    Console.WriteLine("Incorrect number!!!");
}

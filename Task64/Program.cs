void PrintNumbers(int number)
{
    if (number == 1)
    {
        Console.Write(number + " ");
        return;
    }

    Console.Write(number + " ");
    PrintNumbers(number - 1);
}

Console.WriteLine("Please, enter your number");
if (Int32.TryParse(Console.ReadLine(), out int myNumber))
{
    if (myNumber <= 0)
    {
        Console.WriteLine("Incorrect number!!! Please, enter number > 0");
    }
    else
    {
        PrintNumbers(myNumber);
    }
}
else
{
    Console.WriteLine("Incorrect number!!!");
}


int ReturnNumbersSum(int firstNumber, int secondNumber)
{
    int sum = firstNumber;
    if (firstNumber == secondNumber)
    {
        return sum;
    }
    else
    {
        return sum + ReturnNumbersSum(firstNumber + 1, secondNumber);
    }
}

Console.WriteLine("Please, enter your number");
bool myFirstNumberConverted = Int32.TryParse(Console.ReadLine(), out int myFirstNumber);
Console.WriteLine("Please, enter your second number");
bool mySecondNumberConverted = Int32.TryParse(Console.ReadLine(), out int mySecondNumber);
if (mySecondNumberConverted && myFirstNumberConverted)
{
    if (myFirstNumber <= 0 || mySecondNumber <= 0)
    {
        Console.WriteLine("Incorrect numbers!!! Please, enter numbers > 0");
    }
    else
    {
        if (myFirstNumber < mySecondNumber)
        {
            Console.WriteLine($"Sum = {ReturnNumbersSum(myFirstNumber, mySecondNumber)}");
        }
        else
        {
            Console.WriteLine($"Sum = {ReturnNumbersSum(mySecondNumber, myFirstNumber)}");
        }
    }
}
else
{
    Console.WriteLine("Incorrect number!!!");
}


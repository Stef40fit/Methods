//Write a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
//•	Read an integer number from the console
//•	Create a method called GetMultipleOfEvenAndOdds()
//•	Create a method GetSumOfEvenDigits()
//•	Create GetSumOfOddDigits()
//•	You may need to use Math.Abs() for negative numbers




int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);
int output = GetMultipleOfEvenAndOdds(number);
Console.WriteLine(output);

static int GetMultipleOfEvenAndOdds(int number)
{
    int sumEven = GetSumOfEvenDigits(number);
    int sumOdd = GetSumOfOddDigits(number);
    int result = sumEven * sumOdd;
    return result;
}

static int  GetSumOfEvenDigits(int number)
    {
    int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            number = number / 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }
        }
        return sum;
    }

static int GetSumOfOddDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number = number / 10;
        if (digit % 2 != 0)
        {
            sum += digit;
        }
    }
    return sum;
}
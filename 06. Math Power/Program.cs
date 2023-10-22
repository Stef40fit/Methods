//•	Reads two integer numbers from the console: base number and power
//•	Create a method, which receives two numbers as parameters:
//o The first number – the base
//o	The second number – the power
//•	The method should return the base raised to the given power

static int MathPower(int baseNumber, int powerNumber)
{
    int input = baseNumber;
   for (int i = 0; i < powerNumber - 1; i++)
    {
        input *= baseNumber;
    }
   return input;
}

int baseNumber = int.Parse(Console.ReadLine());
int powerNumber = int.Parse(Console.ReadLine());

int result = MathPower (baseNumber, powerNumber);



Console.WriteLine(result);
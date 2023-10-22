﻿//Write a program that:
//•	Reads an integer number N from the console
//•	Create a method that prints the sign of an entered number N:
//•	Print:
//o If the number is positive (N > 0): "The number {number} is positive."
//o If the number is negative (N < 0): "The number {number} is negative."
//o If the number is zero (N = 0): "The number {number} is zero."


static void PrintNumberSign(int number)
{
    if (number == 0) { Console.WriteLine($"The number {number} is zero."); }
    else if (number < 0) { Console.WriteLine($"The number {number} is negative."); }
    else { Console.WriteLine($"The number {number} is positive."); }
}
int number = int.Parse(Console.ReadLine());
PrintNumberSign(number);

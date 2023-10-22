//•	Reads a string on the first line from the console, representing a product - "coffee",  "water", "coke" or "snacks"
//•	Reads an integer on the second line from the console, representing the quantity of the product
//•	Create a method that calculates and prints the total price of an order
//•	The method should receive two parameters: product and quantity
//•	The prices for a single item of each product are:
//	coffee – 1.50
//	water – 1.00
//	coke – 1.40
//	snacks – 2.00
//•	Print the result, rounded to the second decimal place


string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double result = CalculatePrice(product, quantity);
Console.WriteLine($"{result:f2}");


static double CalculatePrice(string product, int quantity)
{
    double result = 0;

    if (product == "coffee")
    {
        result = quantity * 1.50;
    }
    else if (product == "water")
    {
        result = quantity * 1.00;
    }
    else if (product == "coke")
    {
        result = quantity * 1.40;
    }
    else if (product == "snacks")
    {
        result = quantity * 2.00;
    }

    return result;
}
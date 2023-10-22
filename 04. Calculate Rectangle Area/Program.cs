//•	Reads two integer numbers from the console: width and length
//•	Create a method which returns rectangle area with given width and length
//Hint: Rectangle area can be calculated when you multiply width and length of the rectangle. 
static int CalcRectArea(int w, int l)
{
    return w * l;
}
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int area = CalcRectArea(width, length);
Console.WriteLine(area);





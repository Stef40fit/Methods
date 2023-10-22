//•	Reads a text (string) and repeat count (integer number) from the console
//•	Write a method that receives a string and a repeat count 
//•	The method should return a new string, containing the initial one, repeated count times without space
static string RepeatText(string text, int count)
{
    string output = "";
    for (int i = 0; i < count; i++)
    {
        output += text;
    }
    return output;
}

string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

string result = RepeatText(text, count);



Console.WriteLine(result);
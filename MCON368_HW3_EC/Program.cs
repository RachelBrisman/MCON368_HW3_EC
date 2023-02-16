Console.WriteLine("Please enter the length of your rectangle.\nChoose a number between 1 and 15");

String length_result = Console.ReadLine();
int length;

while(!Int32.TryParse(length_result, out length))
{
    Console.WriteLine("Please only type a number.");
    length_result = Console.ReadLine();
}

Console.WriteLine("Please enter the width of your rectangle.\nChoose a number between 1 and 10");

String width_result = Console.ReadLine();
int width;

while(!Int32.TryParse(width_result, out width))
{
    Console.WriteLine("Please only type a number.");
    width_result = Console.ReadLine();
}

length = length < 1 ? 1 : (length > 15 ? 15 : length);
width = width < 1 ? 1 : (width > 10 ? 10 : width);

for (int i = 0; i < width; i++)
{
    for (int j = 0; j < length; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

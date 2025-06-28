// See https://aka.ms/new-console-template for more information
Console.WriteLine("Right Angle Triangle");
Console.Write("Enter Number of Rows for Triangle = ");
if (int.TryParse(Console.ReadLine(), out int inputRows))
{
    for (int r = 1; r <= inputRows; r++)
    {
        for (int c = 1; c <= r; c++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Enter a valid number");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Enter Number of * per side = ");
if (int.TryParse(Console.ReadLine(), out int inputRows))
{
    for (int r = 1; r <= inputRows; r++)
    {
        for (int ct = 1; ct <= r; ct++)
        {
            Console.Write("  ");
        }
        for (int cs = 1; cs <= inputRows; cs++)
        {
            Console.Write("  *");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Enter a valid number");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Enter Number of * for height = ");
if (int.TryParse(Console.ReadLine(), out int inputHeight))
{
    Console.Write("Enter Number of * for width = ");
    if (int.TryParse(Console.ReadLine(), out int inputWidth))
    {
        for (int r = 1; r <= inputHeight; r++)
        {
            if (r == 1 || r == inputHeight)
            {
                for (int counter = 1; counter <= inputWidth; counter++)
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.Write("*");
                for (int cs = 2; cs < inputWidth; cs++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Enter a valid Width");
    }
}
else
{
    Console.WriteLine("Enter a valid Height");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Diamond Pattern");
Console.Write("Enter Number of * per side = ");
if (int.TryParse(Console.ReadLine(), out int inputRows))
{
    int rows = inputRows*2 - 1;
    for (int r = 1; r <= rows; r++)
    {
        int tabcols1 = r <= inputRows ? (inputRows - r) : r- inputRows;
        for (int tc1 = 1; tc1 <= tabcols1; tc1++)
        {
            Console.Write("  ");
        }
        int starcols = r <= inputRows ? r : (rows - r) + 1;
        for (int sc = 1; sc <= starcols; sc++)
        {
            Console.Write(" *");
        }
        int tabcols2 = r <= inputRows ? r -1 : (rows - r);
        for (int tc2 = 1; tc2 <= tabcols2; tc2++)
        {
            Console.Write(" *");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Enter a valid number");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Enter length of infinity - ");
int length = Convert.ToInt32(Console.ReadLine());
int height = length / 2 + 1;
Console.WriteLine("Entered string - \"" + length + "\"");
for (int i = 1; i <= height; i++)
{
    if (i <= height / 2 + 1)
    {
        //int 
        for (int ut = 0; ut < length; ut++)
        {
            Console.WriteLine(i);
        }
    }
    else
    {
        for (int lt = 0; lt < length; lt++)
        {
            Console.WriteLine(i);
        }
    }
}
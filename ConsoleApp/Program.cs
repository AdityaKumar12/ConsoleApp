// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.Write("Enter a string - ");
Dictionary<char, int> charcount = new Dictionary<char, int>();
string str = Console.ReadLine();
Console.WriteLine("Entered string - \"" + str + "\"");
foreach (char chr in str.ToLower().ToCharArray())
{
    if (!charcount.ContainsKey(chr)) charcount.Add(chr, 1);
    else charcount[chr] = charcount[chr] + 1;
}
foreach (var di in charcount) Console.WriteLine($"Char {di.Key} appears {di.Value} times.");
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class Program
{
    public static void Main(string[] args)
    {
        // Example of using 'out' and 'ref' keywords in C#
        int refVar1 = 5;
        string refVar2 = "Hello";
        int outVar1;
        string outVar2;


        RefExample(ref refVar1, ref refVar2);
        Console.WriteLine("Ref variables: refVar1 = " + refVar1 + ", refVar2 = " + refVar2);

        OutExample(out outVar1, out outVar2);
        Console.WriteLine("Out variable: outVar1 = " + outVar1 + ", outVar2 = " + outVar2);
    }
    static void RefExample(ref int refvar1, ref string refvar2)
    {
        refvar1 = 10; // This will modify the original variable
        refvar2 = refvar2 + " World"; // This will also modify the original variable
    }

    static void OutExample(out int outVar1, out string outVar2)
    {
        outVar1 = 20; // This must assign a value before returning
        outVar2 = "Good Day!"; // This must assign a value before returning
    }
}
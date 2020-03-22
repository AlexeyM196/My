using System;

public static class CustomPrints
{
    public static void Print(int[] output, string arg)
    {
        Console.WriteLine("{0}", arg);
        foreach (var item in output)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine('\n');
    }


    public static void Print(decimal output, string arg)
    {
        Console.Write("{0}{1}", arg, output);
        Console.WriteLine('\n');
    }


    public static void Print(int output, string arg)
    {
        Console.Write("{0}{1}", arg, output);
        Console.WriteLine('\n');
    }


    public static void Print(string output, string arg)
    {
        Console.Write("{0}{1}", arg, output);
        Console.WriteLine('\n');
    }

    public static void Print(bool output, string arg)
    {
        if (output)
        {
            Console.Write("{0} правильной", arg);
        }
        else
        {
            Console.Write("{0} неправильной", arg);
        }        
    }
}

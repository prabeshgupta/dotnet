//Also known as primitive type

using System;

class ValueType
{
    static void Main(string[] args)
    {
        int value = 5;
        Console.WriteLine(value);

        //Passing value
        pass(value);
    }

    static void pass(int i)
    {
        ++i;
        Console.WriteLine(i);
    }
}
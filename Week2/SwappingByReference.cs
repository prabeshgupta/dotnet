using System;

namespace Week2.Task1;

class Values
{
    public int num;
}

class SwappingByReference
{
    public static void Main(string[] args)
    {
        Values v1 = new Values();
        v1.num = 3;
        Values v2 = new Values();
        v2.num = 2;

        swap(v1, v2);
        Console.WriteLine("v1:{0}\nv2:{1}", v1.num, v2.num);
    }

    public static void swap(Values p1, Values p2)
    {
        p1.num = p1.num + p2.num;
        p2.num = p1.num - p2.num;
        p1.num = p1.num - p2.num;
    }
}
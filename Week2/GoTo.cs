using System;
namespace Week2.Task11;
class GoTo
{
    public static void Main(string[] args)
    {
        bool flag = true;
        goto next;
        flag = false;
    next:
        Console.WriteLine(flag);
    }
}
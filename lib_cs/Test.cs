using System;
using System.Collections.Generic;
using Utils;

class Program
{
    public static void Main()
    {
        var p = new PolymorphicGraph<int>();

        for(int i = 0; i < 7; i++)
        {
            p.Add(i);
        }
        p.ConfigureBalancedBinaryTree();

        Console.Write(p.ToString());
    }
}
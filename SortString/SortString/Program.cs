﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {

        static void Main(string[] args)
        {
        string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
        string[] words = str.Split(' ');
        Array.Sort(words);
        var s = string.Join(" ", words);
        Console.WriteLine("Original sentence:");
        Console.WriteLine(str);
        Console.WriteLine("Sentence after sorting:");
        Console.WriteLine(s);
        Console.ReadKey();
        }
    }
}

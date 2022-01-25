using System;
using System.Linq;
using System.Collections.Generic;
 
class Program
{
    static void Main(string[] args)
    {
        string str = "vaibhav";
        var Frequency = from i in str
                   group i by i into j
                   select j;
        foreach (var arr in Frequency)
        {
            Console.WriteLine("Character " + arr.Key + ": " + arr.Count() + " times");
        }      
    }
}

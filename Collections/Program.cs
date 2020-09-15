using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var saga = new List<string>();
            saga.Add("Det");
            saga.Add("var");
            saga.Add("en");
            saga.Add("gång");
            saga.Add("en");
            saga.Add("saga");
            foreach (var s in saga)
            {
                Console.Write($"{s} ");
            }
            Console.ReadLine();
        }
    }
}

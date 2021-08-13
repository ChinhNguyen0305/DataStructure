using System;
using System.Collections;
using System.Collections.Generic;


namespace reverseStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            Random rdn = new Random();
            System.Console.WriteLine("stack 1");
            foreach (int v in st)
            {
                System.Console.WriteLine(v);
            }
            for (int i = 0; i < 10; i++)
            {
                int generate = rdn.Next(20, 90);
                st.Push(generate);
            }
            ArrayList reverse = new ArrayList();
            System.Console.WriteLine("Stack");
            for (int i = 0; i < st.Count; i++)
            {
                reverse.Add(st.Pop());
            }
            foreach (int v in reverse)
            {
                System.Console.WriteLine(v);
            }
        }
    }
}

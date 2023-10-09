using System;
using System.Collections;

class MainClass
{
    public static void Main(string[] args)
    {
        Stack st = new Stack();

        st.Push(1);
        st.Push(2);
        st.Push(3);

        while (st.Count > 0)
        {
            Console.WriteLine(st.Pop());
        }
    }
}
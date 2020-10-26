using System;

namespace StacksAndQueuesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            int data;
            //Console.WriteLine("Enter value: ");
            //data = Convert.ToInt32(Console.ReadLine());
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
        }
    }
}

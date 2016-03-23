using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSorter<int> bublesorter = new BubbleSorter<int>(CreateRandomArray(10,0,100));
            bublesorter.Print();
            bublesorter.Sort();
            bublesorter.Print();

            InsertionSorter<int> insertionsorter = new InsertionSorter<int>(CreateRandomArray(15, 0, 100));
            insertionsorter.Print();
            insertionsorter.Sort();
            insertionsorter.Print();

            MyStack<string> mystack = new MyStack<string>(5);
            Console.WriteLine("---Stack---\n");
            mystack.Push("a");
            mystack.Push("b");
            mystack.Push("c");
            mystack.Push("d");
            mystack.Push("e");
            mystack.Push("f");
            mystack.Print();
            mystack.Pop();
            mystack.Pop();
            mystack.Print();
            mystack.Push("A");
            mystack.Print();
            Console.WriteLine("Peek from Stack: {0}\n", mystack.Peek());

            MyQueue<string> myqueue = new MyQueue<string>(5);
            Console.WriteLine("---Queue---\n");
            myqueue.Enqueue("a");
            myqueue.Enqueue("b");
            myqueue.Enqueue("c");
            myqueue.Enqueue("d");
            myqueue.Enqueue("e");
            myqueue.Enqueue("f");
            myqueue.Print();
            myqueue.Dequeue();
            myqueue.Dequeue();
            myqueue.Print();
            myqueue.Enqueue("A");           
            myqueue.Print();
            Console.WriteLine("Peek from Queue: {0}\n", myqueue.Peek());


            //Leave console opened
            Console.ReadKey();
        }

        static public int[] CreateRandomArray(int arrayLenght, int min, int max)
        {
            int[] randomArray = new int[arrayLenght];
            Random randomValue = new Random();
            for (int i = 0; i < arrayLenght; i++)
            {
                randomArray[i] = randomValue.Next(min, max);
            }
            return randomArray;
        }

        //Method to generate Array, inputs - number of elements
        //static public T CreateArray<T>(int arraylenght, Type type)
        //{
        //    T randomArray<T> = new T[arrayLenght];
        //    Random randomValue = new Random();
        //    for (int i = 0; i < arrayLenght; i++)
        //    {
        //        randomArray[i] = randomValue.Next(min, max);
        //    }
        //    return randomArray;
        //}




    }
}

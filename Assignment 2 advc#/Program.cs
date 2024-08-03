using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Collections;

namespace Assignment_2_advc_
{

    public class FixedSizeList<T>
    {
        private T[] items;
        private int count;
        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return items.Length; }
        }

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                Console.WriteLine("Capacity must be greater than zero.");
            }
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= items.Length)
            {
                Console.WriteLine("List is full. Cannot add more elements.");
            }
            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index is out of range.");
            }
            return items[index];
        }

     
    }

    internal class Program
    {
        public static void Reverse(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

               
                left++;
                right--;
            }
        }
        static void Main(string[] args)
        {
            #region Part 1
            //1.Array

            //Structure: A collection of elements of the same data type stored in contiguous memory locations.
            // Time Complexity:
            //  Access: O(1)
            //  Search: O(n)
            //  Insertion: O(n)
            //   Deletion: O(n)
            //  Business Case: Arrays are useful when you need to store a fixed-size collection of elements and access them by index.
            //int[] scores = new int[5] { 10, 20, 30, 40, 50 };
            // Console.WriteLine(scores[2]); // Output: 30


            //   2.List < T >

            //  Structure: A dynamic collection of elements of the same data type stored in a contiguous block of memory.
            //  Time Complexity:
            //  Access: O(1)
            //  Search: O(n)
            //  Insertion: O(n)
            // Deletion: O(n)
            //Business Case: Lists are useful when you need to store a dynamic collection of elements and access them by index.

            //List<int> scores = new List<int> { 10, 20, 30, 40, 50 };
            //scores.Add(60);
            //Console.WriteLine(scores[2]); // Output: 30
            //. LinkedList<T>

            // Structure: A dynamic collection of elements of the same data type stored as a sequence of nodes, where each node points to the next node.
            // Time Complexity:
            //  Access: O(n)
            // Search: O(n)
            // Insertion: O(1) 
            // Deletion: O(1)
            //Business Case: Linked lists are useful when you need to frequently insert or delete elements at arbitrary positions.
            //LinkedList<int> scores = new LinkedList<int>();
            //scores.AddLast(10);
            //scores.AddLast(20);
            //scores.AddLast(30);
            //Console.WriteLine(scores.First.Value); // Output: 10

            //   3. Stack<T>

            //    Structure: A last-in-first -out (LIFO)collection of elements.
            //    Time Complexity:
            //   Access: O(1)
            //   Search: O(n)
            //  Insertion: O(1)
            // Deletion: O(1)
            //Business Case: Stacks are useful when you need to implement recursive algorithms or parse expressions.
            //Stack<int> scores = new Stack<int>();
            //scores.Push(10);
            //scores.Push(20);
            //Console.WriteLine(scores.Pop()); // Output: 20
            // 4 Queue<T>

            // Structure: A first-in-first -out (FIFO)collection of elements.
            // Time Complexity:
            //Access: O(1)
            //Search: O(n)
            //Insertion: O(1)
            //Deletion: O(1)
            //Business Case: Queues are useful when you need to implement job scheduling or print queues.
            //Queue<int> scores = new Queue<int>();
            //scores.Enqueue(10);
            //scores.Enqueue(20);
            //Console.WriteLine(scores.Dequeue()); // Output: 10
            //2.ArrayList

            // Structure: A dynamic collection of elements of type object stored in a contiguous block of memory.
            // Time Complexity:
            // Access: O(1)
            // Search: O(n)
            // Insertion: O(n)
            //Deletion: O(n)
            //Business Case: ArrayList is useful when you need to store a dynamic collection of elements of different data types.
            //ArrayList scores = new ArrayList();
            //scores.Add(10);
            //scores.Add("twenty");
            //scores.Add(30);
            //Console.WriteLine(scores[1]); // Output: twenty
            #endregion

            #region part 2
            #region 1
            // ArrayList arrayList = new ArrayList(5) {1,2,3,4,5 };
            //Reverse(arrayList);
            // foreach (int i in arrayList)
            // {
            //     Console.WriteLine(i);
            // }
            #endregion
            #region 2
            //List<int> evenNumbers = new List<int>(6) { 1,2,3,4,5,6};
            //foreach (int i in evenNumbers)
            //{
            //    if (i %2 ==0) {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion
            #region 3
            FixedSizeList<int> list = new FixedSizeList<int>(3);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.Get(i));
            }
            //list.Add(4);
            #endregion
            #endregion


        }
    }
}

using System.Collections;
using System.Collections.Generic;

namespace assignment_adv_C____2_
{
    internal class Program
    {
        //public static int sumarray(ArrayList arrayList)
        //{
        //    int sum = 0;
        //    if (arrayList is not null)
        //    {
        //        for (int i=0;i<arrayList.Count;i++) {
        //            sum += (int)arrayList[i];
        //        }
                
        //    }
        //    return sum;
        //}
        public static int SumList(List<int> list)
        {
            if (list is not null) {
                int sum = 0;
                for (int i = 0; i < list.Count; i++) { 
                
                sum += list[i];
                
                
                }
             return sum;
            
            }
            return 0;
        }
        static void Main(string[] args)
        {
            #region array list
            //ArrayList arraylist = new ArrayList();
            //Console.WriteLine($"COUNT OF ARRAY LIST ={arraylist.Count},Capacity of array ={arraylist.Capacity}");
            //arraylist.Add( 1 );
            //arraylist.Add ( 2 );
            //Console.WriteLine($"COUNT OF ARRAY LIST ={arraylist.Count},Capacity of array ={arraylist.Capacity}");
            //arraylist.AddRange( new int[] {1,2,} );
            //Console.WriteLine($"COUNT OF ARRAY LIST ={arraylist.Count},Capacity of array ={arraylist.Capacity}");
            //arraylist.Add(5);
            //Console.WriteLine($"COUNT OF ARRAY LIST ={arraylist.Count},Capacity of array ={arraylist.Capacity}");


            //ArrayList arrayList=new ArrayList(5) { 1,2,3,4,5};
            //Console.WriteLine($"COUNT OF ARRAY LIST ={arrayList.Count},Capacity of array ={arrayList.Capacity}");
            //arrayList.Add(6);
            //Console.WriteLine($"COUNT OF ARRAY LIST ={arrayList.Count},Capacity of array ={arrayList.Capacity}");

            //arrayList.TrimToSize();
            //Console.WriteLine($"COUNT OF ARRAY LIST ={arrayList.Count},Capacity of array ={arrayList.Capacity}");
            //arrayList.Add("bassim");// System.InvalidCastException
            //int result=sumarray(arrayList);
            //Console.WriteLine(result);
            //foreach (var i in arrayList)
            //{

            //Console.WriteLine(i); }


            #endregion
            #region Generic collection (List)
            //List<int> list = new List<int>();
            //Console.WriteLine($"COUNT OF ARRAY LIST ={list.Count},Capacity of array ={list.Capacity}");
            //list.Add( 1 );
            //Console.WriteLine($"COUNT OF ARRAY LIST ={list.Count},Capacity of array ={list.Capacity}");
            //list.AddRange(new int[] { 3, 4,5 });
            //Console.WriteLine($"COUNT OF ARRAY LIST ={list.Count},Capacity of array ={list.Capacity}");
            //list.Add(8);
            //Console.WriteLine($"COUNT OF ARRAY LIST ={list.Count},Capacity of array ={list.Capacity}");
            //list.TrimExcess();
            //Console.WriteLine($"COUNT OF ARRAY LIST ={list.Count},Capacity of array ={list.Capacity}");

            //List<int> ints = new List<int>(5) {1,2,3,4,5 };
            //Console.WriteLine($"COUNT OF ARRAY LIST ={ints.Count},Capacity of array ={ints.Capacity}");
            //ints.Add(6);
            //Console.WriteLine($"COUNT OF ARRAY LIST ={ints.Count},Capacity of array ={ints.Capacity}");
            //foreach (int i in ints) {

            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < ints.Count; i++) {
            //    Console.WriteLine(ints[i]);
            //}
            //Console.WriteLine(SumList(ints)); 

            #endregion
            #region Generic Collection [Methods]
            //List<int> list = new List<int>(4) { 1, 2, 3, 4 };
            //Console.WriteLine($"COUNT OF ARRAY LIST ={list.Count},Capacity of array ={list.Capacity}");
            //list.Add(5);
            //list.AddRange(new int[] { 1, 2, 3, 5 });
            //Console.WriteLine($"COUNT OF ARRAY LIST ={list.Count},Capacity of array ={list.Capacity}");
            //list.Insert(6, 8);

            //Console.WriteLine($"COUNT OF ARRAY LIST ={list.Count},Capacity of array ={list.Capacity}");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //list.InsertRange(4, new int[] { 1, 2, 3, });
            //Console.WriteLine($"COUNT OF ARRAY LIST ={list.Count},Capacity of array ={list.Capacity}");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //int index = list.BinarySearch(4);
            //Console.WriteLine(index);
            ////list.Remove();
            //Console.WriteLine(list.Contains(2));
            //int[] array = new int[13];
            //list.CopyTo(array, 0);
            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}
            //list.EnsureCapacity(13);
            //list.IndexOf(2);
            //list.LastIndexOf(3);


            #endregion
            #region Generic collection Linked List
            //LinkedList<int> list = new LinkedList<int>();
            //Console.WriteLine(list.Count);
            //list.AddFirst(1);
            //list.AddLast(2);
            //LinkedListNode<int> after = list.Find(1);
            ////list.AddAfter(after, 5);
            //list.AddBefore(after, 7);

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Generic Collections Lists [stack]

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //bool Result = stack.TryPop(out int result);
            //Console.WriteLine(result);
            //Console.WriteLine(Result);
            #endregion

        }
    }
}

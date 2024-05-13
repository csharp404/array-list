using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int size_array = int.Parse(Console.ReadLine());
        int[] arr = new int[size_array];
        //other way to declare a array
        int[] arr2 = { 1, 2, 3, 4, 5 };//take a size from the number of the element it will be static;
        int[] arr3 = new int[] {};//dynamic i dont know how much the size that i want;
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + (i==arr.Length-1 ? "" : ","));
        }
        Console.WriteLine("\nthis is the list : ");
        List<int> lst = new List<int>(2);//if i add a initial value between () that is not mean the maximum size of this list becuase list is dynamic 
        lst.Add(0);
        lst.Add(1);
        lst.Add(2);
        lst.Add(3);
        lst.Add(4);
        lst.Add(5);
        lst.Remove(4);
        Console.WriteLine(lst.Count());
        Console.WriteLine(lst.IndexOf(5));
        Console.WriteLine(lst.LastIndexOf(5));
        lst.Insert(0, 1);
        lst.RemoveAt(2);
        lst.Sort();
        lst.Reverse();
        //lst.Clear();
        //lst[3] = 111;//be careful if you want to edit a value of any index must this index not null i mean it must have a previous value by function add();
        int []arr1 = lst.ToArray();
        foreach (var item in arr1)
        {
            Console.Write(item+",");
        }
    }
}
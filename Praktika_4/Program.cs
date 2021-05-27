using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktila_4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                    ArrayList arr = new ArrayList() { 1, "dd", 2, 3, "A", 23, "n", 1, "qwerty", 345, 1, "bb" };
                    ArrayList list = new ArrayList();
                    string str;
                    for (int i = 0; i < arr.Count; i++)
                    {
                        Type t = arr[i].GetType();
                        Console.WriteLine(t);
                        if (t.Equals(typeof(int)) == false)
                        {
                            str = arr[i].ToString().ToUpper();
                            if (str.Equals(arr[i]))
                            {
                                list.Add(arr[i]);
                            }
                            arr.RemoveAt(i);
                        }
                    }
                    Console.WriteLine("Цифорки:");
                    foreach (var g in arr)
                    {
                        Console.WriteLine(g);
                    }
                    Console.WriteLine("\nБуковки:");
                    foreach (var g in list)
                    {
                        Console.WriteLine(g);
                    }
                    Console.ReadLine();
            }
        }
    }
}

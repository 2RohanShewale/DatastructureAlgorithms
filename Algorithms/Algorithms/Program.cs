﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n1.Permutation\n2.Binary Search\n3.Insertion Sort\nEnter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Permutations permutations = new Permutations();
                        Console.Write("Enter a string: ");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        permutations.permute(str, 0, n - 1);
                        break;
                    case 2:
                        BinarySearch binarySearch = new BinarySearch();
                        Console.WriteLine("Enter word to search:");
                        str = Console.ReadLine();
                        binarySearch.search(str);
                        break;
                    case 3:
                        InsertionSort insertion = new InsertionSort();
                        Console.WriteLine("How many strings you want to add:");
                        int no = Convert.ToInt32(Console.ReadLine());
                        string[] array = new string[no];
                        for (int i = 0; i < no; i++)
                        {
                            Console.WriteLine("Enter string:");
                            string s = Console.ReadLine();
                            array[i] = s;
                        }
                        insertion.Sorting(array);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}

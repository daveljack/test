using System;
using System.Collections.Generic;

/// <summary>
/// 今有陣列資料 0,1,2,3,4,5,6,7,8,9 請寫出資料處理程式碼
/// 1.計算「奇數值總和」減去「偶數值總和」
/// 2.分割成二個陣列。分別存放「偶數值」及「奇數值」
/// </summary>
namespace sln3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] original_array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] odd_array = new int[10], even_array = new int[10];
            int sum_odd = 0,sum_even=0, differ=0;
            int index_odd_array = 0, index_even_array = 0;

            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            for (int i=0;i<original_array.Length;i++)
            {
                if(original_array[i]%2==0)
                {
                    sum_even += original_array[i];
                    even_array[index_even_array] = original_array[i];
                    index_even_array++;
                    evens.Add(original_array[i]);
                }
                else
                {
                    sum_odd += original_array[i];
                    odd_array[index_odd_array] = original_array[i];
                    index_odd_array++;
                    odds.Add(original_array[i]);
                }
            }
            differ = sum_even - sum_odd;
            Console.WriteLine("差值: "+Math.Abs(differ));
            Console.Write("偶數值: ");
            for(int i=0;i< index_even_array; i++)
            {
                Console.Write(even_array[i]+" ");
            }
            Console.Write("\n奇數值: ");
            for (int i = 0; i < index_odd_array; i++)
            {
                Console.Write(odd_array[i] + " ");
            }
            /*Console.Write("\n偶數值: ");
            foreach (int i in evens)
            {
                Console.Write(i);
            }
            Console.Write("\n奇數值: ");
            foreach (int i in odds)
            {
                Console.Write(i);
            }*/


        }
    }
}

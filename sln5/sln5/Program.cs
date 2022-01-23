using System;
using System.Linq;
/// <summary>
/// 今有二陣列，請寫出資料處理程式碼
/// 陣列a:77,5,5,22,13,55,97,796,1,0,9
/// 陣列b:0,1,2,3,4,5,7,8,9
/// 不能用 Union(),Intersect(),Except()
/// </summary>
namespace sln5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 77, 5, 5, 22, 13, 55, 97, 796, 1, 0, 9 };
            int[] b = new int[] { 0, 1, 2, 3, 4, 5, 7, 8, 9 };

            int[] Intersect = new int[20], Except = new int[20], Union = new int[20];
            int Index_Intersect = 0, Index_Except = 0;

            Array.Sort(a);

            Console.Write("交集: ");
            for (int i = 0; i < b.Length; i++)
            {
                if (Array.Exists(a, x => x == b[i]))
                {
                    Intersect[Index_Intersect] = b[i];
                    Console.Write(Intersect[Index_Intersect] + " ");
                    Index_Intersect++;
                }
            }
            //a-交集
            Console.Write("\n差集: ");
            foreach (var i in a)
            {
                if (!Array.Exists(Intersect, x => x == i))
                {
                    Except[Index_Except] = i;
                    Console.Write(Except[Index_Except] + " ");
                    Index_Except++;
                }
            }
            //b+差集
            Console.Write("\n聯集: ");
            Array.Copy(b, Union, b.Length);
            Array.Copy(Except, 0, Union, b.Length, Index_Except);
            for (int i = 0; i < b.Length + Index_Except; i++)
            {
                Console.Write( Union[i]+" ");
            }
            Console.Write("\n"); 
        }
    }
}

using System;

/// <summary>
/// 今有一陣列資料77,5,5,22,13,55,97,4,796,1,0,9請寫出正序排列處理程式碼
/// 不能用sort()
/// </summary>
namespace sln4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 77, 5, 5, 22, 13, 55, 97, 4, 796, 1, 0, 9 };
            for (int i = 0; i < array.Length - 1; i++) 
            {
                for (int j = 0; j < array.Length - i - 1; j++) 
                {
                    if (array[j+1]< array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
            for(int i=0;i< array.Length;i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}

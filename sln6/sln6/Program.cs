using System;
/// <summary>
/// 兩數總和
/// </summary>
namespace sln6
{
    class Program
    {
        public static int[] Two_Sum(int[] array,int target)
        {
            for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[i]+array[j]==target)
                    {
                        return new int[] {i,j};
                    }
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int[] ans = Two_Sum( nums, 9);
            Console.WriteLine(ans[0]+","+ans[1]);
        }
    }
}

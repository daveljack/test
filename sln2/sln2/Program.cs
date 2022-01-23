using System;
/// <summary>
/// 請寫出將字串「人易科技:上 機 測 驗 - 演算法」中的:
/// 1.字元「:」改成全形
/// 2.去掉中文字中間的空白(保留-號二側空白)
/// 3.列印出符號:到-之間的字元
/// </summary>
namespace sln2
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "人易科技:上 機 測 驗 - 演算法";
            Console.WriteLine("原本: "+example);

            string example1=example.Replace(':', '：');
            Console.WriteLine("第一: "+ example1);

            string example2 = example.Replace(" ", string.Empty);
            example2=example2.Insert(example2.IndexOf('-') + 1, " ");
            example2=example2.Insert(example2.IndexOf('-'), " ");
            Console.WriteLine("第二: " + example2);

            int start = example.IndexOf(':');
            int end = example.IndexOf('-');
            string example3 = example.Substring(start + 1, end - start - 1);
            Console.WriteLine("第三: " + example3);


        }
    }
}

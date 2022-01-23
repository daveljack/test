using System;
/// <summary>
/// 今有車輛「汽車」和「機車」，請使用物件的繼承/介面描述二者相同與差易，及二物件的執行程式碼
/// </summary>
namespace sln1
{
    class Motocycle
    {
        public string Liscense { get { return "機車駕照"; } }
        public string Fuel { get { return "汽油"; } }
        public string Driver { set; get; }
        public int Wheel { get { return 2; } }
    }
    class Car:Motocycle
    {
        public new string Liscense { get { return "汽車駕照"; } }
        public new int Wheel
        {
            get { return 4; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Motocycle motocycle = new Motocycle();
            motocycle.Driver = "人人人";
            Console.WriteLine("駕駛: "+ motocycle.Driver+" 駕照: "+ motocycle.Liscense+" 燃料: "+motocycle.Fuel+" 輪子數量: "+motocycle.Wheel);
            Car car = new Car();
            car.Driver = "仁仁仁";
            Console.WriteLine("駕駛: " + car.Driver + " 駕照: " + car.Liscense + " 燃料: " + car.Fuel + " 輪子數量: " + car.Wheel);

        }
    }
}

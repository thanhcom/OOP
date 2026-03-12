using BasicApp.Models;

namespace BasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            DateTime date = DateTime.Now;
            car.Brand = "Toyota";
            car.Year = 2022;

            //car.ShowInfo();
            Console.WriteLine($"Brand: {car.Brand}, Year of Manufacture: {car.Year}, Age: {date.Year-car.Year}");
        }
    }
}
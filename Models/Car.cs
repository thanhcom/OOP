namespace BasicApp.Models
{
    public class Car
    {
        public string? Brand { get; set; }
        public int Year { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Brand} - {Year}");
        }
    }
}
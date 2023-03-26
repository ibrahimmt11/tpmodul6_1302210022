// See https://aka.ms/new-console-template for more information

using tpmodul6_1302210022;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Design by Contract - Ibrahim Mulyo Tsabit");
        SayaTubeVideo video2 = new SayaTubeVideo(null);
        SayaTubeVideo video3 = new SayaTubeVideo("Design by Contract");

        video1.IncreasePlayCount(500);
        video2.IncreasePlayCount(15000000);
        video3.IncreasePlayCount(-100);

        Console.WriteLine("\n");

        Console.WriteLine("Video detail:\n");
        video1.PrintVideoDetail();
        Console.WriteLine("\n");
        video2.PrintVideoDetail();
        Console.WriteLine("\n");
        video3.PrintVideoDetail();
        Console.WriteLine("\n");
    }
}
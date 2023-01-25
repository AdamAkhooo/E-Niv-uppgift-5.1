using System;
class Program
{
    static void Main(string[]args)
    {
        
        string[] namn = new string[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"skriv in ett namn {i + 1}");
                namn[i] = Console.ReadLine();
            }
        Console.WriteLine("Här är de namnen du har valt");
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\n{namn[i]}");
        }
            

        
        
    }
}
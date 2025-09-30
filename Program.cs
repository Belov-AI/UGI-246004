using System;

class ColoredPoem
{
    static void Main()
    {

        ConsoleColor originalColor = Console.ForegroundColor;




        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("«Осень»");
        Console.WriteLine();


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Автор: Александр Сергеевич Пушкин");
        Console.WriteLine();


        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Унылая пора! Очей очарованье!");


        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Приятна мне твоя прощальная краса —");


        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Люблю я пышное природы увяданье,");


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("В багрец и в золото одетые леса.");
        Console.WriteLine();


        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("В их сенях ветра шум и свежее дыханье,");


        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("И мглой волнистою покрыты небеса,");


        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("И редкий солнца луч, и первые морозы,");


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("И отдаленные седой зимы угрозы.");
        Console.WriteLine();

        Console.ForegroundColor = originalColor;


        Console.ReadKey();
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для вычисления площади и периметра ромба");
       

        
        Console.Write("Введите длину стороны ромба: ");
        double side = double.Parse(Console.ReadLine());

        Console.Write("Введите угол между смежными сторонами (в градусах): ");
        double angleDegrees = double.Parse(Console.ReadLine());

        
        if (side <= 0)
        {
            Console.WriteLine("Ошибка: длина стороны должна быть положительным числом!");
            return;
        }

        if (angleDegrees <= 0 || angleDegrees >= 180)
        {
            Console.WriteLine("Ошибка: угол должен быть в диапазоне от 0 до 180 градусов!");
            return;
        }

       
        double perimeter = 4 * side;

       
        double angleRadians = angleDegrees * Math.PI / 180;

        
        double area = Math.Pow(side, 2) * Math.Sin(angleRadians);

       
        Console.WriteLine("\nРезультаты вычислений:");
    
        Console.WriteLine($"Длина стороны: {side:F2}");
        Console.WriteLine($"Угол между сторонами: {angleDegrees:F2}°");
        Console.WriteLine($"Периметр ромба: {perimeter:F2}");
        Console.WriteLine($"Площадь ромба: {area:F2}");

     
        Console.ReadKey();
    }
}

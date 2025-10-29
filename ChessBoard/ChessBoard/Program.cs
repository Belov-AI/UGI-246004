using System;


namespace Chessboard
{
    class Program
    {
        static void Main()
        {
            int boardSize;

            //Здесь ввод размера доски.
            //оформите его в виде бесконечного цикла с проверкой,
            //что 1<= boardSize <= 26
            //и предложением повторного ввода, если условие не выполняется
            //Предусмотрите отказ от ввода (с последующим завершением программы).

            while(true)
            {
                Console.WriteLine("Введите размер доски от 1 до 26 (Enter - выход из программы)");
                var input = Console.ReadLine();

                if (input == string.Empty)
                    return;

                if(!int.TryParse(input, out boardSize))
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }

                if (boardSize > 26 || boardSize < 1)
                {
                    Console.WriteLine("Неверный размер");
                    continue;
                }

                break;
            }

            

            

            PrintBoard(boardSize);           

            Console.ReadKey();
        }

        static void PrintBoard(int size)
        {
            var header = "  ";

            for(int i = 0; i < size; i++)
                header += (char)(0x61 + i);

            Console.WriteLine(header);

            var black = ConsoleColor.DarkBlue;
            var white = ConsoleColor.Yellow;


            for(int row = size; row > 0; row--)
            {
                Console.Write($"{row,2}");

                ConsoleColor color;

                if (row % 2 == 0)
                    color = white;
                else 
                    color = black;

                for(var i = 0; i < size; i++)
                {
                    PrintSquare(color);

                    if (color == black)
                        color = white;
                    else
                        color = black;
                }

                Console.WriteLine(row);
            }
                
            Console.WriteLine(header);
        }

        /// <summary>
        /// Печать квадрата нужного цвета
        /// </summary>
        /// <param name="color">Цвет квадрата</param>
        static void PrintSquare(ConsoleColor color)
        {
            const char square = (char)0x2588;

            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(square);
            Console.ForegroundColor = defaultColor;
        }
    }
}

using System;

class Program
{
    
    static bool DecodePosition(string pos, out int x, out int y)
    {
        x = 0;
        y = 0;

        if (pos.Length != 2)
            return false;

        char file = pos[0]; 
        char rank = pos[1]; 

        if (file >= 'a' && file <= 'h')
            x = file - 'a' + 1; 
        else
            return false;

        if (rank >= '1' && rank <= '8')
            y = rank - '0';
        else
            return false;

        return true;
    }


    static bool BishopCanAttack(int bishopX, int bishopY, int targetX, int targetY)
    {
        return Math.Abs(bishopX - targetX) == Math.Abs(bishopY - targetY);
    }

   
    static bool RookCanAttack(int rookX, int rookY, int targetX, int targetY)
    {
        return (rookX == targetX) || (rookY == targetY);
    }

    static void Main()
    {
        Console.WriteLine("Введите позицию белой фигуры (слон):");
        string whitePos = Console.ReadLine().ToLower();

        Console.WriteLine("Введите позицию черной фигуры (ладья):");
        string blackPos = Console.ReadLine().ToLower();

        int whiteX, whiteY, blackX, blackY;

        if (!DecodePosition(whitePos, out whiteX, out whiteY) ||
            !DecodePosition(blackPos, out blackX, out blackY))
        {
            Console.WriteLine("Ошибка: некорректные позиции");
            return;
        }

        if (whiteX == blackX && whiteY == blackY)
        {
            Console.WriteLine("Ошибка: фигуры не могут стоять на одной клетке");
            return;
        }

      
        bool bishopAttacks = BishopCanAttack(whiteX, whiteY, blackX, blackY);


        bool rookAttacks = RookCanAttack(blackX, blackY, whiteX, whiteY);

        if (bishopAttacks && rookAttacks)
            Console.WriteLine("Фигуры бьют друг друга");
        else if (bishopAttacks)
            Console.WriteLine("Слон бьет ладью");
        else if (rookAttacks)
            Console.WriteLine("Ладья бьет слона");
        else
            Console.WriteLine("Фигуры не бьют друг друга");
    }
}
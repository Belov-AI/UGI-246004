using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой пешки");
            var whitePawnPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию черной пешки");
            var blackPawnPosition = Console.ReadLine();

            if(whitePawnPosition == blackPawnPosition)
            {
                Console.WriteLine("Пешки не могут стоять на одной клетке");
                return;
            }

            int whitePawnH, whitePawnV;
            int blackPawnH, blackPawnV;

            (whitePawnV, whitePawnH) = DecodePosition(whitePawnPosition);
            (blackPawnV, blackPawnH) = DecodePosition(blackPawnPosition);

            if (whitePawnH == 1 || whitePawnH == 8 || blackPawnH == 1 || blackPawnH == 8)
            {
                Console.WriteLine("Пешки не могут стоять на 1-й или 8-й горизонтали");
                return;
            }

            if (IsUnderStrikeByBlackPawn(whitePawnPosition, blackPawnPosition) ||
                IsUnderStrikeByWhitePawn(blackPawnPosition, whitePawnPosition))
                Console.WriteLine("Пешки бьют друг друга");
            else
                Console.WriteLine("Пешки не бьют друг друга");

        }

        static (int, int) DecodePosition(string position)
        {
            var vert = (int)position[0] - 0x60;
            var hor = int.Parse(position[1].ToString());

            return (vert, hor);
        }

        static bool IsUnderStrikeByWhitePawn(string position,string whitePawnPostition)
        {
            int pV, pH,wpV,wpH;

            (pV, pH) = DecodePosition(position);
            (wpV, wpH) = DecodePosition(whitePawnPostition);

            return pH - wpH == 1 && Math.Abs(pV - wpV) == 1;
        }

        static bool IsUnderStrikeByBlackPawn(string position, string blackPawnPostition)
        {
            int pV, pH, bpV, bpH;

            (pV, pH) = DecodePosition(position);
            (bpV, bpH) = DecodePosition(blackPawnPostition);

            return bpH - pH == 1 && Math.Abs(pV - bpV) == 1;
        }
    }
}

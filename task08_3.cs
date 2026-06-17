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
            Console.WriteLine("Введите позицию белого короля (например, e2)");
            var whiteKingPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию черной пешки (например, d7)");
            var blackPawnPosition = Console.ReadLine();

            if (!IsCorrectPosition(whiteKingPosition) || !IsCorrectPosition(blackPawnPosition))
            {
                Console.WriteLine("Некорректная позиция. Нужно: буква a-h и цифра 1-8");
                return;
            }

            if (whiteKingPosition == blackPawnPosition)
            {
                Console.WriteLine("Фигуры не могут стоять на одной клетке");
                return;
            }

            int wkFile, wkRank;
            int bpFile, bpRank;

            DecodePosition(whiteKingPosition, out wkFile, out wkRank);
            DecodePosition(blackPawnPosition, out bpFile, out bpRank);

            var kingStrikesPawn = IsUnderStrikeByWhiteKing(blackPawnPosition, whiteKingPosition);
            var pawnStrikesKing = IsUnderStrikeByBlackPawn(whiteKingPosition, blackPawnPosition);

            if (kingStrikesPawn || pawnStrikesKing)
                Console.WriteLine("Какая-то из фигур находится под боем другой");
            else
                Console.WriteLine("Ни одна из фигур не находится под боем другой");
        }

        static bool IsCorrectPosition(string position)
        {
            if (string.IsNullOrEmpty(position) || position.Length != 2)
                return false;

            var file = position[0];
            var rank = position[1];

            return (file >= 'a' && file <= 'h') && (rank >= '1' && rank <= '8');
        }

        static void DecodePosition(string position, out int file, out int rank)
        {
            file = position[0] - 'a' + 1;      
            rank = position[1] - '0';         
        }

        static bool IsUnderStrikeByWhiteKing(string targetPosition, string whiteKingPosition)
        {
            int tFile, tRank, kFile, kRank;

            DecodePosition(targetPosition, out tFile, out tRank);
            DecodePosition(whiteKingPosition, out kFile, out kRank);

            return Math.Abs(tFile - kFile) <= 1 && Math.Abs(tRank - kRank) <= 1;
        }

        static bool IsUnderStrikeByBlackPawn(string targetPosition, string blackPawnPosition)
        {
            int tFile, tRank, pFile, pRank;

            DecodePosition(targetPosition, out tFile, out tRank);
            DecodePosition(blackPawnPosition, out pFile, out pRank);

            // Черная пешка бьет "вниз": на одну горизонталь меньше и на одну вертикаль влево/вправо [web:113]
            return (pRank - tRank == 1) && (Math.Abs(tFile - pFile) == 1);
        }
    }
}
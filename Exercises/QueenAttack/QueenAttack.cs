
using System;
namespace Exercism_Exercises.Exercises.QueenAttack
{
    public class Queen
    {
        public Queen(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Row { get; }
        public int Column { get; }
    }
    public static class QueenAttack
    {
        public static bool CanAttack(Queen white, Queen black)
        {
            if (white.Row == black.Row && white.Column == black.Column)
                throw new ArgumentException("The queens can't be on the same position.");

            return AreOnTheSameRow(white.Row, black.Row) || AreOnTheSameColumn(white.Column, black.Column) || AreOnTheSameDiagonal(white.Row, white.Column, black.Row, black.Column);
        }

        private static bool AreOnTheSameRow(int whiteRow, int blackRow) => whiteRow == blackRow;
        private static bool AreOnTheSameColumn(int whiteColumn, int blackColumn) => whiteColumn == blackColumn;
        private static bool AreOnTheSameDiagonal(int whiteRow, int whiteColumn, int blackRow, int blackColumn) => Math.Abs(whiteRow - blackRow) == Math.Abs(whiteColumn - blackColumn);

        public static Queen Create(int row, int column)
        {
            if (row < 0 || row > 7 || column < 0 || column > 7)
                throw new ArgumentOutOfRangeException($"({row},{column}) is not a valid postion on the board.");

            return new Queen(row, column);
        }
    }
}//Made by ericssonGamerz4


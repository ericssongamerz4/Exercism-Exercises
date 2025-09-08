using System.Text;

namespace Exercism_Exercises.Exercises.Transpose
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Transpose
    {
        public static string String(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";

            string output = string.Empty;

            string[] grid = input.Split("\n");

            List<int> padding = new List<int>() { };

            for (int i = 0; i < grid.Length; i++)
                padding.Add(grid[i..].Max(c => c.Length));

            for (int i = 0; i < grid.Max(c => c.Length); i++)
            {
                if (i != 0)
                    output += "\n";

                for (int j = 0; j < grid.Length; j++)
                {
                    try
                    {
                        output += grid[j][i];
                    }
                    catch
                    {
                        if (i < padding[j])
                            output += " ";
                    }
                }
            }
            return output;
        }
    }
    //public static class Transpose
    //{
    //    public static string String(string input)
    //    {
    //        string result = string.Empty;

    //        if (string.IsNullOrEmpty(input))
    //            return result;

    //        string[] inputRows = input.Split('\n');

    //        int longestStringLength = inputRows.MaxBy(x => x.Length).Length;

    //        for (int i = 0; i < longestStringLength; i++)
    //        {
    //            StringBuilder row = new();
    //            foreach (var item in inputRows)
    //            {
    //                if (i < item.Length)
    //                    row.Append(item[i]);
    //                else
    //                    row.Append(' ');
    //            }

    //            result += row.ToString().TrimEnd(); // trim just this row

    //            if (i + 1 < longestStringLength)
    //                result += "\n";
    //        }
    //        return result;
    //    }
    //}



}
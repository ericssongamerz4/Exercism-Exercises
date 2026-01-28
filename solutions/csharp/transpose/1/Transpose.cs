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
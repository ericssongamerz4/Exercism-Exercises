using System.Text.RegularExpressions;

public class LogParser
{
    public bool IsValidLine(string input) => Regex.IsMatch(input, @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]");
    public string[] SplitLogLine(string input) => Regex.Split(input, @"<[\-\^\*=]+>");

    public int CountQuotedPasswords(string lines) => Regex.Count(lines, @"\""(password)\""| \""?(password)?\"" ", RegexOptions.IgnoreCase);

    public string RemoveEndOfLineText(string line) => Regex.Replace(line, @"end-of-line\d+", string.Empty);
    public string[] ListLinesWithPasswords(string[] lines)
    {
        List<string> res = [];
        foreach (var line in lines) 
        {
            Match passwordMatch = Regex.Match(line, @"password\w+",RegexOptions.IgnoreCase);

            if (passwordMatch != Match.Empty) 
            { 
                res.Add($"{passwordMatch.Value}: {line}");
            }
            else
            {
                res.Add($"--------: {line}");
            }
        }
        return res.ToArray();
    }
}

//Made by ericssonGamerz4
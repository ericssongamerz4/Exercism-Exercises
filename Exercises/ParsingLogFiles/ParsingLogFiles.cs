using System.Text.RegularExpressions;

namespace Exercism_Exercises.Exercises.ParsingLogFiles;

public class LogParser
{
    readonly string isValidLinePattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
    readonly string splitLogLinePattern = @"<[\^*=-]+>";
    readonly string countQuotedPasswordsPattern = @""".*(password).*""";//@"""(password)\""| \""?(password)?\"" ";
    readonly string removeEndOfLineTextPattern = @"end-of-line\d+";
    readonly string weakPasswordPattern = @"password\w+";

    public bool IsValidLine(string input) => Regex.IsMatch(input, isValidLinePattern);
    public string[] SplitLogLine(string input) => Regex.Split(input, splitLogLinePattern);
    public int CountQuotedPasswords(string lines) => Regex.Count(lines, countQuotedPasswordsPattern, RegexOptions.IgnoreCase);
    public string RemoveEndOfLineText(string line) => Regex.Replace(line, removeEndOfLineTextPattern, string.Empty);
    public string[] ListLinesWithPasswords(string[] lines)
    {
        List<string> res = [];
        foreach (var line in lines)
        {
            Match weakPasswordMatch = Regex.Match(line, weakPasswordPattern, RegexOptions.IgnoreCase);

            res.Add((weakPasswordMatch != Match.Empty) ? $"{weakPasswordMatch.Value}: {line}" : $"--------: {line}");
        }
        return res.ToArray();
    }
}

//Made by ericssonGamerz4
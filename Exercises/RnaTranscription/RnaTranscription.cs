using System.Text;

namespace Exercism_Exercises.Exercises.RnaTranscription
{
public static class RnaTranscription
{
    public static string ToRna(string strand)
    {
        if (string.IsNullOrWhiteSpace(strand))
            return string.Empty;

        StringBuilder sb = new();

        foreach (char c in strand)
        {
            sb.Append(DnaToRnaConveter(c));
        }

        return sb.ToString();
    }

    private static char DnaToRnaConveter(char nucleotide) => nucleotide switch
    {
        'G' => 'C',
        'C' => 'G',
        'T' => 'A',
        'A' => 'U',
        _ => throw new ArgumentException($"'{nucleotide}' is not a valid nucleotide."),
    };
}
}



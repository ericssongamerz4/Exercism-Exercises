namespace Exercism_Exercises.Exercises.ProteinTranslation
{
    public static class ProteinTranslation
    {
        public static string[] Proteins(string strand)
        {
            List<string> result = [];

            if(strand.Length % 3 != 0)
                throw new ArgumentException("Strand length must be a multiple of 3.");

            for (int i = 0; i < strand.Length; i += 3)
            {
                 string? protein = GetProteinValue(strand.Substring(i, 3));

                if (protein is null)
                    return result.ToArray();

                result.Add(protein);
            }

            return result.ToArray();
        }

        private static string? GetProteinValue(string strand)
        {
            switch (strand)
            {
                case "AUG":
                    return "Methionine";

                case "UUU" or "UUC":
                    return "Phenylalanine";

                case "UUA" or "UUG":
                    return "Leucine";

                case "UCU" or "UCC" or "UCA" or "UCG":
                    return "Serine";

                case "UAC" or "UAU":
                    return "Tyrosine";

                case "UGC" or "UGU":
                    return "Cysteine";

                case "UGG":
                    return "Tryptophan";

                case "UAA" or "UAG" or "UGA":
                    return null;

                default:
                    throw new ArgumentException($"{strand} doesn't exist.");
            }
        }
    }
}

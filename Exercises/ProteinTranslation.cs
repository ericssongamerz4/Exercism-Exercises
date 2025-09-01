namespace Exercism_Exercises.Exercises
{
    public static class ProteinTranslation
    {
        public static string[] Proteins(string strand)
        {
            List<string> result = [];

            for (int i = 0; i < strand.Length; i+=3)
            {
                string protein = strand.Substring(i,3);
                switch (protein)
                {
                    case "AUG":
                        result.Add("Methionine");
                        break;

                    case "UUU" or "UUC":
                        result.Add("Phenylalanine");
                        break;

                    case "UUA" or "UUG":
                        result.Add("Leucine");
                        break;

                    case "UCU" or "UCC" or "UCA" or "UCG":
                        result.Add("Serine");
                        break;

                    case "UAC" or "UAU":
                        result.Add("Tyrosine");
                        break;

                    case "UGC" or "UGU":
                        result.Add("Cysteine");
                        break;

                    case "UGG":
                        result.Add("Tryptophan");
                        break;

                    case "UAA" or "UAG" or "UGA":
                        return result.ToArray();

                    default:
                        throw new Exception($"{protein} doesn't exist.");
                }
            }

            return result.ToArray();
        }
    }
}

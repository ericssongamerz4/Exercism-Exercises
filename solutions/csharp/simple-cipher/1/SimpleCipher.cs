using System.Text;

public class SimpleCipher
{
    public SimpleCipher() => key = CreateRandomKey();

    public SimpleCipher(string key) => this.key = key;

    private string key;
    public string Key
    {
        get
        {
            return key;
        }
        private set { key = value; }
    }
    private static int Decrypt(char c, int shift) => ((c - 'a') - shift + 26) % 26;

    private static int Encrypt(char c, int shift) => ((c - 'a') + shift) % 26;

    private static char IndexToChar(int value) => Convert.ToChar(value + 97);

    public string Encode(string text)
    {
        StringBuilder result = new StringBuilder();

        string extendedKey = ExtendKey(Key, targetKeyLength: text.Length);

        for (int i = 0; i < text.Length; i++)
        {
            int shift = extendedKey[i] - 'a';

            if (char.IsLetter(text[i]))
                result.Append(IndexToChar(Encrypt(text[i], shift)));

            else
                result.Append(text[i]);
        }

        return result.ToString();
    }

    public string Decode(string ciphertext)
    {
        StringBuilder result = new StringBuilder();

        string extendedKey = ExtendKey(Key, targetKeyLength: ciphertext.Length);

        for (int i = 0; i < ciphertext.Length; i++)
        {
            int shift = extendedKey[i] - 'a';

            if (char.IsLetter(ciphertext[i]))
                result.Append(IndexToChar(Decrypt(ciphertext[i], shift)));

            else
                result.Append(ciphertext[i]);
        }

        return result.ToString();
    }

    //Creates a random 100 character key
    private static readonly Random random = new();
    private static string CreateRandomKey()
    {
        string key = string.Empty;
        for (int i = 0; i < 100; i++)
        {
            key += (char)random.Next('a', 'z' + 1);
        }
        return key;
    }

    //Extends the key if it's shorter that the text
    private static string ExtendKey(string key, int targetKeyLength)
    {
        string result;

        int amount = targetKeyLength / key.Length;

        result = string.Concat(Enumerable.Repeat(key, amount + 1));

        return result.Substring(0, targetKeyLength);
    }
}
//Made by ericssonGamerz4
using System.Text;

namespace Exercism_Exercises.Exercises.SimpleCipher;

/*
Instructions
Create an implementation of the Vigenère cipher. The Vigenère cipher is a simple substitution cipher.

Cipher terminology
A cipher is an algorithm used to encrypt, or encode, a string. The unencrypted string is called the plaintext and the encrypted string is called the ciphertext. Converting plaintext to ciphertext is called encoding while the reverse is called decoding.

In a substitution cipher, each plaintext letter is replaced with a ciphertext letter which is computed with the help of a key. (Note, it is possible for replacement letter to be the same as the original letter.)

Encoding details
In this cipher, the key is a series of lowercase letters, such as "abcd". Each letter of the plaintext is shifted or rotated by a distance based on a corresponding letter in the key. An "a" in the key means a shift of 0 (that is, no shift). A "b" in the key means a shift of 1. A "c" in the key means a shift of 2, and so on.

The first letter of the plaintext uses the first letter of the key, the second letter of the plaintext uses the second letter of the key and so on. If you run out of letters in the key before you run out of letters in the plaintext, start over from the start of the key again.

If the key only contains one letter, such as "dddddd", then all letters of the plaintext are shifted by the same amount (three in this example), which would make this the same as a rotational cipher or shift cipher (sometimes called a Caesar cipher). For example, the plaintext "iamapandabear" would become "ldpdsdqgdehdu".

If the key only contains the letter "a" (one or more times), the shift distance is zero and the ciphertext is the same as the plaintext.

Usually the key is more complicated than that, though! If the key is "abcd" then letters of the plaintext would be shifted by a distance of 0, 1, 2, and 3. If the plaintext is "hello", we need 5 shifts so the key would wrap around, giving shift distances of 0, 1, 2, 3, and 0. Applying those shifts to the letters of "hello" we get "hfnoo".

Random keys
If no key is provided, generate a key which consists of at least 100 random lowercase letters from the Latin alphabet. 
 
 
 */


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
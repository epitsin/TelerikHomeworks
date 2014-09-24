//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR 
//(exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

namespace EncodingDecodingStringUsingKey
{
    class EncodingDecodingStringUsingKey
    {
        static string Encode (string text, string key)
        {
            char[] textArray = text.ToCharArray();
            char[] keyArray = new char[textArray.Length];
            for (int i = 0, j = 0; i < keyArray.Length; i++, j++)
            {
                keyArray[i] = key[j];
                if (j == key.Length-1)
                {
                    j = -1;
                }
            }
            StringBuilder XORed = new StringBuilder();
            for (int i = 0; i < textArray.Length; i++)
            {
                XORed.Append((char)(textArray[i] ^ keyArray[i]));
            }
            return XORed.ToString();
        }

        static string Decode (string text, string key)
        {
            return Encode(text, key);
        }

        static void Main()
        {
            string text = "We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.";
            string key = "mad";
            string encoded = Encode(text, key);
            string decoded = Decode(encoded, key);
            Console.WriteLine(text);
            Console.WriteLine("The encoded message is: ");
            Console.WriteLine(encoded);
            Console.WriteLine("And back again : ");
            Console.WriteLine(decoded);
        }
    }
}

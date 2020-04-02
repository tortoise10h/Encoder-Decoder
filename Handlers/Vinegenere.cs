using System;
using System.Text.RegularExpressions;

namespace Encoder_Decoder.Handlers
{
    public class Vinegenere
    {
        public static string encode(string text, string key)
        {
            text = Regex.Replace(text, @"[^\w]", "").ToUpper();
            key = Regex.Replace(key, @"[^\w]", "").ToUpper();
            key = generateKey(text, key);
            string result = encodeText(text, key);

            return result;
        }

        public static string generateKey(string text, string key)
        {

            int textLength = text.Length;
            int keyLength = key.Length;
            int i = 0;
            while (key.Length < textLength)
            {
                if (i == keyLength)
                    i = 0;

                key += key[i];
                i++;
            }

            return key;
        }

        public static string encodeText(string text, string key)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                int x = (text[i] + key[i]) % 26;

                x += 'A';

                result += (char)x;
            }
            return result;
        }

        public static string decode(string cipherText, string key)
        {
            cipherText = Regex.Replace(cipherText, @"[^\w]", "").ToUpper();
            key = Regex.Replace(key, @"[^\w]", "").ToUpper();
            key = generateKey(cipherText, key);
            return decodeText(cipherText, key);
        }

        public static string decodeText(string cipherText, string key)
        {
            string result = "";
            for (int i = 0; i < cipherText.Length; i++)
            {
                int x = (cipherText[i] - key[i] + 26) % 26;

                x += 'A';

                result += (char)x;
            }
            return result;
        }
    }

}
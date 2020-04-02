using System;
using System.Linq;

namespace Encoder_Decoder.Handlers
{
    public class Affine
    {
        private static char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public static string encode(string code, string key)
        {
            // split to array character by single character in string
            char[] codeArr = code.ToCharArray();
            char[] keyArr = key.ToCharArray();
            try
            {
                ValidateKey(keyArr);
            }
            catch (System.ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


            string result = "";

            foreach (char c in codeArr)
            {
                int currentCharPositionInAlphabet = Array.IndexOf(characters, c);
                result += keyArr[currentCharPositionInAlphabet];
            }

            return result;
        }

        public static void ValidateKey(char[] keyArr)
        {
            if (keyArr.Length != characters.Length)
            {
                throw new System.ArgumentException("Number of character in key is not valid (valid is 26 characters)", "original");
            }
            if (keyArr.Length != keyArr.Distinct().Count())
            {
                throw new System.ArgumentException("Key can not contain duplicate character", "original");
            }

        }

        public static string decode(string code, string key)
        {
            // split to array character by single character in string
            char[] codeArr = code.ToCharArray();
            char[] keyArr = key.ToCharArray();

            try
            {
                ValidateKey(keyArr);
            }
            catch (System.ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            string result = "";

            foreach (char c in codeArr)
            {
                int currentCharPositionKey = Array.IndexOf(keyArr, c);
                result += characters[currentCharPositionKey];
            }

            return result;
        }
    }
}
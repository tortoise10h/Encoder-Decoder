using System;

namespace Encoder_Decoder.Handlers
{
    public class ShiftCipher
    {
        private static char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public static string encode(string code, int k)
        {

            // split code to array single character of code
            char[] codeArr = code.ToCharArray();
            try
            {
                if (code.Equals("") == true)
                {
                    throw new System.ArgumentException("Please enter non empty string", "original");
                }
                if (k > 26 || k < -26)
                {
                    throw new System.ArgumentException("k range is only from -26 -> 26", "original");
                }
            }
            catch (System.ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            string result = "";

            foreach (char c in codeArr)
            {
                int charCurrentPositionInAlphabet = Array.IndexOf(characters, c);
                int delta = charCurrentPositionInAlphabet + k;
                int newCharPositionInAlphabet = HandleNewCharPositionWhenDecode(delta);

                result += characters[newCharPositionInAlphabet];
            }

            return result;
        }

        private static int HandleNewCharPositionWhenDecode(int delta)
        {
            int newCharPositionInAlphabet = 0;
            if (delta > 0 && delta <= characters.Length)
            {
                // shift forward and not repeat the cycle
                newCharPositionInAlphabet = delta;

            }
            else if (delta > 0 && delta > characters.Length)
            {
                // shift forward and repeat the cycle
                newCharPositionInAlphabet = delta - characters.Length;
            }
            else if (delta < 0 && Math.Abs(delta) <= characters.Length)
            {
                // shift backward
                newCharPositionInAlphabet = delta + characters.Length;
            }

            return newCharPositionInAlphabet;
        }


        public static string decode(string code, int k)
        {
            return encode(code, -k);
        }
    }
}
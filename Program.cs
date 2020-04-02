using System;
using System.Linq;
using System.Text.RegularExpressions;
using Encoder_Decoder.Handlers;

namespace encoder_decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("#Yo, Welcome to Encoder_Decoder console#");
                Console.WriteLine("1. Encode using Shift Cipher.");
                Console.WriteLine("2. Decode of Shift Cipher.");
                Console.WriteLine("3. Encode using Affine.");
                Console.WriteLine("4. Decode of Affine.");
                Console.WriteLine("5. Encode using Vinegenere.");
                Console.WriteLine("6. Decode of Vinegenere.");
                Console.WriteLine("0. Exit!");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter string to encode: ");
                            string code = Console.ReadLine();
                            Console.WriteLine("Enter k: ");
                            int k = Convert.ToInt32(Console.ReadLine());
                            string encoded = ShiftCipher.encode(code, k);
                            Console.WriteLine("\n>>> Encoded of '{0}' is: {1}\n", code, encoded);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter string to decode: ");
                            string code = Console.ReadLine();
                            Console.WriteLine("Enter k: ");
                            int k = Convert.ToInt32(Console.ReadLine());
                            string decoded = ShiftCipher.decode(code, k);
                            Console.WriteLine("\n>>> Decoded of '{0}' is: {1}\n", code, decoded);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter string to encode: ");
                            string code = Console.ReadLine();
                            Console.WriteLine("Enter key: ");
                            string key = Console.ReadLine();
                            string encoded = Affine.encode(code, key);
                            Console.WriteLine("\n>>> Encoded of '{0}' is: {1}\n", code, encoded);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter string to decode: ");
                            string code = Console.ReadLine();
                            Console.WriteLine("Enter key: ");
                            string key = Console.ReadLine();
                            string decoded = Affine.decode(code, key);
                            Console.WriteLine("\n>>> Encode of '{0}' is: {1}\n", code, decoded);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter string to encode: ");
                            string code = Console.ReadLine();
                            Console.WriteLine("Enter key: ");
                            string key = Console.ReadLine();
                            string encoded = Vigenere.encode(code, key);
                            Console.WriteLine("\n>>> Encoded of '{0}' is: {1}\n", code, encoded);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Enter string to decode: ");
                            string code = Console.ReadLine();
                            Console.WriteLine("Enter key: ");
                            string key = Console.ReadLine();
                            string decoded = Vigenere.decode(code, key);
                            Console.WriteLine("\n>>> Encode of '{0}' is: {1}\n", code, decoded);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("!!!Wrong number! Please enter again!!!\n");
                            break;
                        }
                }
            }
            Console.WriteLine("\n\n###################################\n#####!!! Thank for using <3 !!!#####\n###################################");
        }
    }
}

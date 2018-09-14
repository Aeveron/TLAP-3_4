using System;

namespace TLAP_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MainOutput(args[0] == "e", args[1]);
        }

        private static void MainOutput(bool encrypt, string plaintext)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
            var code = "QWERTYUIOPÅÆØLKJHGFDSAZXCVBNM";
            var cipherText = Encrypting(plaintext,
                encrypt ? alphabet : code,
                encrypt ? code : alphabet);

            Console.WriteLine(cipherText);

        }

        private static string Encrypting(string plaintext, string alphabet, string code)
        {
            var cipherText = "";
            for (int i = 0; i < plaintext.Length; i++)
            {
                cipherText += EncryptChar(plaintext[i], alphabet, code);
            }

            return cipherText;
        }

        private static char EncryptChar(char c, string alphabet, string code)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == char.ToUpper(c))
                {
                    return code[i];
                }
            }

            return c;
        }
    }
}

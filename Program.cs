using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Pss... What's your secret message?");
            string message = Console.ReadLine();
            // Array Split
            char[] secretMessage = message.ToLower().ToCharArray();


            // encrypted message
            char[] encryptedMessage = new char[secretMessage.Length];


            //  For Loop
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char secretVar = secretMessage[i];
                int alphaPos = Array.IndexOf(alphabet, secretVar);
                int cypherPos = (alphaPos + 3) % 26;
                char encryptedChar = alphabet[cypherPos];
                encryptedMessage[i] = encryptedChar;
            }

            string newMessage = String.Join("", encryptedMessage);
            Console.WriteLine(newMessage);
        }
    }
}

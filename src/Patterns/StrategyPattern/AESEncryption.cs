using System;

namespace Patterns.StrategyPattern
{
    public class AESEncryption : IEncryptionAlgorithm
    {
        public void Encrypt(string messsage)
        {
            Console.WriteLine("Encrypting message using AES");

        }
    }
}
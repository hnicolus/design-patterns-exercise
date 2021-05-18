using System.Security.Cryptography;
using System;

namespace Patterns.StrategyPattern
{
    public class DESEncryption : IEncryptionAlgorithm
    {
        public void Encrypt(string messsage)
        {
            Console.WriteLine("Encrypting message using DES");
        }
    }
}
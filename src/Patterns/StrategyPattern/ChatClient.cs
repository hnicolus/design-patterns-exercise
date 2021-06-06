using System;

namespace Patterns.StrategyPattern
{
    public class ChatClient
    {

        public IEncryptionAlgorithm Encryption { get; set; }
        public ChatClient(IEncryptionAlgorithm encryptionAlgorithm)
        {
            Encryption = encryptionAlgorithm;
        }
        public void Send(String message)
        {
            Encryption.Encrypt(message);
            Console.WriteLine("Sending the encrypted message...");
        }
    }
}
using System;

namespace Patterns.StrategyPattern
{
    public interface IEncryptionAlgorithm
    {
        void Encrypt(string messsage);
    }
}
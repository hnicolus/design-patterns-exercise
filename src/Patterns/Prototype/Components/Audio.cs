using System;

namespace Patterns.Prototype
{
    public class Audio : IComponent
    {
        public Audio(string audioName)
        {
            this.AudioName = audioName;
        }
        public string AudioName { get; set; }
        public IComponent Clone()=> new Audio(AudioName);
    }
}
using System;

namespace Patterns.Prototype
{
    public static class VideoEditorProgram
    {
        public static void Run()
        {
            var text = new Text("Hello World");
            var audio = new Audio("C:/audios/joyToTheWorld.mp3");
            var clonedText =(Text) ContextMenu.Duplicate(text);
            var clonedAudio = (Audio) ContextMenu.Duplicate(audio);

            Console.WriteLine("Original text :" + text.Content);
            Console.WriteLine("Cloned text :" + clonedText.Content);
            
            Console.WriteLine("Original Audio :" + audio.AudioName);
            Console.WriteLine("Cloned Audio :" + clonedAudio.AudioName);

        }   
    }
}
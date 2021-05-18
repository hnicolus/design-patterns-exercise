using System;

namespace Patterns.Command
{
    public class VideoEditor
    {
        private string text;
        private float contrast = 0.5f;

        public float Contrast { get => contrast; set => contrast = value; }
        public string Text { get => text; set => text = value; }


        public void setText(String text)
        {
            this.text = text;
        }

        public void removeText()
        {
            this.text = "";
        }

        public override string ToString()
        {
            return "VideoEditor{" +
                    "contrast=" + contrast +
                    ", text='" + text + '\'' +
                    '}';
        }
    }
}
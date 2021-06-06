using System;

namespace Patterns.FlyWeight.spreadsheetApplication
{
    public class Cell
    {
        private readonly int row;
        private readonly int column;
        private String content;
        private String fontFamily;
        private int fontSize;
        private bool isBold;

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public string GetFontFamily()
        {
            return fontFamily;
        }

        public void SetFontFamily(string fontFamily)
        {
            this.fontFamily = fontFamily;
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public void SetFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public bool IsBold()
        {
            return isBold;
        }

        public void SetBold(bool bold)
        {
            isBold = bold;
        }

        public void Render()
        {
            System.Console.WriteLine($"({row}, {column}: {content} [{fontFamily}]\n");
        }
    }
}
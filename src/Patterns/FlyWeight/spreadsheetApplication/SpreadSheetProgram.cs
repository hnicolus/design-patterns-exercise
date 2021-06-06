using System;

namespace Patterns.FlyWeight.spreadsheetApplication
{
    public static class SpreadSheetProgram
    {
        public static void Run()
        {
            var sheet = new SpreadSheet();
            sheet.SetContent(0, 0, "Hello");
            sheet.SetContent(1, 0, "World");
            sheet.SetFontFamily(0, 0, "Arial");
            sheet.Render();
        }
    }
}
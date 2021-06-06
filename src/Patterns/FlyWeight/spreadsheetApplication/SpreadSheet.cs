using System;

namespace Patterns.FlyWeight.spreadsheetApplication
{
    public class SpreadSheet
    {
        private static readonly int MAX_ROWS = 3;
        private static readonly int MAX_COLS = 3;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.
        private readonly String _fontFamily = "Times New Roman";
        private readonly int _fontSize = 12;
        private readonly bool _isBold = false;

        private Cell[,] _cells = new Cell[MAX_ROWS, MAX_COLS];
        public SpreadSheet()
        {
            GenerateCells();
        }

        private void GenerateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col);
                    cell.SetFontFamily(_fontFamily);
                    _cells[row, col] = cell;
                }
        }

        public void SetContent(int row, int col, String content)
        {
            EnsureCellExists(row, col);
            _cells[row, col].SetContent(content);
        }

        private void EnsureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new ArgumentOutOfRangeException("Row argument is out of range");

            if (col < 0 || col >= MAX_COLS)
                throw new ArgumentOutOfRangeException("Column is out of range");
        }

        public void SetFontFamily(int row, int col, String fontFamily)
        {
            EnsureCellExists(row, col);
            var cell = _cells[row, col];
            cell.SetFontFamily(fontFamily);
        }

        public void Render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    _cells[row, col].Render();
        }
    }
}
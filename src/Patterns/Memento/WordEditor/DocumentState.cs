namespace Patterns.Memento.WordEditor
{
    public class DocumentState
    {
        public string Content { get; init; }
        public string FontName { get; init; }
        public int FontSize { get; init; }
    }
}
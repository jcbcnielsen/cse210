public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chap, int verse)
    {
        _book = book;
        _chapter = chap;
        _startVerse = verse;
    }
    public Reference(string book, int chap, int start, int end)
    {
        _book = book;
        _chapter = chap;
        _startVerse = start;
        _endVerse = end;
    }

    public string GetDisplayText()
    {
        if (_endVerse != null)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }
}
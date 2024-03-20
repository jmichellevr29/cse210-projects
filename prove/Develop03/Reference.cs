public class Reference 
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // setter and getters 
    public string GetBook()
    {
        return _book;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    //functions
     public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    // display 
    public override string ToString()
    {
        if(_endVerse == -1)
            return $"{_book} {_chapter}: {_verse}";
        else if (_verse == _endVerse)
            return $"{_book} {_chapter}: {_verse}";
        else 
            return $"{_book} {_chapter}: {_verse}-{_endVerse}";
    }
}
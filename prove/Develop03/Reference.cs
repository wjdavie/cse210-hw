using System;

class Reference
{
    private string _verse;
    private string _endVerse;
    private string _book;
    private string _chapter;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetReferenceString()
    {
        if (_endVerse is null || _endVerse == _verse)
        return $"{_book} {_chapter}:{_verse}";  
        else
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}
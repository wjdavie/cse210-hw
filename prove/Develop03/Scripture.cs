using System;

class Scripture
{
    private Reference _reference;

    private List<Word> _words;
    private Random _random;

    public Scripture()
    {
        _words = new List<Word>();
        _random = new Random();
    }

    public void ShowScripture(Reference reference, string verse)
    {
        _reference = reference;
        string[] words = verse.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetScripture()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetWord() + " ";
        }
        return $"{_reference.GetReferenceString()}\n{scriptureText}";
    }

    public bool AllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void ShowWords()
    {
        foreach (Word word in _words)
        {
            word.ShowWord();
        }
    }

    public void HideWords() //As part of my "Showing Creativity" I set the HideWords method to only hid a maximum of 3 words at a time. It alwo makes sure that only words that are visible get hidden.
    {
        int allWords = _words.Count(w => !w.IsHidden());
        int toHide = Math.Min(3, allWords);

        int hiddenCount = 0;

        while (hiddenCount < toHide)
        {
            int index = _random.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].HideWord();
                hiddenCount++;
            }
        }
    }

}
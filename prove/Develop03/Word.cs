using System;
using System.Text;

class Word
{
    private string _text;
    private bool _hidden;
    private string _hiddenWord;

    public Word(string text)
    {
        _text = text;
        StringBuilder hiddenBuilder = new StringBuilder();
        foreach(char c in text)
        {
            hiddenBuilder.Append("_");
        }
        _hiddenWord = hiddenBuilder.ToString();

    }

    public void HideWord()
    {
        _hidden = true;
    }

    public void ShowWord()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetWord()
    {
        if(_hidden == true)
            return _hiddenWord; //Return underscores for each letter in the word.
        else
            return _text; //Return the visible text.
    }
}
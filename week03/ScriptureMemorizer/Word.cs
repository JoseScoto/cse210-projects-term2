using System;
using System.Collections.Generic;

class Word
{
    private string _text;
    private bool _isHidden;

    // Method to store a word
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Methods to hide or show the word
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Shows the word or the underscores if it's hidden
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}
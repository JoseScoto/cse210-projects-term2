class Scripture
{
    // Objects to store, reference and list
    private Reference _reference;
    private List<Word> _words;

    // Constructor that splits text into words and creates objects
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // This picks the random words that aren't hidden
    public void HideRandomWords(int numberToHide)
    {
        // Count how many words are not hidden yet
        int wordsLeft = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                wordsLeft++;
            }
        }
        
        // Make sure we don't try to hide more words than we have left
        int wordsToHide = numberToHide;
        if (wordsToHide > wordsLeft)
        {
            wordsToHide = wordsLeft;
        }
        
        Random random = new Random();
        int hiddenCount = 0;
        
        while (hiddenCount < wordsToHide)
        {
            int randomIndex = random.Next(0, _words.Count);
            
            // If this word isn't already hidden, hide it
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        
        // Combine all the word display texts with spaces
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        
        return $"{reference}: {scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        // Check if all words are hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
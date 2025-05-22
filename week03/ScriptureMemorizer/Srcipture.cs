public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitText = text.Split(" ");
        foreach (string t in splitText)
        {
            Word w = new Word(t);
            _words.Add(w);
        }
    }

    public void HideRandomWords(int numToHide)
    {
        Random random = new Random();
        int shownWords = _words.Count - NumberHidden();
        if (numToHide > shownWords)
        {
            numToHide = shownWords;
        }
        for (int i = 0; i < numToHide; i++)
        {
            // Find and hide a word that is not already hidden
            bool didHide = false;
            while (didHide == false)
            {
                int indexToHide = random.Next(0, _words.Count);
                if (_words[indexToHide].IsHidden() == false)
                {
                    _words[indexToHide].Hide();
                    didHide = true;
                }
            }
        }
    }
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        displayText += "\n   ";
        foreach (Word w in _words)
        {
            displayText += $" {w.GetDisplayText()}";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        int numHidden = NumberHidden();
        if (numHidden == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private int NumberHidden()
    {
        int numHidden = 0;
        foreach (Word w in _words)
        {
            if (w.IsHidden() == true)
            {
                numHidden++;
            }
        }
        return numHidden;
    }
}
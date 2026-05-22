public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<string> stringList = text.Split(' ').ToList();
        foreach (string i in stringList)
        {
            Word word = new Word(i);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomNumber = new Random();
        int randomSelection = 0;
        for (int i = 0; i < numberToHide; i++)
        {
            randomSelection = randomNumber.Next(_words.Count);
            if (_words[randomSelection].IsHidden() && IsCompletelyHidden() == false)
            {
                HideRandomWords(1);
            }
            else
            {
                _words[randomSelection].Hide();
            }
        }

    }

    public string GetDisplayText()
    {
        List<string> rawTextList = new List<string>();
        for (int i = 0; i < _words.Count; i++)
        {
            rawTextList.Add(_words[i].GetDisplayText());
        }
        string displayText = string.Join(" ", rawTextList);
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}
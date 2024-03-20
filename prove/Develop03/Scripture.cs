using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideRandomWord(int numberToHide)
    {
        Random rnd = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int index = rnd.Next(_words.Count);
            if(!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }
    public string GetDisplayText()
    {
        string textDisplayed = string.Join(" ",_words.Select(word => word.GetDisplayText()));
        return $"{_reference}: {textDisplayed}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}
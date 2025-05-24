public class Scripture
{
    private Reference _reference;
    private List<Word> _wordList;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _wordList = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string wordText in words)
        {
            Word word = new Word(wordText);
            _wordList.Add(word);
        }
    }

    public void HideRandomWords(int numberOfWords)
    {
        Random random = new Random();
        List<Word> unhiddenWords = _wordList.Where(w => !w.IsHidden()).ToList();
        numberOfWords = Math.Min(numberOfWords, unhiddenWords.Count);
        for (int i = 0; i < numberOfWords; i++)
        {
            int randomIndex = random.Next(unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
            unhiddenWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + "\n";
        foreach (Word word in _wordList)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _wordList)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
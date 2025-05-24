
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public string Reference { get; }
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        Reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide = 3)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        var random = new Random();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        return $"{Reference} | {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}

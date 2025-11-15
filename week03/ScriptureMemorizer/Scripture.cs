using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();
        string[] pieces = text.Split(" ");
        foreach (string piece in pieces)
        {
            Word w = new Word(piece);
            _words.Add(w);
        }
    }
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";
        foreach (Word w in _words)
        {
            result += w.GetDisplayText() + " ";
        }
        return result;
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rand.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            // stop if all are hidden
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
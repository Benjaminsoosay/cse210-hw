
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return _text.All(char.IsPunctuation) || _text.Length == 0
                ? _text  // don't replace punctuation or empty strings
                : new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}

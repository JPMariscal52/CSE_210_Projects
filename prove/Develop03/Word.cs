using System.Text;

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

    public string GetDisplayTextWord()
    {
        if (_isHidden == true)
        {
            string _wordHidden = "";

            foreach (char letra in _text)
            {
                _wordHidden += "_";
            }
            
            return _wordHidden;
        }
        else
        {
            return _text.ToString();
        }
    }

}
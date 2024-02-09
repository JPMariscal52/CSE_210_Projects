using System.Text;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, String text)
    {
        _reference = reference;

        string[] scriptureWords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in scriptureWords)
            {
                _words.Add(new Word(word));
            }
    }


    public void HiddeRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<int> wordsListIndex = new List<int>();

        int index = 0;
        foreach (var word in _words)
            {
                if (word.IsHidden()==false)
                    {
                        wordsListIndex.Add(index);
                    }
                    index++;
            }

        int wordsHideNumber = Math.Min(numberToHide, wordsListIndex.Count);

        for (int i = 0; i < wordsHideNumber; i++)
        {
            int randomIndex = random.Next(0, wordsListIndex.Count - 1);
            int wordIndex = wordsListIndex[randomIndex];
            
            Word randomWord = _words[wordIndex];
            randomWord.Hide();

            wordsListIndex.RemoveAt(randomIndex);
        }
    }


    public string GetDisplayTextScript()
    {
        string scriptureText = "";
        foreach (Word word in _words)
            {
                scriptureText += word.GetDisplayTextWord() + " ";
            }

        string reference = _reference.GetDisplayTextRef();

        return $"{reference} {scriptureText}";
    }

    public bool IsCompletelyHiden()
    {
        int hiddenWordsNumber = 0;

        foreach(Word word in _words)
        {
            bool boolValue = word.IsHidden();
            if(boolValue == true)
            {
                hiddenWordsNumber++;
            }

        }

        if(hiddenWordsNumber == _words.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

}
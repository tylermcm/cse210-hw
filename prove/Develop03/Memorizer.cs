using System;

class Memorizer
{
    private Scripture scripture;
    private List<string> _wordList;
    
    public Memorizer(Scripture _scripture)
    {
        scripture = _scripture;
        _wordList = new List<string>();
        textToList();
    }

    private void textToList()
    {
        _wordList = scripture.Output().Split(' ').ToList();
    }

    public void removeFromList()
    {
        int toRemove = new Random().Next(2,3);
        int wordsRemoved = 0;
        
        do 
        {
            int randIndex = new Random().Next(0, _wordList.Count());
            if (_wordList[randIndex].Contains('_') == false)
            {
                _wordList[randIndex] = new string('_', _wordList[randIndex].Length);
                wordsRemoved++;

            }

        }while (wordsRemoved != toRemove);  
    }

    public string Output()
    {
        return string.Join(' ', _wordList);
    }
    
    public bool wordsLeft()
    {
        bool returnValue = false;
        
        foreach (string word in _wordList)
        {
            if (word.Contains('_') == false)
            {
                returnValue = true;
                break;
            }
        }

        return returnValue;
    }

}


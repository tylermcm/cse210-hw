using System;

class Scripture
{
    private string text;
    private Reference reference;

    public Scripture(Reference _reference, string _text)
    {
        reference = _reference;
        text = _text;
    }
    
    public string Output()
    {
        return string.Format("{0}", text);
    }

    
}


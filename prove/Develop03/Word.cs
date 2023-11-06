using System;

public class Word
{
    private string word;
    private bool hidden;

    public Word(string word)
    {
        this.word = word;
        this.hidden = false;
    }

    public bool Hide() => hidden = true;

    public bool IsHidden()
    {
        return hidden;
    }

    public override string ToString()
    {
        if (hidden)
        {
            return "______";
        }
        return word;
    }
}

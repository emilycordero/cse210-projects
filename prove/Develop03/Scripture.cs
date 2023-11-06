using System;

public class Scripture
{
        private string reference;
        private string text;
        private List<Word> words;

        public Scripture(string reference, string text)
        {
            this.reference = reference;
            this.text = text;
            this.words = new List<Word>();

            // by using .Split method we will split the scripture text into words
            string[] wordArray = text.Split(' ');
            foreach (string word in wordArray)
            {
                words.Add(new Word(word));
            }
        }


        public void HideRandomWord()
        {
            Random random = new Random();
            int index = random.Next(words.Count);

            // Hide word at the random index if it is not already hidden
            if (words[index].IsHidden())
            {
                // if already hidden
                HideRandomWord();
            }
            else
            {
                words[index].Hide();
            }
        }

        // in the instance all words hidden, return true to exit program
        public bool AllWordsHidden()
        {
            foreach (Word word in words)
            {
                if (word.IsHidden())
                {
                    continue;
                }
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            string reconstructedText = "";
            foreach (Word word in words)
            {
                reconstructedText += " " + word;
            }

            return $"{reference}: {reconstructedText}";
        }
    }



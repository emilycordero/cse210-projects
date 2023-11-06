using System;

public class Reference
{

        private string reference;
        private string text;
        private string filepath = "scriptures.txt";
        // i couldn't figure out how to read and return a random scripture from a separate file but i tried to 

        public Reference(string reference, string filepath)
        {
            this.reference = reference;
            this.text = File.ReadAllText(filepath);
        }
        public string GetRandomScripture()
        {
            string[] scriptures = this.text.Split('.');
            Random random = new Random();
            int randomIndex = random.Next(0, scriptures.Length);
            return scriptures[randomIndex].Trim();
        
        }
}

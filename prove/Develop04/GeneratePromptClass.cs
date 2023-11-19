using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class GeneratePromptClass : Program
{
	public GeneratePromptClass()
	{
        string promptFile = File.ReadAllText("prompts.txt");
        List<string> promptList = new List<string>(promptFile.Split('.'));

        GeneratePrompt(promptFile);
        return;

    }
    static void GeneratePrompt(string prompt)
    {
        Random random = new Random();
        List<string> promptList = new List<string>();
        foreach (string line in promptList)
        {
            promptList.Add(line);
        }
        
        int randomIndex = random.Next(0, promptList.Count);
        prompt = promptList[randomIndex].Trim();

        Console.WriteLine(prompt);

    }

    internal void GeneratePrompt()
    {
        throw new NotImplementedException();
    }
}

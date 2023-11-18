using System;
using System.IO;

public class GeneratePromptClass
{
	public GeneratePromptClass()
	{
		
		string promptFile = 'prompts.txt';
		string content = "[Empty File]";
        List<string> promptList = new List<string>();
        
        foreach (string line in content.Split('.'))
		{
            promptList.Add(line);
        }

        Random random = new Random();
        int randomIndex = random.Next(0, promptList.Length);
        string prompt =  promptList[randomIndex].Trim();
        return prompt;
    }
    static void GeneratePrompt(string prompt)
    {
        Random random = new Random();
        List<string> list = new List<string>();
        list.Add("");
        int randomIndex = random.Next(0, List.Length);
    }
}

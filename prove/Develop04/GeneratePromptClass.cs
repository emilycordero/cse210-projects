using System;
using System.Collections.Generic;

public class GeneratePromptClass
{
    private List<string> promptList;

    public GeneratePromptClass()
    {
        string promptFile = "C:\\Users\\corde\\OneDrive\\Documents\\GitHub\\cse210-projects\\prove\\Develop04\\prompts.txt";
        promptList = new List<string>();

        foreach (string line in promptFile.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
        {
            promptList.Add(line);
        }
    }

    public string GeneratePrompt()
    {
        promptList = new List<string>();
        Random random = new Random();
        int randomIndex = random.Next(0, promptList.Count);
        string prompt = promptList[randomIndex].Trim();
        return prompt;
    }
}
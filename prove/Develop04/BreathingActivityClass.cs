public class BreathingActivityClass
{
    private DateTime startTime;
    private DateTime futureTime;
    private int duration;

    public BreathingActivityClass()
    {
        string _name = "Breathing";
        string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        duration = 6;
        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(duration);
        ProcessNumber(duration);
    }

    public void ProcessNumber(int duration)
    {
        while (startTime < futureTime)
        {
            breathIn();
            breathOut();
        }
    }

    public void breathIn()
    {
        string breath = "Breathe in ";
        Console.WriteLine(breath);
        for (int i = 0; i < duration; i++)
        {
            Console.Write(i);
        }
    }

    public void breathOut()
    {
        string breath = "Breathe out ";
        Console.WriteLine(breath);
        for (int i = 0; i < duration; i++)
        {
            Console.Write(i);
        }
    }
}
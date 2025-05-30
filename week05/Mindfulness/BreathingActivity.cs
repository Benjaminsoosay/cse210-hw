
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing";
        description = "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.";
    }

    public void Run()
    {
        Start();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Pause(4);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            Pause(6);
            Console.WriteLine("\n");
        }

        End();
    }
}


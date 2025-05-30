
public class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name} Activity.");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void End()
    {
        Console.WriteLine("Well done!");
        DisplayAnimation();
        Console.WriteLine($"You have completed the {name} Activity for {duration} seconds.");
        DisplayAnimation();
    }

    protected void DisplayAnimation()
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < 10; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
        }
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}


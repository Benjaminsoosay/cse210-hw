
namespace EternalQuest
{
    public abstract class Goal
    {
        public string Name { get; }
        public string Description { get; }
        public int Points { get; }

        protected Goal(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
        }

        public abstract int RecordEvent();
        public abstract override string ToString();
        public abstract string ToFileString();
    }
}


namespace EternalQuest
{
    class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordEvent()
        {
            return Points;
        }

        public override string ToString()
        {
            return $"[EternalGoal] {Name}: {Description} - Points: {Points}";
        }

        public override string ToFileString()
        {
            return $"EternalGoal|{Name}|{Description}|{Points}";
        }
    }
}

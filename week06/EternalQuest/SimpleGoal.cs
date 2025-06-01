
namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        private bool _isCompleted;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isCompleted = false;
        }

        public override int RecordEvent()
        {
            if (!_isCompleted)
            {
                _isCompleted = true;
                return Points;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"[SimpleGoal] {Name}: {Description} - Points: {Points} - Completed: {_isCompleted}";
        }

        public override string ToFileString()
        {
            return $"SimpleGoal|{Name}|{Description}|{Points}|{_isCompleted}";
        }
    }
}

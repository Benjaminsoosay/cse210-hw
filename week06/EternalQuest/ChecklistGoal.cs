
namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        private int _targetCount;
        private int _bonusPoints;
        private int _currentCount;

        public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount = 0)
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _bonusPoints = bonusPoints;
            _currentCount = currentCount;
        }

        public override int RecordEvent()
        {
            if (_currentCount < _targetCount)
            {
                _currentCount++;
                if (_currentCount == _targetCount)
                {
                    return Points + _bonusPoints;
                }
                return Points;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"[ChecklistGoal] {Name}: {Description} - Points: {Points} - Completed: {_currentCount}/{_targetCount}";
        }

        public override string ToFileString()
        {
            return $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_bonusPoints}|{_currentCount}";
        }
    }
}

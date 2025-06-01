
using System.Collections.Generic;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        // Add other methods as needed
    }
}


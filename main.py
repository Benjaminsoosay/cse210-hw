
from goal_manager import GoalManager
from simple_goal import SimpleGoal
from eternal_goal import EternalGoal
from checklist_goal import ChecklistGoal

def main():
    manager = GoalManager()

    # Create some goals
    goal1 = SimpleGoal("Read a book", 10)
    goal2 = EternalGoal("Exercise daily", 5)
    goal3 = ChecklistGoal("Complete project milestones", 15, 3, 10)

    # Add goals to manager
    manager.add_goal(goal1)
    manager.add_goal(goal2)
    manager.add_goal(goal3)

    # Display goals
    manager.display_goals()

    # Mark some goals as completed
    goal1.mark_completed()
    goal3.mark_completed()
    goal3.mark_completed()
    goal3.mark_completed()

    print("\nAfter marking some goals as completed:\n")
    manager.display_goals()

    # Save goals to file
    manager.save_goals("goals.json")

    # Load goals from file
    new_manager = GoalManager()
    new_manager.load_goals("goals.json")

    print("\nLoaded goals from file:\n")
    new_manager.display_goals()

if __name__ == "__main__":
    main()

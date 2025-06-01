
namespace ExerciseTracking
{
    public abstract class Activity
    {
        public string Date { get; }
        public int Length { get; }

        protected Activity(string date, int length)
        {
            Date = date;
            Length = length;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{Date} {this.GetType().Name} ({Length} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
        }
    }
}

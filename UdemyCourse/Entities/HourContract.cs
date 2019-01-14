using System;

namespace UdemyCourse.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Duration { get; set; }

        public HourContract(DateTime date, double valuePerHour, int duration)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Duration = duration;
        }

        public double TotalValue()
        {
            return Duration * ValuePerHour;
        }
    }
}

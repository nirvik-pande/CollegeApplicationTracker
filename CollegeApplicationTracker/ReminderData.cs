using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApplicationTracker
{
    public static class ReminderData
    {
        public static List<Reminder> Reminders { get; set; } = new List<Reminder>();
    }

    public class Reminder
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Date.ToShortDateString()} {Time.ToShortTimeString()}";
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Person
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public void Reply(object sender, AlarmEventArgs e)
        {
            if (sender is AlarmClock alarmClock)
                Console.WriteLine($"{Name}: Эй, {alarmClock.Name}! " +
                    $"Уже {e.Time.ToShortTimeString()}? {Message}");
        }
    }
}

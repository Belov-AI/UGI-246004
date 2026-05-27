using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class AlarmEventArgs : EventArgs
    {
        public DateTime Time { get; set; }
        public string EventDescription { get; set; }
    }

    internal delegate void AlarmEventHandler(object sender, AlarmEventArgs e);

    internal class AlarmClock
    {
        public string Name { get; set; }

        public event AlarmEventHandler Ring;

        protected virtual void OnRing(AlarmEventArgs e)
        {
            if (Ring != null)
            {
                Console.WriteLine(
                    $"{e.EventDescription}!!! Уже {e.Time.ToShortTimeString()}!");

                Ring(this, e);
            }
        }

        public void WakeUp(string description) => OnRing(new AlarmEventArgs() 
            { Time = DateTime.Now, EventDescription = description });
    }
}

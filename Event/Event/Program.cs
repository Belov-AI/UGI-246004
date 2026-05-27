using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alarm = new AlarmClock() { Name = "будильник" };

            var boy = new Person() { Name = "Ваня", Message = "Дай поспать!" };
            alarm.Ring += boy.Reply;

            var girl = new Person() { Name = "Таня", Message = "Уже встаю..." };
            alarm.Ring += girl.Reply;

            var dog = new Dog() { Name = "Бобик" };
            alarm.Ring += dog.Bark;

            alarm.WakeUp("Пора вставать");

            alarm.Ring -= boy.Reply;

            Console.WriteLine();
            alarm.WakeUp("Хватит спать!");
        }
    }
}

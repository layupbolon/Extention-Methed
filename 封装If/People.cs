using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 封装If
{
    public class People
    {
        public string Name { get; set; }
        public bool IsHungry { get; set; }
        public bool IsThirsty { get; set; }
        public bool IsTired { get; set; }
        public int WorkCount { get; private set; }

        public void Eat()
        {
            Console.WriteLine("Eat");
            IsHungry = false;
        }
        public void Drink()
        {
            Console.WriteLine("Drink");
            IsThirsty = false;
        }
        public void Rest()
        {
            Console.WriteLine("Rest");
            IsTired = false;
        }
        public void Work()
        {
            Console.WriteLine("Work");
            IsHungry = IsThirsty = IsTired = true;
            WorkCount++;
        }
    }

    public static class Extention
    {
        public static T If<T>(this T t, Predicate<T> predicate, params Action<T>[] actions) where T : class
        {
            if (t == null) throw new ArgumentNullException();
            if (predicate(t))
            {
                foreach (var action in actions)
                    action(t);
            }
            return t;
        }
    }
}

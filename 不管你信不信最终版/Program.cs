using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 不管你信不信最终版
{
    class Program
    {
        public static Func<Predicate<IThing>, Func<IThing, Func<bool>>> whatEver = p => i => () => p(i);
        static void Main(string[] args)
        {
            IThing it = null;
            IPerson you = null;
            IPerson I = null;
            if (whatEver(you.Believe)(it).OrNot())
            {
                I.Believe(it);
            }
        }
    }

    public interface IPerson
    {
        bool Believe(IThing thing);
    }
    public interface IThing
    {
        void JustHappened();
    }

    public static class Extensions
    {
        public static bool OrNot(this Func<bool> func)
        {
            return func() || !func();
        }
    }
}

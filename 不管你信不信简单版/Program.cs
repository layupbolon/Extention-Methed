using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 不管你信不信简单版
{
    class Program
    {
        static void Main(string[] args)
        {
            IThing it = null;
            IPerson you = null;
            IPerson I = null;

            try
            {
                if (((WhatEver)you.Believe).OrNot(it))
                {
                    I.Believe(it);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("It's a miracle!");
            }
            finally
            {
                it.JustHappened();
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

    public delegate bool WhatEver(IThing obj);
    public static class Extensions
    {
        public static bool OrNot(this WhatEver func, IThing t)
        {
            return func(t) || !func(t);
        }
    }
}

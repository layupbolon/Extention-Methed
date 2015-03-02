using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    public class BaseClass
    {
        public int publicInt;
        protected int protectedInt;
        internal int internalInt;
        private int privateInt;
    }

    public class Class1 : BaseClass
    {
    }

    public class Class2 : Class1
    {
    }

    public static class Extention
    {
        public static void ExtentFunction(this BaseClass baseClass)
        {
            //baseClass.
        }
    }
}

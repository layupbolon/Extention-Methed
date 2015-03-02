using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    public interface ITestA { }
    public static class ITestAHelper
    {
        public static void TestA(this ITestA obj)
        {
            Console.WriteLine("ITestAHelper.TestA");
        }
    }
    public interface ITestB { }
    public static class ITestBHelper
    {
        public static void TestB(this ITestB obj)
        {
            Console.WriteLine("ITestBHelper.TestB");
        }
    }
    public class Test : ITestA, ITestB
    {
        //public void TestA()
        //{
        //    Console.WriteLine("Test.TestA");
        //}
    }
}

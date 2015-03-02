using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using ExtentionSimple;
//using Extention;
//using InheritanceTest;
//using 封装If;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region string

            //"test extention function".Print();
            //"123".AsRegexableString().

            #endregion

            #region 封装If

            ////常规代码
            //People people1 = new People { Name = "张三", IsHungry = true, IsThirsty = true, IsTired = true };
            //if (people1.IsHungry) people1.Eat();
            //if (people1.IsThirsty) people1.Drink();
            //if (people1.IsTired) people1.Rest();
            //if (!people1.IsHungry && !people1.IsThirsty && !people1.IsTired) people1.Work();

            ////使用扩展方法
            //People people2 = new People { Name = "李四", IsHungry = true, IsThirsty = true, IsTired = true }
            //    .If(p => p.IsHungry, p => p.Eat())
            //    .If(p => p.IsThirsty, p => p.Drink())
            //    .If(p => p.IsTired, p => p.Rest())
            //    .If(p => !p.IsHungry && !p.IsThirsty && !p.IsTired, p => p.Work());

            #endregion

            #region 类继承

            //Class1 c1 = new Class2();
            //c1.ExtentFunction();

            #endregion

            #region 接口

            //Test obj1 = new Test();
            //obj1.TestA();
            //obj1.TestB();

            #endregion

            #region LINQ

            //List<int> ids = new List<int>() { 1, 2, 3, 4, 5 };
            //var result = ids.Where(i => i > 3);
            //Console.WriteLine(string.Join(",", result));

            #endregion

            Console.ReadKey();
        }
    }
}

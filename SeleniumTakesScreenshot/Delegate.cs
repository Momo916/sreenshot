using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTakesScreenshot
{
    delegate void DelegateName(string input);
    public class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }
        public void Say(string message)
        {
            Console.WriteLine("{0} says:{1}", name, message);
        }
    }
    public class Delegate
    {
        public static void dd()
        {
            int? x = null;
            x = 5;

            int z = x ?? 10;
            Console.WriteLine("z={0}", z);
        }

    }








    delegate void DG(int a, int b);//声明委托类型

    class comp
    {
        
        public static void Method(int a, int b)
        {
            Console.WriteLine((a > b).ToString());
        }
        public static void Method2(int a, int b)
        {
            Console.WriteLine((a < b).ToString());
        }
    }
    class Persons
    {
        public static void ps(int a,int b)
        {
            Console.WriteLine("I am a person!");
        }

    }
    public class mains
    {
        DG Instance = comp.Method; //声明委托实例
        DG test = Persons.ps;

        public void M()
        {
            Instance += comp.Method2;
            Instance(1, 2);
            //var a = (DG[])Instance.GetInvocationList();
            //a[0].Invoke(1, 2);
            test(0,1);
        }

    }


}

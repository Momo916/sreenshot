using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using System.IO;

namespace SeleniumTakesScreenshot
{
    class Program
    {
        static void Main(string[] args)
        {
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //Console.WriteLine("the driver handle is: "+driver.WindowHandles[0]);

            ////Puts a Implicit wait, Will wait for 10 seconds before throwing exception
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            ////Launch website
            //driver.Navigate().GoToUrl("http://www.calculator.net/");

            ////Maximize the browser
            //driver.Manage().Window.Maximize();

            //// Click on Math Calculators
            //driver.FindElement(By.CssSelector("div#menu>div:nth-child(3)>a")).Click();
            //Console.WriteLine("the driver handle is: " + driver.WindowHandles[0]);

            //// Click on Percent Calculators
            //driver.FindElement(By.CssSelector("div#menu>div:nth-child(4)>div:nth-child(3)>a")).Click();

            //// Enter value 10 in the first number of the percent Calculator
            //driver.FindElement(By.Id("cpar1")).SendKeys("10");

            //// Enter value 50 in the second number of the percent Calculator
            //driver.FindElement(By.Id("cpar2")).SendKeys("50");

            //// Click Calculate Button
            //driver.FindElement(By.XPath(".//*[@id='content']/table/tbody/tr[2]/td/input[2]")).Click();

            //// Get the Result Text based on its xpath
            //String result = driver.FindElement(By.XPath(".//*[@id='content']/p[2]/font/b")).Text;

            //File screenshot = ((ITakesScreenshot)driver).GetScreenshot(OutputType.FILE);

            ////FileUtils.copyFile(screenshot, new File("D:screenshotsscreenshots1.jpg"));	

            ////Print a Log In message to the screen
            //Console.WriteLine(" The Result is " + result);

            ////Close the Browser.
            //driver.Close();

            //List<int> list = new List<int>()
            //{
            //    1,5,3,11,0
            //};
            //list.OrderBy(p => p);

            //Console.WriteLine(list.Max(p=>p));
            //foreach (var num in list)
            //{
            //    Console.WriteLine(num);
            //}

            //List<Product> products = Product.GetSampleProducts();

            //Predicate<Product> test = delegate(Product p) { return p.Price > 10m; };
            //List<Product> match = products.FindAll(test);
            //match.OrderBy(p => p.Price);
            //foreach (var p in match.OrderBy(p => p.Price))
            //{
            //    Console.WriteLine(p);
            //}

            //products.Sort((x, y) => x.Price.CompareTo(y.Price));
            //foreach (var p in match.OrderBy(p => p.Price))
            //{
            //    Console.WriteLine(p);
            //}
            //Action<Product> print = Console.WriteLine;
            //match.ForEach(print);

            //products.Sort(delegate(Product x, Product y) { return x.Name.CompareTo(y.Name); });
            //products.Sort((x, y) => x.Name.CompareTo(y.Name));
            //products.OrderBy(p => p.Name);
            //foreach (var product in products.OrderBy(p => { return p.Name; }))
            //{
            //    Console.WriteLine(product);
            //}

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            //Query.query();
            //Query.queryAndSort();
            //Query.queryWithLINQ();
            //SaveAs.SaveAsExcel();
            //Console.WriteLine(Reverse.reverse("hello world!"));
            //Person p = new Person("Lily");
            //p.Say("dd");
            //Delegate.dd();

            //string text = @"Do you like green eggs and ham? I do not like them, Sam-I-am. I do not like green eggs and ham.";

            //Dictionary<string, int> fre = Dictionary.CountWords(text);


            //foreach (KeyValuePair<string, int> item in fre)
            //{
            //    string word = item.Key;
            //    int count = item.Value;
            //    Console.WriteLine("{0},{1}", word, count);
            //}

            //foreach (var item in fre)
            //{
            //    Console.WriteLine("{0},{1}", item.Key, item.Value);

            //}

            //Console.WriteLine(Reverse.reverse("hello"));
            //string dd = "word";
            //Console.WriteLine(dd.reverse());

            //string[] str = { "hello","world"};
            //string str = "hello";
            //Console.WriteLine(str);
            //str.Reverse();
            //Console.WriteLine(str);
            //foreach (var item in str.Reverse())
            //{
            //    Console.WriteLine(item);
            //}

            //mains ma = new mains();
            //ma.M();

            //int longth = longestSubString.Queue("momo momo  momo    momo");
            //int longth = longestSubString.lengthOfLongestSubstring("abcadef");
            //Console.WriteLine(longth);

            int[] ifDup = new int[] { 1, 2, 3,4,5,4};
            Console.WriteLine(IfHasDupElements.IfDupM2(ifDup));
            

            //int[] num = new int[] {3,4,5,9,10,13};
            //List<string> range = SummaryofRange.summaryRanges(num);
            //foreach (var item in range)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            Console.ReadKey();



        }

    }
}

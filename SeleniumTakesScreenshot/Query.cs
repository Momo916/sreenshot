using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace SeleniumTakesScreenshot
{
    class Query
    {
        static List<Product> products = Product.GetSampleProducts();
        static List<Supplier> suppliers = Supplier.GetSampleSupplier();

        static Action<Product> print = Console.WriteLine;
        public static void query()
        {
            foreach (var product in products.Where(p => p.Price > 11m))
            {
                Console.WriteLine(product);
            }
        }
        public static void queryAndSort()
        {
            foreach (var item in products.Where(p => p.Price > 10).OrderBy(p => p.Price))
            {
                Console.WriteLine(item);
            }
         
        }
        public static void queryWithNull()
        {
            foreach (var product in products.Where(p => p.Price == null))
            {
                Console.WriteLine(product.Name
                    );
            }
        }
        public static void queryWithExpression()
        {
            var filtered = from Product p in products where p.Price > 10m select p;
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }
        public static void queryWithLINQ()
        {
            //products.ForEach(Console.WriteLine);
            suppliers.ForEach(Console.WriteLine);

            var filtered = from p in products
                           join s in suppliers
                           on p.SupplierID equals s.SupplierID
                           where p.Price > 10m
                           orderby s.Name, p.Name
                           select new { SupplierName = s.Name, ProductName = p.Name };
            foreach (var f in filtered)
            {
                Console.WriteLine("Supplier={0}; Product={1}", f.SupplierName, f.ProductName);
            }
        }
        public void queryFromXML()
        {
            XDocument doc = XDocument.Load("data.XML");
            var filtered = from p in doc.Descendants("Product")
                           join s in doc.Descendants("Supplier")
                           on (int)p.Attribute("SupplierID") equals (int)s.Attribute("SupplierID")
                           where (decimal)p.Attribute("Price") > 10
                           orderby (string)s.Attribute("Name"), (string)p.Attribute("Name")
                           select new { SupplierName = (string)s.Attribute("Name"), ProductName = (string)p.Attribute("Name") };
        }
        public void SaveAsExcel()
        {
            //var app= new ApplicationException
        }
    }
}

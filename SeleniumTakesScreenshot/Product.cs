using System.Collections;
using System.Collections.Generic;
public class Product
{
    public string Name { get; private set; }
    //public decimal Price { get; private set; }
    public int SupplierID { get; private set; }
    private decimal? price;
    public decimal? Price
    {
        get { return price; }
        private set { price = value; }
    }
    public Product(string name, decimal price,int supplierID)
    {
        Name = name;
        Price = price;
        SupplierID = supplierID;
    }
    Product() { }
    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product(name:"West Side Story",price:9.99m,supplierID:0),
            new Product(name:"Assassins",price:114.99m,supplierID:1),
            new Product(name:"Frogs",price:13.99m,supplierID:2),
            new Product(name:"Sweeney Todd",price:10.99m,supplierID:3),
            new Product(name:"Toy Todd",price:105.99m,supplierID:4),

        };
    }
    public override string ToString()
    {
        return string.Format("{0}:{1}", Name, Price);
    }
}
class ProductNameCompare : IComparer<Product>
{
    public int Compare(Product x, Product y)
    {
        //return x.Name.CompareTo(y.Name);
        return x.Name.CompareTo(y.Price);

    }
}

class ProductNameCompare1 : IComparer<string>
{
    public int Compare(string x, string y)
    {
        return x.CompareTo(y);
    }
}
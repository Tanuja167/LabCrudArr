using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCrudArr
{
    public class Product
    {
        int id;
        String name;
        int price;
        public Product(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return id + " :" + name + " " + price;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }

    public class ProductImplementation
    {
        Product[] product;
        int count;
        public ProductImplementation()
        {
            product = new Product[5];
            count = 0;
        }
        public void AddProduct(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the id");
                int pid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Product name");
                String pname = Console.ReadLine();
                Console.WriteLine("Entre the price");
                int price = int.Parse(Console.ReadLine());
                product[count] = new Product(pid, pname, price);
                count++;
            }
        }
        public void ShowAllProduct()
        {
            for (int i = 0; i < count; i++)
            {
                if (product[i] != null)
                {
                    Console.WriteLine(product[i]);
                }
            }
        }
        public void SearchProductById(int id)
        {
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i] != null)
                {
                    if (product[i].Id == id)
                    {
                        Console.WriteLine(product[i]);
                    }
                    if (product[i].Id != id)
                    {
                        Console.WriteLine("Product is not prsent: ");
                    }
                }
            }
        }
        public void UpadteProduct(int id, int newprice)
        {
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i] != null)
                {
                    if (product[i].Id == id)
                    {
                        product[i].Price = newprice;
                    }

                    if (product[i].Id != id)
                    {
                        Console.WriteLine("Id not match: ");
                    }
                }
            }
        }
        public void DeleteProduct(int id)
        {
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i] != null)
                {
                    if (product[i].Id == id)
                    {
                        product[i] = null;
                    }
                    if (product[i].Id != id)
                    {
                        Console.WriteLine("This product is not Available:"); ;
                    }
                }
            }
        }
    }


}


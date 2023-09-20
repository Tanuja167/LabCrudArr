using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCrudArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductImplementation product = new ProductImplementation();
            char ch = ' ';
            do
            {
                Console.WriteLine("1.Add\n2.Show\n3.Update\n4.Delete\n 5.Serach");
                Console.WriteLine("enter the choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many products you want to add");
                        int n = Convert.ToInt32(Console.ReadLine());
                        product.AddProduct(n);
                        break;
                    case 2:
                        Console.WriteLine("////////////////////");
                        product.ShowAllProduct();
                        break;
                    case 3:
                        Console.WriteLine("enter the id for update");
                        int pid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the new price");
                        int price = int.Parse(Console.ReadLine());
                        product.UpadteProduct(pid, price);
                        break;
                    case 4:
                        Console.WriteLine("Enter the id for delete");
                        int dbid = Convert.ToInt32(Console.ReadLine());
                        product.DeleteProduct(dbid);
                        break;
                    case 5:
                        Console.WriteLine("Enter id for search");
                        int id = int.Parse(Console.ReadLine());
                        product.SearchProductById(id);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Do you want to continue....");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');






            

        }
    }
}


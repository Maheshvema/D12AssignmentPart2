using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            herbalproduct product = new herbalproduct();
            product.Set();
            product.Show();
            Console.ReadKey();
        }
    }
}
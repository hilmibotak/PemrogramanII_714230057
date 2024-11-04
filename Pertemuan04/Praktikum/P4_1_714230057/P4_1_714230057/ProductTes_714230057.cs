using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230057
{
    internal class ProductTes_714230057
    {
        static void Main(string[] args)
        {
            //Product_714230069 myProduct = new Product_714230069();

            //jawaban no 14 sehingga bisa running
            //Console.WriteLine(myProduct.GetMyType());

            //myProduct.MyType = "DVD";

            //Console.WriteLine(myProduct.MyType);

            Book_714230057 product1 = new Book_714230057("Book", "C# Object Oriented Solution", "300");
            DVD_714230057 product2 = new DVD_714230057("Ethernal Sunshine Of The Spotless Mind", "145");

            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}

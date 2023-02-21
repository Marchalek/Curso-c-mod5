using System;
using System.Globalization;
namespace Course_mod5 {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("T");

            Console.WriteLine(p);
        }
    }
}
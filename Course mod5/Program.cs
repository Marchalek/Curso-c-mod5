namespace Course_mod5 {

    internal class Program {

        private static void Main(string[] args) {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "tv 4lk";

            Console.WriteLine(p);
        }
    }
}
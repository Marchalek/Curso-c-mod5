using System.Globalization;
namespace Course_mod5 {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
            _quantidade = 0;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            _quantidade = quantidade;
        }

        public string GetNome() {
            return this._nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                this._nome = nome;
            }

        }

        public double GetPreco() {
            return this._preco;
        }

        public int GetQuantidade() {
            return this._quantidade;
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

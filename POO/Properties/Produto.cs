using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //assim ele aceita tando com a sobrecarga quanto com a classe vazia, sem passagem de parametros
        public Produto()
        {

        }

        //os contrutores, o que faz ser possivel quando se instancia a classe já passar os parametros pela propria classe

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //propriedades. permite que você use no código principal Só o a chamada do atributo pra ficar mais visual
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $"
                + Preco.ToString("f2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, total: $  "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
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
            return Nome
                + ", $"
                + Preco.ToString("f2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, total: $  "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

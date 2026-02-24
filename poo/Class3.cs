using System;
using System.Collections.Generic;
using System.Text;

namespace poo
{
        public class Produto
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome , decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    public class Produtoimportado : Produto
    {
        public decimal taxaalfandegaria { get; set; }

        public Produtoimportado(string nome , decimal preco , decimal taxa ) : base(nome, preco)
        {
            taxaalfandegaria = taxa;
        }
        public void Calcularprecofinal()
        {
            Preco += taxaalfandegaria;
        }
    }
    class Class3
    {
           static void Main(string[] args)
        {
            Produtoimportado ps5 = new Produtoimportado("PS5", 4000.00m, 500.00m);

            ps5.Calcularprecofinal();
        }
    }
}

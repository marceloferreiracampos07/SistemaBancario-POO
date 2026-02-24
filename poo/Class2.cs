using System;
using System.Collections.Generic;
using System.Text;

namespace poo
{
    public class Veiculo
    {
        public virtual void mover()
        {
            Console.WriteLine("o veiculo esta se movendo ");
        }
    }
    public class Aviao : Veiculo
    {
        public override void mover()
        {
            Console.WriteLine("o aviao esta voando");
        }


    }
    public class Carro : Veiculo
    {
        public override void mover()
        {
            Console.WriteLine("o carro essa acelerando");
        }
    }
    class Class2
    {
        static void Main(string[] args)
        {
            List<Veiculo> garagem = new List<Veiculo>();



            garagem.Add(new Aviao());
            garagem.Add(new Carro());
            garagem.Add(new Veiculo());

            Console.WriteLine("--- Testando o Polimorfismo ---");

            foreach (var v in garagem)
            {

                v.mover();
            }
        }
    }
}

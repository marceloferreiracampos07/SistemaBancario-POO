using System;
using System.Collections.Generic;
using System.Text;

namespace poo
{
    public class Meiopagamento
    {
        protected decimal valor {  get; set; }

        public Meiopagamento(decimal valor )
        {
            this.valor = valor;
        }
        public virtual void Efetuarpagamento()
        {
            Console.WriteLine($"iniciando pagamneto no valor de {valor}");
        }
    }
    public class Pix : Meiopagamento
    {
        private string _chavePix;

        public Pix(string chavePix , decimal valor ) : base(valor)
        {
            _chavePix = chavePix;
        }
        public override void Efetuarpagamento()
        {
            Console.WriteLine($"pagamento via pix realizado para a chave {_chavePix} no valor de {valor}");
        }
      
        
    }
    public class Cartao : Meiopagamento
    {
        protected int parcelas { get; set; }

        public Cartao(int parcelas , decimal valor ) : base(valor)
        {
            this.parcelas = parcelas;
        }
        public override void Efetuarpagamento()
        {
            decimal valordivido = valor / parcelas;

            Console.WriteLine($"pagamento foi feito em {parcelas} parcelas  de R$ {valordivido}");
        }
    }
   class Class4
    {
        static  void Main(string[] args)
        {
            Pix pagamentoPix = new Pix("81986225088", 150.00m);
            pagamentoPix.Efetuarpagamento();

        }
    }
}

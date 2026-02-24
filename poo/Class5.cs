using static System.Net.Mime.MediaTypeNames;

namespace poo
{
    public class Contabanco
    {
        protected string? Conta {  get; set; }
        protected string? Nome { get; set; }
        protected decimal Saldo { get; set; }

        public Contabanco(string conta , string nome , decimal saldo)
        {
            this.Conta = conta;
            this.Nome = nome;
            this.Saldo = saldo;
        }
        public virtual void Exibirsaldo()
        {
            Console.WriteLine($"seu saldo é de {Saldo}");
        }
        public virtual void Depositar(decimal valor )
        {
            valor += Saldo;
            Console.WriteLine($"foi realizado um deposito de {valor}");
        }
        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;
            Console.WriteLine($"foi realizado um saque no valor de {valor}");
        }
    }
    public class ContaCorrente : Contabanco
    {
        public ContaCorrente(string conta, string nome, decimal saldo) : base(conta, nome, saldo)
        {
        }

        public override void Exibirsaldo()
        {
            Console.WriteLine($"o saldo da sua conta corrente é R${Saldo}");
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"foi realizado um deposito de R${valor} na sua conta corrente");
        }

        public override void Sacar(decimal valor)
        {
            Saldo -= valor;
            Console.WriteLine($"saque no valor de R${valor} realizado com sucesso da sua conta corrente");
        }
    }
    public class Contapoupanca : Contabanco
    {
        
        public Contapoupanca(string conta, string nome, decimal saldo) : base(conta, nome, saldo)
        {
        }

        public const decimal TaxaJuros = 0.005m;

      
        public override void Depositar(decimal valor)
        {
            decimal rendimento = valor * TaxaJuros;
            Saldo += (valor + rendimento);
            Console.WriteLine($"Depósito de {valor} realizado com rendimento de {rendimento}.");
        }

     
        public override void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso.");
            }
            else
            {
               
                Console.WriteLine(" Saldo insuficiente para este saque.");
            }
        }
    }
    public class Containvestimento : Contabanco
    {
        public Containvestimento(string conta , string nome , decimal saldo ) : base(conta ,nome,saldo) 
        {
            
        }
        public const decimal TaxaRemuneracao = 0.009m;
        public const decimal Taxaimposto = 0.001m;

        public override void Depositar(decimal valor)
        {
            decimal juros = valor * TaxaRemuneracao;
            Saldo += (valor + juros);

        }
        public override void Exibirsaldo()
        {
            Console.WriteLine($"seu saldo da conta investimento {Saldo}");
        }
        public override void Sacar(decimal valor)
        {
            decimal imposto = valor * Taxaimposto;
            decimal total = valor + imposto;
            if (Saldo >= total)
            {
                Saldo -= total;
                Console.WriteLine($"seu saldo atualizado {Saldo}");
            }
            else
            {
                Console.WriteLine("nao foi possivel o valor do saque é maior que o saldo");
            }
        }

    }
    class Class5
    {
        

           
static void Main(string[] args)
            {
                Console.WriteLine("--- TESTE CONTA CORRENTE ---");
                ContaCorrente cc = new ContaCorrente("101", "Fulano", 0m);
                cc.Depositar(500m);
                cc.Sacar(200m);
                cc.Exibirsaldo();

                Console.WriteLine("\n--- TESTE CONTA POUPANÇA ---");
                Contapoupanca cp = new Contapoupanca("202", "Beltrano", 0m);
                cp.Depositar(1000m);
                cp.Exibirsaldo();
                cp.Sacar(1200m);
                cp.Sacar(500m);
                cp.Exibirsaldo();

                Console.WriteLine("\n--- TESTE CONTA INVESTIMENTO ---");
                Containvestimento ci = new Containvestimento("303", "Ciclano", 0m);
                ci.Depositar(1000m);
                ci.Exibirsaldo();

                ci.Sacar(100m);
                ci.Exibirsaldo();

                Console.ReadLine();
            }
    }
}

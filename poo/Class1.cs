using System;

namespace poo
{
  
    public class Personagem
    {
        public string? Nome { get; set; }
        public int Nivel { get; set; }

        public virtual void ExibirPersonagem()
        {
            Console.WriteLine($"Nome: {Nome}, Nível: {Nivel}");
        }
    }

    public class Guerreiro : Personagem
    {
        public decimal Forca { get; set; }

        public void AtacarComEspada()
        {
            
            Console.WriteLine($"{Nome} atacou com espada! Força de impacto: {Forca}");
        }
    }

    
    public class Mago : Personagem
    {
        public int Mana { get; set; }

        public void LancarFeitico()
        {
            Console.WriteLine($"{Nome} lançou uma bola de fogo gastando {Mana} de mana!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Guerreiro gaur = new Guerreiro();
            gaur.Nome = "Aragorn";
            gaur.Nivel = 10;
            gaur.Forca = 85.5m;

            gaur.ExibirPersonagem(); 
            gaur.AtacarComEspada(); 

            Console.WriteLine("---");

          
            Mago m = new Mago { Nome = "Gandalf", Nivel = 20, Mana = 100 };
            m.ExibirPersonagem();
            m.LancarFeitico();
        }
    }
}
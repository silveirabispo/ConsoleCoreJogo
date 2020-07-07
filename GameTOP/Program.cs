using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador("Ronaldo"));
            jogo.IniciarJogo();
        }
    }

    public class Jogador
    {
        public string _Nome { get; set; }
        public Jogador(string nome)
        {
            _Nome = nome;
        }

        public void Chuta()
        {
            Console.Write($"{_Nome} esta chutando.");
        }

        public void Corre()
        {
            Console.Write($"{_Nome} esta correndo.");
        }

        public void Passa()
        {
            Console.Write($"{_Nome} está passando.");
        }
    }
}

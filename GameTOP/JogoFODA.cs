namespace GameTOP
{
    public class JogoFODA
    {
        private readonly Jogador _jogador;
        public JogoFODA(Jogador jogador)
        {
            _jogador = jogador;

        }

        public void IniciarJogo()
        {
            System.Console.Write($"{_jogador._Nome} deu um passe");
        }
    }
}
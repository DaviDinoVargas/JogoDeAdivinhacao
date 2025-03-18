namespace JogoDeAdivinhacaoConsoleApp1
{
    public static class JogoDeAdivinhacao
    {
        public static int numeroSecreto;
        public static int totalTentativas;

        public enum ResultadoTentativa
        {
            Acertou,
            NumeroMenor,
            NumeroMaior
        }

        public static void IniciarNovoJogo(int tentativas)
        {
            Random geradorDeNumeros = new Random();
            numeroSecreto = geradorDeNumeros.Next(1, 21);
            totalTentativas = tentativas;
        }
        public static ResultadoTentativa VerificarTentativa(int numeroDigitado)
        {
            if (numeroDigitado == numeroSecreto)
                return ResultadoTentativa.Acertou;

            return numeroDigitado > numeroSecreto ?
            ResultadoTentativa.NumeroMaior :
            ResultadoTentativa.NumeroMenor;
        }

        public static int ObterNumeroSecreto()
        {
            return numeroSecreto;
        }
    }
}


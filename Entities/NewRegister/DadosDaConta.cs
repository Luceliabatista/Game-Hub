namespace GameHub
{
    class DadosDaConta
    {
        public string Name { get; private set; } = null!;
        public int Age { get; private set; }
        public string Cpf { get; private set; } = null!;
        public string Senha { get; private set; } = null!;
        public int Pontuacao { get; set; }

        public DadosDaConta( string name, int age, string cpf, string senha, int pontuacao )
        {
            Name = name;
            Age = age;
            Cpf = cpf;
            Senha = senha;
            Pontuacao = pontuacao;
        }
    }
}

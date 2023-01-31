
namespace GameHub.Entities
{
    public static class Menus
    {
       public static void MenuInicial()
        {
            Console.WriteLine("Por favor, digite a opção desejada: \n");
            Console.WriteLine("1 - Criar conta de usuário");
            Console.WriteLine("2 - Efetuar Login \n");
            Console.WriteLine("0 - Sair");
        }

        public static void MenuJogos()
        {
            Console.WriteLine("Por favor, digite a opção do jogo que quer jogor: \n");
            Console.WriteLine("1 - Jogo da Velha");
            Console.WriteLine("2 - Jogo de Xadrez");
            Console.WriteLine("3 - Batalha Naval");
            Console.WriteLine("4 - Ranking \n");
            Console.WriteLine("0 - Sair");
        }

        //void Menu()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Digite o número da opção desejada: ");
        //    Console.WriteLine("1 - Adicionar jogadores");
        //    Console.WriteLine("2 - Pontuação do último jogo");
        //    Console.WriteLine("3 - Histórico de pontuações");
        //    Console.WriteLine("4 - Jogar");
        //    Console.WriteLine("0 - Encerrar jogo");
        //}
    }
}

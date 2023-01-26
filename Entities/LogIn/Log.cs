namespace GameHub
{
    public class Log
    {
        private static bool retornoDelecao;
        private static int resposta;
        readonly ClassFinalizer finalizer = new();

        //Método que realiza a verificação de login na conta de usuário
        public static void LogIn( List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos )
        {
            Console.Clear();
            Console.WriteLine("   LOGIN   ");
            Console.Write("CPF: ");
            string CpfDotitular = Console.ReadLine();
            Console.Write("Senha: ");
            string senhaDeLogin = Console.ReadLine();

            int indexCpfParaLogar = cpfs.FindIndex(cpf => cpf == CpfDotitular);
            int indexSenhaParaLogar = senhas.FindIndex(senha => senha == senhaDeLogin);

            if (indexCpfParaLogar == -1 || indexSenhaParaLogar == -1) {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Não é possível exibir esta conta");
                Console.WriteLine("MOTIVO: Conta não encontrada");
                ClassFinalizer.Finalizer();
            }
            else {
            }
        }

        //Menu de opções de alterações possíveis para usuários cadastrados


        //Método que realiza a remoção da conta do usuário logado da base de dados de cadastros
        static void DeletarUsuario( int indexCpfParaLogar, List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos )
        {

            int indexParaDeletar = indexCpfParaLogar;

            if (indexParaDeletar == -1) {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Não foi possível deletar esta conta de usuário");
                Console.WriteLine("MOTIVO: Conta não encontrada.");
            }
            else if (saldos[indexParaDeletar] > 0) {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Não foi possível deletar esta conta de usuário");
                Console.WriteLine("MOTIVO: Conta possui saldo POSITIVO. É necessário antes zerar esta conta");
            }
            else {
                Console.Clear();
                Console.WriteLine("FAVOR, TECLE 1 SE DESEJA REALMENTE EXCLUIR ESTA CONTA \n");
                Console.WriteLine("Ou, tecle 0 para voltar ao menu anterior");
                int confirmacao = int.Parse(Console.ReadLine());
                if (confirmacao == 1) {

                    cpfs.RemoveAt(indexParaDeletar);
                    titulares.RemoveAt(indexParaDeletar);
                    senhas.RemoveAt(indexParaDeletar);
                    saldos.RemoveAt(indexParaDeletar);
                    retornoDelecao = true;

                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Conta deletada com sucesso!");
                    Console.WriteLine("-----------------------------------");

                }
                else {
                    retornoDelecao = false;
                }
            }
        }
    }
}


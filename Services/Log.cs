using GameHub.Entities;
using GameHub.Games.BatalhaNaval;
using GameHub.Games.JogoDaVelha;
using GameHub.Games.JogoDeXadrez;
using static GameHub.Services.Register;

namespace GameHub.Services
{
    public class DataLog
    {

        public static void LogIn()
        {
            int option = 0;
            Console.Clear();
            List<DataRegister> dataLog = new();
            Console.WriteLine("   LOGIN   ");
            Console.Write("CPF: ");
            string CpfDotitular = Console.ReadLine();
            Console.Write("Senha: ");
            string senhaDeLogin = Console.ReadLine();

            dataLog = SerializeDeserialize.Read<DataRegister>(@"C:\Users\lucel\SharpCoders\GameHub\GameHub\data\jogadores.json");
            DataRegister indexCpfParaLogar = dataLog.Find(cpf => cpf.Cpf == CpfDotitular);
            DataRegister indexSenhaParaLogar = dataLog.Find(senha => senha.Senha == senhaDeLogin);

            if (indexCpfParaLogar == null || indexSenhaParaLogar == null) {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Não é possível exibir esta conta");
                Console.WriteLine("MOTIVO: Conta não encontrada");
                FinalizerClass.Finalizer();
            }
            else {
                Console.Clear();
                Console.WriteLine($"Olá {indexCpfParaLogar.Name}");
                Menus.MenuJogos();
                option = int.Parse(Console.ReadLine());

                switch (option) {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Aplicação Encerrada!");
                        break;
                    case 1:
                        Game1.JogoDaVelha();
                        break;
                    case 2:
                        Game2.JogoDeXadrez();
                        break;
                    case 3:
                        Game3.BatalhaNaval();
                        break;
                    case 4:
                        Ranking.HistoricoPontuacao();
                        break;
                }
            } while (option != 0) ;

        }
    }
}


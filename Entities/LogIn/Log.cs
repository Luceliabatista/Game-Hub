using static GameHub.Register;

namespace GameHub
{
    public class DataLog
    {

        public static List<DataRegister> Login = new();

        public static void LogIn()
        {
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
                ClassFinalizer.Finalizer();
            }
            else {
                Console.WriteLine($"Olá {indexCpfParaLogar.Name}");
            }
        }
    }
}

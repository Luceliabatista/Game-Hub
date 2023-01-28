using GameHub.Entities;
using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Linq;

namespace GameHub.Services
{
    public static class Register
    {

        public static void RegistrarNovoUsuario()
        {
            Console.Clear();
            Console.WriteLine("   CADASTRO   ");

            var dataRegister = new DataRegister();

            Console.WriteLine("Digite o CPF: ");
            dataRegister.Cpf = Console.ReadLine();
            Console.WriteLine("Digite o nome: ");
            dataRegister.Name = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            dataRegister.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a senha: ");
            dataRegister.Senha = Console.ReadLine();
            dataRegister.Pontuacao = 0;
            SerializeDeserialize.Write(@"C:\Users\lucel\SharpCoders\GameHub\GameHub\data\jogadores.json", dataRegister);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Novo usuário registrado com sucesso!");
            FinalizerClass.Finalizer();
        }
    }
}


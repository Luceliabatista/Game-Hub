using GameHub.Entities;
using GameHub.Services;

namespace GameHub
{
    class Program
    {
        static void Main(string[] args)
        {      
            Console.WriteLine("Olá! Seja Bem Vinda(o) ao Game!\n");
            int option;

            do
            {
                Menus.MenuInicial();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Aplicação Encerrada!");
                        break;
                    case 1:
                        Register.RegistrarNovoUsuario();
                        break;
                    case 2:
                        DataLog.LogIn();
                        break;
                }
            } while (option != 0);
        }
    }
}
namespace GameHub
{
    class Program
    {
        static void Main(string[] args)
        {
            static void ShowMenu()
            {
                Console.WriteLine("Por favor, digite a opção desejada: \n");
                Console.WriteLine("1 - Criar conta de usuário");
                Console.WriteLine("2 - Efetuar Login \n");
                Console.WriteLine("0 - Sair");
            }

            Console.WriteLine("Olá! Seja Bem Vinda(o) ao Game!\n");
            int option;


            do
            {
                ShowMenu();
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
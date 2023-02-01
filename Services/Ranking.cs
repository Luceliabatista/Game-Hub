using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Services
{
    public class Ranking
    {
        public static List<DataRegister> ContasDeUsuarios;
        public static DataRegister Top5;


        public static void HistoricoPontuacao()
        {
            ContasDeUsuarios = SerializeDeserialize.Read<DataRegister>(@"C:\Users\lucel\SharpCoders\GameHub\GameHub\data\jogadores.json");

            Console.WriteLine("Raking");

            

        }
    }
}
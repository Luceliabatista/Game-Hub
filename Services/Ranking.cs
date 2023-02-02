using GameHub.Entities;
using GameHub.Games.BatalhaNaval.pecas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Services
{
    public class Ranking
    {
        public static List<DataRegister> Top5;



        public static void HistoricoPontuacao()
        {
            List<DataRegister> ContasDeUsuarios = new();
            ContasDeUsuarios = SerializeDeserialize.Read<DataRegister>(@"C:\Users\lucel\SharpCoders\GameHub\GameHub\data\jogadores.json");

            var InDescOrder = ContasDeUsuarios.OrderByDescending(s => s.Pontuacao);


            int cont = 0;
            foreach (var player in InDescOrder) {
                do {
                    for (int i = 0; i < 5; ++i) {
                        Console.WriteLine($"{player.Name}: {player.Pontuacao}");
                    }
                    cont++;
                } while (cont < 5);
            }
        }


    }
}
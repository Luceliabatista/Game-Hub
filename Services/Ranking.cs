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

            var InDescOrder = ContasDeUsuarios.OrderByDescending(s => s.Pontuacao).ToList();
            Console.Clear();
            Console.WriteLine("Ranking: Top 5 ");
            Console.WriteLine();
            for (int i = 0; i < InDescOrder.Count; ++i) {
                if (i == 5) {
                    break;
                }
                else {
                    var player = InDescOrder[i];
                    Console.WriteLine($"{player.Name}: {player.Pontuacao}");
                }
            }
            Console.WriteLine();
            FinalizerClass.Finalizer();
        }


    }
}
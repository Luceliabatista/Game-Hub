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


        public static void HistoricoPontuacao()
        {
            ContasDeUsuarios = SerializeDeserialize.Read<DataRegister>(@"C:\Users\lucel\SharpCoders\GameHub\GameHub\data\jogadores.json");

            Console.WriteLine("Raking");


            ContasDeUsuarios.Sort(delegate ( DataRegister p1, DataRegister p2 )
            {
                return (p1.Pontuacao.CompareTo(p2.Pontuacao));

            });

            ContasDeUsuarios.ForEach(delegate ( DataRegister p )
            {
                if (p.Pontuacao != 0) {
                    Console.WriteLine(String.Format("{0} {1}", p.Name, p.Pontuacao));
                }
            });

        }
    }
}
using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Services
{
    class Verificar
    {
        public static DataRegister Jogador1 { get; set; }
        public static DataRegister Jogador2 { get; set; }
        public static DataRegister Vitoria { get; set; }


        public static void ContadorVitoria()
        {
            if (Vitoria == Jogadores.Jogador1)
            {
                Vitoria.Pontuacao++;

            }
            else if (Vitoria == Jogadores.Jogador2)
            {
                Vitoria.Pontuacao++;
            }

        }
    }
}

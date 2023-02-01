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
        public static DataRegister JogadorX { get; set; }
        public static DataRegister JogadorO { get; set; }
        public static DataRegister Vitoria { get; set; }


        public static void ContadorVitoria()
        {
            if (Vitoria == Jogadores.JogadorX) {
                Vitoria.Pontuacao++;

            }
            else if (Vitoria == Jogadores.JogadorO) {
                Vitoria.Pontuacao++;
            }

        }
    }
}

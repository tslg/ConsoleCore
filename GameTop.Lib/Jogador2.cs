using GameTop.Interface;
using System;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public String Chuta()
        {
            return "Romario chuta \n";
        }

        public String Corre()
        {
            return "Romario corre \n";
        }

        public String Passe()
        {
            return "Romario passa \n";
        }
    }
}
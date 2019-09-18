using GameTop.Interface;
using System;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
       public String Chuta()
        {
            return "Ronaldo chuta \n";
        }

        public String Corre()
        {
            return "Ronaldo corre \n";
        }

        public String Passe()
        {
            return "Ronaldo passa \n";
        }
    }
}
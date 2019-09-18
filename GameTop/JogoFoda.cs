using GameTop.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTop
{
    public class JogoFoda
    {
        public readonly iJogador _JogadorA;
        public readonly iJogador _JogadorB;
        
        public JogoFoda(iJogador JogadorA, iJogador JogadorB)
        {
            _JogadorA = JogadorA;
            _JogadorB = JogadorB;
        }

        public void IniciarJogo()
        {
            System.Console.Write(_JogadorA.Corre());
            System.Console.Write(_JogadorA.Chuta());
            System.Console.Write(_JogadorA.Passe());
            //
            System.Console.Write("\n PRÓXIMO JOGAOR \n");
            //
            System.Console.Write(_JogadorB.Corre());
            System.Console.Write(_JogadorB.Chuta());
            System.Console.Write(_JogadorB.Passe());
        }
    }
}

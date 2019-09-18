using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
                new Jogador2(),
                new Jogador1()
            );

            jogo.IniciarJogo();
        }
    }
}

using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogofoda = new JogoFoda(new Jogador1("Fábio"), new Jogador2("Amanda"));
            jogofoda.IniciarJogo();
        }
    }

}

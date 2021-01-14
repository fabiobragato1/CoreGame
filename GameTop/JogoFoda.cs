using System;
using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
        public readonly iJogador _jogadorA;
        public readonly iJogador _jogadorB;
        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            Console.Write("Primeiro jogador:\n");
            Console.Write(_jogadorA.Passa());
            Console.Write(_jogadorA.Chuta());
            Console.Write(_jogadorA.Corre());
            Console.Write("Segundo Jogador:\n");
            Console.Write(_jogadorB.Passa());
            Console.Write(_jogadorB.Chuta());
            Console.Write(_jogadorB.Corre());
        }
    }
}
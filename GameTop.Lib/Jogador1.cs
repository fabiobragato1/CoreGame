using System;
using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _NomeJogador;

        public Jogador1(string nome)
        {
            this._NomeJogador = nome;
        }

        public string Chuta()
        {
            return $"{_NomeJogador} está chutando.\n";
        }

        public string Passa()
        {
            return $"{_NomeJogador} está passando.\n";
        }

        public string Corre()
        {
            return $"{_NomeJogador} está correndo.\n";
        }

    }
}
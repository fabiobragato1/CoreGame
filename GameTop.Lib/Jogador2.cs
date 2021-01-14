using System;
using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public readonly string _NomeJogador;

        public Jogador2(string nome)
        {
            this._NomeJogador = nome;
        }

        public string Chuta()
        {
            return $"{_NomeJogador} está defendendo.\n";
        }

        public string Passa()
        {
            return $"{_NomeJogador} está interceptando a bola.\n";
        }

        public string Corre()
        {
            return $"{_NomeJogador} está correndo.\n";
        }

    }
}
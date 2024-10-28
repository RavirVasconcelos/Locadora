using System;
using System.Globalization;
using System.Collections.Generic;

namespace Locadora
{

    public class Serie : Locadora
    {

        public Serie(string nome, string genero, double valor, int id)
        {

            Nome = nome;
            Genero = genero;
            Valor = valor;
            Id = id;

        }
        public override string ToString()
        {
            return "ID: " + "Series " +
                Nome +
                ", " + Genero +
                ", $ " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
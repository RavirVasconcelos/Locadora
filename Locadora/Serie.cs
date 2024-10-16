using System;
using System.Globalization;
using System.Collections.Generic;

namespace Locadora
{

    public class Serie : Locadora
    {

        public Serie(string nome, string genero, double valor)
        {

            Nome = nome;
            Genero = genero;
            Valor = valor;

        }
        public override string ToString()
        {
            return Nome +
                ", " + Genero +
                ", $ " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;


namespace Projeto___Compra_de_Iphone_Parcelado.Entites
{
    internal class Parcelas
    {
        public double ValorCompra { get; set; }
        public double ValorParcela { get; set; }

        public Parcelas(double valorParcela)
        {
            ValorParcela = valorParcela;
        }

        public override string ToString()
        {
            return $"Valor da Parcela: {ValorParcela}";

        }

    }

 
}

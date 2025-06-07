using System;
using System.Collections.Generic;
using System.Linq;


namespace Projeto___Compra_de_Iphone_Parcelado.Entites
{
    interface  IPagamentos
    {
         double CalcularValorTotal(double valor);

         double CalcularParcela(double valorTotal, int numeroParcelas);
    }
}

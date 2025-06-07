using System;
using System.Collections.Generic;
using System.Linq;


namespace Projeto___Compra_de_Iphone_Parcelado.Entites
{
    internal class Iphone
    {
        public double ValorIphone { get; set; }
        public int numeroParcelas { get; set; }

        public Iphone(double valorIphone, int numeroParcelas)
        {
            ValorIphone = valorIphone;
            this.numeroParcelas = numeroParcelas;
        }
    }
}

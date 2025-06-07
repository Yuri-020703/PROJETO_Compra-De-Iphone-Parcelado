using System;
using System.Collections.Generic;
using System.Linq;


namespace Projeto___Compra_de_Iphone_Parcelado.Entites
{
    internal class Boleto : IPagamentos
    {
        public Iphone Iphone { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public double Parcela { get; set; }

        private double Taxa = 0.05;


        public double CalcularValorTotal(double valor)
        {
            ValorTotal = valor * Taxa + valor;
            return ValorTotal;
        }

        public double CalcularParcela(double valorTotal, int numeroParcelas)
        {
            Parcela = valorTotal / numeroParcelas;
            return  Parcela;
        }

        public Boleto(Iphone iphone, DateTime data)
        {
            Iphone = iphone;
            Data = data;
        }
    }
}

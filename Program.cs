using Projeto___Compra_de_Iphone_Parcelado.Entites;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Projeto___Compra_de_Iphone_Parcelado
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {

                Produtos[] produtos = new Produtos[]
            {
                new Produtos("Iphone X (64GB)", 1500),
                new Produtos("Iphone XR (64GB)", 1800),
                new Produtos("Iphone XR (128GB)", 2000),
                new Produtos("Iphone 11 (64GB)", 2000),
                new Produtos("Iphone 11 Pro (128GB)", 2300),
                new Produtos("Iphone 12 (64GB)", 2500),
                new Produtos("Iphone 13 (128GB)", 2750),
                new Produtos("Iphone 13 Pro (256GB)", 2900),
                new Produtos("Iphone 14 (128GB)", 3200),
                new Produtos("Iphone 14 Pro (256GB)", 3600),
            };



                for (int i = 0; i < produtos.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.      {produtos[i].Nome} : R$ {produtos[i].Preco}");
                }

                Console.WriteLine();
                Console.Write("Digite o número correspondente ao modelo do Iphone que você deseja comprar: ");
                int opc = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Em quantos meses você deseja parcelar a compra?");

                int meses = int.Parse(Console.ReadLine());

                Iphone iphone = null;

                switch (opc)
                {
                    case 1:
                        iphone = new Iphone(produtos[opc - 1].Preco, meses);
                        break;
                    case 2:
                        iphone = new Iphone(produtos[opc - 1].Preco, meses);
                        break;
                    case 3:
                        iphone = new Iphone(produtos[opc - 1].Preco, meses);
                        break;
                    case 4:
                        iphone = new Iphone(produtos[opc - 1].Preco, meses);
                        break;
                    case 5:
                        iphone = new Iphone(produtos[opc - 1].Preco, meses);
                        break;
                    case 6:
                        iphone = new Iphone(produtos[opc - 1].Preco, meses);
                        break;
                    case 7:
                        iphone = new Iphone(produtos[opc - 1].Preco, meses);
                        break;
                    case 8:
                        iphone = new Iphone(produtos[opc - 1].Preco, meses);
                        break;
                    case 9:
                        iphone = new Iphone(produtos[opc - 1].Preco, meses);
                        break;
                    case 10:
                        iphone = new Iphone(produtos[opc - 1].Preco, meses);
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida ! ");
                        break;
                }

                Boleto boleto = new Boleto(iphone, DateTime.Now);
                double total = boleto.CalcularValorTotal(iphone.ValorIphone);
                double parcela = boleto.CalcularParcela(total, meses);

                Console.WriteLine();

                Console.WriteLine("Acompanhe os boletos da sua compra:");

                Console.WriteLine();

                for (int i = 1; i <= meses; i++)
                {
                    Console.WriteLine($"Boleto {i}: ");
                    Console.WriteLine("--------------------");
                    Console.WriteLine($"Valor : {boleto.Parcela}");
                    Console.WriteLine($"Data de vencimento: {boleto.Data.AddMonths(i).ToString("dd/MM/yyy")}");
                    Console.WriteLine("--------------------");
                    Console.WriteLine($"Modelo do Iphone: {produtos[opc - 1]}");
                    Console.WriteLine($"Valor do Iphone: {iphone.ValorIphone}");
                    Console.WriteLine($"Taxa de parcelamento: 5%");
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Por favor, digite apenas números.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado. Detalhes:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Essa é a calculadora de combustíveis! Gostaria de simular qual combustível está mais vantajoso? 1 - SIM, 2 - NÃO.");

        int start = int.Parse(Console.ReadLine());

        while (start != 2)
        {
            Console.WriteLine("Qual o preço do Álcool?");
            double precoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço da Gasolina?");
            double precoG = double.Parse(Console.ReadLine());
            double relVantagem = precoA / precoG;
            if (relVantagem > 0.7){
              Console.WriteLine("GASOLINA! Neste momento é mais vantajoso abastecer com gasolina.");
            } else if (relVantagem == 0.7){
              Console.WriteLine("Tanto faz! Os dois combustíveis têm a mesma performance.");
            } else if (relVantagem < 0.7){
              Console.WriteLine("ÁLCOOL! Neste momento é mais vantajoso abastecer com Álcool.");
            }
          Console.WriteLine("Gostaria de fazer outra simulação de combustíveis? 1 - SIM, 2 - NÃO.");
          start = int.Parse(Console.ReadLine());
          }
          Console.WriteLine("Suas respostas foram geradas! Volte sempre!");
        }
      }


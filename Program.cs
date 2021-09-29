using System;

namespace AMS_Lista_Foreger
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] produtos = new string[5];
          {
            produtos [0] = "Arroz";
            produtos [1] = "feijão";
            produtos [2] = "Leite";
            produtos [3] = "Açucar";
            produtos [4] = "Macarrão";
          
            foreach(string mercado in produtos)
            {

              Console.WriteLine(mercado);
              

            }
          }

          
        }
    }
}

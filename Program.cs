using System;

namespace AMS_Lista_Foreger
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] produtos = new string[6];
          {
            produtos [0] = "Arroz";
            produtos [1] = "feijão";
            produtos [2] = "Leite";
            produtos [3] = "Açucar";
            produtos [4] = "Macarrão";
            produtos [5] = "Sopa de Pedro";
          
            foreach(string mercado in produtos)
            {

              Console.WriteLine(mercado);
              

            }
          }

          
        }
    }
}

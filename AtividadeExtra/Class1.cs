

using System.Security.Cryptography;

namespace TrabalhoExtra
{
    internal class Class1
    {


        public double Produto1;

        public double Produto2;

        public double Produto3;

        public double Produto4;

        public double Total;

        private double icms;

        public double Imposto;



        public void CupomFiscal()
        {

            Console.WriteLine("Digite o valor do Produto 1: ");
            Produto1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do Produto 2: ");
            Produto2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do Produto 3: ");
            Produto3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do Produto 4: ");
            Produto4 = double.Parse(Console.ReadLine());

            icms = 0.18; 

            Total = Produto1 + Produto2 + Produto3 + Produto4;

            Imposto = Total * icms;

            Console.WriteLine("O valor total da sua compra deu: " + Total + "$");
            Console.WriteLine("O valor do imposto é: " + Imposto + "$");



        }



    }



}


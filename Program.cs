using System;

namespace ThisAndConstructor
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Soma primeiraSoma;

            double numero1 = double.Parse(Console.ReadLine());
            double numero2 = double.Parse(Console.ReadLine());
            double numero3 = double.Parse(Console.ReadLine());

            primeiraSoma = new Soma(numero1, numero2, numero3);

            primeiraSoma.Resultado();

            double numero4 = double.Parse(Console.ReadLine());
            double numero5 = double.Parse(Console.ReadLine());
            double numero6 = double.Parse(Console.ReadLine());

            primeiraSoma = new Soma(numero4, numero5);

            primeiraSoma.Resultado();

        }
    }
}

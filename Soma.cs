using System;
namespace ThisAndConstructor
{
    public class Soma
    {
        double numero1, numero2, numero3, resultado;

        public Soma(double numero1, double numero2, double numero3)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            this.numero3 = numero3;
        }

        public Soma(double numero1, double numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            this.numero3 = 0;
        }

        public void Resultado(){

            resultado = numero1 + numero2 + numero3;

            Console.WriteLine("O resultado eh: " + resultado);
        }
    }
}

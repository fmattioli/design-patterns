using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class PizzaMussarela : Pizza
    {
        public PizzaMussarela()
        {
            Nome = "Pizza de Mussarela";
        }
        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min.");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando pizza de  {Nome}.");
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando pizza de  {Nome}.");
        }
    }
}

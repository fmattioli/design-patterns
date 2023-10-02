namespace SimpleFactory
{
    public class Veiculo
    {
        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerando veiculo");
        }

        public virtual void Parar()
        {
            Console.WriteLine("Parando veiculo");
        }
    }


    public class Aeronave : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Delocando aeronave");
        }

        public override void Parar()
        {
            Console.WriteLine("Aterrisando aeronave");
        }
    }
}

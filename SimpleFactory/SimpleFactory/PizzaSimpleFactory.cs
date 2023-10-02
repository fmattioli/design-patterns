namespace SimpleFactory
{
    internal sealed class PizzaSimpleFactory
    {
        public static Pizza CriarPizza(string? tipo)
        {
            Pizza pizza;
            switch (tipo)
            {
                case "C":
                    pizza = new PizzaCalabresa();
                    break;
                case "M": 
                    pizza= new PizzaMussarela();
                    break;
                default:
                    throw new ApplicationException($"A pizza de {tipo} não foi criada!");
            }

            return pizza;
        }
    }
}

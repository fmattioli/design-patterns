namespace SimpleFactory
{
    internal class Pizzaria
    {
        public static void SolicitarPizza()
        {
            Console.WriteLine("==========Pizzaria==============");
            Console.WriteLine("Informe a pizza (C)alabresa ou (M)ussarela \n");
            var tipo = Console.ReadLine()?.ToUpper();
            try
            {
                Pizza pizza = PizzaSimpleFactory.CriarPizza(tipo);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();
                Console.WriteLine("Pizza concluída!");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro ao preparar a pizza {ex.Message}");
            }
        }
    }
}

using System.Collections.Generic;

namespace SingletonVsFactory
{
    public static class PizzaStringFormatters
    {
        public static string PizzaPrepareFormatter(string p, string style)
        {
            return $"Preparing Pizzeria {p} Style {style} Using";
        }
        public  static string CheesePizzaFormatter( DoughTypes dough, CheeseTypes cheese, SauceTypes sauce, List<VeggieTypes> veggies)
        {

            return $"Dough: {dough}, Cheese: {cheese}, Sauce: {sauce}, Veggies: {string.Join(", ", veggies)}".Replace("_", " ");
        }
        public  static string ClamPizzaFormatter( DoughTypes dough, ClamTypes clam, CheeseTypes cheese, SauceTypes sauce, List<VeggieTypes> veggies)
        {

            return $"Dough: {dough}, Clam: {clam}, Cheese: {cheese}, Sauce: {sauce}, Veggies: {string.Join(", ", veggies)}".Replace("_", " ");
        }
        public  static string VeggiePizzaFormatter( DoughTypes dough, SauceTypes sauce, List<VeggieTypes> veggies)
        {

            return $"Dough: {dough}, Sauce: {sauce}, Veggies: {string.Join(", ", veggies)}".Replace("_", " ");
        }

        public static string BakeFormatter()
        {
            return "Baking at 135 degree Celsius for 25 minutes";
        }

        public static string CutFormatter()
        {
            return "Cutting into diagonal pieces";
        }

        public static string BoxFormatter(string c)
        {
            return $"Putting pizza in {c} coloured box";
        }
    }
}
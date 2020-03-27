using System;
using System.Collections.Generic;
using System.Linq;

namespace SingletonVsFactory
{
    public class PizzeriaBFactory : IPizzeria
    {
        private readonly List<string> _log = new List<string>();
        private const string Pizza = "B";
        private string _type = "";
        public void Order(string type)
        {
            if (new[] {"Cheese", "Clam", "Veggie"}.All(x => x != type))
            {
                throw  new Exception("Invalid Order");
            }

            _type = type;
        }

        public void Prepare()
        {
            _log.Add($"Preparing Pizzeria {Pizza} Style {_type} Using");
            switch (_type)
            {
                case "Cheese":
                    _log.Add(PizzaStringFormatters.CheesePizzaFormatter(GetDough(), GetCheese(), GetSauce(), GetVeggieList()));
                    break;
                case "Clam":
                    _log.Add(PizzaStringFormatters.ClamPizzaFormatter(GetDough(),GetClam(), GetCheese(), GetSauce(), GetVeggieList()));
                    break;
                case "Veggie":    
                    _log.Add(PizzaStringFormatters.VeggiePizzaFormatter(GetDough(),GetSauce(),GetVeggieList()));
                    break;
            }
        }

        public void Bake()
        {
            _log.Add(PizzaStringFormatters.BakeFormatter());
        }

        public void Cut()
        {
            _log.Add(PizzaStringFormatters.CutFormatter());
        }

        public void Box()
        {
            _log.Add(PizzaStringFormatters.BoxFormatter(GetBoxColor()));
        }


        public CheeseTypes GetCheese()
        {
            return CheeseTypes.Parmesan;
        }

        public ClamTypes GetClam()
        {
            return ClamTypes.Fresh_Clam;
        }

        public DoughTypes GetDough()
        {
            return DoughTypes.Deep_Dish;
        }
        public SauceTypes GetSauce()
        {
            return SauceTypes.Plum_Tomato;
        }

        public List<VeggieTypes> GetVeggieList()
        {
            return new List<VeggieTypes>()
            {
                VeggieTypes.Cucumber,
                VeggieTypes.Onions,
                VeggieTypes.Bell_Peppers
            };
        }

        public string GetBoxColor()
        {
            return "Green";
        }

        public List<string> Log()
        {
            return _log;
        }
    }
}
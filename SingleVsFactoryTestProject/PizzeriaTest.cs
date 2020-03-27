using NUnit.Framework;
using SingletonVsFactory;

namespace SingleVsFactoryTestProject
{

    [TestFixture]
    public class PizzeriaTest
    {
        [Test]
        public void Pizzeria_Should_Log_StyleAndPizzaType()
        {
            var pizzaA = new PizzeriaAFactory();
            pizzaA.Order("Cheese");
            pizzaA.Prepare();
            Assert.AreEqual("Preparing Pizzeria A Style Cheese Using",pizzaA.Log()[0]);
        }
        [Test]
        public void Pizzeria_Should_Log_Ingredients()
        {
            var pizzaA = new PizzeriaAFactory();
            pizzaA.Order("Cheese");
            pizzaA.Prepare();

            Assert.IsTrue(pizzaA.Log()[1].Contains("Dough: Thin Crust"));
            Assert.IsTrue(pizzaA.Log()[1].Contains("Cheese: Mozzarella"));
            Assert.IsTrue(pizzaA.Log()[1].Contains("Sauce: Cherry Tomato"));
            Assert.IsTrue(pizzaA.Log()[1].Contains("Veggies: Olives, Onions, Bell Pepper"));
        }
        [Test]
        public void Pizzeria_Should_Log_Bake()
        {
            var pizzaA = new PizzeriaAFactory();
            pizzaA.Order("Cheese");
            pizzaA.Prepare();
            pizzaA.Bake();
            Assert.AreEqual("Baking at 135 degree Celsius for 25 minutes", pizzaA.Log()[2]);
        }
        [Test]
        public void Pizzeria_Should_Log_Cut()
        {
            var pizzaA = new PizzeriaAFactory();
            pizzaA.Order("Cheese");
            pizzaA.Prepare();
            pizzaA.Bake();
            pizzaA.Cut();
            Assert.AreEqual("Cutting into diagonal pieces", pizzaA.Log()[3]);
        }
        [Test]
        public void Pizzeria_Should_Log_Box()
        {
            var pizzaA = new PizzeriaAFactory();
            pizzaA.Order("Cheese");
            pizzaA.Prepare();
            pizzaA.Bake();
            pizzaA.Cut();
            pizzaA.Box();

            Assert.AreEqual("Putting pizza in Red coloured box", pizzaA.Log()[4]);
        }
    }
}

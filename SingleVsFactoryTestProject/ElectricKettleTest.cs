using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using SingletonVsFactory;
namespace SingleVsFactoryTestProject
{
    [TestFixture]

    public class ElectricKettleTest
    {

        [Test]
        public void ElectricKettle_Should_Be_Singleton()
        {
            ElectricKettle firstVariable = ElectricKettle.GetSingleton();
            ElectricKettle secondVariable = ElectricKettle.GetSingleton();


            firstVariable.Fill();
            var data = firstVariable.GetState();
            var result = secondVariable.GetState();

            Assert.AreEqual(data.Item1, result.Item1);
            Assert.AreEqual(data.Item2, result.Item2);

        }

        [Test]
        public void ElectricKettle_Should_Return_Starting()
        {
            ElectricKettle kettle = ElectricKettle.GetSingleton();

            var data = kettle.GetState();

            Assert.AreEqual("Starting", data.Item1);
            Assert.AreEqual(ElectricKettleStatus.Empty, data.Item2);

        }
        [Test]
        public void ElectricKettle_Should_Return_Filling()
        {
            ElectricKettle kettle = ElectricKettle.GetSingleton();
            kettle.Fill();
            var data = kettle.GetState();

            Assert.AreEqual("Filling...", data.Item1);
            Assert.AreEqual(ElectricKettleStatus.InProgress, data.Item2);

        }
        [Test]
        public void ElectricKettle_Should_Return_BoilingThenBoiledStatus()
        {
            ElectricKettle kettle = ElectricKettle.GetSingleton();
            kettle.Fill();
            kettle.Boil();
            var data = kettle.GetState();

            Assert.AreEqual("Boiling...", data.Item1);
            Assert.AreEqual(ElectricKettleStatus.Boiled, data.Item2);

        }
        [Test]
        public void ElectricKettle_Should_Return_DrainingThenEmptyStatus()
        {
            ElectricKettle kettle = ElectricKettle.GetSingleton();
            kettle.Fill();
            kettle.Boil();
            kettle.Drain();
            var data = kettle.GetState();

            Assert.AreEqual("Draining...", data.Item1);
            Assert.AreEqual(ElectricKettleStatus.Empty, data.Item2);

        }

        

    }
}

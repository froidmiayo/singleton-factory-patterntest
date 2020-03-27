using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonVsFactory
{

    public interface IPizzeria
    {
        void Order(string type);
        void Prepare();
        void Bake();
        void Cut();
        void Box();

        CheeseTypes GetCheese();
        ClamTypes GetClam();
        DoughTypes GetDough();
        SauceTypes GetSauce();
        List<VeggieTypes> GetVeggieList();
        string GetBoxColor();
        List<string> Log();
    }
}

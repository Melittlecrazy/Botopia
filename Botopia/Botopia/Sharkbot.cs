using System;
using static System.Console;
using static Botopia.CardsANDdeck;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botopia
{
    class Sharkbot : Bot
    {
        public Sharkbot(string _name, string _discription, int _ID) : base(_name, _discription, _ID)
        {
            Name = _name; 
        }

        public static void Cardgames()
        {
            WriteLine("Yeah this never actually worked, so press anykey to go back to the menu");
            ReadKey();
            new World();
        }

        //public override void Act()
        //{
        //}
    }
}

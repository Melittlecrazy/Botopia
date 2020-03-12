using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botopia
{
    class Trabot : Bot
    {
        public Trabot(string _name, string _discription, int _ID) : base(_name, _discription, _ID)
        {

        }
        public override void Act()
        {
        var dictionary = new Dictionary<string, string>();
            dictionary.Add("Cats", "display the same main attachment styles as babies and dogs");
            dictionary.Add("McDonald's", "buys about 2 billion eggs every year for their U.S. restaurants alone.");
            

            void Run()
            {
                Console.WriteLine("This is Trabot, wanna learn som facts?");
                    
                   
                Console.WriteLine("----------------------------------------------------\n");
                Console.WriteLine("Want plant do you want to know the name of?");
                string search = Console.ReadLine();

                if (search == "Cat" && dictionary.TryGetValue("Arrowroo", out string description))
                {
                    Console.WriteLine("The scienticic name for Arrowroo is Canna edulis");
                }
                else 
                {
                    Console.WriteLine("yeah no that's wrong try again.");
                }
                
            }
        }
    }
}

﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Random facts from http://www.factslides.com/
namespace Botopia
{
    class Trabot : Bot
    {
        public Trabot(string _name, string _discription, int _ID) : base(_name, _discription, _ID)
        {
            Name = _name;
            
        }
        
            public static void Questions() 
            { 
        var dictionary = new Dictionary<string, string>();
            dictionary.Add("Cats", "display the same main attachment styles as babies and dogs");
            dictionary.Add("McDonald's", "buys about 2 billion eggs every year for their U.S. restaurants alone.");
            dictionary.Add("Brendan Behan", "Irish poet became an alcoholic at the age of eight");

            WriteLine("Hi, I'm Alex Trabot, wanna learn some facts?");
            Q1();
            void Q1()
            {
                WriteLine("----------------------------------------------------\n");
                WriteLine("What animal displays the same main attachment styles as babies and dogs?" + 
                    "\n - Frogs"+
                    "\n - Cats"+
                    "\n - Hamsters");
                string search = ReadLine();
                if (search == "Cats" && dictionary.TryGetValue("Cats", out string description))
                {
                    WriteLine("Correct! Cats display the same main attachment styles as babies and dogs");
                    Q2();
                }
                else 
                {
                    WriteLine("yeah no that's wrong try again.");
                    Q1();
                }
            }
            void Q2()
            { 
                WriteLine("----------------------------------------------------\n");
                WriteLine("Which fast food franchise buys about 2 billion eggs every year for their U.S. restaurants alone?" +
                    "\n - Wendy's" +
                    "\n - McDonald's" +
                    "\n - Burger King");
                string search = ReadLine();
                if (search == "McDonald's" && dictionary.TryGetValue("McDonald's", out string description))
                {
                    WriteLine("Correct! McDonal's buys about 2 billion eggs every year for their U.S. restaurants alone.");
                    Q3();
                }
                else
                {
                    WriteLine("Yeah no that's wrong try again.");
                    Q2();
                }
            }
            void Q3()
            {
                WriteLine("----------------------------------------------------\n");
                WriteLine("Which Irish poet became an alcoholic at the age of eight?" +
                    "\n - Shakespeare" +
                    "\n - Brendan Behan" +
                    "\n - Eavan Boland");
                string search = ReadLine();
                if (search == "Brendan Behan" && dictionary.TryGetValue("Brendan Behan", out string description))
                {
                    WriteLine("Correct! The Irish poet Brendan Behan became an alcoholic at the age of eight.");
                    WriteLine("Press anykey to go back to the menu...");
                    ReadKey();
                    World world = new World();
                }
                else
                {
                    WriteLine("Yeah no that's wrong try again.");
                    Q3();
                }
                
            }
        }
            //For what ever reason, I can't get this to be called anywhere    
        //public override void Act()
        //{    
            
        //}
    }
}

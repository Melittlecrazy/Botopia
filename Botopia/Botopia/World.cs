using System;
using static System.Console;
using static Botopia.Utility;
using static Botopia.Sharkbot;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botopia
{
    class World
    {
		static List<Bot> bots = new List<Bot>();
		public World()
		{
			SetUp();
			Menu();
			
			
		}
		private void Greetings()
		{
			Print("Sup.");
		}
		private void SetUp()
		{
			Title = "Adopt-a-bot";
			BackgroundColor = ConsoleColor.Cyan;
			ForegroundColor = ConsoleColor.Black;
			Clear();
		}
		public void Menu()
		{
			Clear();
			if (Hasbot() == true)
			{

				Print("which bot do you want to adopt?");
				//foreach (Bot bot in bots){ Print($@"      -{bot.Name}"); }

				WriteLine("	-Genericbot" + "\n	-Trabot" + "\n	-Sharkbot"+ "\n	-Exit");
			}

			string input = ReadLine();
			if (input == "genericbot" || input == "Genericbot" || input == "GenericBot" || input == "gen" || input == "generic" || input == "gbot" || input == "gb" || input == "g" || input == "ge" || input == "gene" || input == "gener" || input == "genericbot" || input == "generi" || input == "genbot" )
			{
				Bot.Act();
			}
			else if (input == "trabot" || input == "Trabot" || input == "TracBot" || input == "tra" || input == "tr" || input == "tbot" || input == "t" || input == "tb" )
			{
				Trabot.Questions();
					
			}
			else if (input == "sharkbot" || input == "Sharkbot" || input == "SharkBot" || input == "shark" || input == "shr" || input == "sbot" || input == "sb" || input == "s" || input == "sh" || input == "shar" || input == "sharkb")
			{
				Cardgames();
			}
			else if (input == "exit"|| input == "Exit")
			{
				
			}
		}

		private bool Hasbot()
		{
			if (bots.Count <= 1)
				return true;
			return false;
		}

		private void Adopt()
		{
			bots.Add(new Bot("Genericbot", "I am a regular bot.", 000001));
			bots.Add(new Trabot("Trabot", "Let's read books!", 000002));
			bots.Add(new Sharkbot("Sharkbot", "Give me gold.",000003));
		}
	}
}

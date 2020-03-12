using System;
using static System.Console;
using static Botopia.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botopia
{
    class World
    {
		List<Bot> bots = new List<Bot>();
		public World()
		{
			SetUp();
			Menu();
			Greetings();
			
		}
		private void Greetings()
		{
			Print("Sup.");
		}
		private void SetUp()
		{
			Title = "Adopt-a-bot";
			BackgroundColor = ConsoleColor.Cyan;
			ForegroundColor = ConsoleColor.Red;
			Clear();
		}
		public void Menu()
		{
			WriteLine("");
			if (Hasbot())
			{
				
				Print("which bot do you want to adopt?");
				foreach (Bot bot in bots)
				{
					Print($"      * {bot.Name}");
				}
			}
			string input = ReadLine();
			if (input == "trabot")
			{
				Trabot.Run();
					
			}
		}

		private bool Hasbot()
		{
			if (bots.Count >= 1)
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

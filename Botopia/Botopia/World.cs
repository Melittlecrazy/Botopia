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
			if (Hasbot())
			{
				Print("which bot do you want to adopt?");
				foreach (Bot bot in bots)
				{
					Print($"      * {bot.Name}");
				}
			}
			string input = ReadLine();
		}

		private bool Hasbot()
		{
			if (bots.Count >= 1)
				return true;
			return false;
		}

		private void Adopt()
		{
			bots.Add(new Bot("Dragoon", "I am a regular dragon.", 000001));
			bots.Add(new Trabot("Falkor", "Let's read books!", 000002));
			bots.Add(new Sharkbot("Smog", "Give me gold.",000003));
		}
	}
}

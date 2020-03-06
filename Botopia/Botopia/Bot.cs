using System;

using static System.Console;
using static Botopia.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botopia
{
    class Bot
    {
		private string name = "Tis a dragoon!";
		public string Name { get => name; set => name = value; }
		public string Description = "";
		private const int ID = 0;


		public virtual void Act() { }

		public virtual void Status(){}
		public void Status(string _message)
		{
			Print(_message);
		}
		public Bot(string _name, string _discription, int _ID)
		{
			name = _name;
			
		}
	}
}

using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
	public class MockCommanderRepo : ICommanderRepo
	{
		public IEnumerable<Command> GetAppCommands () {
			var commands = new List<Command> {
				new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "kettle & pan" },
				new Command { Id = 1, HowTo = "Cut bread", Line = "Get knife", Platform = "kitchen" },
				new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Cup" }
			};

			return commands;
		}

		public Command GetCommandById (int id) {
			return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "kettle & pan" };
		}

	}
}
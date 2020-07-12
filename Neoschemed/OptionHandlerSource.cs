using Syroot.Worms.Armageddon;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Neoschemed
{
	public class OptionHandlerSource
	{
		private Scheme scheme;
		private List<OptionHandler> handlers = new List<OptionHandler>();

		public OptionHandlerSource(Scheme scheme)
        {
			this.scheme = scheme;
			CreateHandlers();
        }

		public IEnumerable<OptionHandler> Handlers
        {
			get => handlers;
        }

		bool ParseBooleanValue(string raw)
        {
			if(raw == "1" || raw.ToLower() == "true")
				return true;
			if(raw == "0" || raw.ToLower() == "false")
				return false;

			throw new ArgumentException("Boolean parameter must have value of 0, 1, false or true");
        }

		void CreateHandlers()
        {
			handlers.Add(new OptionHandler("Aqua Sheep", new string[] { "--aquasheep", "-as" }, (raw) => { scheme.AquaSheep = ParseBooleanValue(raw); }));
        }

		public OptionHandler Find(string alias)
        {
			foreach(var h in handlers)
            {
				if(h.Aliases.Contains(alias))
					return h;
            }

			return null;
        }
	}
}

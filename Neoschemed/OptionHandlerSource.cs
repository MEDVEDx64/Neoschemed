using Syroot.Worms.Armageddon;
using System;
using System.Collections.Generic;

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
			handlers.Add(new OptionHandler(new string[] { "--aquasheep", "-as" }, (raw) => { scheme.AquaSheep = ParseBooleanValue(raw); }));
        }

		public OptionHandler Find(string alias)
        {
			throw new NotImplementedException();
        }
	}
}

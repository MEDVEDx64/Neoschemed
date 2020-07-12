using System;
using System.Collections.Generic;

namespace Neoschemed
{
	public class OptionHandler
	{
		string[] aliases;
		Action<string> setter;

		public OptionHandler(string[] aliases, Action<string> setter)
		{
			this.aliases = aliases;
			this.setter = setter;
		}

		public IEnumerable<string> Aliases
        {
			get => aliases;
        }

		public void SetValue(string rawValue)
        {
			setter(rawValue);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Neoschemed
{
	public class OptionHandler : IEquatable<OptionHandler>
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

        public bool Equals([AllowNull] OptionHandler other)
        {
			return Enumerable.SequenceEqual(aliases, other.aliases);
        }

        public void SetValue(string rawValue)
        {
			setter(rawValue);
        }
    }
}
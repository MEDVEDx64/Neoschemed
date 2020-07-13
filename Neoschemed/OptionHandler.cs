using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Neoschemed
{
	public enum OptionCategory
    {
		Generic,
		Extended,
		Weapon,
    }

	public class OptionHandler : IEquatable<OptionHandler>
	{
		string[] aliases;
		Action<string> setter;

		public OptionHandler(string[] aliases, Action<string> setter, OptionCategory category = OptionCategory.Generic, string description = null)
		{
			Category = category;
			Description = description;
			this.aliases = aliases;
			this.setter = setter;
		}

		public OptionCategory Category { get; }
		public string Description { get; }

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
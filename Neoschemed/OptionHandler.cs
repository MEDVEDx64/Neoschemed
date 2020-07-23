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

	public enum OptionValueType
    {
		Boolean,
		Decimal,
		Float,
		Enum,
    }

	public class OptionHandler : IEquatable<OptionHandler>
	{
		string[] aliases;
		Action<string> setter;
		OptionValueType type;

		public OptionHandler(string[] aliases, Action<string> setter, OptionValueType type, OptionCategory category = OptionCategory.Generic, string description = null)
		{
			Category = category;
			Description = description;
			this.aliases = aliases;
			this.setter = setter;
			this.type = type;

			WorkingAliases = aliases.Select(a => a.ToLower());
		}

		public OptionCategory Category { get; }
		public string Description { get; set; }

		// Only intended for help print
		public IEnumerable<string> PrintableAliases
        {
			get => aliases;
        }

		// These are lower-cased aliases for a command, used in argument parsing, equations etc.
		public IEnumerable<string> WorkingAliases { get; }

        public bool Equals([AllowNull] OptionHandler other)
        {
			return Enumerable.SequenceEqual(WorkingAliases, other.WorkingAliases);
        }

		public string GetValueTypeName()
        {
			return type.ToString().ToLower();
        }

        public void SetValue(string rawValue)
        {
			setter(rawValue);
        }
    }
}
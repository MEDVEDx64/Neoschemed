using Syroot.Worms.Armageddon;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Neoschemed
{
	public partial class OptionHandlerSource
	{
		private Scheme scheme;
		private List<OptionHandler> handlers = new List<OptionHandler>();
		private OptionCategory quickCategory = OptionCategory.Generic;
		private OptionHandler quickHandler = null;

		public OptionHandlerSource(Scheme scheme)
        {
			this.scheme = scheme;
			CreateHandlers();
        }

		public IEnumerable<OptionHandler> Handlers
        {
			get => handlers;
        }

		static bool ParseBooleanValue(string raw)
        {
			if(raw == "1" || raw.ToLower() == "true")
				return true;
			if(raw == "0" || raw.ToLower() == "false")
				return false;

			throw new ArgumentException("Boolean parameter must have value of 0, 1, false or true");
        }

		static object ParseOptionalValue<T>(string raw)
		{
			if (raw == "default" || raw == "null")
				return null;

			var t = typeof(T);

			if (t == typeof(bool))
				return ParseBooleanValue(raw);

			if (t == typeof(byte))
				return byte.Parse(raw);
			if (t == typeof(sbyte))
				return sbyte.Parse(raw);
			if (t == typeof(short))
				return short.Parse(raw);
			if (t == typeof(ushort))
				return ushort.Parse(raw);
			if (t == typeof(int))
				return int.Parse(raw);
			if (t == typeof(uint))
				return uint.Parse(raw);

			throw new ArgumentException("Bug: cannot parse \"" + t.Name + "\" type");
		}

		void SetQuickHandlerCategory(OptionCategory category)
        {
			quickCategory = category;
        }

		void AddQuickHandler(OptionValueType type, Action<string> setter, string propName, params string[] extraKeys)
        {
			var aliases = new List<string> { "--" + propName };
			aliases.AddRange(extraKeys);
			quickHandler = new OptionHandler(aliases.ToArray(), setter, type, quickCategory);
			handlers.Add(quickHandler);
        }

		void SetQuickDescription(string description)
        {
			if(quickHandler != null)
            {
				quickHandler.Description = description;
            }
        }

		void TellParamHasDefaultValue()
        {
			SetQuickDescription("Accepts 'default' value");
        }

		public OptionHandler Find(string alias)
        {
			foreach(var h in handlers)
            {
				if(h.WorkingAliases.Contains(alias.ToLower()))
					return h;
            }

			return null;
        }

		public IEnumerable<OptionHandler> GetHandlersByCategory(OptionCategory category)
        {
			foreach(var handler in handlers)
            {
				if (handler.Category == category)
					yield return handler;
            }
        }
	}
}

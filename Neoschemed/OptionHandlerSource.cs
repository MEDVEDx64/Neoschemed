using Syroot.Worms.Armageddon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
			var low = raw.ToLower();
			if(low == "1" || low == "true" || low == "yes")
				return true;
			if(low == "0" || low == "false" || low == "no")
				return false;

			throw new ArgumentException("Boolean parameter must have value of 0, 1, false or true");
        }

		static T ParseEnumValue<T>(string raw)
        {
			// Not a good solution, but it allows case-independent enum parsing
			var buf = raw.ToArray();

			for(int i = 0; i < raw.Length; i++)
            {
				if(i == 0)
					buf[i] = char.ToUpper(raw[i]);
				else
					buf[i] = char.ToLower(raw[i]);
            }

			return (T)Enum.Parse(typeof(T), new string(buf));
		}

		static IEnumerable<T> ParseEnumFlags<T>(string raw)
        {
			if(raw.ToLower() == "none")
            {
				yield break;
            }

			var flags = raw.Split(',');
			foreach(var flag in flags)
            {
				yield return ParseEnumValue<T>(flag);
            }
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
			if (t == typeof(float))
				return float.Parse(raw);

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

		void DescribeEnumValues<T>()
        {
			var desc = new StringBuilder();
			desc.Append("Acceptable values: ");

			if(quickHandler.ValueType == OptionValueType.Flags)
            {
				desc.Append("none, ");
            }
			
			foreach(var e in Enum.GetValues(typeof(T)))
            {
				desc.Append(e.ToString().ToLower() + ", ");
            }

			desc.Remove(desc.Length - 2, 2);
			SetQuickDescription(desc.ToString());
        }

		sbyte ParseAmmoValue(string raw)
        {
			if (raw == "inf") return 10;
			return sbyte.Parse(raw);
        }

		byte ParsePowerValue(string raw)
        {
			var value = int.Parse(raw);
			if (value == 0)
				throw new ArgumentException("'0' is not a valid weapon power value");

			return (byte)(value - 1);
        }

		void GenerateWeaponHandlers()
        {
			foreach (var w in Enum.GetValues(typeof(Weapon)))
            {
				var weapon = (Weapon)w;

				AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Weapons[weapon].Ammo = ParseAmmoValue(raw); }, w.ToString() + "Ammo");
				AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Weapons[weapon].Delay = sbyte.Parse(raw); }, w.ToString() + "Delay");
				AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Weapons[weapon].Power = ParsePowerValue(raw); }, w.ToString() + "Power");
				AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Weapons[weapon].Prob = sbyte.Parse(raw); }, w.ToString() + "Prob");
			}
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

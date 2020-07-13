using System;
using System.Collections.Generic;
using System.Linq;
using Syroot.Worms.Armageddon;

namespace Neoschemed
{
	public class Schemed
	{
        private Scheme scheme;
		private OptionHandlerSource optSource;
		private string srcFile = null;
		private string dstFile = null;
		private SchemeVersion enforcedVersion = SchemeVersion.Version3;

		private const byte SIGNATURE_BYTE = 0x90;

		private IDictionary<OptionHandler, (string Key, string Value)> parsedArgs = new Dictionary<OptionHandler, (string, string)>();

		public Schemed()
		{
			scheme = new Scheme();
			optSource = new OptionHandlerSource(scheme);
		}

		void PrintHelp()
		{
			Console.Write("This is Neoschemed, a console interface for editing Worms Armageddon version 3 schemes.\n"
				+ "  usage: Neoschemed.exe [options]\n\n"
				+ "Essential options:\n"
				+ "    -i [file] - Load scheme from file;\n"
				+ "    -o [file] - File where the scheme will be saved. If not set, the input scheme will be overwritten;\n"
				+ "    -v [format_version] - Enforce a scheme to be saved in older format (default behavior is to upconvert schemes to version 3);\n");

			PrintOptionsHelp(optSource.GetHandlersByCategory(OptionCategory.Generic), "Generic scheme");
			PrintOptionsHelp(optSource.GetHandlersByCategory(OptionCategory.Extended), "Extended V3 scheme");
			PrintOptionsHelp(optSource.GetHandlersByCategory(OptionCategory.Weapon), "Weapons");

			Console.Write("\nAll scheme parameters are case-insensitive, so --aquasheep and --AquaSheep will be recognized as the same parameter.\n");
		}

		void PrintOptionsHelp(IEnumerable<OptionHandler> handlers, string text)
		{
			Console.Write("\n" + text + " options (always followed by a value):\n");

			foreach (var handler in handlers)
			{
				var aliasStr = "";
				foreach (var alias in handler.Aliases)
				{
					aliasStr += (alias + " | ");
				}

				if (aliasStr.Length > 0)
				{
					aliasStr = aliasStr[0..^3];
				}

				Console.WriteLine("    " + aliasStr + (handler.Description == null ? "" : " - " + handler.Description));
			}
		}

		public void HandleArgs(string[] args)
        {
			if(args.Contains("-h") || args.Contains("--help") || args.Contains("-?"))
			{
				PrintHelp();
				return;
			}

			if((args.Length % 2) != 0)
            {
				Console.WriteLine("Invalid syntax; check if there are missing values for some options you specified.");
				return;
            }

			for(int i = 0; i < args.Length; i += 2)
            {
				if(args[i] == "-i")
                {
					srcFile = args[i + 1];
					continue;
                }

				if(args[i] == "-o")
                {
					dstFile = args[i + 1];
					continue;
                }

				if(args[i] == "-v")
                {
					uint version;
					if (!uint.TryParse(args[i + 1], out version))
						version = 0;

					switch(version)
                    {
						case 1: enforcedVersion = SchemeVersion.Version1; break;
						case 2: enforcedVersion = SchemeVersion.Version2; break;
						case 3: enforcedVersion = SchemeVersion.Version3; break;

						default:
							Console.WriteLine("Error: file version value must be in range 1-3");
							return;
                    }

					continue;
                }

				if(!args[i].StartsWith('-'))
                {
					Console.WriteLine("Invalid syntax (at \"" + args[i] + " " + args[i + 1] + "\")");
					return;
                }

				args[i] = args[i].ToLower();
				var opt = optSource.Find(args[i]);
				if(opt == null)
                {
					Console.WriteLine("Unknown parameter \"" + args[i] + "\"");
					return;
                }

				if (parsedArgs.ContainsKey(opt))
					Console.WriteLine("Warning: parameter \"" + args[i] + "\" duplicated");

				parsedArgs[opt] = (args[i], args[i + 1]);
            }

			Load();

			scheme.Version = enforcedVersion;
			
			ApplyValues();
			Save();
		}

		void Load()
        {
			if(srcFile != null)
				scheme.Load(srcFile);
        }

		void Save()
		{
			if (srcFile == null && dstFile == null)
			{
				Console.WriteLine("You must specify at least source or destination scheme file, using -i nor -o keys relatively. " +
					"Pass \"-h\" (or \"--help\") parameter to learn more.");
				return;
			}

			scheme.SchemeEditor = (SchemeEditor)SIGNATURE_BYTE;
			scheme.Save((dstFile == null) ? srcFile : dstFile);
		}

		void ApplyValues()
		{
			foreach (var k in parsedArgs.Keys)
			{
				try
				{
					k.SetValue(parsedArgs[k].Value);
				}
				catch (Exception e)
				{
					Console.WriteLine("Exception while parsing value for \"" + parsedArgs[k].Key + "\"");
					Console.WriteLine("  " + e.GetType() + ": " + e.Message);
				}
			}
		}
	}
}
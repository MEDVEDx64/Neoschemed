using System;
using System.Collections.Generic;
using System.Linq;
using Syroot.Worms.Armageddon;

namespace Neoschemed
{
	public class Schemed
	{
		private Scheme scheme = new Scheme();
		private string srcFile = null;
		private string dstFile = null;

		private IDictionary<OptionHandler, string> parsedArgs = new Dictionary<OptionHandler, string>();

		public Schemed()
		{
		}

		void PrintHelp()
		{
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

				if(!args[i].StartsWith('-'))
                {
					Console.WriteLine("Invalid syntax (at \"" + args[i] + " " + args[i + 1] + "\")");
					return;
                }

				var opt = OptionHandlerSource.Find(args[i]);
				if(opt == null)
                {
					Console.WriteLine("Unknown parameter \"" + args[i] + "\"");
					return;
                }

				parsedArgs[opt] = args[i + 1];
            }
		}
	}
}
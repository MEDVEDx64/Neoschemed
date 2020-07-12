using System;
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

		public Schemed()
		{
			scheme = new Scheme();
			optSource = new OptionHandlerSource(scheme);
		}

		void PrintHelp()
		{
		}

		void Save()
        {
			if(srcFile == null && dstFile == null)
            {
				Console.WriteLine("You must specify at least source or destination scheme file name, using -i nor -o keys relatively.");
				return;
            }

			scheme.Save((dstFile == null) ? srcFile : dstFile);
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

				var opt = optSource.Find(args[i]);
				if(opt == null)
                {
					Console.WriteLine("Unknown parameter \"" + args[i] + "\"");
					return;
                }

				try
				{
					opt.SetValue(args[i + 1]);
				}
				catch(Exception e)
                {
					Console.WriteLine("Exception while parsing value for \"" + args[i] + "\"");
					Console.WriteLine("  " + e.GetType() + ": " + e.Message);
                }
            }

			Save();
		}
	}
}
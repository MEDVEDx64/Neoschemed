namespace Neoschemed
{
    public partial class OptionHandlerSource
    {
		void CreateHandlers()
		{
			handlers.Add(new OptionHandler("Aqua Sheep", new string[] { "--aquasheep", "-as" }, (raw) => { scheme.AquaSheep = ParseBooleanValue(raw); }));
			handlers.Add(new OptionHandler("Artillery mode", new string[] { "--artillery", "-am" }, (raw) => { scheme.ArtilleryMode = ParseBooleanValue(raw); }));
			handlers.Add(new OptionHandler("Enable blood effects", new string[] { "--blood", "-b" }, (raw) => { scheme.Blood = ParseBooleanValue(raw); }));
			handlers.Add(new OptionHandler("Enable Donor Cards", new string[] { "--donorcards", "-dc" }, (raw) => { scheme.DonorCards = ParseBooleanValue(raw); }));
			handlers.Add(new OptionHandler("Dud mines", new string[] { "--dudmines", "--dud", "-dm" }, (raw) => { scheme.DudMines = ParseBooleanValue(raw); }));
		}
	}
}

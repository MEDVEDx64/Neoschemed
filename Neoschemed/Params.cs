namespace Neoschemed
{
    public partial class OptionHandlerSource
    {
		void CreateHandlers()
		{
			handlers.Add(new OptionHandler(new string[] { "--aquasheep", "-as" }, (raw) => { scheme.AquaSheep = ParseBooleanValue(raw); }));
			handlers.Add(new OptionHandler(new string[] { "--artillery", "-am" }, (raw) => { scheme.ArtilleryMode = ParseBooleanValue(raw); }));
			handlers.Add(new OptionHandler(new string[] { "--blood", "-b" }, (raw) => { scheme.Blood = ParseBooleanValue(raw); }));
			handlers.Add(new OptionHandler(new string[] { "--donorcards", "-dc" }, (raw) => { scheme.DonorCards = ParseBooleanValue(raw); }));
			handlers.Add(new OptionHandler(new string[] { "--dudmines", "--dud", "-dm" }, (raw) => { scheme.DudMines = ParseBooleanValue(raw); }));

			handlers.Add(new OptionHandler(new string[] { "--anglecheatglitch", "-xacg" }, (raw) => { scheme.Extended.AngleCheatGlitch = ParseBooleanValue(raw); }, category: OptionCategory.Extended));
			handlers.Add(new OptionHandler(new string[] { "--antilockaim", "-xala" }, (raw) => { scheme.Extended.AntiLockAim = ParseBooleanValue(raw); }, category: OptionCategory.Extended));
			handlers.Add(new OptionHandler(new string[] { "--antilockpower", "-xalp" }, (raw) => { scheme.Extended.AntiLockPower = ParseBooleanValue(raw); }, category: OptionCategory.Extended));
		}
	}
}

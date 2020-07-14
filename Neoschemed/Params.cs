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

			SetQuickHandlerCategory(OptionCategory.Extended);

			AddQuickHandler(nameof(scheme.Extended.AngleCheatGlitch), (raw) => { scheme.Extended.AngleCheatGlitch = ParseBooleanValue(raw); });
			AddQuickHandler(nameof(scheme.Extended.AntiLockAim), (raw) => { scheme.Extended.AntiLockAim = ParseBooleanValue(raw); });
			AddQuickHandler(nameof(scheme.Extended.AntiLockPower), (raw) => { scheme.Extended.AntiLockPower = ParseBooleanValue(raw); });
			AddQuickHandler(nameof(scheme.Extended.AntiSink), (raw) => { scheme.Extended.AntiSink = ParseBooleanValue(raw); });
			AddQuickHandler(nameof(scheme.Extended.AutoReaim), (raw) => { scheme.Extended.AutoReaim = ParseBooleanValue(raw); });
			AddQuickHandler(nameof(scheme.Extended.AngleCheatGlitch), (raw) => { scheme.Extended.AngleCheatGlitch = ParseBooleanValue(raw); });
		}
	}
}

namespace Neoschemed
{
    public partial class OptionHandlerSource
    {
		void CreateHandlers()
		{
			SetQuickHandlerCategory(OptionCategory.Generic);

			AddQuickHandler((raw) => { scheme.AquaSheep = ParseBooleanValue(raw); }, nameof(scheme.AquaSheep), "-as");
			AddQuickHandler((raw) => { scheme.ArtilleryMode = ParseBooleanValue(raw); }, nameof(scheme.ArtilleryMode), "--artillery", "-am");
			AddQuickHandler((raw) => { scheme.Blood = ParseBooleanValue(raw); }, nameof(scheme.Blood), "-b");
			AddQuickHandler((raw) => { scheme.DonorCards = ParseBooleanValue(raw); }, nameof(scheme.DonorCards), "-dc");
			AddQuickHandler((raw) => { scheme.DudMines = ParseBooleanValue(raw); }, nameof(scheme.DudMines), "--dud", "-dm");

			SetQuickHandlerCategory(OptionCategory.Extended);

			AddQuickHandler((raw) => { scheme.Extended.AngleCheatGlitch = ParseBooleanValue(raw); }, nameof(scheme.Extended.AngleCheatGlitch));
			AddQuickHandler((raw) => { scheme.Extended.AntiLockAim = ParseBooleanValue(raw); }, nameof(scheme.Extended.AntiLockAim));
			AddQuickHandler((raw) => { scheme.Extended.AntiLockPower = ParseBooleanValue(raw); }, nameof(scheme.Extended.AntiLockPower));
			AddQuickHandler((raw) => { scheme.Extended.AntiSink = ParseBooleanValue(raw); }, nameof(scheme.Extended.AntiSink));
			AddQuickHandler((raw) => { scheme.Extended.AutoReaim = ParseBooleanValue(raw); }, nameof(scheme.Extended.AutoReaim));
			AddQuickHandler((raw) => { scheme.Extended.AngleCheatGlitch = ParseBooleanValue(raw); }, nameof(scheme.Extended.AngleCheatGlitch));
		}
	}
}

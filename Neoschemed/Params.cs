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
			AddQuickHandler((raw) => { scheme.Extended.AutoRetreat = ParseBooleanValue(raw); }, nameof(scheme.Extended.AutoRetreat));
			AddQuickHandler((raw) => { scheme.Extended.BattyRope = ParseBooleanValue(raw); }, nameof(scheme.Extended.BattyRope));
			AddQuickHandler((raw) => { scheme.Extended.BloodAmount = (byte?)ParseOptionalValue<byte>(raw); }, nameof(scheme.Extended.BloodAmount));
			TellParamHasDefaultValue();
			AddQuickHandler((raw) => { scheme.Extended.CircularAim = ParseBooleanValue(raw); }, nameof(scheme.Extended.CircularAim));
			AddQuickHandler((raw) => { scheme.Extended.ConserveUtilities = ParseBooleanValue(raw); }, nameof(scheme.Extended.ConserveUtilities));
			AddQuickHandler((raw) => { scheme.Extended.ConstantWind = ParseBooleanValue(raw); }, nameof(scheme.Extended.ConstantWind));
			AddQuickHandler((raw) => { scheme.Extended.CrateLimit = ushort.Parse(raw); }, nameof(scheme.Extended.CrateLimit));
			AddQuickHandler((raw) => { scheme.Extended.CrateRate = byte.Parse(raw); }, nameof(scheme.Extended.CrateRate));
			AddQuickHandler((raw) => { scheme.Extended.CrateShower = ParseBooleanValue(raw); }, nameof(scheme.Extended.CrateShower));
			AddQuickHandler((raw) => { scheme.Extended.DoubleTimeCount = byte.Parse(raw); }, nameof(scheme.Extended.DoubleTimeCount));
			AddQuickHandler((raw) => { scheme.Extended.DrillImpartsVelocity = (bool?)ParseOptionalValue<bool>(raw); }, nameof(scheme.Extended.DrillImpartsVelocity));
			TellParamHasDefaultValue();
			AddQuickHandler((raw) => { scheme.Extended.ExpediteUtilities = ParseBooleanValue(raw); }, nameof(scheme.Extended.ExpediteUtilities));
			AddQuickHandler((raw) => { scheme.Extended.ExplosionFallDamage = ParseBooleanValue(raw); }, nameof(scheme.Extended.ExplosionFallDamage));
			AddQuickHandler((raw) => { scheme.Extended.ExtendedFuse = ParseBooleanValue(raw); }, nameof(scheme.Extended.ExtendedFuse));
		}
	}
}

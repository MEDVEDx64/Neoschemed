namespace Neoschemed
{
    public partial class OptionHandlerSource
    {
		void CreateHandlers()
		{
			SetQuickHandlerCategory(OptionCategory.Generic);

			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.AquaSheep = ParseBooleanValue(raw); }, nameof(scheme.AquaSheep), "-as");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.ArtilleryMode = ParseBooleanValue(raw); }, nameof(scheme.ArtilleryMode), "--artillery", "-am");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Blood = ParseBooleanValue(raw); }, nameof(scheme.Blood), "-b");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.DonorCards = ParseBooleanValue(raw); }, nameof(scheme.DonorCards), "-dc");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.DudMines = ParseBooleanValue(raw); }, nameof(scheme.DudMines), "--dud", "-dm");

			SetQuickHandlerCategory(OptionCategory.Extended);

			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AngleCheatGlitch = ParseBooleanValue(raw); }, nameof(scheme.Extended.AngleCheatGlitch));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AntiLockAim = ParseBooleanValue(raw); }, nameof(scheme.Extended.AntiLockAim));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AntiLockPower = ParseBooleanValue(raw); }, nameof(scheme.Extended.AntiLockPower));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AntiSink = ParseBooleanValue(raw); }, nameof(scheme.Extended.AntiSink));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AutoReaim = ParseBooleanValue(raw); }, nameof(scheme.Extended.AutoReaim));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AutoRetreat = ParseBooleanValue(raw); }, nameof(scheme.Extended.AutoRetreat));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.BattyRope = ParseBooleanValue(raw); }, nameof(scheme.Extended.BattyRope));
			AddQuickHandler(OptionValueType.Numeric, (raw) => { scheme.Extended.BloodAmount = (byte?)ParseOptionalValue<byte>(raw); }, nameof(scheme.Extended.BloodAmount));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.CircularAim = ParseBooleanValue(raw); }, nameof(scheme.Extended.CircularAim));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ConserveUtilities = ParseBooleanValue(raw); }, nameof(scheme.Extended.ConserveUtilities));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ConstantWind = ParseBooleanValue(raw); }, nameof(scheme.Extended.ConstantWind));
			AddQuickHandler(OptionValueType.Numeric, (raw) => { scheme.Extended.CrateLimit = ushort.Parse(raw); }, nameof(scheme.Extended.CrateLimit));
			AddQuickHandler(OptionValueType.Numeric, (raw) => { scheme.Extended.CrateRate = byte.Parse(raw); }, nameof(scheme.Extended.CrateRate));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.CrateShower = ParseBooleanValue(raw); }, nameof(scheme.Extended.CrateShower));
			AddQuickHandler(OptionValueType.Numeric, (raw) => { scheme.Extended.DoubleTimeCount = byte.Parse(raw); }, nameof(scheme.Extended.DoubleTimeCount));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.DrillImpartsVelocity = (bool?)ParseOptionalValue<bool>(raw); }, nameof(scheme.Extended.DrillImpartsVelocity));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ExpediteUtilities = ParseBooleanValue(raw); }, nameof(scheme.Extended.ExpediteUtilities));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ExplosionFallDamage = ParseBooleanValue(raw); }, nameof(scheme.Extended.ExplosionFallDamage));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ExtendedFuse = ParseBooleanValue(raw); }, nameof(scheme.Extended.ExtendedFuse));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.FiringPausesTimer = ParseBooleanValue(raw); }, nameof(scheme.Extended.FiringPausesTimer));
			AddQuickHandler(OptionValueType.Numeric, (raw) => { scheme.Extended.FlameLimit = ushort.Parse(raw); }, nameof(scheme.Extended.FlameLimit));
			AddQuickHandler(OptionValueType.Numeric, (raw) => { scheme.Extended.FlameTouchDecay = byte.Parse(raw); }, nameof(scheme.Extended.FlameTouchDecay));
		}
	}
}

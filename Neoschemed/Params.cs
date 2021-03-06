﻿using Syroot.Worms.Armageddon;

namespace Neoschemed
{
    public partial class OptionHandlerSource
    {
		void CreateHandlers()
		{
			SetQuickHandlerCategory(OptionCategory.Generic);

			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.AquaSheep = ParseBooleanValue(raw); }, nameof(scheme.AquaSheep));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.ArtilleryMode = ParseBooleanValue(raw); }, nameof(scheme.ArtilleryMode), "--artillery", "-am");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Blood = ParseBooleanValue(raw); }, nameof(scheme.Blood));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.DonorCards = ParseBooleanValue(raw); }, nameof(scheme.DonorCards), "-dc");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.DudMines = ParseBooleanValue(raw); }, nameof(scheme.DudMines), "--dud", "-dm");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.FallDamage = int.Parse(raw); }, nameof(scheme.FallDamage), "-fd");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.GodWorms = ParseBooleanValue(raw); }, nameof(scheme.GodWorms), "-g");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.HealthCrateEnergy = byte.Parse(raw); }, nameof(scheme.HealthCrateEnergy), "-hcen");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.HealthCrateProb = sbyte.Parse(raw); }, nameof(scheme.HealthCrateProb), "-hcpr");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.HotSeatTime = byte.Parse(raw); }, nameof(scheme.HotSeatTime), "-hs");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.IndiLand = ParseBooleanValue(raw); }, nameof(scheme.IndiLand), "-l");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.ManualWormPlacement = ParseBooleanValue(raw); }, nameof(scheme.ManualWormPlacement), "--placement", "-p");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.MineDelay = byte.Parse(raw); }, nameof(scheme.MineDelay), "-md");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.MineDelayRandom = ParseBooleanValue(raw); }, nameof(scheme.MineDelayRandom), "-mdr");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.NumberOfWins = byte.Parse(raw); }, nameof(scheme.NumberOfWins), "--wins", "-w");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.ObjectCount = byte.Parse(raw); }, nameof(scheme.ObjectCount), "-oc");
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.ObjectTypes = ParseEnumValue<MapObjectType>(raw); }, nameof(scheme.ObjectTypes), "-ot");
			DescribeEnumValues<MapObjectType>();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Replays = ParseBooleanValue(raw); }, nameof(scheme.Replays));
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.RetreatTime = byte.Parse(raw); }, nameof(scheme.RetreatTime), "-ret");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.RetreatTimeRope = byte.Parse(raw); }, nameof(scheme.RetreatTimeRope), "-retr");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.RoundTimeMinutes = byte.Parse(raw); }, nameof(scheme.RoundTimeMinutes), "-rmin");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.RoundTimeSeconds = byte.Parse(raw); }, nameof(scheme.RoundTimeSeconds), "-rsec");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.SheepHeaven = ParseBooleanValue(raw); }, nameof(scheme.SheepHeaven));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.ShowRoundTime = ParseBooleanValue(raw); }, nameof(scheme.ShowRoundTime));
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.Stockpiling = ParseEnumValue<Stockpiling>(raw); }, nameof(scheme.Stockpiling));
			DescribeEnumValues<Stockpiling>();
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.SuddenDeathEvent = ParseEnumValue<SuddenDeathEvent>(raw); }, nameof(scheme.SuddenDeathEvent));
			DescribeEnumValues<SuddenDeathEvent>();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.SuperWeapons = ParseBooleanValue(raw); }, nameof(scheme.SuperWeapons), "--super", "-sw");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.TeamWeapons = ParseBooleanValue(raw); }, nameof(scheme.TeamWeapons), "-tw");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.TurnTime = byte.Parse(raw); }, nameof(scheme.TurnTime), "-t");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.TurnTimeInfinite = ParseBooleanValue(raw); }, nameof(scheme.TurnTimeInfinite), "-inf");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.UpgradeCluster = ParseBooleanValue(raw); }, nameof(scheme.UpgradeCluster), "-cu");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.UpgradeGrenade = ParseBooleanValue(raw); }, nameof(scheme.UpgradeGrenade), "-gu");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.UpgradeLongbow = ParseBooleanValue(raw); }, nameof(scheme.UpgradeLongbow), "-lu");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.UpgradeShotgun = ParseBooleanValue(raw); }, nameof(scheme.UpgradeShotgun), "-su");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.UtilityCrateProb = sbyte.Parse(raw); }, nameof(scheme.UtilityCrateProb), "-ucpr");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.WaterRiseRate = byte.Parse(raw); }, nameof(scheme.WaterRiseRate), "-wr");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.WeaponCrateProb = sbyte.Parse(raw); }, nameof(scheme.WeaponCrateProb), "-wcpr");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.WormEnergy = byte.Parse(raw); }, nameof(scheme.WormEnergy), "--health", "-h");
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.WormSelect = ParseEnumValue<WormSelect>(raw); }, nameof(scheme.WormSelect));
			DescribeEnumValues<WormSelect>();

			SetQuickHandlerCategory(OptionCategory.Extended);

			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AngleCheatGlitch = ParseBooleanValue(raw); }, nameof(scheme.Extended.AngleCheatGlitch));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AntiLockAim = ParseBooleanValue(raw); }, nameof(scheme.Extended.AntiLockAim));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AntiLockPower = ParseBooleanValue(raw); }, nameof(scheme.Extended.AntiLockPower));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AntiSink = ParseBooleanValue(raw); }, nameof(scheme.Extended.AntiSink));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AutoReaim = ParseBooleanValue(raw); }, nameof(scheme.Extended.AutoReaim));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.AutoRetreat = ParseBooleanValue(raw); }, nameof(scheme.Extended.AutoRetreat));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.BattyRope = ParseBooleanValue(raw); }, nameof(scheme.Extended.BattyRope), "--batty");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.BloodAmount = (byte?)ParseOptionalValue<byte>(raw); }, nameof(scheme.Extended.BloodAmount));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.CircularAim = ParseBooleanValue(raw); }, nameof(scheme.Extended.CircularAim));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ConserveUtilities = ParseBooleanValue(raw); }, nameof(scheme.Extended.ConserveUtilities));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ConstantWind = ParseBooleanValue(raw); }, nameof(scheme.Extended.ConstantWind));
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.CrateLimit = ushort.Parse(raw); }, nameof(scheme.Extended.CrateLimit));
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.CrateRate = byte.Parse(raw); }, nameof(scheme.Extended.CrateRate));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.CrateShower = ParseBooleanValue(raw); }, nameof(scheme.Extended.CrateShower));
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.DoubleTimeCount = byte.Parse(raw); }, nameof(scheme.Extended.DoubleTimeCount));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.DrillImpartsVelocity = (bool?)ParseOptionalValue<bool>(raw); }, nameof(scheme.Extended.DrillImpartsVelocity));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ExpediteUtilities = ParseBooleanValue(raw); }, nameof(scheme.Extended.ExpediteUtilities));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ExplosionFallDamage = ParseBooleanValue(raw); }, nameof(scheme.Extended.ExplosionFallDamage));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ExtendedFuse = ParseBooleanValue(raw); }, nameof(scheme.Extended.ExtendedFuse));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.FiringPausesTimer = ParseBooleanValue(raw); }, nameof(scheme.Extended.FiringPausesTimer));
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.FlameLimit = ushort.Parse(raw); }, nameof(scheme.Extended.FlameLimit));
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.FlameTouchDecay = byte.Parse(raw); }, nameof(scheme.Extended.FlameTouchDecay));
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.FlameTurnDecay = float.Parse(raw); }, nameof(scheme.Extended.FlameTurnDecay));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.FloatingWeaponGlitch = ParseBooleanValue(raw); }, nameof(scheme.Extended.FloatingWeaponGlitch));
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.Friction = float.Parse(raw); }, nameof(scheme.Extended.Friction));
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.GameSpeed = float.Parse(raw); }, nameof(scheme.Extended.GameSpeed));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.GirderRadiusAssist = ParseBooleanValue(raw); }, nameof(scheme.Extended.GirderRadiusAssist));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.GlideGlitch = ParseBooleanValue(raw); }, nameof(scheme.Extended.GlideGlitch));
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.Gravity = float.Parse(raw); }, nameof(scheme.Extended.Gravity));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.GroupPlaceAllies = ParseBooleanValue(raw); }, nameof(scheme.Extended.GroupPlaceAllies), "--group");
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.Extended.HealthCure = ParseEnumValue<HealthCure>(raw); }, nameof(scheme.Extended.HealthCure));
			DescribeEnumValues<HealthCure>();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.HerdDoublingGlitch = (bool?)ParseOptionalValue<bool>(raw); }, nameof(scheme.Extended.HerdDoublingGlitch));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.IndianRopeGlitch = (bool?)ParseOptionalValue<bool>(raw); }, nameof(scheme.Extended.IndianRopeGlitch), "--indian");
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.JetpackBungeeGlitch = ParseBooleanValue(raw); }, nameof(scheme.Extended.JetpackBungeeGlitch));
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.JetpackMaxSpeed = float.Parse(raw); }, nameof(scheme.Extended.JetpackMaxSpeed));
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.KaosMod = byte.Parse(raw); }, nameof(scheme.Extended.KaosMod), "--kaos");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.KeepControlHeadBump = ParseBooleanValue(raw); }, nameof(scheme.Extended.KeepControlHeadBump));
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.Extended.KeepControlSkim = ParseEnumValue<SkimControlLoss>(raw); }, nameof(scheme.Extended.KeepControlSkim));
			DescribeEnumValues<SkimControlLoss>();
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.Extended.KeepControlXImpact = ParseEnumValue<XImpactControlLoss>(raw); }, nameof(scheme.Extended.KeepControlXImpact));
			DescribeEnumValues<XImpactControlLoss>();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.LoseControlDoesntEndTurn = ParseBooleanValue(raw); }, nameof(scheme.Extended.LoseControlDoesntEndTurn), "-ldet");
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.NoCrateProbability = (byte?)ParseOptionalValue<byte>(raw); }, nameof(scheme.Extended.NoCrateProbability));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ObjectPushByExplosion = (bool?)ParseOptionalValue<bool>(raw); }, nameof(scheme.Extended.ObjectPushByExplosion));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.ProjectileMaxSpeed = float.Parse(raw); }, nameof(scheme.Extended.ProjectileMaxSpeed));
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.Extended.Roofing = ParseEnumValue<Roofing>(raw); }, nameof(scheme.Extended.Roofing));
			DescribeEnumValues<Roofing>();
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.RopeKnockForce = (byte?)ParseOptionalValue<byte>(raw); }, nameof(scheme.Extended.RopeKnockForce));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.RopeMaxSpeed = float.Parse(raw); }, nameof(scheme.Extended.RopeMaxSpeed));
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.Extended.RopeRollDrops = ParseEnumValue<RopeRollDrops>(raw); }, nameof(scheme.Extended.RopeRollDrops));
			DescribeEnumValues<RopeRollDrops>();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.RopeUpgrade = ParseBooleanValue(raw); }, nameof(scheme.Extended.RopeUpgrade));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.RoundTimeFractional = ParseBooleanValue(raw); }, nameof(scheme.Extended.RoundTimeFractional));
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.RwGravity = float.Parse(raw); }, nameof(scheme.Extended.RwGravity));
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.Extended.RwGravityType = ParseEnumValue<RwGravityType>(raw); }, nameof(scheme.Extended.RwGravityType));
			DescribeEnumValues<RwGravityType>();
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.RwWind = float.Parse(raw); }, nameof(scheme.Extended.RwWind));
			AddQuickHandler(OptionValueType.Flags, (raw) => {
				scheme.Extended.SheepHeavenFlags = 0;
				foreach (SheepHeavenFlags f in ParseEnumFlags<SheepHeavenFlags>(raw)) scheme.Extended.SheepHeavenFlags |= f;
			}, nameof(scheme.Extended.SheepHeavenFlags));
			DescribeEnumValues<SheepHeavenFlags>();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ShotDoesntEndTurn = ParseBooleanValue(raw); }, nameof(scheme.Extended.ShotDoesntEndTurn), "-sdet");
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ShotDoesntEndTurnAll = ParseBooleanValue(raw); }, nameof(scheme.Extended.ShotDoesntEndTurnAll));
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.Extended.SkipWalk = ParseEnumValue<SkipWalk>(raw); }, nameof(scheme.Extended.SkipWalk));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.SuddenDeathNoWormSelect = ParseBooleanValue(raw); }, nameof(scheme.Extended.SuddenDeathNoWormSelect));
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.SuddenDeathTurnDamage = byte.Parse(raw); }, nameof(scheme.Extended.SuddenDeathTurnDamage));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.TerrainOverlapGlitch = (bool?)ParseOptionalValue<bool>(raw); }, nameof(scheme.Extended.TerrainOverlapGlitch));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.UndeterminedCrates = (bool?)ParseOptionalValue<bool>(raw); }, nameof(scheme.Extended.UndeterminedCrates));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.UndeterminedMineFuse = (bool?)ParseOptionalValue<bool>(raw); }, nameof(scheme.Extended.UndeterminedMineFuse));
			TellParamHasDefaultValue();
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.Viscosity = float.Parse(raw); }, nameof(scheme.Extended.Viscosity));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.ViscosityWorms = ParseBooleanValue(raw); }, nameof(scheme.Extended.ViscosityWorms));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.WeaponsDontChange = ParseBooleanValue(raw); }, nameof(scheme.Extended.WeaponsDontChange));
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.Wind = short.Parse(raw); }, nameof(scheme.Extended.Wind));
			AddQuickHandler(OptionValueType.Decimal, (raw) => { scheme.Extended.WindBias = byte.Parse(raw); }, nameof(scheme.Extended.WindBias));
			AddQuickHandler(OptionValueType.Float, (raw) => { scheme.Extended.WormBounce = float.Parse(raw); }, nameof(scheme.Extended.WormBounce));
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.Extended.WormPhasingAlly = ParseEnumValue<WormPhasing>(raw); }, nameof(scheme.Extended.WormPhasingAlly));
			DescribeEnumValues<WormPhasing>();
			AddQuickHandler(OptionValueType.Enum, (raw) => { scheme.Extended.WormPhasingEnemy = ParseEnumValue<WormPhasing>(raw); }, nameof(scheme.Extended.WormPhasingEnemy));
			DescribeEnumValues<WormPhasing>();
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.WormSelectAnytime = ParseBooleanValue(raw); }, nameof(scheme.Extended.WormSelectAnytime));
			AddQuickHandler(OptionValueType.Boolean, (raw) => { scheme.Extended.WormSelectKeepHotSeat = ParseBooleanValue(raw); }, nameof(scheme.Extended.WormSelectKeepHotSeat));

			SetQuickHandlerCategory(OptionCategory.Weapon);

			GenerateWeaponHandlers();
		}
	}
}

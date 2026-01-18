using TerraFX.Interop.Windows;

namespace BossMod.Modules.Dawntrail.Savage.M10SDaringDevils;

[SkipLocalsInit]

sealed class HotImpact(BossModule module) : Components.CastSharedTankbuster(module, (uint)AID.HotImpact, 6f);

[ModuleInfo(BossModuleInfo.Maturity.WIP,
StatesType = typeof(DaringDevilsStates),
ConfigType = null, // replace null with typeof(RedHotConfig) if applicable
ObjectIDType = typeof(OID),
ActionIDType = typeof(AID), // replace null with typeof(AID) if applicable
StatusIDType = typeof(SID), // replace null with typeof(SID) if applicable
TetherIDType = null, // replace null with typeof(TetherID) if applicable
IconIDType = null, // replace null with typeof(IconID) if applicable
PrimaryActorOID = (uint)OID.RedHot,
Contributors = "HerStolenLight",
Expansion = BossModuleInfo.Expansion.Dawntrail,
Category = BossModuleInfo.Category.Savage,
GroupType = BossModuleInfo.GroupType.CFC,
GroupID = 1071u,
NameID = 14370u,
SortOrder = 1,
PlanLevel = 0)]
public sealed class DaringDevils(WorldState ws, Actor primary) : BossModule(ws, primary, new(100f, 100f), new ArenaBoundsSquare(20f));

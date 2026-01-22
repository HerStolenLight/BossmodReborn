using FFXIVClientStructs.FFXIV.Client.Game.InstanceContent;
using TerraFX.Interop.Windows;

namespace BossMod.Modules.Dawntrail.Savage.M10SDaringDevils;

[SkipLocalsInit]

sealed class HotImpact(BossModule module) : Components.CastSharedTankbuster(module, (uint)AID.HotImpact, 6f);

sealed class AlleyOopInfernoSpreads(BossModule module) : Components.SpreadFromCastTargets(module, (uint)AID.AlleyOopInfernoSpreads, 5f);

sealed class PyrotationStack(BossModule module) : Components.StackWithIcon(module, (uint)IconID.PyrotationStack, (uint)AID.Pyrotation1, 5f, 2, 8, 3); //TODO: Doesn't show - why?

sealed class DeepBlue(BossModule module) : Components.Adds(module, (uint)OID.DeepBlue);

sealed class DiversDare(BossModule module) : Components.RaidwideCast(module, (uint)AID.DiversDare);

sealed class SickSwellKB(BossModule module) : Components.SimpleKnockbacks(
    module,
    (uint)AID.SickSwell1,   // boss cast is the clean trigger
    distance: 10f,
    kind: Kind.DirForward,
    stopAtWall: false); // outside wall is deadly;

sealed class SickestTakeOff(BossModule module) : Components.SimpleAOEs(module, (uint)AID.SickestTakeOff1, new AOEShapeRect(50f, 7.5f));

sealed class AlleyOopDoubleDip(BossModule module) : Components.BaitAwayEveryone(module, module.Enemies((uint)OID.DeepBlue).FirstOrDefault(), new AOEShapeCone(60f, 11.25f.Degrees()), (uint)AID.AlleyOopDoubleDipHit1)
{
    public override void OnEventCast(Actor caster, ActorCastEvent spell)
    {
       if (spell.Action.ID == (uint)AID.AlleyOopDoubleDipHit1)
        {
            ActiveBaits.Clear();
        }
    }
}

[ModuleInfo(BossModuleInfo.Maturity.WIP,
StatesType = typeof(DaringDevilsStates),
ConfigType = null, // replace null with typeof(RedHotConfig) if applicable
ObjectIDType = typeof(OID),
ActionIDType = typeof(AID), // replace null with typeof(AID) if applicable
StatusIDType = typeof(SID), // replace null with typeof(SID) if applicable
TetherIDType = null, // replace null with typeof(TetherID) if applicable
IconIDType = typeof(IconID), // replace null with typeof(IconID) if applicable
PrimaryActorOID = (uint)OID.RedHot,
Contributors = "HerStolenLight",
Expansion = BossModuleInfo.Expansion.Dawntrail,
Category = BossModuleInfo.Category.Savage,
GroupType = BossModuleInfo.GroupType.CFC,
GroupID = 1071u,
NameID = 14370u,
SortOrder = 1,
PlanLevel = 0)]
public sealed class M10SDaringDevils(WorldState ws, Actor primary) : BossModule(ws, primary, new(100f, 100f), new ArenaBoundsSquare(20f))
{
    public Actor? DeepBlue { get; private set; }

    public Actor? BossDeepBlue() => DeepBlue;

    protected override void UpdateModule()
    {
        // cache secondary boss
        DeepBlue ??= GetActor((uint)OID.DeepBlue);
    }

    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        if (DeepBlue != null)
            Arena.Actor(DeepBlue);
        Arena.Actor(PrimaryActor);
    }
}

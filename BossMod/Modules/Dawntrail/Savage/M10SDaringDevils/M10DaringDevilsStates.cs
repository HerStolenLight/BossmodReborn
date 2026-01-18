using BossMod.Dawntrail.Dungeon.D04Vanguard.D040VanguardSentryR7;
using BossMod.DawnTrail.Raid.M10NDaringDevils;

namespace BossMod.Modules.Dawntrail.Savage.M10SDaringDevils;
sealed class DaringDevilsStates : StateMachineBuilder
{
    public DaringDevilsStates(BossModule module) : base(module)
    {
        DeathPhase(default, SinglePhase);
    }

    private void SinglePhase(uint id)
    {
        HotImpact(id, 9.19f);
        FlameFloater(id, 8.43f, 4);
    }

    private void HotImpact(uint id, float delay)
    {
        Cast(id, (uint)AID.HotImpact, delay, 5f, "Shared Tankbuster")
            .ActivateOnEnter<HotImpact>()
            .SetHint(StateMachine.StateHint.Tankbuster);
    }

    private void FlameFloater(uint id, float delay, int count)
    {
        Cast(id, (uint)AID.FlameFloaterVisual, delay, 7f, "Flame Floater")
            .ActivateOnEnter<FlameFloater>();
    }
}

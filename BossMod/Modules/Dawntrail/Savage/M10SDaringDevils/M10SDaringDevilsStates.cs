namespace BossMod.Modules.Dawntrail.Savage.M10SDaringDevils;
sealed class DaringDevilsStates : StateMachineBuilder
{
    private readonly M10SDaringDevils _module;
    public DaringDevilsStates(M10SDaringDevils module) : base(module)
    {
        _module = module;
        DeathPhase(default, SinglePhase);
    }

    private void SinglePhase(uint id)
    {
        HotImpact(id, 9.19f);
        FlameFloater(id + 0x10000u, 8.43f, 4);
        AlleyOopInferno(id + 0x10001u, 18.54f);
        CutbackBlaze(id + 0x10002u, 5.15f);
        Pyrotation(id + 0x10003u, 2.10f, 3);
        DiversDare(id + 0x10004u, 7.71f);
        SickSwell(id + 0x20000u, 11.64f);
        SickSwellHit(id + 0x20001u, 18.23f);
        BlueAlleyOop(id + 0x20002u, 10.2f);
    }

    private void HotImpact(uint id, float delay)
    {
        Cast(id, (uint)AID.HotImpact, delay, 5f, "Shared Tankbuster")
            .ActivateOnEnter<HotImpact>()
            .ActivateOnEnter<FlameFloatVoidzones>()
            .DeactivateOnExit<HotImpact>()
            .SetHint(StateMachine.StateHint.Tankbuster);
    }

    private void FlameFloater(uint id, float delay, int count)
    {
        Cast(id, (uint)AID.FlameFloaterVisual, delay, 7f, "Flame Floater")
            .ActivateOnEnter<FlameFloater>();
    }
    private void AlleyOopInferno(uint id, float delay)
    {
        Cast(id, (uint)AID.AlleyOopInferno, delay, 4.30f, "Alley-Oop Inferno")
            .ActivateOnEnter<AlleyOopInfernoSpreads>()
            .ActivateOnEnter<AlleyOopInfernoVoidzones>();
    }
    private void CutbackBlaze(uint id, float delay)
    {
        Cast(id, (uint)AID.CutbackBlazeVisual, delay, 4.30f, "Cutback Blaze")
            .ActivateOnEnter<CutbackBlazeCone>()
            .ActivateOnEnter<CutbackBlazeVoidZones>()
            .ActivateOnEnter<PyrotationStack>()
            .DeactivateOnExit<CutbackBlazeCone>();
    }
    private void Pyrotation(uint id, float delay, int count)
    {
        Cast(id, (uint)AID.Pyrotation, delay, 4.30f, "Pyrotation")
            .ActivateOnEnter<PyrotationPuddles>();
    }
    private void DiversDare(uint id, float delay)
    {
        Cast(id, (uint)AID.DiversDare, delay, 5f, "RaidWide")
            .ActivateOnEnter<DiversDare>()
            .ActivateOnEnter<DeepBlue>()
            .DeactivateOnExit<FlameFloatVoidzones>()
            .DeactivateOnExit<PyrotationStack>()
            .DeactivateOnExit<CutbackBlazeVoidZones>()
            .DeactivateOnExit<AlleyOopInfernoVoidzones>()
            .DeactivateOnExit<PyrotationPuddles>()
            .DeactivateOnExit<AlleyOopInfernoSpreads>()
            .DeactivateOnExit<FlameFloater>();
    }
    private void SickSwell(uint id, float delay)
    {
        ActorCast(id, _module.BossDeepBlue, (uint)AID.SickSwell, delay, 3f, false, "Sick Swell")
            .ActivateOnEnter<SickSwellKB>()
            .ActivateOnEnter<SickestTakeOff>()
            .ActivateOnEnter<SickestTakeoffSpreadStacks>();
    }
    private void SickSwellHit(uint id, float delay)
    {
        Timeout(id, delay, "SickSwell/Takeoff Hit")
            .DeactivateOnExit<SickSwellKB>()
            .DeactivateOnExit<SickestTakeOff>();
    }
    private void BlueAlleyOop(uint id, float delay)
    {
        ActorCastMulti(id, _module.BossDeepBlue, [(uint)AID.ReverseAlleyOopVisual, (uint)AID.AlleyOopDoubleDipVisual], delay, 5f, false, "Blue Alley-oop")
            .DeactivateOnExit<SickestTakeoffSpreadStacks>()
            .ActivateOnEnter<AlleyOopDoubleDip>();
    }
}

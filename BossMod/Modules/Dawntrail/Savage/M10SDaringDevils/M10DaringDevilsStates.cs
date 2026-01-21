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
        FlameFloater(id + 0x10000u, 8.43f, 4);
        AlleyOopInferno(id + 0x10001u, 18.54f);
        CutbackBlaze(id + 0x10002u, 5.15f);
        Pyrotation(id + 0x10003u, 2.10f, 3);
        DiversDare(id + 0x10004u, 7.71f);
        SickSwell(id + 0x20000u, 14.64f);
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
        Cast(id, (uint)AID.SickSwell, delay, 3f, "Sick Swell");
    }

}

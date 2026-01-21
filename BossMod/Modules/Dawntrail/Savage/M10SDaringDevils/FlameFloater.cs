namespace BossMod.Modules.Dawntrail.Savage.M10SDaringDevils;

sealed class FlameFloater(BossModule module) : Components.GenericAOEs(module)
{
    //todo: Anything
    private AOEInstance[] _aoes = [];
    private readonly Actor badguy = module.PrimaryActor;
    private static readonly AOEShapeRect rect = new(60f, 4f);
    private class Target
    {
        public required Actor Actor;
        public required int Order;
    }
    private readonly List<Target> _targets = [];
    public override void OnStatusGain(Actor actor, ref ActorStatus status)
    {
        switch (status.ID)
        {
            case (uint)SID.FirstInLine:
                _targets.Add(new Target { Actor = actor, Order = 0 });
                break;
            case (uint)SID.SecondInLine:
                _targets.Add(new Target { Actor = actor, Order = 1 });
                break;
            case (uint)SID.ThirdInLine:
                _targets.Add(new Target { Actor = actor, Order = 2 });
                break;
            case (uint)SID.FourthInLine:
                _targets.Add(new Target { Actor = actor, Order = 3 });
                break;
        }
        if (_targets.Count == 4)
        {
            _targets.Sort((a, b) => a.Order.CompareTo(b.Order));
        }
    }

    public override ReadOnlySpan<AOEInstance> ActiveAOEs(int slot, Actor actor)
    {
        if (_targets.Count == 0)
        {
            return [];
        }
        var targets = CollectionsMarshal.AsSpan(_targets);
        var len = targets.Length;
        List<AOEInstance> aoes = [];
        for (var i = 0; i < len; i++)
        {
            WPos pos;
            if (i == 0)
            {
                pos = badguy.Position;
            }
            else
            {
                pos = targets[i - 1].Actor.Position;
            }
            aoes.Add(new(rect, pos, (targets[i].Actor.Position - pos).ToAngle()));
        }
        return CollectionsMarshal.AsSpan([.. aoes]);
    }
    public override void OnEventCast(Actor caster, ActorCastEvent spell)
    {
        if (spell.Action.ID is ((uint)AID.FlameFloaterDash1) or ((uint)AID.FlameFloaterDash2) or ((uint)AID.FlameFloaterDash3) or ((uint)AID.FlameFloaterDash4))
        {
            _targets.RemoveAt(0);
        }
    }
}

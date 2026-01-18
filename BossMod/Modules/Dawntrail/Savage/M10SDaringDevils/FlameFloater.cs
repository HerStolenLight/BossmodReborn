
using TerraFX.Interop.Windows;
using static BossMod.Components.GenericAOEs;

namespace BossMod.Modules.Dawntrail.Savage.M10SDaringDevils;

sealed class FlameFloater(BossModule module) : Components.GenericAOEs(module)
{
    //todo: Anything
    private AOEInstance[] _aoes = [];
    private Actor badguy = module.PrimaryActor;
    private static readonly AOEShapeRect rect = new(60f, 4f);
    private class Target
    {
        public Actor Actor;
        public int Order;
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
}

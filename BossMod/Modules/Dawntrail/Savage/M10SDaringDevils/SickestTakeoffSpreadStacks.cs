using FFXIVClientStructs.FFXIV.Client.Game.InstanceContent;

namespace BossMod.Modules.Dawntrail.Savage.M10SDaringDevils;
sealed class SickestTakeoffSpreadStacks(BossModule module) : Components.GenericStackSpread(module)
{
    private bool? lpStack;
    public override void AddGlobalHints(GlobalHints hints)
    {
        if (lpStack is bool stack)
        {
            hints.Add($"Stored: {(stack ? "Light Party stacks" : "Spreads")}");
        }
    }
    public override void OnStatusGain(Actor actor, ref ActorStatus status)
    {
        if (actor.OID == (uint)OID.DeepBlue)
        {
            var party = Raid.WithoutSlot(true, false, false);
            switch (status.Extra)
            {
                case 0x3ED:
                    foreach (var player in party)
                    {
                        if (player.Role == Role.Healer)
                        {
                            Stacks.Add(new(player, 5f, 2, 4, WorldState.FutureTime(15.7f)));
                        }
                    }
                    break;
                case 0x3EE:
                    foreach (var player in party)
                    {
                        Spreads.Add(new(player, 5f, WorldState.FutureTime(15.7f)));
                    }
                    break;
            }
        }
    }
    public override void OnEventCast(Actor caster, ActorCastEvent spell)
    {
        if (spell.Action.ID is (uint)AID.AwesomeSlab1 or (uint)AID.AwesomeSplash)
        {
            if (lpStack is bool stacks)
            {
                if (stacks)
                {
                    Stacks.Clear();
                }
                else
                {
                    Spreads.Clear();
                }
            }
        }
    }
}

namespace BossMod.Modules.Dawntrail.Savage.M10SDaringDevils;
sealed class CutbackBlazeCone(BossModule module) : BossComponent(module)
{
    private readonly Actor badguy = module.PrimaryActor;
    public override void DrawArenaForeground(int pcSlot, Actor pc)
    {
        // Draw cone from boss to farthest player
        // first, find farthest player from boss
        var sortedparty = Raid.WithoutSlot(false, true, true).SortedByRange(badguy.Position);
        var target = sortedparty.Last();
        Arena.AddCone(badguy.Position, 60f, (badguy.Position - target.Position).ToAngle(), new(157.5f));
    }
}

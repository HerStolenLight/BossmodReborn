namespace BossMod.Modules.Dawntrail.Savage.M10SDaringDevils;
sealed class FlameFloatVoidzones(BossModule module) : Components.Voidzone(module, 0f, GetFlameFloaters)
{
    private static readonly AOEShapeRect dashrect = new(60f, 4f);
    public override ReadOnlySpan<AOEInstance> ActiveAOEs(int slot, Actor actor)
    {
        var aoes = new List<AOEInstance>();
        foreach (var source in Sources(Module))
        {
            aoes.Add(new(dashrect, source.Position, source.Rotation));
        }
        return CollectionsMarshal.AsSpan(aoes);
    }

    public override void AddAIHints(int slot, Actor actor, PartyRolesConfig.Assignment assignment, AIHints hints)
    {
        if (!Sources(Module).Any())
            return;
        if (MovementHintLength == 0)
        {
            foreach (var s in Sources(Module))
            {
                hints.TemporaryObstacles.Add(new SDRect(s.Position, s.Rotation, 60f, 0f, 4f));
            }
        }
    }

    private static Actor[] GetFlameFloaters(BossModule module)
    {
        var enemies = module.Enemies((uint)OID.FlameFloaterRect);
        var count = enemies.Count;
        var index = 0;
        var floaters = new Actor[count];
        for (var i = 0; i < count; i++)
        {
            var z = enemies[i];
            if (z.EventState != 7)
            {
                floaters[index++] = z;
            }
        }
        return floaters;
    }
}

sealed class AlleyOopInfernoVoidzones(BossModule module) : Components.Voidzone(module, 5f, GetAlleyOopInfernos)
{
    private static Actor[] GetAlleyOopInfernos(BossModule module)
    {
        var enemies = module.Enemies((uint)OID.AlleyOopInfernoVoid);
        var count = enemies.Count;
        var index = 0;
        var voids = new Actor[count];
        for (var i = 0; i < count; i++)
        {
            var z = enemies[i];
            if (z.EventState != 7)
            {
                voids[index++] = z;
            }
        }
        return voids;
    }
}


sealed class CutbackBlazeVoidZones(BossModule module) : Components.Voidzone(module, 0f, GetBlazers)
{
    private static readonly AOEShapeCone _cone = new(60f, 157.5f.Degrees());
    public override ReadOnlySpan<AOEInstance> ActiveAOEs(int slot, Actor actor)
    {
        var aoes = new List<AOEInstance>();
        foreach (var source in Sources(Module))
        {
            aoes.Add(new(_cone, source.Position, source.Rotation));
        }
        return CollectionsMarshal.AsSpan(aoes);
    }

    public override void AddAIHints(int slot, Actor actor, PartyRolesConfig.Assignment assignment, AIHints hints)
    {
        if (!Sources(Module).Any())
            return;
        if (MovementHintLength == 0)
        {
            foreach (var s in Sources(Module))
            {
                hints.TemporaryObstacles.Add(new SDCone(s.Position, 60f, s.Rotation, 157.5f.Degrees()));
            }
        }
    }

    private static Actor[] GetBlazers(BossModule module)
    {
        var enemies = module.Enemies((uint)OID.CutbackBlazeVoid);
        var count = enemies.Count;
        var index = 0;
        var blazers = new Actor[count];
        for (var i = 0; i < count; i++)
        {
            var z = enemies[i];
            if (z.EventState != 7)
            {
                blazers[index++] = z;
            }
        }
        return blazers;
    }
}

sealed class PyrotationPuddles(BossModule module) : Components.Voidzone(module, 5f, GetPyros)
{
    private static Actor[] GetPyros(BossModule module)
    {
        var enemies = module.Enemies((uint)OID.PyrotationCircles);
        var count = enemies.Count;
        var index = 0;
        var pyros = new Actor[count];
        for (var i = 0; i < count; i++)
        {
            var z = enemies[i];
            if (z.EventState != 7)
            {
                pyros[index++] = z;
            }
        }
        return pyros;
    }
}

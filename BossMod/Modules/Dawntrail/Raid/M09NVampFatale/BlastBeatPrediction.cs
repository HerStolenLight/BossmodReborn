using FFXIVClientStructs.FFXIV.Client.Game.UI;

namespace BossMod.Modules.Dawntrail.Raid.M09NVampFatale;
sealed class BlastBeatPrediction(BossModule module) : Components.GenericAOEs(module)
{
    private AOEInstance[] _aoe = [];
    public override ReadOnlySpan<AOEInstance> ActiveAOEs(int slot, Actor actor) => _aoe;
    private static readonly AOEShapeCircle blastPredictionCircle = new(8.5f); // predictions aren't exact due to server ticks, so we give it an extra half yard on the warnings
    // two patterns, each has 2, 3, then 5 aoes in sequence. 
    private static readonly WPos[] horizCenters = [new(103f, 94f), new(99f, 106f), new(113f, 100f), new(93f, 89f), new(93f, 111f), new(100f, 80f), new(119f, 94f), new(112f, 116f), new(88f, 116f), new(81f, 94f)];
    private static readonly WPos[] vertCenters = [new(106f, 100f), new(94f, 100f), new(87f, 100f), new(106f, 89f), new(107f, 111f), new(80f, 101f), new(93f, 81f), new(116f, 88f), new(94f, 120f), new(116f, 111f)];
    private WPos[] centers = [];

    private static readonly WPos horizCheck = new(106f, 100f);
    private static readonly WPos vertCheck = new(100f, 106f);

    private bool foundpattern = false;

    private int bursts = 0;

    public override void OnActorRenderflagsChange(Actor actor, int renderflags)
    {
        if (actor.OID == (uint)OID.VampetteFatale)
        {
            if (!foundpattern)
            {
                if (actor.Position == horizCheck)
                {
                    foundpattern = true;
                    TimedAoEs(true);
                }
                else if (actor.Position == vertCheck)
                {
                    foundpattern = true;
                    TimedAoEs(false);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
    private void TimedAoEs(bool horizontal)
    {
        if (horizontal)
        {
            centers = horizCenters;
        }
        else
        {
            centers = vertCenters;
        }
        _aoe = [new(blastPredictionCircle, centers[0]), new(blastPredictionCircle, centers[1])];
    }
    public override void OnCastFinished(Actor caster, ActorCastInfo spell)
    {
        if (spell.Action.ID == (uint)AID.BlastBeat)
        {
            bursts++;
            if (bursts == 2)
            {
                _aoe = [new(blastPredictionCircle, centers[2]), new(blastPredictionCircle, centers[3]), new(blastPredictionCircle, centers[2]), new(blastPredictionCircle, centers[4])];
            }
            if (bursts == 5)
            {
                _aoe = [new(blastPredictionCircle, centers[5]), new(blastPredictionCircle, centers[6]), new(blastPredictionCircle, centers[7]), new(blastPredictionCircle, centers[8]), new(blastPredictionCircle, centers[9])];
            }
            if (bursts == 10)
            {
                _aoe = [];
                bursts = 0;
                centers = [];
            }
        }
    }
}

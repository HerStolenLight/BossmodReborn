namespace BossMod.Modules.Dawntrail.Savage.M10SDaringDevils;

public enum OID : uint
{
    SickSwell = 0x4B5A, // R1.000, x1
    RedHot = 0x4B57, // R4.000, x1 Boss
    DeepBlue = 0x4B58, // R4.000, x1 Boss
    XtremeAether = 0x4B59, // R1.500, x28
    Actor1ea1a1 = 0x1EA1A1, // R0.500-2.000, x1, EventObj type
    Exit = 0x1E850B, // R0.500, x1, EventObj type
    Actor4AE7 = 0x4AE7, // R1.000, x4
    TheXtremes = 0x4BDF, // R1.000, x2
    WateryGrave = 0x4AC0, // R1.000, x4
    WateryGrave1 = 0x4B5C, // R4.000, x0 (spawn during fight)
    Helper = 0x233C, // R0.500, x24, Helper type
    FlameFloaterRect = 0x1EBF30, // R0.500, x0 (spawn during fight), Flame Floater Rectangle voidzone
    AlleyOopInfernoVoid = 0x1EBF31, // R0.500, x0 (spawn during fight), EventObj type, Alleyoop Inferno round voidzone
    CutbackBlazeVoid = 0x1EBF33, // R0.500, x0 (spawn during fight), EventObj type
    PyrotationCircles = 0x1EBF32, // R0.500, x0 (spawn during fight), EventObj type, Pyrotation Voidzone
    Actor1ebfce = 0x1EBFCE, // R0.500, x0 (spawn during fight), EventObj type
}

public enum AID : uint
{
    AutoAttack = 48639, // RedHot->player, no cast, single-target
    HotImpact = 46518, // RedHot->players, 5.0s cast, range 6 circle
    Ability = 46456, // RedHot->location, no cast, single-target
    FlameFloaterVisual = 46522, // RedHot->self, 7.0s cast, single-target
    FlameFloaterDash1 = 46523, // RedHot->location, no cast, range 60 width 8 rect
    FlameFloaterDash2 = 46524, // RedHot->location, no cast, range 60 width 8 rect
    FlameFloaterDash3 = 46525, // RedHot->location, no cast, range 60 width 8 rect
    FlameFloaterDash4 = 46526, // RedHot->location, no cast, range 60 width 8 rect
    Ability1 = 46460, // RedHot->self, no cast, single-target
    AlleyOopInferno = 46528, // RedHot->self, 4.3+0.7s cast, single-target
    AlleyOopInfernoSpreads = 46529, // Helper->player, 5.0s cast, range 5 circle
    CutbackBlazeVisual = 46537, // RedHot->self, 4.3+0.7s cast, single-target
    CutbackBlazeCone = 46538, // Helper->self, no cast, range 60 ?-degree cone
    Pyrotation = 46530, // RedHot->self, 4.3+0.7s cast, single-target
    Pyrotation1 = 46531, // Helper->players, no cast, range 6 circle
    DiversDare = 46520, // RedHot->self, 5.0s cast, range 60 circle
    _AutoAttack_1 = 48640, // DeepBlue->player, no cast, single-target
    SickSwell = 46539, // DeepBlue->self, 3.0s cast, single-target
    SickestTakeOff = 46541, // DeepBlue->self, 4.0s cast, single-target
    SickestTakeOff1 = 46542, // Helper->self, 7.0s cast, range 50 width 15 rect
    SickSwell1 = 46540, // Helper->self, 7.0s cast, range 50 width 50 rect
    AwesomeSplash = 46543, // Helper->players, no cast, range 5 circle
    Rsv465601100SE2DC5B04EE2DC5B04 = 46560, // DeepBlue->self, 5.0s cast, single-target
    Rsv465611100SE2DC5B04EE2DC5B04 = 46561, // Helper->self, no cast, range 60 ?-degree cone
    Rsv465621100SE2DC5B04EE2DC5B04 = 46562, // Helper->self, no cast, range 60 ?-degree cone
    DeepImpact = 46519, // DeepBlue->self, 4.9s cast, single-target
    DeepImpact1 = 44486, // DeepBlue->players, no cast, range 6 circle
    DiversDare1 = 46521, // DeepBlue->self, 5.0s cast, range 60 circle
    Ability2 = 46457, // DeepBlue->location, no cast, single-target
    XtremeSpectacular = 46553, // RedHot->self, 4.0s cast, single-target
    XtremeSpectacular1 = 46554, // DeepBlue->self, 4.0s cast, single-target
    XtremeSpectacular2 = 46500, // TheXtremes->self, 7.4s cast, range 50 width 40 rect
    XtremeSpectacular3 = 46556, // TheXtremes->self, no cast, range 60 circle
    XtremeSpectacular4 = 47050, // TheXtremes->self, no cast, range 60 circle
    EpicBrotherhood = 46458, // RedHot->DeepBlue, no cast, single-target
    EpicBrotherhood1 = 46459, // DeepBlue->RedHot, no cast, single-target
    InsaneAir = 47255, // RedHot->self, 5.9+1.5s cast, single-target
    InsaneAir1 = 47256, // DeepBlue->self, 5.9+1.5s cast, single-target
    Rsv465791100SE2DC5B04EE2DC5B04 = 46579, // RedHot->self, no cast, single-target
    Rsv465841100SE2DC5B04EE2DC5B04 = 46584, // DeepBlue->self, no cast, single-target
    Rsv465861100SE2DC5B04EE2DC5B04 = 46586, // Helper->player, no cast, range 6 circle
    Rsv465811100SE2DC5B04EE2DC5B04 = 46581, // Helper->self, no cast, range 60 ?-degree cone
    InsaneAir2 = 47257, // RedHot->self, 3.9+1.5s cast, single-target
    InsaneAir3 = 47258, // DeepBlue->self, 3.9+1.5s cast, single-target
    Rsv465831100SE2DC5B04EE2DC5B04 = 46583, // RedHot->self, no cast, single-target
    Rsv465761100SE2DC5B04EE2DC5B04 = 46576, // DeepBlue->self, no cast, single-target
    Rsv465781100SE2DC5B04EE2DC5B04 = 46578, // Helper->self, no cast, range 60 ?-degree cone
    Rsv465851100SE2DC5B04EE2DC5B04 = 46585, // Helper->players, no cast, range 6 circle
    Rsv465751100SE2DC5B04EE2DC5B04 = 46575, // RedHot->self, no cast, single-target
    Rsv465801100SE2DC5B04EE2DC5B04 = 46580, // DeepBlue->self, no cast, single-target
    Rsv465771100SE2DC5B04EE2DC5B04 = 46577, // Helper->self, no cast, range 60 ?-degree cone
    Rsv465821100SE2DC5B04EE2DC5B04 = 46582, // Helper->self, no cast, range 60 ?-degree cone
    Ability3 = 46461, // DeepBlue->self, no cast, single-target
    Rsv459531100SE2DC5B04EE2DC5B04 = 45953, // RedHot->self, 5.0s cast, range 60 circle
    Rsv459541100SE2DC5B04EE2DC5B04 = 45954, // DeepBlue->self, 5.0s cast, range 60 circle
    HotImpact1 = 46464, // RedHot->player, 5.0s cast, range 6 circle
    Rsv472491100SE2DC5B04EE2DC5B04 = 47249, // DeepBlue->location, 5.3+1.0s cast, ???
    Rsv465471100SE2DC5B04EE2DC5B04 = 46547, // Helper->self, 6.8s cast, range 60 120.000-degree cone
    AwesomeSlab = 46552, // Helper->players, no cast, range 6 circle
    SteamBurst = 46587, // XtremeAether->self, 3.0s cast, range 9 circle
    HotAerial = 46532, // RedHot->self, 5.0s cast, single-target
    HotAerial1 = 47389, // RedHot->player, no cast, single-target
    HotAerial2 = 47390, // Helper->player, no cast, range 6 circle
    HotAerial3 = 47391, // Helper->player, no cast, range 6 circle
    HotAerial4 = 47392, // Helper->player, no cast, range 6 circle
    HotAerial5 = 47393, // Helper->players, no cast, range 6 circle
    AwesomeSlab1 = 46544, // Helper->players, no cast, range 6 circle
    DeepAerial = 46563, // DeepBlue->location, 5.0s cast, single-target
    DeepAerial1 = 46564, // Helper->self, 6.0s cast, range 6 circle
    Weaponskill = 46570, // WateryGrave->player, no cast, single-target
    XtremeWave = 46533, // RedHot->self, 4.9s cast, single-target
    XtremeWave1 = 46534, // DeepBlue->self, 4.9s cast, single-target
    XtremeWave2 = 46545, // RedHot->location, no cast, range 60 width 8 rect
    XtremeWave3 = 46546, // DeepBlue->location, no cast, range 60 width 8 rect
    ScathingSteam = 44487, // WateryGrave1->self, 1.0s cast, range 60 circle
    XtremeWave4 = 46536, // DeepBlue->self, 4.9s cast, single-target
    XtremeWave5 = 46535, // RedHot->self, 4.9s cast, single-target
    FlameFloater5 = 46548, // RedHot->self, 5.0s cast, single-target
    FlameFloater6 = 46527, // RedHot->location, no cast, range 60 width 8 rect
    FreakyPyrotation = 46486, // RedHot->self, 4.3+0.7s cast, single-target
    FreakyPyrotation1 = 46487, // Helper->players, no cast, range 6 circle
    Rsv465101100SE2DC5B04EE2DC5B04 = 46510, // RedHot->self, 5.0s cast, range 60 circle
    Rsv465111100SE2DC5B04EE2DC5B04 = 46511, // DeepBlue->self, 5.0s cast, range 60 circle
    Rsv465571100SE2DC5B04EE2DC5B04 = 46557, // DeepBlue->self, 5.0s cast, single-target
    Rsv465581100SE2DC5B04EE2DC5B04 = 46558, // Helper->self, no cast, range 60 ?-degree cone
    Rsv465591100SE2DC5B04EE2DC5B04 = 46559, // Helper->self, no cast, range 60 ?-degree cone
    InsaneAir4 = 46567, // DeepBlue->self, 6.9+1.5s cast, single-target
    InsaneAir5 = 46566, // RedHot->self, 6.9+1.5s cast, single-target
    Rsv465121100SE2DC5B04EE2DC5B04 = 46512, // Helper->players, 1.0s cast, range 15 circle
    Rsv465131100SE2DC5B04EE2DC5B04 = 46513, // Helper->players, 1.0s cast, range 15 circle
    InsaneAir6 = 46569, // DeepBlue->self, 6.9+1.5s cast, single-target
    InsaneAir7 = 46568, // RedHot->self, 6.9+1.5s cast, single-target
    AwesomeSplash1 = 46551, // Helper->player, no cast, range 5 circle
    UnmitigatedExplosion = 46565, // Helper->self, no cast, range 60 circle
    ImpactZone = 46572, // WateryGrave1->self, no cast, range 60 circle
    ImpactZone1 = 46571, // WateryGrave->self, no cast, range 60 circle
}

public enum SID : uint
{
    DirectionalDisregard = 3808, // none->RedHot/DeepBlue, extra=0x0
    FirstInLine = 3004, // none->player, extra=0x0 Flame Floater Hit 1
    SecondInLine = 3005, // none->player, extra=0x0 Flame Floater Hit 2
    ThirdInLine = 3006, // none->player, extra=0x0 Flame Floater Hit 3
    FourthInLine = 3451, // none->player, extra=0x0 Flame Floater Hit 4
    FireResistanceDownII = 2937, // RedHot/Helper->player, extra=0x0
    MagicVulnerabilityUp = 2941, // Helper/RedHot/DeepBlue->player, extra=0x0
    Unknown = 2056, // none->DeepBlue, extra=0x3EE/0x435/0x3EF/0x3ED/0x3F0
    Watersnaking = 4975, // none->player, extra=0x0
    Firesnaking = 4974, // none->player, extra=0x0
    Stun = 2656, // none->player, extra=0x0
    Rsv48291100S74CFC3B0E74CFC3B0 = 4829, // none->player, extra=0x12C
    DamageDown = 2911, // XtremeAether/Helper->player, extra=0x0
    Burns = 3065, // none->player, extra=0x0
    Burns1 = 3066, // none->player, extra=0x0
    Rsv48281100S74CFC3B0E74CFC3B0 = 4828, // none->player, extra=0x0
    Rsv48271100S74CFC3B0E74CFC3B0 = 4827, // none->player, extra=0x0
    SustainedDamage = 4149, // Helper/WateryGrave1/WateryGrave->player, extra=0x1/0x3
    BrotherlyLove = 4972, // none->RedHot/DeepBlue, extra=0x0
    VulnerabilityDown = 929, // none->WateryGrave1, extra=0x0

}

public enum IconID : uint
{
    _Gen_Icon_m0676trg_tw_d0t1p = 259, // player->self
    _Gen_Icon_target_ae_5m_s5_fire0c = 660, // player->self
    _Gen_Icon_m0982trg_g0c = 666, // player->self
    _Gen_Icon_m0982trg_c1c = 636, // player->self
    _Gen_Icon_m0982trg_c0c = 635, // player->self
    PyrotationStack = 659, // player->self
}


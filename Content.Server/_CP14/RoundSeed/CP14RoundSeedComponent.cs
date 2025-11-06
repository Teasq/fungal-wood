/*
 * All right reserved to CrystallPunk.
 *
 * This file is licensed under the MIT License
 * from commit c69cb0320ee66bbeed0ba72fd66654bad6b0a863
 */

namespace Content.Server._CP14.RoundSeed;

/// <summary>
/// This is used for round seed
/// </summary>
[RegisterComponent, Access(typeof(CP14RoundSeedSystem))]
public sealed partial class CP14RoundSeedComponent : Component
{
    [ViewVariables]
    public static int MaxValue = 10000;

    [ViewVariables]
    public int Seed;
}

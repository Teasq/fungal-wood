/*
 * All right reserved to CrystallPunk.
 *
 * This file is licensed under the MIT License
 * from commit c69cb0320ee66bbeed0ba72fd66654bad6b0a863
 */

using Content.Server._CP14.BiomeSpawner.EntitySystems;
using Content.Shared.Parallax.Biomes;
using Robust.Shared.Prototypes;

namespace Content.Server._CP14.BiomeSpawner.Components;

/// <summary>
/// fills the tile in which it is located with the contents of the biome. Includes: tile, decals and entities
/// </summary>
[RegisterComponent, Access(typeof(CP14BiomeSpawnerSystem))]
public sealed partial class CP14BiomeSpawnerComponent : Component
{
    [DataField]
    public ProtoId<BiomeTemplatePrototype> Biome = "Grasslands";
}

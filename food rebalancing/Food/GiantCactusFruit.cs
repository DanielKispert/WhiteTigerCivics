﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;

    [Serialized]
    [LocDisplayName("Giant Cactus Fruit")]
    [Weight(10)]
    [Yield(typeof(GiantCactusFruitItem), typeof(GatheringSkill), new float[] {1f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.9f, 2.0f})]
    [Crop]
    [Tag("Crop", 1)]
    [Tag("Harvestable", 1)]
    [Tag("Fruit", 1)]
    [Tag("Raw Food", 1)]
    [Ecopedia("Food", "Produce", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class GiantCactusFruitItem : FoodItem
    {
        public override LocString DisplayDescription    => Localizer.DoStr("A bulbous fruit that used to top Saguaro cacti.");
        
        public override float Calories                  => 50;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 2, Fat = 2, Protein = 0, Vitamins = 4};
    }

}

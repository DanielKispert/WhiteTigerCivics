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
    [LocDisplayName("Prickly Pear Fruit")]
    [Weight(10)]
    [Yield(typeof(PricklyPearFruitItem), typeof(GatheringSkill), new float[] {1f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.9f, 2.0f})]
    [Crop]
    [Tag("Crop", 1)]
    [Tag("Harvestable", 1)]
    [Tag("Fruit", 1)]
    [Tag("Raw Food", 1)]
    [Ecopedia("Food", "Produce", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class PricklyPearFruitItem : FoodItem
    {
        public override LocString DisplayDescription    => Localizer.DoStr("A succulent fruit coated in a rather terrifying array of spines.");
        
        public override float Calories                  => 95;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 2, Fat = 1, Protein = 1, Vitamins = 4};
    }

}

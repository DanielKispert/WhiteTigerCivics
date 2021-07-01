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
    [LocDisplayName("Raw Meat")]
    [Weight(100)]
    [Ecopedia("Food", "Meat", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class RawMeatItem : FoodItem
    {
        public override LocString DisplayNamePlural     => Localizer.DoStr("Raw Meat");
        public override LocString DisplayDescription    => Localizer.DoStr("Fresh raw meat from the hunt. It should probably be cooked before being consumed.");
        
        public override float Calories                  => 125;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 0, Fat = 8, Protein = 4, Vitamins = 0};
    }

}

﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;

    [Serialized]
    [LocDisplayName("Raw Bacon")]
    [Weight(50)]
    [Ecopedia("Food", "Meat", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class RawBaconItem : FoodItem
    {
        public override LocString DisplayNamePlural     => Localizer.DoStr("Raw Bacon");
        public override LocString DisplayDescription    => Localizer.DoStr("A fatty cut of meat that happens to be inexplicably tastier than other cuts.");
        
        public override float Calories                  => 200;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 0, Fat = 9, Protein = 3, Vitamins = 0};
    }

    [RequiresSkill(typeof(ButcherySkill), 2)]
    public partial class RawBaconRecipe :
        RecipeFamily
    {
        public RawBaconRecipe()
        {
            var product = new Recipe(
                "RawBacon",
                Localizer.DoStr("Raw Bacon"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(RawMeatItem), 6, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),   
                },
                new CraftingElement<RawBaconItem>(1),
                new CraftingElement<ScrapMeatItem>(4f)  
                );

            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(ButcherySkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(RawBaconRecipe), 0.8f, typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Raw Bacon"), typeof(RawBaconRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(ButcheryTableObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}

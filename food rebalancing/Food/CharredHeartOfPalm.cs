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
    [LocDisplayName("Charred Heart Of Palm")]
    [Weight(100)]
    [Tag("CharredVegetable", 1)]
    [Ecopedia("Food", "Charred Food", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class CharredHeartOfPalmItem : FoodItem
    {
        public override LocString DisplayNamePlural     => Localizer.DoStr("Charred Hearts Of Palm");
        public override LocString DisplayDescription    => Localizer.DoStr("Heart of palm collected fom fallen pineapple trees that have been charred over a campfire.");
        
        public override float Calories                  => 210;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 6, Fat = 1, Protein = 3, Vitamins = 2};
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 0)]
    public partial class CharredHeartOfPalmRecipe :
        RecipeFamily
    {
        public CharredHeartOfPalmRecipe()
        {
            var product = new Recipe(
                "CharredHeartOfPalm",
                Localizer.DoStr("Charred Heart Of Palm"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(HeartOfPalmItem), 2, true),  
                },
                new CraftingElement<CharredHeartOfPalmItem>(1)
                );

            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(CampfireCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(CharredHeartOfPalmRecipe), 0.5f, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Charred Heart Of Palm"), typeof(CharredHeartOfPalmRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}

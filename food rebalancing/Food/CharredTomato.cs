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
    [LocDisplayName("Charred Tomato")]
    [Weight(100)]
    [Tag("CharredVegetable", 1)]
    [Ecopedia("Food", "Charred Food", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class CharredTomatoItem : FoodItem
    {
        public override LocString DisplayDescription    => Localizer.DoStr("The blackened char on this tomato would contrast well with the red skin if there was any unburt surface left.");
        
        public override float Calories                  => 350;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 7, Fat = 0, Protein = 1, Vitamins = 4};
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 0)]
    public partial class CharredTomatoRecipe :
        RecipeFamily
    {
        public CharredTomatoRecipe()
        {
            var product = new Recipe(
                "CharredTomato",
                Localizer.DoStr("Charred Tomato"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(TomatoItem), 2, true),  
                },
                new CraftingElement<CharredTomatoItem>(1)
                );

            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(CampfireCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(CharredTomatoRecipe), 0.5f, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Charred Tomato"), typeof(CharredTomatoRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}

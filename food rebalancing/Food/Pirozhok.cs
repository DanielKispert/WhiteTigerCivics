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
    [LocDisplayName("Pirozhok")]
    [Weight(400)]
    [Ecopedia("Food", "Baking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class PirozhokItem : FoodItem
    {
        public override LocString DisplayNamePlural     => Localizer.DoStr("Pirozhki");
        public override LocString DisplayDescription    => Localizer.DoStr("A baked bun filled with tasty meat and mushrooms.");
        
        public override float Calories                  => 850;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 14, Fat = 10, Protein = 19, Vitamins = 4};
    }

    [RequiresSkill(typeof(AdvancedBakingSkill), 1)]
    public partial class PirozhokRecipe :
        RecipeFamily
    {
        public PirozhokRecipe()
        {
            var product = new Recipe(
                "Pirozhok",
                Localizer.DoStr("Pirozhok"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(PastryDoughItem), 1, typeof(AdvancedBakingSkill), typeof(AdvancedBakingLavishResourcesTalent)), 
                    new IngredientElement(typeof(PreparedMeatItem), 2, typeof(AdvancedBakingSkill), typeof(AdvancedBakingLavishResourcesTalent)),   
                    new IngredientElement("Fungus", 4, typeof(AdvancedBakingSkill), typeof(AdvancedBakingLavishResourcesTalent)),   
                },
                new CraftingElement<PirozhokItem>(1)
                );

            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(AdvancedBakingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(PirozhokRecipe), 3, typeof(AdvancedBakingSkill), typeof(AdvancedBakingFocusedSpeedTalent), typeof(AdvancedBakingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Pirozhok"), typeof(PirozhokRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}

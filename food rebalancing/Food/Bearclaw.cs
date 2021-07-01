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
    [LocDisplayName("Bearclaw")]
    [Weight(300)]
    [Ecopedia("Food", "Baking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class BearclawItem : FoodItem
    {
        public override LocString DisplayDescription    => Localizer.DoStr("A sweet pastry with seperated sections that look a bit like a claw.");
        
        public override float Calories                  => 850;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 12, Fat = 21, Protein = 6, Vitamins = 7};
    }

    [RequiresSkill(typeof(AdvancedBakingSkill), 1)]
    public partial class BearclawRecipe :
        RecipeFamily
    {
        public BearclawRecipe()
        {
            var product = new Recipe(
                "Bearclaw",
                Localizer.DoStr("Bearclaw"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(PastryDoughItem), 1, typeof(AdvancedBakingSkill), typeof(AdvancedBakingLavishResourcesTalent)), 
                    new IngredientElement(typeof(SugarItem), 4, typeof(AdvancedBakingSkill), typeof(AdvancedBakingLavishResourcesTalent)),   
                },
                new CraftingElement<BearclawItem>(1)
                );

            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(AdvancedBakingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(BearclawRecipe), 3, typeof(AdvancedBakingSkill), typeof(AdvancedBakingFocusedSpeedTalent), typeof(AdvancedBakingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Bearclaw"), typeof(BearclawRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}

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
    [LocDisplayName("Meat Pie")]
    [Weight(600)]
    [Ecopedia("Food", "Baking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class MeatPieItem : FoodItem
    {
        public override LocString DisplayDescription    => Localizer.DoStr("Much like a huckleberry pie, but filled to the brim with succulent meat.");
        
        public override float Calories                  => 1300;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 11, Fat = 15, Protein = 13, Vitamins = 5};
    }

    [RequiresSkill(typeof(BakingSkill), 3)]
    public partial class MeatPieRecipe :
        RecipeFamily
    {
        public MeatPieRecipe()
        {
            var product = new Recipe(
                "MeatPie",
                Localizer.DoStr("Meat Pie"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(FlourItem), 4, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)), 
                    new IngredientElement(typeof(ScrapMeatItem), 12, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),   
                    new IngredientElement("Fat", 2, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),   
                },
                new CraftingElement<MeatPieItem>(1)
                );

            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(BakingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(MeatPieRecipe), 2, typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Meat Pie"), typeof(MeatPieRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}

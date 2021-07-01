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
    [LocDisplayName("Camas Bread")]
    [Weight(500)]
    [Tag("Bread", 1)]
    [Ecopedia("Food", "Baking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class CamasBreadItem : FoodItem
    {
        public override LocString DisplayNamePlural     => Localizer.DoStr("Camas Bread");
        public override LocString DisplayDescription    => Localizer.DoStr("A bread with a camas twist for a bit of flavor and fun. ");
        
        public override float Calories                  => 800;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 15, Fat = 13, Protein = 5, Vitamins = 9};
    }

    [RequiresSkill(typeof(AdvancedBakingSkill), 1)]
    public partial class CamasBreadRecipe :
        RecipeFamily
    {
        public CamasBreadRecipe()
        {
            var product = new Recipe(
                "CamasBread",
                Localizer.DoStr("Camas Bread"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(CamasPasteItem), 1, typeof(AdvancedBakingSkill), typeof(AdvancedBakingLavishResourcesTalent)), 
                    new IngredientElement(typeof(LeavenedDoughItem), 1, typeof(AdvancedBakingSkill), typeof(AdvancedBakingLavishResourcesTalent)),   
                },
                new CraftingElement<CamasBreadItem>(1)
                );

            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(AdvancedBakingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(CamasBreadRecipe), 3, typeof(AdvancedBakingSkill), typeof(AdvancedBakingFocusedSpeedTalent), typeof(AdvancedBakingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Camas Bread"), typeof(CamasBreadRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}

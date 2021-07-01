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
    [LocDisplayName("Charred Taro")]
    [Weight(100)]
    [Tag("CharredVegetable", 1)]
    [Ecopedia("Food", "Charred Food", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class CharredTaroItem : FoodItem
    {
        public override LocString DisplayNamePlural     => Localizer.DoStr("Charred Taro");
        public override LocString DisplayDescription    => Localizer.DoStr("Blackened taro root. Not the tastiest meal, but a great source of energy for early rainforest settlers.");
        
        public override float Calories                  => 350;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 10, Fat = 0, Protein = 1, Vitamins = 1};
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 0)]
    public partial class CharredTaroRecipe :
        RecipeFamily
    {
        public CharredTaroRecipe()
        {
            var product = new Recipe(
                "CharredTaro",
                Localizer.DoStr("Charred Taro"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(TaroRootItem), 2, true),  
                },
                new CraftingElement<CharredTaroItem>(1)
                );

            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(CampfireCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(CharredTaroRecipe), 0.5f, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Charred Taro"), typeof(CharredTaroRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}

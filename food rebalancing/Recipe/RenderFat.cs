﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
    [RequiresSkill(typeof(CampfireCookingSkill), 1)] 
    public partial class RenderFatRecipe :
        RecipeFamily
    {
        public RenderFatRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "RenderFat",
                    Localizer.DoStr("Render Fat"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(RawMeatItem), 6, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<TallowItem>(2),  
    
                    })
            };
            this.ExperienceOnCraft = 0.5f;  
            this.LaborInCalories = CreateLaborInCaloriesValue(60, typeof(CampfireCookingSkill)); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(RenderFatRecipe), 0.8f, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));     
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Render Fat"), typeof(RenderFatRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}

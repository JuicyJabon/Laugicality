using Terraria;
using Terraria.ModLoader;

namespace Laugicality.Items.Accessories
{
    public class InfernoGem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Ignites nearby enemies");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 28;
            item.value = 100;
            item.rare = 2;
            item.accessory = true;
            //item.defense = 1000;
            //item.lifeRegen = 19;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(116, 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2348, 4);
            recipe.AddTile(null, "AlchemicalInfuser");
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe Hrecipe = new ModRecipe(mod);
            Hrecipe.AddIngredient(null, "ObsidiumBar", 8);
            Hrecipe.AddTile(77);
            Hrecipe.SetResult(2422);
            Hrecipe.AddRecipe();
        }
    }
}
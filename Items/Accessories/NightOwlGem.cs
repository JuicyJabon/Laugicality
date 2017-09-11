using Terraria;
using Terraria.ModLoader;

namespace Laugicality.Items.Accessories
{
    public class NightOwlGem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases Night Vision");
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
            player.nightVision = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(299, 4);
            recipe.AddTile(null, "AlchemicalInfuser");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExampleMod.Items.Weapons
{
	public class ExampleLaserWeapon : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Example Laser Weapon");
			Tooltip.SetDefault("Shoot a laser beam that can eliminate everything...");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.noMelee = true;
			item.magic = true;
			item.channel = true;                            //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 5;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;				//Speed is not important here
			item.useAnimation = 20;                         
			item.shoot = mod.ProjectileType("ExampleLaser");
			item.value = Item.sellPrice(0, 3, 0, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ExampleItem", 10);
			recipe.AddTile(mod, "ExampleWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

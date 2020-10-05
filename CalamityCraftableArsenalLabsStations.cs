using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityCraftableArsenalLabsStations
{
	public class CalamityCraftableArsenalLabsStations : Mod
	{
		public override void AddRecipes()
		{
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			
			ModRecipe recipeChargingStationItem = new ModRecipe(this);
			if (calamityMod != null) {
				recipeChargingStationItem.AddTile(TileID.Anvils);
				recipeChargingStationItem.AddIngredient(calamityMod.ItemType("DubiousPlating"), 10);
				recipeChargingStationItem.AddIngredient(calamityMod.ItemType("MysteriousCircuitry"), 10);
				recipeChargingStationItem.SetResult(calamityMod.ItemType("ChargingStationItem"), 1);
				recipeChargingStationItem.AddRecipe();
			}
			
			ModRecipe recipePowerCellFactoryItem = new ModRecipe(this);
			if (calamityMod != null) {
				recipePowerCellFactoryItem.AddTile(TileID.Anvils);
				recipePowerCellFactoryItem.AddIngredient(calamityMod.ItemType("DubiousPlating"), 10);
				recipePowerCellFactoryItem.AddIngredient(calamityMod.ItemType("MysteriousCircuitry"), 10);
				recipePowerCellFactoryItem.SetResult(calamityMod.ItemType("PowerCellFactoryItem"), 1);
				recipePowerCellFactoryItem.AddRecipe();
			}
			
			ModRecipe recipeDubiousPlating = new ModRecipe(this);
			if (calamityMod != null) {
				recipeDubiousPlating.AddTile(TileID.Anvils);
				recipeDubiousPlating.AddIngredient(ItemID.Glass, 10);
				recipeDubiousPlating.AddRecipeGroup("IronBar", 10);
				recipeDubiousPlating.SetResult(calamityMod.ItemType("DubiousPlating"), 1);
				recipeDubiousPlating.AddRecipe();
			}
			
			ModRecipe recipeMysteriousCircuitry = new ModRecipe(this);
			if (calamityMod != null) {
				recipeMysteriousCircuitry.AddTile(TileID.Anvils);
				recipeMysteriousCircuitry.AddIngredient(ItemID.Glass, 10);
				recipeMysteriousCircuitry.AddRecipeGroup("IronBar", 10);
				recipeMysteriousCircuitry.SetResult(calamityMod.ItemType("MysteriousCircuitry"), 1);
				recipeMysteriousCircuitry.AddRecipe();
			}
		}
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Potions
{
	public class HealthPotion: ItemBase
	{
		public HealthPotion()
		{
			Name = "A health potion";
			Description = "Red fizzy liquid!";
			Weight = 1;
			Type = ItemType.Potion;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Armor
{
	public class WoodenShield : ItemBase
	{
		public WoodenShield()
		{
			Name = "A wooden shield";
			Description = "More apt to give a splinter than protect you.";
			Weight = 2;
			Type = ItemType.Armor;
		}
	}
}

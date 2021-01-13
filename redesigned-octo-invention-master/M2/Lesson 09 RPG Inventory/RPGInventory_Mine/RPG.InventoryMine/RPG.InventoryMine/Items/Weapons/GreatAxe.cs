using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Weapons
{
	public class GreatAxe : ItemBase
	{
		public GreatAxe()
		{
			Name = "Great Axe";
			Description = "An axe, it's great!";
			Weight = 5;
			Type = ItemType.Weapon;
		}
	}
}

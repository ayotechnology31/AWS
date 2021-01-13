using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Weapons
{
	public class Sword : ItemBase
	{
		public Sword()
		{
			Name = "A wooden sword";
			Description = "It's dangerous to go alone, take this.";
			Weight = 3;
			Type = ItemType.Weapon;
		}
	}
}

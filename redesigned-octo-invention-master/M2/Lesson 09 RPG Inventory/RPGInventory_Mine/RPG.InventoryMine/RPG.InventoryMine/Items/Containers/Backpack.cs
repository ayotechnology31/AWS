using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Containers
{
	public class Backpack : ContainerBase
	{
		public Backpack() : base(4)
		{
			Name = "A leather backpack.";
			Description = "A rugged leather backpack.";
			Weight = 1;
			Type = ItemType.Container;
		}
	}
}

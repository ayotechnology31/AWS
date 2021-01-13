using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items
{
	public abstract class ItemBase
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int Weight { get; set; }
		//public string Type { get; set; }
		public ItemType Type { get; set; }
	}
}

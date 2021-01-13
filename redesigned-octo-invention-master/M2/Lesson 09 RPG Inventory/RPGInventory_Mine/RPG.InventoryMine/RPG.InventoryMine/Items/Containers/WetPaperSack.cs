using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Containers
{
	public class WetPaperSack : WeightRestrictedContainer
	{
		public WetPaperSack() : base(8, 3)
		{
			Name = "Wet Paper Sack";
			Description = "Damp and flimsy";
			Type = ItemType.Container;
			Weight = 1;
		}
	}
}

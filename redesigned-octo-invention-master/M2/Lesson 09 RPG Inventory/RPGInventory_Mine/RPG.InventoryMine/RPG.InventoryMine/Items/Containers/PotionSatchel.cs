using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Containers
{
	public class PotionSatchel : SpecificContainer
	{
		public PotionSatchel(): base(4, ItemType.Potion)
		{

		}

		//public override bool AddItem(ItemBase itemToAdd)
		//{
		//	if(itemToAdd.Type == "Potion")
		//	{
		//		return base.AddItem(itemToAdd);
		//	}
		//	return false;
		//}
	}
}

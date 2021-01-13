using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Containers
{
	public enum AddItemStatus
	{

		Success,
		BagIsFull, 
		ItemTooHeavy,
		ItemNotRightType
	}
}

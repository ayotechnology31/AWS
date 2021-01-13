using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Containers
{
	public class SpecificContainer : ContainerBase
	{
		private ItemType _requiredType;
		public SpecificContainer(int capacity, ItemType requiredType) : base(capacity)
		{
			_requiredType = requiredType;
		}

		public override AddItemStatus AddItem(ItemBase itemToAdd)
		{
			if(itemToAdd.Type == _requiredType)
			{
				return base.AddItem(itemToAdd);
			}
			return AddItemStatus.ItemNotRightType;
		}
	}
}

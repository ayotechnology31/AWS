using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Containers
{
	public class WeightRestrictedContainer : ContainerBase
	{
		public int _maxWeight;
		private int _currentWeight;
		public WeightRestrictedContainer(int capacity, int maxWeight) : base(capacity)
		{
			_maxWeight = maxWeight;
		}

		public override AddItemStatus AddItem(ItemBase itemToAdd)
		{
			if(_currentWeight + itemToAdd.Weight > _maxWeight)
			{
				return AddItemStatus.ItemTooHeavy;
			}
			AddItemStatus status = base.AddItem(itemToAdd);
			if (status == AddItemStatus.Success)
			{
				_currentWeight += itemToAdd.Weight;
			}

			return status;
		}

		public override ItemBase RemoveItem()
		{
			ItemBase removedItem = base.RemoveItem();
			if(removedItem != null)
			{
				_currentWeight -= removedItem.Weight;
			}
			return removedItem;
		}
	}
}

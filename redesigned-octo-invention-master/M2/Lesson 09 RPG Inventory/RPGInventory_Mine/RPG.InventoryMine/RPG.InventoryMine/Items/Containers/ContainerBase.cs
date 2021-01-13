using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.InventoryMine.Items.Containers
{
	public abstract class ContainerBase : ItemBase
	{
		// capacity - available to container and it's children
		protected int _capacity;
		protected ItemBase[] _items;
		protected int _currentIndex;

		public ContainerBase(int capacity)
		{
			_capacity = capacity;
			_items = new ItemBase[capacity];
			_currentIndex = 0;
		}

		public virtual AddItemStatus AddItem(ItemBase itemToAdd)
		{
			if(_capacity == _currentIndex)
			{
				return AddItemStatus.BagIsFull;
			}
			else
			{
				_items[_currentIndex] = itemToAdd;
				_currentIndex++;
				return AddItemStatus.Success;
			}
		}

		public virtual ItemBase RemoveItem()
		{
			if (_currentIndex == 0)
			{
				return null;
			}
			else
			{
				_currentIndex--;
				ItemBase itemToReturn = _items[_currentIndex];
				_items[_currentIndex] = null;
				return itemToReturn;
			}
		}
	}
}

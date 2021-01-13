using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using RPG.InventoryMine.Items;
using RPG.InventoryMine.Items.Containers;
using RPG.InventoryMine.Items.Potions;
using RPG.InventoryMine.Items.Weapons;

namespace RPG.InventoryTests
{
	[TestFixture]
	public class ContainerTests
	{
		[Test]
		public void CanAddItemToBackpack()
		{
			Backpack b = new Backpack();
			HealthPotion p = new HealthPotion();

			AddItemStatus actual = b.AddItem(p);
			Assert.AreEqual(AddItemStatus.Success, actual);
		}

		[Test]
		public void CannotAddItemToFullBackpack()
		{
			Backpack b = new Backpack();
			GreatAxe axe = new GreatAxe();

			b.AddItem(axe);
			b.AddItem(axe);
			b.AddItem(axe);
			b.AddItem(axe);

			AddItemStatus actual = b.AddItem(axe);
			Assert.AreEqual(AddItemStatus.BagIsFull, actual);
		}

		[Test]
		public void CanRemoveItemFromBackpack()
		{
			Backpack b = new Backpack();
			HealthPotion p = new HealthPotion();

			b.AddItem(p);

			ItemBase actual = b.RemoveItem();

			Assert.AreEqual(p, actual);
		}

		[Test]
		public void EmptyBagReturnsNull()
		{
			Backpack b = new Backpack();
			ItemBase item = b.RemoveItem();

			Assert.IsNull(item);
		}

		[Test]
		public void PotionSatchelOnlyAllowsPotion()
		{
			PotionSatchel satchel = new PotionSatchel();
			GreatAxe axe = new GreatAxe();

			AddItemStatus result = satchel.AddItem(axe);
			Assert.AreEqual(AddItemStatus.ItemNotRightType, result);

			HealthPotion potion = new HealthPotion();
			result = satchel.AddItem(potion);
			Assert.AreEqual(AddItemStatus.Success, result);
		}

		[Test]
		public void WeightRestrictedBagRestrictsWeight()
		{
			WetPaperSack sack = new WetPaperSack();
			HealthPotion potion = new HealthPotion();

			Assert.AreEqual(AddItemStatus.Success, sack.AddItem(potion));

			Sword sword = new Sword();
			Assert.AreEqual(AddItemStatus.ItemTooHeavy, sack.AddItem(sword));

			ItemBase item = sack.RemoveItem();
			Assert.AreEqual(AddItemStatus.ItemTooHeavy, sack.AddItem(sword));
		}
	}
}

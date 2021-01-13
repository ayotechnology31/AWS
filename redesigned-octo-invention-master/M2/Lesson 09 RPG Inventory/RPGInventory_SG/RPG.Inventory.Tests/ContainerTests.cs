using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RPG.Inventory.Items.Containers;
using RPG.Inventory.Items.Potions;
using RPG.Inventory.Items;
using RPG.Inventory.Items.Weapons;

namespace RPG.Inventory.Tests
{
    [TestFixture]
    public class ContainerTests
    {
        [Test]
        public void CanAddItemToBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            bool actual = b.AddItem(p);
            Assert.AreEqual(true, actual);
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

            bool actual = b.AddItem(axe);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void CanRemoveItemFromBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            b.AddItem(p);

            Item actual = b.RemoveItem();

            // do these two variables reference the same object
            Assert.AreEqual(p, actual);
        }

        [Test]
        public void EmptyBagReturnsNull()
        {
            Backpack b = new Backpack();
            Item item = b.RemoveItem();

            Assert.IsNull(item);
        }

        [Test]
        public void PotionSatchelOnlyAllowsPotions()
        {
            PotionSatchel satchel = new PotionSatchel();
            GreatAxe axe = new GreatAxe();

            bool result = satchel.AddItem(axe);
            Assert.AreEqual(false, result);

            HealthPotion potion = new HealthPotion();
            result = satchel.AddItem(potion);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void WeightRestrictedBagRestrictsWeight()
        {
            WetPaperSack sack = new WetPaperSack();
            HealthPotion potion = new HealthPotion();

            Assert.AreEqual(true, sack.AddItem(potion));

            Sword sword = new Sword();
            Assert.AreEqual(false, sack.AddItem(sword));

            Item item = sack.RemoveItem();
            Assert.AreEqual(true, sack.AddItem(sword));
        }
    }
}

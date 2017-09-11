using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Inventory
    {

        int XPLevelUnlock;
        int slots;
        List<Item> items;
        
        public Inventory(int slots)
        {
            items = new List<Item>(slots);
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Remove(Item item)
        {
            items.Remove(item);
        }

        public bool CheckInventoryFull(int XPLevelUnlock, int maxSlots)
        {
            switch (XPLevelUnlock)
            {
                case (XPLevelUnlock < 5):
                    maxSlots = 15;
                    break;
                case (XPLevelUnlock >= 5 && XPLevelUnlock < 10):
                    maxSlots = 30;
                    break;
                case (XPLevelUnlock >= 10 && XPLevelUnlock < 15):
                    maxSlots = 40;
                    break;
                case (XPLevelUnlock >= 15 && XPLevelUnlock < 20):
                    maxSlots = 75;
                    break;
                case (XPLevelUnlock >= 20 && XPLevelUnlock < 30):
                    maxSlots = 100;
                    break;

            }

            bool inventoryFull = false;
            if(maxSlots == slots)
            {
                inventoryFull = true;
                return inventoryFull;
            }
            else
            {
                return inventoryFull;
            }
        }

        public abstract class ObtainableItem
        {
            public string Name { get; set; }
            public int MaxStackQtt { get; set; }

            protected ObtainableItem()
            {
                MaxStackQtt = 1;
            }
        }

        public class HelthPotion : ObtainableItem
        {
            public HelthPotion()
            {
                MaxStackQtt = 5;
            }
        }

        public class MagicPotion : ObtainableItem
        {
            public MagicPotion()
            {
                MaxStackQtt = 10;
            }
        }

        public class RightHandWeapon : ObtainableItem        //In this system, Right hand weapons are the main ones. 1 stack
        {
            public RightHandWeapon()
            {
                MaxStackQtt = 1;
            }
        }

        public class LeftHandWeapon : ObtainableItem        //In this system, left hand weapons are the throwables
        {
            public LeftHandWeapon()
            {
                MaxStackQtt = 20;
            }
        }
    }
}

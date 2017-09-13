using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Inventory
    {

        static int XPLevelUnlock;
        static int slots;
        static int maxSlots = 10;
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

        public static bool CheckInventoryFull(int XPLevelUnlock, int maxSlots)
        {

            switch (XPLevelUnlock)
            {
                case 5:
                    maxSlots += 5;                                     //Slots at 15;
                    break;
                case 10:
                    maxSlots += 5;                                     //Slots at 20
                    break;
                case 15:
                    maxSlots += 5;                                     //Slots at 25
                    break;
                case 20:
                    maxSlots += 5;                                     //Slots at 30
                    break;
                case 30:
                    maxSlots += 10;                                    //Slots at 40
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



        public enum LHWeapon { ShortSword, LongSword, BattleAxe, LongBow, ShortBow, Scythe, Dagger }     //Left Hand Weapons
        public enum RHWeapon { Shield, LongShield, Balestra, LeadPistol, Explosive, Torch }              //Right Hand Weappons
        public enum Ammo { PistolBullets, ExplosivePack, Arrows }                                    //Ammo count
    }


}

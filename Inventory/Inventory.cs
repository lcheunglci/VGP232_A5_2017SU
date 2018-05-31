using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public enum Items
    {
        Empty,                                          //0
        Max_Potion,                                     //1
        Max_Ether,                                      //2
        Persimmon_Leaf_Sushi,                           //3
        Crimson_Cider,                                  //4
        Bacon_Bread,                                    //5
        Diamond_Sword,                                  //6
        Diamond_Shield,                                 //7
        Silvergrace_Earrings,                           //8
        Dai_Ryumyaku_Jufuku_of_Fending,                 //9
        Dai_Ryumyaku_Tsutsu_Hakama_of_Casting           //10
    }
    public class Item
    {

        public string Label { get; set; }
        public int Id { get; set; }

        public Item(string label, int id)
        {
            Label = label;
            Id = id;
        }
    }
    public class InventorySystem
    {
        List<Item> mInventory = new List<Item>();

        public void AddItem(string label, Items enum_item)
        {
            mInventory.Add(new Item(label,(int)enum_item));
        }

        public bool RemoveItem(Items enum_item)
        {
            bool found = false;
            for (int i = 0; i < mInventory.Count; i++)
            {
                if(mInventory[i].Id == (int)enum_item)
                {
                    Console.WriteLine("Item_ID:{0} found at mInventory[{1}], item successfully found and removed", (int)enum_item, i);
                    found = true;
                    mInventory.RemoveAt(i);
                    return found;
                }
            }
            if(!found)
            {
                Console.WriteLine("Unable to remove item_id:{0} from inventory, item does not exist", (int)enum_item);
                return found;
            }
            else
            {
                return found;
            }
        }

        public void PrintInventory()
        {
            for (int i = 0; i < mInventory.Count; i++)
            {
                Console.WriteLine("mInventory[{0}]: {1} (ItemID: {2})", i, mInventory[i].Label, mInventory[i].Id);
            }
        }
    }
}

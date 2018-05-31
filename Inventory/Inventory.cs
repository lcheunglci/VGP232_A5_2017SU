using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Inventory
    {
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

        public void PrintInventory()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("Inventory.items[{0}]: {1} (Type: {2})", i, items[i].name, items[i].type.ToString());
            }
        }
    }
}

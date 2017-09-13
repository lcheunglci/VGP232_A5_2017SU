using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Inventory;

namespace InventoryTestCase
{
    [TestFixture]
    public class InventoryUnitTest
    {
        static int LevelTest = 10;
        static int maxSlotTest = 20;
        static int slotsTest = 19;

        [TestCase]
        public void CheckInventoryFullTest()
        {
            Inventory.Inventory.CheckInventoryFull(LevelTest, maxSlotTest);
            Assert.IsTrue(slotsTest < maxSlotTest);
        }
    }
}

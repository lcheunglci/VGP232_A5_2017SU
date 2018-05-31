﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory;
using PersistentData;
using Character;

namespace vgp232_Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Systems...");
            // TODO: create inventory system
            Inventory.Inventory mInv = new Inventory.Inventory(10);
            mInv.Add(new Item("Dai-Ryumyaku Jufuku of Fending", 1, ItemType.equipment));
            mInv.Add(new Item("Max Potion", 1, ItemType.consumable));
            mInv.Add(new Item("Max Ether", 1, ItemType.consumable));
            mInv.Add(new Item("Diamond Sword", 1, ItemType.equipment));
            mInv.Add(new Item("Diamond Shield", 1, ItemType.equipment));
            mInv.Add(new Item("Silvergrace Earrings of Fending", 1, ItemType.equipment));
            mInv.Add(new Item("Aether Compass", 1, ItemType.key));
            mInv.Add(new Item("Empty Dalmascan Wine Bottle", 1, ItemType.key));
            mInv.Add(new Item("Pazuzu Feather", 1, ItemType.key));

            mInv.PrintInventory();

            Console.WriteLine("Initializing Character Manager");
            Character.Character player;

            // load the character
            player = PersistentData.PersistentData.Deserialize<Character.Character>("player.xml");
            if (player == null)
            {
                Console.WriteLine("No player found, creating new default character");
                player = new Character.Character(100, Race.Elf, Alignment.Neutral);
            }
            

            CharacterManager characterManager = CharacterManager.Instance;
            characterManager.Player = player;
            Character.Character enemyOne = new Character.Character(50, Race.Orc, Alignment.ChaoticEvil);
            Character.Character enemyTwo = new Character.Character(50, Race.Orc, Alignment.NeutralEvil);
            characterManager.AddEnemy(enemyOne);
            characterManager.AddEnemy(enemyTwo);


            // TODO: create persistent data system
            
            // save the player
            Console.WriteLine("Saving players and Enemys");
            PersistentData.PersistentData.Serialize<CharacterManager>(characterManager, "character.xml");


            Console.WriteLine("Press return to exit...");
            Console.ReadKey();
        }
    }
}

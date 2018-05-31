﻿using System;
using System.Collections.Generic;

namespace Character
{
    public class CharacterManager
    {
#region singleton
        private static CharacterManager instance;

        public static CharacterManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CharacterManager();
                }
                return instance;
            }
        }

#endregion

        public Character player;
        public List<Character> npcs = new List<Character>();
        public List<Character> enemies = new List<Character>();

        public Character Player
        {
            get { return player; }
            set
            {
                Console.WriteLine("Player has been set");
                player = value;
            }
        }

        public void AddEnemy(Character enemy)
        {
            Console.WriteLine("An Enemy has been added");
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Character enemy)
        {
            Console.WriteLine("An Enemy has been removed");
            enemies.Remove(enemy);
        }

        public void AddNPC(Character npc)
        {
            Console.WriteLine("An NPC has been added");
            npcs.Add(npc);
        }

        public void RemoveNPC(Character npc)
        {
            Console.WriteLine("An NPC has been removed");
            npcs.Remove(npc);
        }
    }
}

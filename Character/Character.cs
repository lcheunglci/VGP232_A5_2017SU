﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public enum Race { Dwarf, Elf, Goblin, Giant, Halfling, Orc, Vampires, Werewolf, Sphinx }
    public enum Alignment { LawfulGood, LawfulNeutral, LawfulEvil, NeutralGood, Neutral, NeutralEvil, ChaoticGood, ChaoticNeutral, ChaoticEvil }

    public class Character
    {
        public int HealthPoints
        {
            get; set;
        }

        public Race Race
        {
            get; set;
        }

        public Alignment Alignment
        {
            get; set;
        }

        public Character()
        {

        }

        public Character(int hp, Race r, Alignment a)
        {
            HealthPoints = hp;
            Race = r;
            Alignment = a;
        }

        public void TakeDamage(int damage)
        {
            HealthPoints -= damage;
        }

        public void RestoreHealth(int amount)
        {
            HealthPoints += amount;
        }
    }
}

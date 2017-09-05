using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public enum Race { Dwarf, Elf, Goblin, Giant, Halfling, Orc, Vampires, Werewolf, Sphinx }

    public class Character
    {
        int healthPoints;
        Race race;
    }
}

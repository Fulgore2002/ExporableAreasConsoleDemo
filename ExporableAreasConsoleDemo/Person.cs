using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExporableAreasConsoleDemo
{
    public enum Archetype
    {
        Mage,
        Rogue,
        Bard,
        Brawler
    }
    class Person
    {
        public string Name;
        public double Age;
        public double Currency;
        public Archetype Occupation;
        public List<Item> Inventory = new List<Item> ();
    }
}

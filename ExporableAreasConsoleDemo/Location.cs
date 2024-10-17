using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExporableAreasConsoleDemo
{
    class Location
    {
        public string Name;
        public string Description;
        public string Scenario;
        public Item ItemPlayerGets = new Item();


        //association example - "uses a"
        public void Visit(Person p)
        {
            DisplayUtility.Print(Scenario);
            p.Inventory.Add(ItemPlayerGets);
            DisplayUtility.Print($"{ItemPlayerGets.Name} has been added to your inventory");
        }
    }
}

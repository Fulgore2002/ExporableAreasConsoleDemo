using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExporableAreasConsoleDemo.DisplayUtility;

namespace ExporableAreasConsoleDemo
{
    class Adventure
    {
        // An adeventure has a player - example of containment "has a"
        Player player;
        //fields and properties
        public string Name = "Awesome Adventure!";
        private List<Location> locations = new List<Location>();

        private void setUpLocations()
        {
            locations.Add(new Location() { ItemPlayerGets = new Item() { Name = "Home Base", Description = "Where the player lives" } });  
            locations.Add(new Location() { Name = "Haunted Forest", Description = "Spooky spookiness" });
            locations.Add(new Location() { Name = "Choclate Mountains", Description = "Best when there" });
            locations.Add(new Location() { Name = "Desert", Description = "Has an awesome temple with loot" });
            locations.Add(new Location() { Name = "Castle", Description = "very cool castle" });
            locations.Add(new Location() { Name = "Max's Lair", Description = " Home of Max the boss cat" });
            locations.Add(new Location() { Name = "Rainbow River", Description = " Lair of Max the boss cat" });
        }

        //operations/verbs/methods/functions
        private void SetUpPlayer()
        {
            Print("welcome! Please enter your name:");
            string input = GetInput();
            player = new Player(input);
        }
        private string showMenu()
        {
            string output = "Locations: \n";
            int Number = 1;
            foreach (Location location in locations) 
            {
                output += $"   {Number} {location.Name} ({location.Description})\n";
                Number++; //Number = Number + 1 or Number
            }

            return output;
        }
        private int getLoactionChoice()
        {
            //int choice = 0;
            //string input = GetInput();
            //if (int.TryParse(input, out choice)) 
            //{

            //}

            if (int.TryParse(GetInput(), out int choice))
            {
                return choice-1;
            }

            return 0;
        }
        public void SetUp() 
        {
            SetUpPlayer();
            setUpLocations();
            Print($"Okay, {player.Name} where would you like to go ");
            Print(showMenu());

            //int choce = getLoactionChoice();
            //string Scenario = locations[choice].Scenario;
            //Print(Scenario);
            Location location = locations[getLoactionChoice()];

            Print(locations.Scenario);
            location[].Visit(player);

            //Print(getLoactionChoice());
        }
        public void Play()
        {
            //Print(input)
        }
    }
}

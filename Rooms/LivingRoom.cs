using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarrativeProject.Rooms
{
    internal class LivingRoom : Room
    {
        internal override string CreateDescription() => @"You are in happily in your living room, 
        you [dog] is giving you a look that     
        means he wants to play outside, and     
        there is your [TV] where you can watch 
        a nice movie.";

        internal override void ReceiveChoice(string choice)
        {
            switch(choice)
            {
                case "dog":
                    Console.WriteLine("you and your puppy had such a great time and everyone is happy");
                    Game.Finish();
                    break;
                case "TV":
                    Console.WriteLine(  "You wanted to watch a movie " +
                                        "but the sad face of you puppy does not let" +
                                        "you."); goto case"dog";
                default:
                    Console.WriteLine("Invalid command.");
                    break;

            }
        }
    }
}

using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace NarrativeProject.Rooms
{
    internal class Bathroom : Room
    {
        public string yesOrno = "";
        internal override string CreateDescription() =>
@"In your bathroom, the [bath] is filled with hot water.
The [mirror] in front of you reflects your depressed face.
You can return to your [bedroom].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bath":
                    Console.WriteLine("You relax in the bath, but there is not running water, do you want to turn it on [yes] or [no]?");
                    yesOrno = Console.ReadLine();
                    switch (yesOrno)
                    {
                        case "yes":
                            Console.WriteLine("you had a nice bath and now leave it but there is something strange in the mirror");
                            Game.Transition<Bathroom>();
                            break;
                        case "no":
                            Console.WriteLine("you leave the bath");
                            Game.Transition<Bathroom>();
                            break;
                        default:
                            Console.WriteLine("Invalid command.");
                            break;
                    }
                    break;
                case "mirror":
                    switch (IsOn(choice))
                    {
                        case true:
                            Console.WriteLine("you see a code 6969 in the morrow, what");
                            break;
                        case false:
                            Console.WriteLine("you see your sad depressive but beaty face in the mirror");
                            break;
                        default:
                            Console.WriteLine("Invalid command.");
                            break;



                    }
                    break;
                case "bedroom":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
        public virtual bool IsOn(string yesOrNo)
        {
            if(yesOrno == "yes") return true;

            else if(yesOrno == "no") return false;
            else
            {
                return false;
            }
        }
    }
}

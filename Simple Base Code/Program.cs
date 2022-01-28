using System;

namespace Simple_Base_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            bool locked = true;
            map m = new map();

            Console.WriteLine("Hello Mr. L, this game is a work in progress currently in Pre-Alpha! So far the only thing we have completed is a few commands, and we have made comments in the code");
            Console.Write(" for each room.");

            Console.WriteLine("Welcome to the Two Mikes Game");
            Console.WriteLine("next: Move to the next room");
            Console.WriteLine("prev: Move to the previous room");
            Console.WriteLine("interact: Shows a list of objects to interact with");
            Console.WriteLine("help: will bring up a menu like this");
            Console.WriteLine("!WARNING! Mispelling will cause game to end :)");


            while (end == false)
            {

                switch (Console.ReadLine())
                {
                    case "next":
                        if (m.getLocked() == false)
                        {
                            m.nextRoom();
                            Console.WriteLine("Yo u in");
                        }
                        break;

                    case "prev":
                        if (m.getCount() != 0)
                        {
                            m.prevRoom();
                            Console.WriteLine("back");
                        }

                        else
                        {
                            Console.WriteLine("cant go back");
                        }
                        break;


                    case "help":
                        Console.WriteLine("next: Move to the next room");
                        Console.WriteLine("prev: Move to the previous room");
                        Console.WriteLine("interact: Shows a list of objects to interact with");
                        Console.WriteLine("help: will bring up a menu like this");
                        Console.WriteLine("key: only when needing to unlock next room for testing");
                        Console.WriteLine("!WARNING! Mispelling will cause game to end :)");
                        break;

                    //anything after this is for testing only!!!!
                    case "key":
                        Console.WriteLine("used admin key");
                        m.unlockRoom();
                        break;

                    default:
                        Console.WriteLine("All good things have to come to an end, Goodbye :)");
                        end = true;
                        break;
                }
            }
            
        }
    }
}

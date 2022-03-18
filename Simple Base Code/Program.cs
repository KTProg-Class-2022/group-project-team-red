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

            Console.WriteLine("Hello Mr. L Mikey Naj and I (Ryan) have finished sprint 2 just in time, and now we are moving on to sprint 3");
            Console.WriteLine("If you type in the word 'key' you will automatically open the room, although this is just for testing so that we can get around the map properly");
            Console.WriteLine("");


            Console.WriteLine("Welcome to the Two Mikes Game");
            Console.WriteLine("next: Move to the next room");
            Console.WriteLine("prev: Move to the previous room");
            Console.WriteLine("interact: Shows a list of objects to interact with");
            Console.WriteLine("help: will bring up a menu like this");
            Console.WriteLine("key: only when needing to unlock next room for testing");
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

                        else
                        {
                            Console.WriteLine("Locked bum");
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

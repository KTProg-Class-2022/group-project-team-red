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


            while (end == false)
            {
                 switch (Console.ReadLine())
                {
                    case "next":
                        if (m.getLocked() == false)
                        {
                            m.nextRoom();
                        }
                        break;

                    case "prev":
                        m.prevRoom();
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

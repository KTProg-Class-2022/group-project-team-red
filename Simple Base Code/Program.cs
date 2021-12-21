using System;

namespace Simple_Base_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean end = false;
            map m = new map();


            while (end == false)
            {
                switch (Console.ReadLine())
                {
                    case "next":
                        break;

                    case "prev":
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    
    class map
    {
        List<room> roomList = new List<room>();
        room r;
        int counter = 0;
        item ex;

        List<item> najRoom = new List<item>();
        List<item> ryanRoom = new List<item>();
        
        public map()
        {
            

            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    r = new room("Tutorial");
                }

                if (i == 1)
                {
                    r = new room("Mikey Naj");
                    /* there is a timer that starts when the player enters the room, and they have to open a box in the center of the room after they enter
                     * Box has a puzzle in it with one missing piece, player has to find it
                     * there are two tables, broken picture frame with broken glass
                     * empty shelf, window with natural light
                     * Puzzle piece will be found hiding behind the broken frame, next to broken glass
                     * player takes the puzzle piece, completes puzzle, gets a key to leave the room and they walk out of the door
                     */
                    ex = new item("timer", "start running");
                    najRoom.Add(ex);

                    ex = new item("box", "open");
                    najRoom.Add(ex);

                    ex = new item("puzzle", "not assembled");
                    najRoom.Add(ex);

                    ex = new item("Table one", "empty");
                    najRoom.Add(ex);

                    ex = new item("Table two", "blank piece of paper");
                    najRoom.Add(ex);

                    ex = new item("shelf", "empty");
                    najRoom.Add(ex);

                    ex = new item("window", "open");
                    najRoom.Add(ex);

                    ex = new item("picture frame", "broken");
                    najRoom.Add(ex);

                    ex = new item("missing puzzle piece", "assemble");
                    najRoom.Add(ex);

                    ex = new item("key", "open door");
                    najRoom.Add(ex);
                }

                if (i == 2)
                {
                    r = new room("Ryan");
                    /* Bomb
                     * 4 Buttons in a Closet
                     * Plant changes color
                     * Robot
                     * Wall Carvings
                     * End Table with Light
                     * Door exit
                     * Shelf
                     */
                    
                    ex = new item("Bomb", "Blow Up");
                    ryanRoom.Add(ex);

                    ex = new item("Buttons", "For player to press");
                    ryanRoom.Add(ex);

                    ex = new item("Robot", "Robot needs to be fixed");
                    ryanRoom.Add(ex);

                    ex = new item("Wall Carvings", "For player to look at");
                    ryanRoom.Add(ex);

                    ex = new item("End table with light", "Light can see wall carvings");
                    ryanRoom.Add(ex);

                    ex = new item("Shelf", "Will have stuff");
                    ryanRoom.Add(ex);

                    ex = new item("Door", "player can exit");
                    ryanRoom.Add(ex);

                }

                if (i == 3)
                {
                    r = new room("Duffy");
                    /*
                     * 
                     * 
                     * 
                     */
                }

                else
                {
                    r = new room("Ana");
                    /*
                     * 
                     * 
                     * 
                     */
                }

                roomList.Add(r);
            }

            r = roomList[0];
        }

        public int roomCount()
        {
            return roomList.Count;
        }

        public room currentRoom()
        {
            return r;
        }

        public room nextRoom()
        {
            counter++;
            r = roomList[counter];
            return r;

        }

        public room prevRoom()
        {
            counter--;
            r = roomList[counter];
            return r;
        }

        public int getCount()
        {
            return counter;
        }

        public bool getLocked()
        {
            return r.getLocked();
        }

        //testing only!!!!
        public void unlockRoom()
        {
            r.unlock();
        }
    }
}

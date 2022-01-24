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

        public bool getLocked()
        {
            return r.getLocked();
        }
    }
}

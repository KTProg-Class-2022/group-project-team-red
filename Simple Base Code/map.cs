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
                }

                if (i == 2)
                {
                    r = new room("Ryan");
                }

                if (i == 3)
                {
                    r = new room("Duffy");
                }

                else
                {
                    r = new room("Ana");
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    class room
    {
        bool locked = true;
        public room(string name)
        {

        }

        public bool getLocked()
        {
            return locked;
        }

        //testing only
        public void unlock()
        {
            locked = false;
        }
    }
}

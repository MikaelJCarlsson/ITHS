using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämmning1
{
    class Person
    {
        public int Xpos { get; set; }
        public int Ypos { get; set; }


    }
    class Polis : Person
    {

        public Polis(int y, int x)
        {
            Ypos = y;
            Xpos = x;
        }
    }

    class Tjuv : Person
    {
        public Tjuv(int y, int x)
        {
            Ypos = y;
            Xpos = x;
        }
    }
    class Medborgare : Person
    {
        public Medborgare(int y, int x)
        {
            Ypos = y;
            Xpos = x;
        }
    }
}

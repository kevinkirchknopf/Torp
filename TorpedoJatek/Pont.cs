using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorpedoJatek
{
    public class Pont
    {
        public int x {  get; set; }
        public int y { get; set; }
        public Hajo Hajo { get; set; }

        public bool talalat { get; set; }


        public Pont(int x, int y, Hajo h)
        {
            this.y = y;
            this.x = x;
            this.Hajo = h;
            talalat = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TorpedoJatek
{
    public class Hajo
    {
        public int Meret { get; set; }
        public int Elet { get; set; }
        public int Irany { get; set; }
        public readonly Palya palya;
        // 0,1
        //vizszint,fuggoleges
        public Hajo(int meret, Palya p)
        {
            Meret = meret;
            Elet = meret;
            palya = p;
        }
        public void KordinataBekeres()
        {
            int x;
            int y;
            do
            {
                Console.WriteLine("Add meg a hajó koordinátáit (1,5)");
                string[] koord = Console.ReadLine().Split(",");
                x = int.Parse(koord[0]);
                y = int.Parse(koord[1]);
                Console.WriteLine("Milyen irányban álljon a hajó vízszintes(0) v függőleges (1)");
                Irany = int.Parse(Console.ReadLine());
                Console.Clear();
                
            } while (!Lerakhato(x, y));

            Lerak(x, y, Irany);

        }

        public void Lerak(int x, int y, int irany)
        {

            for (int i = 0; i < Meret; i++)
            {
                if (irany == 0)
                {
                    palya.HajoPontLerak(new Pont(x, y + i, this));
                }
                else if (irany == 1)
                {
                    palya.HajoPontLerak(new Pont(x + i, y, this));
                }

            }

        }
        private bool Lerakhato(int x, int y)
        {

            if (Irany == 0 && (y + Meret - 1 >= palya.sor || x >= palya.oszlop))
            {
                return false; // Out of bounds
            }
            else if (Irany == 1 && (x + Meret - 1 >= palya.oszlop || y >= palya.sor))
            {
                return false; // Out of bounds
            }

            for (int i = 0; i < Meret; i++)
            {
                if (Irany == 0 && palya.IsOccupied(x, y + i))
                {
                    return false; // Collides with an existing ship (horizontal)
                }
                else if (Irany == 1 && palya.IsOccupied(x + i, y))
                {
                    return false; // Collides with an existing ship (vertical)
                }
            }

            return true;

        }






    }
}

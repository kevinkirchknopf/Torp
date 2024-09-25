using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TorpedoJatek
{
    public class Hajo
    {
        public int Meret { get; set; }
        public int Elet { get; set; }
        public int Irany { get; set; }
        private readonly Palya palya;
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
            int irany;
            do
            {
                Console.WriteLine("Add meg a hajó koordinátáit (1,5)");
                string[] koord = Console.ReadLine().Split(",");
                x = int.Parse(koord[0]);
                y = int.Parse(koord[1]);
                Console.WriteLine("Milyen irányban álljon a hajó vízszintes(0) v függőleges (1)");
                irany = int.Parse(Console.ReadLine());
            } while (!Lerakhato());

            Lerak(x,y,irany);
            
        }
  
        public void Lerak(int x, int y,int irany)
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

        private bool Lerakhato()
        {

            if(Meret > palya.oszlop || Meret > palya.sor)
            {
                return false;
            }
            else
            {

            }

            return true;
        }

    }






}

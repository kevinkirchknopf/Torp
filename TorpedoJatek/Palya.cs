using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorpedoJatek
{
    public class Palya
    {
        private List<Pont> Tenger { get; set; }
        public int oszlop { get; set; }
        public int sor { get; set; }
        public bool talalat { get; set; }

       

        public void HajoLerak()
        {
            Hajo egy = new(2, this);
            Hajo kettő = new(3, this);
            egy.KordinataBekeres();
            kettő.KordinataBekeres();
            Kirajzol();
        }
        public Palya(int oszlopszam, int sorszam)
        {
            this.oszlop = oszlopszam;
            this.sor = sorszam;
            
            Tenger = new List<Pont>();
        }
        public void Kirajzol()
        {
            Console.Clear();

            keret();
            foreach (Pont p in Tenger)
            {
          
                    Console.SetCursorPosition(p.y, p.x);
                    Console.WriteLine(p.Hajo.Meret);
                
            }

        }

        public void HajoPontLerak(Pont p)
        {
            Tenger.Add(p);
        }

        private void keret()
        {
           
            Console.WriteLine(new string('#', oszlop + 2));

          
            for (int i = 0; i < sor; i++)
            {
                Console.Write("#");
                Console.Write(new string(' ', oszlop)); 
                Console.WriteLine("#");
            }

            
            Console.WriteLine(new string('#', oszlop + 2));

        }

        public bool FoglaltPont(int x, int y)
        {
         
            return false;
        }

        public Pont lovestalalt()
        {
            
            foreach(Pont p in Tenger)
            {
                if(p.Hajo == null)
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("O");
                    return p;
                }
                
            }
            return null;
        }

        public bool IsOccupied(int x, int y)
        {
            
            foreach (Pont point in Tenger)
            {
                
                if (point.x == x && point.y == y)
                {
                    return true; 
                }
            }
            return false; 
        }
    }




}

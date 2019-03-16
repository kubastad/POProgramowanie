using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtvAgd
{
    //kanal down, liczba programow, nazwenistwo do parametrow wprowadzanych
    class Telewizor
    {
        private bool podlaczony;
        private bool wlaczony;
        private int kanal;

        //W procentach
        private int glosnosc;
        private int jasnosc;

        public Telewizor()
        {
            podlaczony = false;
            wlaczony = false;
            kanal = 1;
            glosnosc = 50;
            jasnosc = 50;
        }

        public Telewizor(bool podl, bool wl, int jas)
        {
            podlaczony = podl;
            wlaczony = wl;
            jasnosc = jas;
        }

        public Telewizor(Telewizor inny)
        {
            podlaczony = inny.podlaczony;
            wlaczony = inny.wlaczony;
            kanal = inny.kanal;
            glosnosc = inny.glosnosc;
            jasnosc = inny.jasnosc;

        }


        public void WlaczTelewizor()
        {
            wlaczony = true;
            Console.WriteLine("Włączono telewizor");
        }

        public void UstawGlosnosc(int x)
        {
            if (x <= 100) glosnosc = x;
            else
                glosnosc = 100;

            Console.WriteLine("Ustawiono glosność: {0}", glosnosc);

        }

        public void ZwiekszJasnosc()
        {
            if (jasnosc<=90) jasnosc += 10;
            Console.WriteLine("Obecna jasnosc: {0}", jasnosc);
        }

        public void KanalUp()
        {
            kanal++;
            Console.WriteLine("Obecny kanal: {0}", kanal);
        }

        
    }
}


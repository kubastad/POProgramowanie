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
        private bool _podlaczony;
        private bool _wlaczony;
        private int _kanal;

        //W procentach
        private int _glosnosc;
        private int _jasnosc;

        public Telewizor()
        {
            _podlaczony = false;
            _wlaczony = false;
            _kanal = 1;
            _glosnosc = 50;
            _jasnosc = 50;
        }

        public Telewizor(bool podlaczony, bool wlaczony, int jasnosc)
        {
            _podlaczony = podlaczony;
            _wlaczony = wlaczony;
            _jasnosc = jasnosc;
        }

        public Telewizor(Telewizor inny)
        {
            _podlaczony = inny._podlaczony;
            _wlaczony = inny._wlaczony;
            _kanal = inny._kanal;
            _glosnosc = inny._glosnosc;
            _jasnosc = inny._jasnosc;

        }


        public void WlaczTelewizor()
        {
            _wlaczony = true;
            Console.WriteLine("Włączono telewizor");
        }

        public void WylaczTelewizor()
        {
            _wlaczony = false;
            Console.WriteLine("Wyłączono telewizor");
        }

        public void UstawGlosnosc(int x)
        {
            if (x <= 100) _glosnosc = x;
            else
                _glosnosc = 100;

            Console.WriteLine("Ustawiono glosność: {0}", _glosnosc);

        }

        public void ZwiekszJasnosc()
        {
            if (_jasnosc<=90) _jasnosc += 10;
            Console.WriteLine("Obecna jasnosc: {0}", _jasnosc);
        }

        public void KanalUp()
        {
            _kanal++;
            Console.WriteLine("Obecny kanal: {0}", _kanal);
        }

        
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtvAgd
{
    class Lodowka
    {
        private bool _podlaczona;
        private bool _wlaczona;
        private int _temperatura;

        public Lodowka()
        {
            _podlaczona = false;
            _wlaczona = false;
            _temperatura = 10;

        }

        public Lodowka(bool podlaczona, bool wlaczona, int temperatura)
        {
            _podlaczona = podlaczona;
            _wlaczona = wlaczona;
            _temperatura = temperatura;

        }

        public Lodowka(Lodowka inna)
        {
            _podlaczona = inna._podlaczona;
            _wlaczona = inna._wlaczona;
            _temperatura = inna._temperatura;
        }

        public void WlaczLodowke()
        {
            _wlaczona = true;
            Console.WriteLine("Włączono lodowke");
        }

        public void TemperaturaUp()
        {
            _temperatura++;
            Console.WriteLine("Zwiekszono temperature. Aktualna: {0}", temperatura);
        }

        public void TemperaturaDown()
        {
            _temperatura--;
            Console.WriteLine("Zmniejszono temperature. Aktualna: {0}", temperatura);
        }



    }
}

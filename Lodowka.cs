using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtvAgd
{
    class Lodowka
    {
        private bool podlaczona;
        private bool wlaczona;
        private int temperatura;

        public Lodowka()
        {
            podlaczona = false;
            wlaczona = false;
            temperatura = 10;

        }

        public Lodowka(bool podl, bool wl, int temp)
        {
            podlaczona = podl;
            wlaczona = wl;
            temperatura = temp;

        }

        public Lodowka(Lodowka inna)
        {
            podlaczona = inna.podlaczona;
            wlaczona = inna.wlaczona;
            temperatura = inna.temperatura;
        }

        public void WlaczLodowke()
        {
            wlaczona = true;
            Console.WriteLine("Włączono lodowke");
        }

        public void TemperaturaUp()
        {
            temperatura++;
            Console.WriteLine("Zwiekszono temperature. Aktualna: {0}", temperatura);
        }

        public void TemperaturaDown()
        {
            temperatura--;
            Console.WriteLine("Zmniejszono temperature. Aktualna: {0}", temperatura);
        }



    }
}

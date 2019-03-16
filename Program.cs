using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtvAgd
{
    class Program
    {
        static void Main(string[] args)
        {
            Telewizor tv1 = new Telewizor(true, true, 50);

            tv1.WlaczTelewizor();
            tv1.UstawGlosnosc(80);
            tv1.ZwiekszJasnosc();
            tv1.ZwiekszJasnosc();

            Telewizor tv2 = new Telewizor(tv1);

            Lodowka lod1 = new Lodowka();

            lod1.WlaczLodowke();
            lod1.TemperaturaUp();
            lod1.TemperaturaUp();
            lod1.TemperaturaUp();
            lod1.TemperaturaDown();

            Lodowka lod2 = new Lodowka(lod1);




            Console.ReadKey();
        }
    }
}

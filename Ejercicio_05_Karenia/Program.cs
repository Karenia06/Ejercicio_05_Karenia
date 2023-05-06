using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05_Karenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Album n1 = new Album(1, "Animales", 7534, new List<Foto>());



            n1.AniadirFoto(new Foto(2, 5, 2007, "Capibara"));
            n1.AniadirFoto(new Foto(3, 99, 2009, "Cocodrilo"));
            n1.AniadirFoto(new Foto(4, 11, 2023, "Gatos"));

            n1.Mostrar();
            n1.TamanoAlbum();
            Console.ReadKey();
        }
    }
}

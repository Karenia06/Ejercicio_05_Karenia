using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05_Karenia
{
    class Album
    {
        int id;
        string nombre;
        int fecha;
        List<Foto> fot;
        int cont;
        float tam;
        public Album() { }
        public Album(int cont)
        {
            this.cont = cont;
        }

        public Album(int id, string nombre, int fecha, List<Foto> fot)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha = fecha;
            this.fot = fot;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Fecha { get => fecha; set => fecha = value; }
        public int Cont { get => cont; set => cont = value; }
        internal List<Foto> Fot { get => fot; set => fot = value; }
        public float Tam { get => tam; set => tam = value; }

        public void AniadirFoto(Foto f)
        {
            try
            {
                this.fot.Add(f);
                this.Cont += 1;
                this.Tam += f.Tamaño_MB;
                Console.WriteLine("\n Se añadió una foto");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n No se puede añadir una foto a: \n" + ex.Message);
                Console.ReadLine();

            }
        }
        public void Mostrar()
        {
            foreach (Foto item in this.fot)
            {
                Console.WriteLine("------------");
                Console.WriteLine(item.ToString());
            }
        }
        public void VaciarAlbum()
        {
            Console.WriteLine("¿Está seguro de eliminar todos los elementos que estan en la lista?: S/N");
            string response = Console.ReadLine();
            if (response == "S" || response == "s")
            {
                Fot = new List<Foto>();
                this.Cont = 0;
                Console.WriteLine("Se han eliminado las fotos");
            }
            else
            {
                Console.WriteLine("No se eliminó. Hay {0} fotos registradas.", this.Cont);
            }
            Console.ReadLine();
        }
        public void EliminarFoto(Foto f)
        {
            Fot.Remove(f);
            Cont -= 1;
            this.Tam -= f.Tamaño_MB;
            Console.WriteLine("Se ha eliminado un registro..");
        }
        public void TamanoAlbum()
        {
            if (this.tam > 1000 && this.tam < 999999)
            {
                Console.WriteLine("\n" + Math.Floor(this.tam / 1000) + " GB");
            }
            else if (this.tam > 1000000)
            {
                Console.WriteLine("\n" + Math.Floor(this.tam / 1000000) + " TB");
            }
            else
            {
                Console.WriteLine("\n" + this.tam + " MB");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05_Karenia
{
    class Foto
    {
        int id_f;
        int tamaño_MB;
        int fecha_creacion;
        string comentarios;


        public Foto(int id_f, int tamaño_MB, int fecha_Creación, string comentarios)
        {
            this.Id_f = id_f;
            this.Tamaño_MB = tamaño_MB;
            this.Fecha_Creacion = fecha_Creación;
            this.Comentarios = comentarios;

        }

        public int Id_f { get => id_f; set => id_f = value; }
        public int Tamaño_MB { get => tamaño_MB; set => tamaño_MB = value; }
        public int Fecha_Creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }

        public override string ToString()
        {
            return "Id: " + this.Id_f + "\n Tamaño: " + this.Tamaño_MB + "\n Fecha: " + this.Fecha_Creacion + "\n Comentario: " + this.Comentarios;
        }
    }
}

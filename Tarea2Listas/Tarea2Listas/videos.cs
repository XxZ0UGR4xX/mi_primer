using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Listas
{
    public class Video
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Url { get; set; }
        public bool Activo { get; set; }

        public Video(string titulo, string autor, string url, bool activo)
        {
            Titulo = titulo;
            Autor = autor;
            Url = url;
            Activo = activo;
        }
    }
}

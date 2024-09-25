using System.Security.Cryptography.X509Certificates;

namespace Tarea2Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> listaVideos = new List<Video>();

            while (true)
            {
                Console.WriteLine("Crear un nuevo video (S/N)?");
                string respuesta = Console.ReadLine();

                if (respuesta.ToUpper() == "N")
                {
                    break;
                }

                Console.WriteLine("Ingrese el título del video:");
                string titulo = Console.ReadLine();

                Console.WriteLine("Ingrese el autor del video:");
                string autor = Console.ReadLine();

                Console.WriteLine("Ingrese la URL del video:");
                string url = Console.ReadLine();

                Console.WriteLine("¿El video está activo? (S/N)");
                string activo = Console.ReadLine();

                bool isActive = activo.ToUpper() == "S";

                Video video = new Video(titulo, autor, url, isActive);
                listaVideos.Add(video);
            }

            Console.WriteLine("Lista de videos:");
            foreach (var video in listaVideos)
            {
                Console.WriteLine($"Título: {video.Titulo}, Autor: {video.Autor}, URL: {video.Url}, Activo: {video.Activo}");
            }
        }
    }
}

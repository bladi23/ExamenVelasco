using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVelasco.Modelos
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int AnioLanzamiento { get; set; }
        public string Discografica { get; set; }
        public int ArtistaId { get; set; } // Clave foránea que referencia a Artista

        // Constructor por defecto
        public Album() { }

        // Constructor completo
        public Album(int albumId, string titulo, string genero, int anioLanzamiento, string discografica, int artistaId)
        {
            AlbumId = albumId;
            Titulo = titulo;
            Genero = genero;
            AnioLanzamiento = anioLanzamiento;
            Discografica = discografica;
            ArtistaId = artistaId;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVelasco.Modelos
{
    public class Artista
    {
        public int ArtistaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }

        // Constructor por defecto
        public Artista() { }

        // Constructor completo
        public Artista(int artistaId, string nombre, string apellido, DateTime fechaNacimiento, string nacionalidad)
        {
            ArtistaId = artistaId;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Nacionalidad = nacionalidad;
        }
    }

}

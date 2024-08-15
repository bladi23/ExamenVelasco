using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using ExamenVelasco.Modelos;

namespace ExamenVelasco.CAD
{
    public class ArtistaDAL
    {
        // Añadir un nuevo artista a la base de datos
        public bool AñadirArtista(Artista artista)
        {
            using (ConexionDB db = new ConexionDB())
            {
                string sql = "INSERT INTO Artistas (nombre, apellido, fecha_nacimiento, nacionalidad) VALUES (@nombre, @apellido, @fechaNacimiento, @nacionalidad)";
                SqlCommand cmd = new SqlCommand(sql, db.Conexion);
                cmd.Parameters.AddWithValue("@nombre", artista.Nombre);
                cmd.Parameters.AddWithValue("@apellido", artista.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", artista.FechaNacimiento);
                cmd.Parameters.AddWithValue("@nacionalidad", artista.Nacionalidad);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Obtener todos los artistas de la base de datos
        public List<Artista> ObtenerArtistas()
        {
            List<Artista> artistas = new List<Artista>();
            using (ConexionDB db = new ConexionDB())
            {
                string sql = "SELECT * FROM Artistas";
                SqlCommand cmd = new SqlCommand(sql, db.Conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        artistas.Add(new Artista
                        {
                            ArtistaId = Convert.ToInt32(reader["artista_id"]),
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(reader["fecha_nacimiento"]),
                            Nacionalidad = reader["nacionalidad"].ToString()
                        });
                    }
                }
            }
            return artistas;
        }

        // Actualizar un artista existente en la base de datos
        public bool ActualizarArtista(Artista artista)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(artista.Nombre) ||
                string.IsNullOrWhiteSpace(artista.Apellido) ||
                artista.FechaNacimiento == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(artista.Nacionalidad))
            {
                // Si algún campo está vacío o FechaNacimiento no es válida, mostrar un mensaje y no realizar la actualización
                MessageBox.Show("Llenar todos los campos antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (ConexionDB db = new ConexionDB())
            {
                string sql = "UPDATE Artistas SET nombre=@nombre, apellido=@apellido, fecha_nacimiento=@fechaNacimiento, nacionalidad=@nacionalidad WHERE artista_id=@artistaId";
                SqlCommand cmd = new SqlCommand(sql, db.Conexion);
                cmd.Parameters.AddWithValue("@artistaId", artista.ArtistaId);
                cmd.Parameters.AddWithValue("@nombre", artista.Nombre);
                cmd.Parameters.AddWithValue("@apellido", artista.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", artista.FechaNacimiento);
                cmd.Parameters.AddWithValue("@nacionalidad", artista.Nacionalidad);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Eliminar un artista de la base de datos
        public bool EliminarArtista(int artistaId)
        {
            using (ConexionDB db = new ConexionDB())
            {
                string sql = "DELETE FROM Artistas WHERE artista_id=@artistaId";
                SqlCommand cmd = new SqlCommand(sql, db.Conexion);
                cmd.Parameters.AddWithValue("@artistaId", artistaId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

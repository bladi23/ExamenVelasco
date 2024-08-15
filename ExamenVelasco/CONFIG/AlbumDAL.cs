using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using ExamenVelasco.Modelos;

namespace ExamenVelasco.CAD
{
    public class AlbumDAL
    {
        // Añadir un nuevo álbum a la base de datos
        public bool AñadirAlbum(Album album)
        {
            using (ConexionDB db = new ConexionDB())
            {
                string sql = "INSERT INTO Albumes (titulo, genero, anio_lanzamiento, discografica, artista_id) VALUES (@titulo, @genero, @anioLanzamiento, @discografica, @artistaId)";
                SqlCommand cmd = new SqlCommand(sql, db.Conexion);
                cmd.Parameters.AddWithValue("@titulo", album.Titulo);
                cmd.Parameters.AddWithValue("@genero", album.Genero);
                cmd.Parameters.AddWithValue("@anioLanzamiento", album.AnioLanzamiento);
                cmd.Parameters.AddWithValue("@discografica", album.Discografica);
                cmd.Parameters.AddWithValue("@artistaId", album.ArtistaId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Obtener todos los álbumes de la base de datos
        public List<Album> ObtenerAlbumes()
        {
            List<Album> albumes = new List<Album>();
            using (ConexionDB db = new ConexionDB())
            {
                string sql = "SELECT * FROM Albumes";
                SqlCommand cmd = new SqlCommand(sql, db.Conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        albumes.Add(new Album
                        {
                            AlbumId = Convert.ToInt32(reader["album_id"]),
                            Titulo = reader["titulo"].ToString(),
                            Genero = reader["genero"].ToString(),
                            AnioLanzamiento = Convert.ToInt32(reader["anio_lanzamiento"]),
                            Discografica = reader["discografica"].ToString(),
                            ArtistaId = Convert.ToInt32(reader["artista_id"])
                        });
                    }
                }
            }
            return albumes;
        }

        // Actualizar un álbum existente en la base de datos
        public bool ActualizarAlbum(Album album)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(album.Titulo) ||
                string.IsNullOrWhiteSpace(album.Genero) ||
                string.IsNullOrWhiteSpace(album.Discografica))
            {
                
                MessageBox.Show("Llenar todos los campos antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            using (ConexionDB db = new ConexionDB())
            {
                string sql = "UPDATE Albumes SET titulo=@titulo, genero=@genero, anio_lanzamiento=@anioLanzamiento, discografica=@discografica WHERE album_id=@albumId";
                SqlCommand cmd = new SqlCommand(sql, db.Conexion);
                cmd.Parameters.AddWithValue("@albumId", album.AlbumId);
                cmd.Parameters.AddWithValue("@titulo", album.Titulo);
                cmd.Parameters.AddWithValue("@genero", album.Genero);
                cmd.Parameters.AddWithValue("@anioLanzamiento", album.AnioLanzamiento);
                cmd.Parameters.AddWithValue("@discografica", album.Discografica);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Eliminar un álbum de la base de datos
        public bool EliminarAlbum(int albumId)
        {
            using (ConexionDB db = new ConexionDB())
            {
                string sql = "DELETE FROM Albumes WHERE album_id=@albumId";
                SqlCommand cmd = new SqlCommand(sql, db.Conexion);
                cmd.Parameters.AddWithValue("@albumId", albumId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

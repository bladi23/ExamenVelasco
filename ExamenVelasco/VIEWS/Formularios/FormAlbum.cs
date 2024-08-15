using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ExamenVelasco.CAD;
using ExamenVelasco.Modelos;

namespace ExamenVelasco.IU.Formularios
{
    public partial class FormAlbum : Form
    {
        public FormAlbum()
        {
            InitializeComponent();
        }

        private void FormAlbum_Load(object sender, EventArgs e)
        {
            CargarArtistas();
            CargarAlbumes();
        }

        private void CargarArtistas()
        {
            List<Artista> artistas = new ArtistaDAL().ObtenerArtistas();
            cmbArtistaId.DataSource = artistas;
            cmbArtistaId.DisplayMember = "Nombre";
            cmbArtistaId.ValueMember = "ArtistaId";
        }

        private void CargarAlbumes()
        {
            List<Album> albumes = new AlbumDAL().ObtenerAlbumes();
            dataGridViewAlbumes.DataSource = albumes;
            dataGridViewAlbumes.AutoGenerateColumns = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Album nuevoAlbum = new Album
            {
                Titulo = txtTitulo.Text,
                Genero = txtGenero.Text,
                AnioLanzamiento = (int)nudAnioLanzamiento.Value,
                Discografica = txtDiscografica.Text,
                ArtistaId = (int)cmbArtistaId.SelectedValue
            };

            bool resultado = new AlbumDAL().AñadirAlbum(nuevoAlbum);

            if (resultado)
            {
                MessageBox.Show("Álbum añadido exitosamente.");
                LimpiarCampos();
                CargarAlbumes();
            }
            else
            {
                MessageBox.Show("Error al añadir el álbum.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlbumes.CurrentRow != null)
            {
                int albumId = (int)dataGridViewAlbumes.CurrentRow.Cells["AlbumId"].Value;

                Album album = new Album
                {
                    AlbumId = albumId,
                    Titulo = txtTitulo.Text,
                    Genero = txtGenero.Text,
                    AnioLanzamiento = (int)nudAnioLanzamiento.Value,
                    Discografica = txtDiscografica.Text,
                    ArtistaId = (int)cmbArtistaId.SelectedValue
                };  

                bool resultado = new AlbumDAL().ActualizarAlbum(album);

                if (resultado)
                {
                    MessageBox.Show("Álbum actualizado exitosamente.");
                    LimpiarCampos();
                    CargarAlbumes();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el álbum.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlbumes.CurrentRow != null)
            {
                int albumId = (int)dataGridViewAlbumes.CurrentRow.Cells["AlbumId"].Value;

                bool resultado = new AlbumDAL().EliminarAlbum(albumId);

                if (resultado)
                {
                    MessageBox.Show("Álbum eliminado exitosamente.");
                    LimpiarCampos();
                    CargarAlbumes();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el álbum.");
                }
            }
        }

        private void LimpiarCampos()
        {
            txtAlbumId.Clear();
            txtTitulo.Clear();
            txtGenero.Clear();
            nudAnioLanzamiento.Value = DateTime.Now.Year;
            txtDiscografica.Clear();
            cmbArtistaId.SelectedIndex = -1;
        }
    }
}

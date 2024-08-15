using System;
using System.Windows.Forms;
using ExamenVelasco.CAD;
using ExamenVelasco.Modelos;
using System.Collections.Generic;

namespace ExamenVelasco.IU.Formularios
{
    public partial class FormArtista : Form
    {
        public FormArtista()
        {
            InitializeComponent();
        }

        private void FormArtista_Load(object sender, EventArgs e)
        {
            CargarArtistas();
        }

        private void CargarArtistas()
        {
            List<Artista> artistas = new ArtistaDAL().ObtenerArtistas();
            dataGridViewArtistas.DataSource = artistas;

            // Asegúrate de que todas las columnas sean visibles, incluyendo el ID si lo deseas mostrar
            dataGridViewArtistas.AutoGenerateColumns = true;
            dataGridViewArtistas.Columns["ArtistaId"].Visible = true;  // Mostrar la columna ID si estaba oculta
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Artista nuevoArtista = new Artista
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Nacionalidad = txtNacionalidad.Text
            };

            bool resultado = new ArtistaDAL().AñadirArtista(nuevoArtista);

            if (resultado)
            {
                MessageBox.Show("Artista añadido exitosamente.");
                LimpiarCampos();
                CargarArtistas();
            }
            else
            {
                MessageBox.Show("Error al añadir el artista.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewArtistas.CurrentRow != null)
            {
                int artistaId = (int)dataGridViewArtistas.CurrentRow.Cells["ArtistaId"].Value;

                Artista artista = new Artista
                {
                    ArtistaId = artistaId,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Nacionalidad = txtNacionalidad.Text
                };

                bool resultado = new ArtistaDAL().ActualizarArtista(artista);

                if (resultado)
                {
                    MessageBox.Show("Artista actualizado exitosamente.");
                    LimpiarCampos();
                    CargarArtistas();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el artista.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewArtistas.CurrentRow != null)
            {
                int artistaId = (int)dataGridViewArtistas.CurrentRow.Cells["ArtistaId"].Value;

                bool resultado = new ArtistaDAL().EliminarArtista(artistaId);

                if (resultado)
                {
                    MessageBox.Show("Artista eliminado exitosamente.");
                    LimpiarCampos();
                    CargarArtistas();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el artista.");
                }
            }
        }

        private void LimpiarCampos()
        {
            txtArtistaId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            txtNacionalidad.Clear();
        }

        private void dataGridViewArtistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
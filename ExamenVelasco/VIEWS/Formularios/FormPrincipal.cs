using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenVelasco.IU.Formularios;
using ExamenVelasco.VIEWS.Formularios;

namespace ExamenVelasco.VIEWS.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_album_Click(object sender, EventArgs e)
        {
            FormAlbum formAlbum = new FormAlbum();
            formAlbum.ShowDialog();


        }

        private void btn_artista_Click(object sender, EventArgs e)
        {
            FormArtista formArtista = new FormArtista();
            formArtista.ShowDialog();
        }
    }
}

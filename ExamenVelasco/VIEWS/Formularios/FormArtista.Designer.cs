namespace ExamenVelasco.IU.Formularios
{
    partial class FormArtista
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblId = new Label();
            txtArtistaId = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblNacionalidad = new Label();
            txtNacionalidad = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridViewArtistas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArtistas).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(13, 13);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            lblId.Visible = false;
            // 
            // txtArtistaId
            // 
            txtArtistaId.Location = new Point(150, 10);
            txtArtistaId.Name = "txtArtistaId";
            txtArtistaId.ReadOnly = true;
            txtArtistaId.Size = new Size(250, 27);
            txtArtistaId.TabIndex = 1;
            txtArtistaId.Visible = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(13, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(13, 90);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(150, 87);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 27);
            txtApellido.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(13, 130);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(128, 20);
            lblFechaNacimiento.TabIndex = 6;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(150, 127);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(13, 170);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(98, 20);
            lblNacionalidad.TabIndex = 8;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(150, 167);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(250, 27);
            txtNacionalidad.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(150, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(240, 210);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 30);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(325, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewArtistas
            // 
            dataGridViewArtistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArtistas.Location = new Point(13, 250);
            dataGridViewArtistas.Name = "dataGridViewArtistas";
            dataGridViewArtistas.RowHeadersWidth = 51;
            dataGridViewArtistas.Size = new Size(698, 188);
            dataGridViewArtistas.TabIndex = 13;
            dataGridViewArtistas.CellContentClick += dataGridViewArtistas_CellContentClick;
            // 
            // FormArtista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(dataGridViewArtistas);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtNacionalidad);
            Controls.Add(lblNacionalidad);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtArtistaId);
            Controls.Add(lblId);
            Name = "FormArtista";
            Text = "FormArtista";
            Load += FormArtista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewArtistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtArtistaId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewArtistas;
    }
}

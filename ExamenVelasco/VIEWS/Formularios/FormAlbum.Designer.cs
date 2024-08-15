namespace ExamenVelasco.IU.Formularios
{
    partial class FormAlbum
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
            this.lblAlbumId = new System.Windows.Forms.Label();
            this.txtAlbumId = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblAnioLanzamiento = new System.Windows.Forms.Label();
            this.nudAnioLanzamiento = new System.Windows.Forms.NumericUpDown();
            this.lblDiscografica = new System.Windows.Forms.Label();
            this.txtDiscografica = new System.Windows.Forms.TextBox();
            this.lblArtistaId = new System.Windows.Forms.Label();
            this.cmbArtistaId = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewAlbumes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioLanzamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbumes)).BeginInit();
            this.SuspendLayout();

            // lblAlbumId
            this.lblAlbumId.AutoSize = true;
            this.lblAlbumId.Location = new System.Drawing.Point(13, 13);
            this.lblAlbumId.Name = "lblAlbumId";
            this.lblAlbumId.Size = new System.Drawing.Size(63, 20);
            this.lblAlbumId.TabIndex = 0;
            this.lblAlbumId.Text = "Album ID";
            this.lblAlbumId.Visible = false;

            // txtAlbumId
            this.txtAlbumId.Location = new System.Drawing.Point(150, 10);
            this.txtAlbumId.Name = "txtAlbumId";
            this.txtAlbumId.ReadOnly = true;
            this.txtAlbumId.Size = new System.Drawing.Size(250, 27);
            this.txtAlbumId.TabIndex = 1;
            this.txtAlbumId.Visible = false;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(13, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título";

            // txtTitulo
            this.txtTitulo.Location = new System.Drawing.Point(150, 47);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(250, 27);
            this.txtTitulo.TabIndex = 3;

            // lblGenero
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(13, 90);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(60, 20);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Género";

            // txtGenero
            this.txtGenero.Location = new System.Drawing.Point(150, 87);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(250, 27);
            this.txtGenero.TabIndex = 5;

            // lblAnioLanzamiento
            this.lblAnioLanzamiento.AutoSize = true;
            this.lblAnioLanzamiento.Location = new System.Drawing.Point(13, 130);
            this.lblAnioLanzamiento.Name = "lblAnioLanzamiento";
            this.lblAnioLanzamiento.Size = new System.Drawing.Size(131, 20);
            this.lblAnioLanzamiento.TabIndex = 6;
            this.lblAnioLanzamiento.Text = "Año Lanzamiento";

            // nudAnioLanzamiento
            this.nudAnioLanzamiento.Location = new System.Drawing.Point(150, 127);
            this.nudAnioLanzamiento.Maximum = 3000;
            this.nudAnioLanzamiento.Minimum = 1800;
            this.nudAnioLanzamiento.Name = "nudAnioLanzamiento";
            this.nudAnioLanzamiento.Size = new System.Drawing.Size(250, 27);
            this.nudAnioLanzamiento.TabIndex = 7;

            // lblDiscografica
            this.lblDiscografica.AutoSize = true;
            this.lblDiscografica.Location = new System.Drawing.Point(13, 170);
            this.lblDiscografica.Name = "lblDiscografica";
            this.lblDiscografica.Size = new System.Drawing.Size(92, 20);
            this.lblDiscografica.TabIndex = 8;
            this.lblDiscografica.Text = "Discográfica";

            // txtDiscografica
            this.txtDiscografica.Location = new System.Drawing.Point(150, 167);
            this.txtDiscografica.Name = "txtDiscografica";
            this.txtDiscografica.Size = new System.Drawing.Size(250, 27);
            this.txtDiscografica.TabIndex = 9;

            // lblArtistaId
            this.lblArtistaId.AutoSize = true;
            this.lblArtistaId.Location = new System.Drawing.Point(13, 210);
            this.lblArtistaId.Name = "lblArtistaId";
            this.lblArtistaId.Size = new System.Drawing.Size(70, 20);
            this.lblArtistaId.TabIndex = 10;
            this.lblArtistaId.Text = "Artista ID";

            // cmbArtistaId
            this.cmbArtistaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArtistaId.FormattingEnabled = true;
            this.cmbArtistaId.Location = new System.Drawing.Point(150, 207);
            this.cmbArtistaId.Name = "cmbArtistaId";
            this.cmbArtistaId.Size = new System.Drawing.Size(250, 28);
            this.cmbArtistaId.TabIndex = 11;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(150, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(240, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(325, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // dataGridViewAlbumes
            this.dataGridViewAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlbumes.Location = new System.Drawing.Point(13, 290);
            this.dataGridViewAlbumes.Name = "dataGridViewAlbumes";
            this.dataGridViewAlbumes.RowHeadersWidth = 51;
            this.dataGridViewAlbumes.RowTemplate.Height = 29;
            this.dataGridViewAlbumes.Size = new System.Drawing.Size(387, 188);
            this.dataGridViewAlbumes.TabIndex = 15;

            // FormAlbum
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 500);
            this.Controls.Add(this.dataGridViewAlbumes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbArtistaId);
            this.Controls.Add(this.lblArtistaId);
            this.Controls.Add(this.txtDiscografica);
            this.Controls.Add(this.lblDiscografica);
            this.Controls.Add(this.nudAnioLanzamiento);
            this.Controls.Add(this.lblAnioLanzamiento);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtAlbumId);
            this.Controls.Add(this.lblAlbumId);
            this.Name = "FormAlbum";
            this.Text = "FormAlbum";
            this.Load += new System.EventHandler(this.FormAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioLanzamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbumes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblAlbumId;
        private System.Windows.Forms.TextBox txtAlbumId;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblAnioLanzamiento;
        private System.Windows.Forms.NumericUpDown nudAnioLanzamiento;
        private System.Windows.Forms.Label lblDiscografica;
        private System.Windows.Forms.TextBox txtDiscografica;
        private System.Windows.Forms.Label lblArtistaId;
        private System.Windows.Forms.ComboBox cmbArtistaId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewAlbumes;
    }
}

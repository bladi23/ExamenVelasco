namespace ExamenVelasco.VIEWS.Formularios
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_album = new Button();
            label1 = new Label();
            btn_artista = new Button();
            SuspendLayout();
            // 
            // btn_album
            // 
            btn_album.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_album.Location = new Point(192, 265);
            btn_album.Name = "btn_album";
            btn_album.Size = new Size(116, 45);
            btn_album.TabIndex = 0;
            btn_album.Text = "ÁLBUM";
            btn_album.UseVisualStyleBackColor = true;
            btn_album.Click += btn_album_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 21);
            label1.Name = "label1";
            label1.Size = new Size(304, 40);
            label1.TabIndex = 1;
            label1.Text = "GESTION DE MUSICA";
            // 
            // btn_artista
            // 
            btn_artista.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_artista.Location = new Point(484, 265);
            btn_artista.Name = "btn_artista";
            btn_artista.Size = new Size(130, 45);
            btn_artista.TabIndex = 2;
            btn_artista.Text = "ARTISTA";
            btn_artista.UseVisualStyleBackColor = true;
            btn_artista.Click += btn_artista_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_artista);
            Controls.Add(label1);
            Controls.Add(btn_album);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_album;
        private Label label1;
        private Button btn_artista;
    }
}
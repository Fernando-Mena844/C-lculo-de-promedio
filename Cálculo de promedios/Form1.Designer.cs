namespace Cálculo_de_promedios
{
    partial class frmSistemaDeNotasITR
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistemaDeNotasITR));
            this.gbRegistroNotas = new System.Windows.Forms.GroupBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.gbPromedio = new System.Windows.Forms.GroupBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarPromedio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.gbRegistroNotas.SuspendLayout();
            this.gbPromedio.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegistroNotas
            // 
            this.gbRegistroNotas.Controls.Add(this.pictureBox1);
            this.gbRegistroNotas.Controls.Add(this.txtNota3);
            this.gbRegistroNotas.Controls.Add(this.txtNota2);
            this.gbRegistroNotas.Controls.Add(this.txtNota1);
            this.gbRegistroNotas.Controls.Add(this.lblError);
            this.gbRegistroNotas.Controls.Add(this.lblNota3);
            this.gbRegistroNotas.Controls.Add(this.lblNota2);
            this.gbRegistroNotas.Controls.Add(this.lblNota1);
            this.gbRegistroNotas.Location = new System.Drawing.Point(27, 31);
            this.gbRegistroNotas.Name = "gbRegistroNotas";
            this.gbRegistroNotas.Size = new System.Drawing.Size(419, 236);
            this.gbRegistroNotas.TabIndex = 0;
            this.gbRegistroNotas.TabStop = false;
            this.gbRegistroNotas.Text = "Registro de Notas";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(152, 137);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(160, 20);
            this.txtNota3.TabIndex = 3;
            this.tlpAyuda.SetToolTip(this.txtNota3, "Ingresa valores entre 0 y 10");
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(152, 88);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(160, 20);
            this.txtNota2.TabIndex = 4;
            this.tlpAyuda.SetToolTip(this.txtNota2, "Ingresa valores entre 0 y 10");
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(152, 45);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(160, 20);
            this.txtNota1.TabIndex = 5;
            this.tlpAyuda.SetToolTip(this.txtNota1, "Ingresa valores entre 0 y 10");
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblError.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(3, 209);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(68, 24);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "Error";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(36, 137);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(39, 13);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(36, 88);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(36, 45);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1";
            // 
            // gbPromedio
            // 
            this.gbPromedio.Controls.Add(this.txtPromedio);
            this.gbPromedio.Controls.Add(this.lblPromedio);
            this.gbPromedio.Location = new System.Drawing.Point(27, 322);
            this.gbPromedio.Name = "gbPromedio";
            this.gbPromedio.Size = new System.Drawing.Size(666, 134);
            this.gbPromedio.TabIndex = 1;
            this.gbPromedio.TabStop = false;
            this.gbPromedio.Text = "Promedio";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(152, 83);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(232, 20);
            this.txtPromedio.TabIndex = 5;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(36, 83);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(95, 13);
            this.lblPromedio.TabIndex = 0;
            this.lblPromedio.Text = "Promedio obtenido";
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnSalir);
            this.gbAcciones.Controls.Add(this.btnAgregarPromedio);
            this.gbAcciones.Controls.Add(this.btnNuevoRegistro);
            this.gbAcciones.Location = new System.Drawing.Point(461, 40);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(232, 227);
            this.gbAcciones.TabIndex = 0;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Image = global::Cálculo_de_promedios.Properties.Resources.icons8_escoba_48;
            this.btnNuevoRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(12, 94);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(198, 47);
            this.btnNuevoRegistro.TabIndex = 3;
            this.btnNuevoRegistro.Text = "Nuevo Registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Cálculo_de_promedios.Properties.Resources.icons8_cerrar_ventana_32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(12, 159);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(198, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPromedio
            // 
            this.btnAgregarPromedio.Image = global::Cálculo_de_promedios.Properties.Resources.icons8_añadir_usuario_masculino_32;
            this.btnAgregarPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPromedio.Location = new System.Drawing.Point(12, 36);
            this.btnAgregarPromedio.Name = "btnAgregarPromedio";
            this.btnAgregarPromedio.Size = new System.Drawing.Size(198, 41);
            this.btnAgregarPromedio.TabIndex = 3;
            this.btnAgregarPromedio.Text = "Agregar Promedio";
            this.btnAgregarPromedio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cálculo_de_promedios.Properties.Resources.icons8_usuario_100;
            this.pictureBox1.Location = new System.Drawing.Point(329, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tlpAyuda
            // 
            this.tlpAyuda.IsBalloon = true;
            this.tlpAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpAyuda.ToolTipTitle = "Mensaje de Ayuda";
            // 
            // frmSistemaDeNotasITR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 483);
            this.Controls.Add(this.gbPromedio);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbRegistroNotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSistemaDeNotasITR";
            this.Text = "Sistema de Notas ITR";
            this.gbRegistroNotas.ResumeLayout(false);
            this.gbRegistroNotas.PerformLayout();
            this.gbPromedio.ResumeLayout(false);
            this.gbPromedio.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistroNotas;
        private System.Windows.Forms.GroupBox gbPromedio;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarPromedio;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpAyuda;
    }
}


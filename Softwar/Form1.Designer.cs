namespace Softwar
{
    partial class Form1
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
            this.picLogoFup = new System.Windows.Forms.PictureBox();
            this.lblFup = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.lblCtrl = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.txtCtrl = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFup)).BeginInit();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogoFup
            // 
            this.picLogoFup.Image = global::Softwar.Properties.Resources.FUP;
            this.picLogoFup.Location = new System.Drawing.Point(0, 0);
            this.picLogoFup.Name = "picLogoFup";
            this.picLogoFup.Size = new System.Drawing.Size(184, 146);
            this.picLogoFup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoFup.TabIndex = 0;
            this.picLogoFup.TabStop = false;
            // 
            // lblFup
            // 
            this.lblFup.AutoSize = true;
            this.lblFup.Location = new System.Drawing.Point(303, 20);
            this.lblFup.Name = "lblFup";
            this.lblFup.Size = new System.Drawing.Size(341, 20);
            this.lblFup.TabIndex = 2;
            this.lblFup.Text = "FUNDACION UNIVERSITARIA DE POPAYAN";
            this.lblFup.Click += new System.EventHandler(this.label2_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.lblSemestre);
            this.grbDatos.Controls.Add(this.cboSemestre);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.lblCtrl);
            this.grbDatos.Controls.Add(this.txtCtrl);
            this.grbDatos.Location = new System.Drawing.Point(25, 231);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(377, 207);
            this.grbDatos.TabIndex = 3;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            this.grbDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCtrl
            // 
            this.lblCtrl.AutoSize = true;
            this.lblCtrl.Location = new System.Drawing.Point(23, 44);
            this.lblCtrl.Name = "lblCtrl";
            this.lblCtrl.Size = new System.Drawing.Size(57, 20);
            this.lblCtrl.TabIndex = 4;
            this.lblCtrl.Text = "No.Ctrl";
            this.lblCtrl.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(23, 145);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(78, 20);
            this.lblSemestre.TabIndex = 6;
            this.lblSemestre.Text = "Semestre";
            // 
            // txtCtrl
            // 
            this.txtCtrl.Location = new System.Drawing.Point(122, 41);
            this.txtCtrl.Name = "txtCtrl";
            this.txtCtrl.Size = new System.Drawing.Size(153, 26);
            this.txtCtrl.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // cboSemestre
            // 
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Items.AddRange(new object[] {
            "Ing Sistemas",
            "Arquitectura",
            "Derecho",
            "Ing Industrial",
            "Trabajo Social ",
            "Ecologia",
            "Psicologia",
            "Administracion De Empresas",
            "Adminin Empresas Agropecuarias ",
            "Contaduria",
            "Licenciatura"});
            this.cboSemestre.Location = new System.Drawing.Point(122, 142);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(98, 28);
            this.cboSemestre.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(892, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 52);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(12, 152);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(146, 41);
            this.btnCargarFoto.TabIndex = 5;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.lblFup);
            this.Controls.Add(this.picLogoFup);
            this.Name = "Form1";
            this.Text = "ALUMNOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFup)).EndInit();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoFup;
        private System.Windows.Forms.Label lblFup;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCtrl;
        private System.Windows.Forms.TextBox txtCtrl;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarFoto;
    }
}


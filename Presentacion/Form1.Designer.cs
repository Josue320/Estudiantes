
namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombres = new System.Windows.Forms.Label();
            this.Apellidos = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(48, 33);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(56, 15);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres";
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSize = true;
            this.Apellidos.Location = new System.Drawing.Point(48, 76);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(56, 15);
            this.Apellidos.TabIndex = 1;
            this.Apellidos.Text = "Apellidos";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(48, 118);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(42, 15);
            this.lblCarnet.TabIndex = 2;
            this.lblCarnet.Text = "Carnet";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(48, 168);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(48, 209);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(48, 255);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(43, 15);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(140, 30);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(251, 23);
            this.txtNombres.TabIndex = 7;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(140, 73);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(251, 23);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(140, 115);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(154, 23);
            this.txtCarnet.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(140, 165);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(154, 23);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(140, 206);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(251, 23);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(140, 252);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(220, 23);
            this.txtCorreo.TabIndex = 12;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(419, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.Size = new System.Drawing.Size(359, 395);
            this.dgvDatos.TabIndex = 13;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(48, 326);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 27);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.lblNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label Apellidos;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnCrear;
    }
}


using AppCore.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private IEstudianteService estudianteService;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Estudiante asset = new Estudiante()
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Carnet = txtCarnet.Text,
                Phone = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Correo = txtCorreo.Text
            };

            estudianteService.Create(asset);
        }
    }
}

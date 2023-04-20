using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProy24
{
    public partial class frmagregar : Form
    {
        public frmagregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            curso nuevocurso = new curso();
            nuevocurso.Nombre = txtnombre.Text;
            nuevocurso.Descripcion = txtdescripcion.Text;
            nuevocurso.Duracion = Convert.ToInt32(medduracion.Text);
            nuevocurso.idsede = Convert.ToInt32(cmbsedes.ValueMember);//revisar esta linea

            conexion objconexion = new conexion();
            int resultado = objconexion.CursoInsertar(nuevocurso);
            if (resultado == 1)
                MessageBox.Show("Se insertó correctamente");
            else
                MessageBox.Show("No se pudo insertar el registro");
            this.Close();
        }

        private void frmagregar_Load(object sender, EventArgs e)
        {
            conexion objconexion = new conexion();
            cmbsedes.DataSource = objconexion.SedesLista();
            cmbsedes.DisplayMember = "nombresede";
            cmbsedes.ValueMember = "idsede";
        }
    }
}

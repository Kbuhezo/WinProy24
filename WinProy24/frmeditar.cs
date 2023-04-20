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
    public partial class frmeditar : Form
    {
        public frmeditar()
        {
            InitializeComponent();
        }

        private void frmeditar_Load(object sender, EventArgs e)
        {

        }
        public void CargarCursoLlenado(curso cursollenado)
        {
            txtidcurso.Text = cursollenado.idcurso.ToString();
            txtnombre.Text = cursollenado.Nombre;
            txtdescripcion.Text = cursollenado.Descripcion;
            medduracion.Text = cursollenado.Duracion.ToString();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            curso editcurso = new curso();
            editcurso.idcurso = Convert.ToInt32(txtidcurso.Text);
            editcurso.Nombre = txtnombre.Text;
            editcurso.Descripcion = txtdescripcion.Text;
            editcurso.Duracion = Convert.ToInt32(medduracion.Text);

            conexion objconexion = new conexion();
            int resultado = objconexion.CursoEditar(editcurso);
            
            if (resultado == 1)
                MessageBox.Show("Editado correctamente");
            else
                MessageBox.Show("No se pudo editar el registro");
            this.Close();
        }
    }
}

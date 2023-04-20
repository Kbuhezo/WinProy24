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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            CargarLista();
        }
        private void CargarLista()
        {
            conexion objconexion = new conexion();
            datos.DataSource = objconexion.CursoListar();

        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            frmagregar frm = new frmagregar();
            frm.ShowDialog();
            CargarLista();
        }
        private curso LlenarCurso()
        {
            curso CursoLlenado = new curso();
            CursoLlenado.idcurso = Convert.ToInt32(datos.SelectedRows[0].Cells["Idcurso"].Value.ToString());
            CursoLlenado.Nombre = datos.SelectedRows[0].Cells["Nombre"].Value.ToString();
            CursoLlenado.Duracion = Convert.ToInt32(datos.SelectedRows[0].Cells["Duracion"].Value.ToString());
            CursoLlenado.Descripcion = datos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            return CursoLlenado;
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            frmeditar frm = new frmeditar();
            frm.CargarCursoLlenado(LlenarCurso());
            frm.ShowDialog();
            CargarLista();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirma;
            confirma = MessageBox.Show("Eliminar registro?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirma==DialogResult.Yes)
            {
                int idcurso = Convert.ToInt32(datos.SelectedRows[0].Cells["idcurso"].Value.ToString());
                conexion objconexion = new conexion();
                int resultado = objconexion.CursoEliminar(idcurso);

                if (resultado == 1)
                    MessageBox.Show("Curso eliminado");
                else
                    MessageBox.Show("Curso no se pudo eliminar");
                CargarLista();
            }
        }
    }
}

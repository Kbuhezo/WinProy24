using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinProy24
{
    public class curso
    {
        private string _Nombre;//con guion abajo es una variable de control
        private int _Duracion;
        private string _varDescripcion;
        private int _idsede;

        public int idcurso {get; set;}

        public string Nombre { 
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public int Duracion {
            get { return _Duracion; }
            set { _Duracion = value; }
        }
        public string Descripcion {
            get { return _varDescripcion; }
            set { _varDescripcion = value; }
        }

        public int idsede
        {
            get { return _idsede; }
            set { _idsede = value; }
        }
    }
}

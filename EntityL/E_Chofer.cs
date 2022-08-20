using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityL
{
    public class E_Chofer
    {

        private int    _ID;
        private string _Nombre;
        private string _Apellido;
        private string _BirthFecha;
        private string _Cedula;

        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string BirthFecha { get => _BirthFecha; set => _BirthFecha = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
    }
}

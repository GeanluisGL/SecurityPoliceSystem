using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityL
{
    public class E_Route
    {

        private int _ID_Ruta;
        private string _RUTA;
        private string _Distance;

        public int ID_Ruta { get => _ID_Ruta; set => _ID_Ruta = value; }
        public string RUTA { get => _RUTA; set => _RUTA = value; }
        public string Distance { get => _Distance; set => _Distance = value; }
    }
}

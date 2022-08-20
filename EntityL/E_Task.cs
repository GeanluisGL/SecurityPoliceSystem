using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityL
{
    public class E_Task
    {

        private int _ID;
        private string _ID_CHOFER;
        private string _ID_BUS;
        private string _ID_RUTA;
        private int _CHOFER;
        private int _RUTA;

        public int ID { get => _ID; set => _ID = value; }
        public string ID_CHOFER { get => _ID_CHOFER; set => _ID_CHOFER = value; }
        public string ID_BUS { get => _ID_BUS; set => _ID_BUS = value; }
        public string ID_RUTA { get => _ID_RUTA; set => _ID_RUTA = value; }
        public int CHOFER { get => _CHOFER; set => _CHOFER = value; }
        public int RUTA { get => _RUTA; set => _RUTA = value; }


    }
}

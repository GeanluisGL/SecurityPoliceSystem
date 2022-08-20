using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityL
{
    public class E_Bus
    {

        private string _PLACA;
        private string _MARCA;
        private string _MODELO;
        private string _COLOR;
        private string _YIAR;

        public string PLACA { get => _PLACA; set => _PLACA = value; }
        public string MARCA { get => _MARCA; set => _MARCA = value; }
        public string MODELO { get => _MODELO; set => _MODELO = value; }
        public string COLOR { get => _COLOR; set => _COLOR = value; }
        public string YIAR { get => _YIAR; set => _YIAR = value; }
    }
}

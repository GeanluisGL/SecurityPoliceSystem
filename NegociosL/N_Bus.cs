using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosL;
using EntityL;

namespace NegociosL
{
    public class N_Bus
    {
        public List<E_Bus> ListarBus(string buscar)
        {
            D_Bus ObjDato = new D_Bus();
            return ObjDato.ListarBus(buscar);
        }

        public void insertusB(E_Bus e_Bus)
        {
            D_Bus ObjDato = new D_Bus();
            ObjDato.insertB(e_Bus);
        }

        public void updateB(E_Bus e_Bus)
        {
            D_Bus ObjDato = new D_Bus();
            ObjDato.updateB(e_Bus);
        }

        public void Showlist()
        {
            D_Bus ObjDato = new D_Bus();
            ObjDato.Showlist();
        }

        public void deleteB(E_Bus e_Bus)
        {
            D_Bus ObjDato = new D_Bus();
            ObjDato.deleteB(e_Bus);
        }
    }
}

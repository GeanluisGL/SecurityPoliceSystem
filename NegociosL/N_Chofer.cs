using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityL;
using DatosL;


namespace NegociosL
{
    public class N_Chofer
    {

        public List<E_Chofer> ListarChofer(string buscar)
        {
            D_Chofer objDato = new D_Chofer();
            return objDato.ListarChofer(buscar);
        }

        public void insert(E_Chofer _Chofer)
        {
            D_Chofer ObjDato = new D_Chofer();
            ObjDato.insertC(_Chofer);
        }

        public void Update(E_Chofer _Chofer)
        {
            D_Chofer ObjDato = new D_Chofer();
            ObjDato.updateC(_Chofer);
        }


        public void Delete(E_Chofer _Chofer)
        {
            D_Chofer ObjDato = new D_Chofer();
            ObjDato.delete(_Chofer);

        }

        public void Showlist()
        {
            D_Chofer ObjDato = new D_Chofer();
            ObjDato.Showlist();
        }
    }
}

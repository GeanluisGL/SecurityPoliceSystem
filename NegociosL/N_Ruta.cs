using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityL;
using DatosL;

namespace NegociosL
{
    public class N_Ruta
    {

        public List<E_Route> ListRuta(string buscar)
        { 
   
           D_Rutas objDato = new D_Rutas();
           return  objDato.ListarRutas(buscar);

        }


        public void insertar(E_Route _Route)
        {
            D_Rutas objDato = new D_Rutas();
            objDato.insertR(_Route);
        }

        public void updateR(E_Route _Route)
        {
            D_Rutas objDato = new D_Rutas();
            objDato.update(_Route);
        }

        public void DeleteR(E_Route _Route)
        {
            D_Rutas objDato = new D_Rutas();
            objDato.DeleteRoute(_Route);
        }

        public void Showlist()
        {
            D_Rutas objDato = new D_Rutas();
            objDato.Showlist();   
        }
    }
}

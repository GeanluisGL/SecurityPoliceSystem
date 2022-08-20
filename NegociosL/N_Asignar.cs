using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityL;
using DatosL;

namespace NegociosL
{
    public class N_Asignar
    {

        public List<E_Task> ListViajes(string buscar)
        {

            D_Task objDato = new D_Task();
            return objDato.ListarViajes(buscar);

        }

        public DataTable ChoferCom()
        {
            D_Task objDato = new D_Task();
            return objDato.ChoferCom();

        }

        public DataTable BusCom()
        {
            D_Task objDato = new D_Task();
            return objDato.BusCom();

        }

        public DataTable RutarCom()
        {
            D_Task objDato = new D_Task();
            return objDato.RutaCom();

        }

        public void insertTV(E_Task e_Task)
        {
            D_Task objDato = new D_Task();
            objDato.insertT(e_Task);
        }

        public void updateTV(E_Task _Task)
        {

            D_Task objDato = new D_Task();
            objDato.updateT(_Task);
        }

        public void DeleteTV(E_Task _Task)
        {

            D_Task objDato = new D_Task();
            objDato.DeleteT(_Task);
        }

        public void Showlist()
        {
            D_Task objDato = new D_Task();
            objDato.Showlist();
        }

    }
}

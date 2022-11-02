using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Logica
{
    public class ServicioDetectives
    {
        RepositorioDetectives repositorio = new RepositorioDetectives();
        

        public DataTable Listardetectives()
        {
            return repositorio.ListarDetectives();

        }


        public DataTable Buscardetective(Detective obj)
        {


            return repositorio.BuscarDetective(obj);

        }


        public string Mantenimientodetective(Detective obj) {

            return repositorio.Mantenimientodedetective(obj);
        
        
        }









    }
}

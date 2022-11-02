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
    public class ServicioSospechosos
    {

        RepositorioSospechosos repositorio = new RepositorioSospechosos();


        public DataTable Listarsospechosos()
        {
            return repositorio.ListarSospechosos();

        }


        public DataTable BuscarSospechoso(Sospechoso obj)
        {


            return repositorio.BuscarSospechoso(obj);

        }


        public string Mantenimientosospechoso(Sospechoso obj)
        {

            return repositorio.Mantenimientodesospechoso(obj);


        }









    }
}

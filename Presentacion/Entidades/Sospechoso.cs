using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sospechoso:Persona
    {


        public Sospechoso()
        {

        }






        public string Alias { get; set; }
        public int Edad { get; set; }
        public int NoVivienda { get; set; }
        public string Localidad { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        
        public string Descripcion { get; set; }

        //bool Fotografia { get; set; }

        public string accion { get; set; }











    }
}

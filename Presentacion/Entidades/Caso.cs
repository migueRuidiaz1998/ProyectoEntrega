using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Caso
    {


        public string IdCaso { get; set; }
        public string NombreClave { get; set; }
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }

        public Detective detective { get; set; }

        public Sospechoso sospechoso { get; set; }

        public Caso()
        {
            
            this.detective = new Detective();
            this.sospechoso = new Sospechoso();
        }





    }
}

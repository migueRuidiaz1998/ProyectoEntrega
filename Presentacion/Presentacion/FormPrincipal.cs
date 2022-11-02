using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BotonDetectives_Click(object sender, EventArgs e)
        {
            FormDetectives detective1 = new FormDetectives();
            detective1.ShowDialog();
            
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonSospechosos_Click(object sender, EventArgs e)
        {
            FormSospechosos sospechoso1 = new FormSospechosos();
            sospechoso1.ShowDialog();



        }



    }
}

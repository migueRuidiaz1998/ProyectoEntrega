using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;
using Logica;


namespace Presentacion
{
    public partial class FormSospechosos : Form
    {



        Sospechoso sos = new Sospechoso();
        ServicioSospechosos servi = new ServicioSospechosos();




        public FormSospechosos()
        {
            InitializeComponent();
        }




        //Metododos


        void Guardar(string accion)
        {
            sos.Identificacion = textBoxIdentificacion.Text;
            sos.Nombres = textBoxNombres.Text;
            sos.Apellidos = textBoxApellidos.Text;
            sos.Alias = textBoxAlias.Text;
            sos.Edad = int.Parse(textBoxEdad.Text);
            sos.NoVivienda= int.Parse(textBoxNoCasa.Text);
            sos.Localidad = textBoxLocalidad.Text;

            sos.Ciudad = textBoxCiudad.Text;
            sos.Departamento = textBoxDepartamento.Text;
            sos.Pais = textBoxPais.Text;
            sos.Descripcion = textBoxDescripcion.Text;
            



            sos.accion = accion;
            string men = servi.Mantenimientosospechoso(sos);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }


        void limpiar()
        {
            textBoxIdentificacion.Text = "";
            textBoxNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxAlias.Text = "";
            textBoxEdad.Text = "";
            textBoxNoCasa.Text = "";
            textBoxLocalidad.Text = "";
            textBoxCiudad.Text = "";
            textBoxDepartamento.Text = "";
            textBoxPais.Text = "";
            textBoxDescripcion.Text= "";
            dataGridView1.DataSource = servi.Listarsospechosos();
            //comboBoxTiposDeCasos.Text = "[Seleccione]";

        }








        //Botones
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void buttonAgregrar_Click(object sender, EventArgs e)
        {
            Guardar("1");
            limpiar();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxIdentificacion.Text != "")
            {
                if (MessageBox.Show("Deseas editar a " + textBoxIdentificacion.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Guardar("2");
                    limpiar();
                }


            }


        }

        
       

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (textBoxIdentificacion.Text != "")
            {
                if (MessageBox.Show("Deseas elimiar a " + textBoxIdentificacion.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Guardar("3");
                    limpiar();
                }


            }
        }

        private void FormSospechosos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servi.Listarsospechosos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            textBoxIdentificacion.Text = dataGridView1[0, fila].Value.ToString();
            textBoxNombres.Text = dataGridView1[1, fila].Value.ToString();
            textBoxApellidos.Text = dataGridView1[2, fila].Value.ToString();
            textBoxAlias.Text = dataGridView1[3, fila].Value.ToString();
            textBoxEdad.Text = dataGridView1[4, fila].Value.ToString();
            textBoxNoCasa.Text = dataGridView1[5, fila].Value.ToString();
            textBoxLocalidad.Text = dataGridView1[6, fila].Value.ToString();
            textBoxCiudad.Text = dataGridView1[7, fila].Value.ToString();
            textBoxDepartamento.Text = dataGridView1[8, fila].Value.ToString();
            textBoxPais.Text = dataGridView1[9, fila].Value.ToString();
            textBoxDescripcion.Text = dataGridView1[10, fila].Value.ToString();


        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != "")
            {
                sos.Nombres = textBoxBuscar.Text;
                DataTable dt = new DataTable();
                dt = servi.BuscarSospechoso(sos);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = servi.Listarsospechosos();
            }

        }

        private void textBoxIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Solonumeros(e);
        }

        private void textBoxNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Sololetras(e);
        }

        private void textBoxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Sololetras(e);
        }

        private void textBoxAlias_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Sololetras(e);
        }

        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Solonumeros(e);
        }

        private void textBoxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Sololetras(e);
        }

        private void textBoxNoCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Solonumeros(e);
        }

        private void textBoxLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Sololetras(e);
        }

        private void textBoxCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Sololetras(e);
        }

        private void textBoxDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Sololetras(e);
        }

        private void textBoxPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Sololetras(e);
        }

        private void textBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Sololetras(e);
        }

        
    }
}

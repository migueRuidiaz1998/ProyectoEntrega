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
    public partial class FormDetectives : Form
    {
        Detective det = new Detective();
        ServicioDetectives servic = new ServicioDetectives();


        public FormDetectives()
        {
            InitializeComponent();
            comboBoxTiposDeCasos.DropDownStyle = ComboBoxStyle.DropDownList;


        }




        //Botones

        private void buttonAgregar_Click(object sender, EventArgs e)
        {



            Guardar("1");
            limpiar();


        }






        //Metodosdfd


        void Guardar(string accion)
        {
            det.Identificacion = textBoxIdentificacion.Text;
            det.Nombres = textBoxNombres.Text;
            det.Apellidos = textBoxApellidos.Text;
            det.AñosDeExperiencia = int.Parse(textBoxExperiencia.Text);
            det.TipoCaso = comboBoxTiposDeCasos.Text;

            det.accion = accion;
            string men = servic.Mantenimientodetective(det);
            MessageBox.Show(men, "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);




        }


        


            void limpiar()
        {
            textBoxIdentificacion.Text = "";
            textBoxNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxExperiencia.Text = "";
            comboBoxTiposDeCasos.Text = "";


            dataGridView1.DataSource = servic.Listardetectives();
            //comboBoxTiposDeCasos.Text = "[Seleccione]";

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetectives_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servic.Listardetectives();
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

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            textBoxIdentificacion.Text = dataGridView1[0, fila].Value.ToString();
            textBoxNombres.Text = dataGridView1[1, fila].Value.ToString();
            textBoxApellidos.Text = dataGridView1[2, fila].Value.ToString();
            textBoxExperiencia.Text = dataGridView1[3, fila].Value.ToString();
            comboBoxTiposDeCasos.Text = dataGridView1[4, fila].Value.ToString();





        }



        //Eventos KeyPres




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

        private void textBoxExperiencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajastxt.Solonumeros(e);
        }

       
    }
}
   

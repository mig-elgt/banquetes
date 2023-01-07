using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionadorDeEventos
{
    public partial class FEmpleados : Form
    {
        private CQuery sql;
        private List<string> datos;
        private DataSet empleados;

        public FEmpleados()
        {
            InitializeComponent();
            sql = new CQuery("Empleado", 0);
        }

        private void closeVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void altaEmpleado_Click(object sender, EventArgs e)
        {
            datos = new List<string>();

            datos.Add(cbTipoEmpleado.SelectedItem.ToString());
            datos.Add(cbTipoEmpleado.SelectedIndex.ToString());
            datos.Add("'" + txtNombre.Text + "'");
            datos.Add("'" + txtApellidoPaterno.Text + "'");
            datos.Add("'" + txtApellidoMaterno.Text + "'");

            if(cbTipoEmpleado.SelectedIndex == 2)
                datos.Add("'" + dateFechaNacimiento.Value.ToString("yyy/MM/dd") + "'");
            else
                datos.Add("'" + dateFechaNacimiento.Value.ToString("MM/dd/yyy") + "'");
            
            datos.Add("'" + txtDireccion.Text + "'");
            datos.Add("'" + txtTelefono.Text + "'");
            datos.Add("'" + txtEmail.Text + "'");
            
            if (cbTipoEmpleado.SelectedIndex == 2)
                datos.Add("'" + dateFechaIngreso.Value.ToString("yyy/MM/dd") + "'");
            else
                datos.Add("'" + dateFechaIngreso.Value.ToString("MM/dd/yyyy") + "'");

            //1 : Operacion de Insercíón.
            sql.ExecuteQuery(datos, 1);
            mostrarEmpleados();
            limpiarControles();
        }

        //Este método se encarga de leer los clientes de todos los sitios y mostrarlos en el datagrid
        private void mostrarEmpleados()
        {
            sql.obtenerDatos(dgEmpleados);
            empleados = new DataSet();
            empleados.Tables.Add(sql.getDataQuery());
            
            dgEmpleados.DataSource = empleados.Tables[0];
            dgEmpleados.Columns[0].Visible = false;
            dgEmpleados.Columns[1].Visible = false;
            dgEmpleados.Columns[dgEmpleados.ColumnCount - 1].Visible = false;
        }

        private void FEmpleados_Load(object sender, EventArgs e)
        {
            cbTipoEmpleado.SelectedIndex = 0;
            mostrarEmpleados();
        }

        private void dgEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgEmpleados.CurrentRow;
            int regAct;

            if (reg != null)
            {
                regAct = reg.Index;
                cbTipoEmpleado.SelectedIndex = Convert.ToInt32(dgEmpleados.Rows[regAct].Cells[1].Value);
                txtNombre.Text = dgEmpleados.Rows[regAct].Cells[2].Value.ToString();
                txtApellidoPaterno.Text = dgEmpleados.Rows[regAct].Cells[3].Value.ToString();
                txtApellidoMaterno.Text = dgEmpleados.Rows[regAct].Cells[4].Value.ToString();
                dateFechaNacimiento.Text = dgEmpleados.Rows[regAct].Cells[5].Value.ToString();
                txtDireccion.Text = dgEmpleados.Rows[regAct].Cells[6].Value.ToString();
                txtTelefono.Text = dgEmpleados.Rows[regAct].Cells[7].Value.ToString();
                txtEmail.Text = dgEmpleados.Rows[regAct].Cells[8].Value.ToString();
                dateFechaIngreso.Text = dgEmpleados.Rows[regAct].Cells[9].Value.ToString();
            }
        }

        private void bajaEmpleado_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgEmpleados.CurrentRow;
            int regAct;

            if (reg != null)
            {
                regAct = reg.Index;
                if (MessageBox.Show("Esta seguro de eliminar al empleado " + dgEmpleados.Rows[regAct].Cells[2].Value.ToString(),
                                "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    string tipoCliente = cbTipoEmpleado.SelectedItem.ToString();
                    string id = dgEmpleados.Rows[regAct].Cells[0].Value.ToString();

                    datos = new List<string>();
                    datos.Add(tipoCliente);
                    datos.Add(dgEmpleados.Columns[0].Name);
                    datos.Add(id);
                    sql.ExecuteQuery(datos, 2);
                    mostrarEmpleados();
                    limpiarControles();
                }
            }
        }

        private void txtBuscarName_TextChanged(object sender, EventArgs e)
        {
            empleados.Tables[0].DefaultView.RowFilter = ("nombre like '" + txtBuscarName.Text + "%'");
            dgEmpleados.DataSource = empleados.Tables[0].DefaultView;
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            cbTipoEmpleado.SelectedIndex = 0;
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void modificarEmpleado_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgEmpleados.CurrentRow;
            string llavePrimaria;
            string campoCondicion;

            if (reg != null)
            {
                datos = new List<string>();

                llavePrimaria = reg.Cells[0].Value.ToString();
                campoCondicion = reg.Cells[1].Value.ToString();

                datos.Add(cbTipoEmpleado.SelectedItem.ToString());
                datos.Add(dgEmpleados.Columns[0].Name);
                datos.Add(llavePrimaria);

                datos.Add(dgEmpleados.Columns[1].Name);
                datos.Add(cbTipoEmpleado.SelectedIndex.ToString());

                datos.Add(dgEmpleados.Columns[2].Name);
                datos.Add("'" + txtNombre.Text + "'");

                datos.Add(dgEmpleados.Columns[3].Name);
                datos.Add("'" + txtApellidoPaterno.Text + "'");

                datos.Add(dgEmpleados.Columns[4].Name);
                datos.Add("'" + txtApellidoMaterno.Text + "'");

                datos.Add(dgEmpleados.Columns[5].Name);
                if (cbTipoEmpleado.SelectedIndex == 2)
                    datos.Add("'" + dateFechaNacimiento.Value.ToString("yyy/MM/dd") + "'");
                else
                    datos.Add("'" + dateFechaNacimiento.Value.ToString("MM/dd/yyy") + "'");


                datos.Add(dgEmpleados.Columns[6].Name);
                datos.Add("'" + txtDireccion.Text + "'");

                datos.Add(dgEmpleados.Columns[7].Name);
                datos.Add("'" + txtTelefono.Text + "'");

                datos.Add(dgEmpleados.Columns[8].Name);
                datos.Add("'" + txtEmail.Text + "'");

                datos.Add(dgEmpleados.Columns[9].Name);
                if (cbTipoEmpleado.SelectedIndex == 2)
                    datos.Add("'" + dateFechaNacimiento.Value.ToString("yyy/MM/dd") + "'");
                else
                    datos.Add("'" + dateFechaNacimiento.Value.ToString("MM/dd/yyy") + "'");


                if (campoCondicion.CompareTo(cbTipoEmpleado.SelectedIndex.ToString()) == 0)
                    sql.setTipoUpdate(0);//Update simple
                else
                    sql.setTipoUpdate(1);//Update Optimizado, cuida la integridad referencial 

                sql.setNombreEntidad("Empleado");
                sql.ExecuteQuery(datos, 3);
                mostrarEmpleados();
            }
        }
    }
}

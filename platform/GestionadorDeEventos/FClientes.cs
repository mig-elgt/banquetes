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
    public partial class FClientes : Form
    {
        private CQuery sql;
        private List<String> datos;
        private DataSet clientes;

        public FClientes()
        {
            InitializeComponent();
            sql = new CQuery("Cliente", 0);
        }
        
        private void altaCliente_Click(object sender, EventArgs e)
        {
            datos = new List<string>();

            datos.Add(cbTipoCliente.SelectedItem.ToString());
            
            datos.Add(cbTipoCliente.SelectedIndex.ToString());

            datos.Add("'"+txtNombre.Text+"'");
            datos.Add("'"+txtApellidoPaterno.Text+"'");
            datos.Add("'"+txtApellidoMaterno.Text+"'");
            datos.Add("'"+txtDireccion.Text+"'");
            datos.Add("'"+txtTelefono.Text+"'");
            datos.Add("'"+txtCiudad.Text+"'");
            datos.Add("'"+txtEmail.Text+"'");
            
            //1 : Operacion de Insercíón.
            sql.ExecuteQuery(datos,1);
            mostrarClientes();
            limpiarControles();
        }

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoCliente.SelectedIndex == 0 || cbTipoCliente.SelectedIndex == 1)
            {
                txtApellidoMaterno.Enabled = false;
                txtApellidoPaterno.Enabled = false;
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
            }
            else
            {
                txtApellidoMaterno.Enabled = true;
                txtApellidoPaterno.Enabled = true;
            }
        }
        
        //Este método se encarga de leer los clientes de todos los sitios y mostrarlos en el datagrid
        private void mostrarClientes()
        {
            sql.obtenerDatos(dgClientes);
            clientes = new DataSet();
            clientes.Tables.Add(sql.getDataQuery());
            dgClientes.DataSource = clientes.Tables[0];
            //dgClientes.Columns[0].Visible = false;
            dgClientes.Columns[1].Visible = false;
            dgClientes.Columns[dgClientes.ColumnCount - 1].Visible = false;
        }
       
        private void bajaCliente_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgClientes.CurrentRow;
            int regAct;

            if (reg != null)
            {
                regAct = reg.Index;
                if (MessageBox.Show("Esta seguro de eliminar al cliente " + dgClientes.Rows[regAct].Cells[2].Value.ToString(),
                               "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    string tipoCliente = cbTipoCliente.SelectedItem.ToString();
                    string id = dgClientes.Rows[regAct].Cells[0].Value.ToString();

                    datos = new List<string>();
                    datos.Add(tipoCliente);
                    datos.Add(dgClientes.Columns[0].Name);
                    datos.Add(id);
                    sql.ExecuteQuery(datos, 2);
                    mostrarClientes();
                    limpiarControles();
                }
            }
        }

        private void dgClientes_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgClientes.CurrentRow;
            int regAct;
            
            if(reg != null)
            {
                regAct = reg.Index;
                cbTipoCliente.SelectedIndex = Convert.ToInt32(dgClientes.Rows[regAct].Cells[1].Value);
                txtNombre.Text = dgClientes.Rows[regAct].Cells[2].Value.ToString();
                txtApellidoPaterno.Text = dgClientes.Rows[regAct].Cells[3].Value.ToString();
                txtApellidoMaterno.Text = dgClientes.Rows[regAct].Cells[4].Value.ToString();
                txtDireccion.Text = dgClientes.Rows[regAct].Cells[5].Value.ToString();
                txtTelefono.Text = dgClientes.Rows[regAct].Cells[6].Value.ToString();
                txtCiudad.Text = dgClientes.Rows[regAct].Cells[7].Value.ToString();
                txtEmail.Text = dgClientes.Rows[regAct].Cells[8].Value.ToString();
            }
        }

        private void txtBuscarName_TextChanged(object sender, EventArgs e)
        {
            clientes.Tables[0].DefaultView.RowFilter = ("nombre like '" + txtBuscarName.Text + "%'");
            dgClientes.DataSource = clientes.Tables[0].DefaultView;
        }

        private void load(object sender, EventArgs e)
        {
            cbTipoCliente.SelectedIndex = 0;
            mostrarClientes();
        }

        private void closeVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsLimpiarText_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            cbTipoCliente.SelectedIndex = 0;
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCiudad.Text = "";
            txtEmail.Text = "";
        }

        private void modificarCliente_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg =dgClientes.CurrentRow;
            string llavePrimaria;
            string campoCondicion;
            List<string> Ent = new List<string>();

            if (reg != null)
            {
                datos = new List<string>();

                llavePrimaria = reg.Cells[0].Value.ToString();
                campoCondicion = reg.Cells[1].Value.ToString();

                datos.Add(cbTipoCliente.SelectedItem.ToString());
                datos.Add(dgClientes.Columns[0].Name);
                datos.Add(llavePrimaria);

                datos.Add(dgClientes.Columns[1].Name);
                datos.Add(cbTipoCliente.SelectedIndex.ToString());

                datos.Add(dgClientes.Columns[2].Name);
                datos.Add("'"+txtNombre.Text+"'");

                datos.Add(dgClientes.Columns[3].Name);
                datos.Add("'"+txtApellidoPaterno.Text+"'");

                datos.Add(dgClientes.Columns[4].Name);
                datos.Add("'"+txtApellidoMaterno.Text+"'");

                datos.Add(dgClientes.Columns[5].Name);
                datos.Add("'" + txtDireccion.Text + "'");

                datos.Add(dgClientes.Columns[6].Name);
                datos.Add("'" + txtTelefono.Text + "'");

                datos.Add(dgClientes.Columns[7].Name);
                datos.Add("'" + txtCiudad.Text + "'");

                datos.Add(dgClientes.Columns[8].Name);
                datos.Add("'" + txtEmail.Text + "'");

                if (campoCondicion.CompareTo(cbTipoCliente.SelectedIndex.ToString()) == 0)
                    sql.setTipoUpdate(0);//Update simple
                else
                {
                    sql.setTipoUpdate(1);//Update Optimizado, cuida la integridad referencial 
                    sql.setCampoCondicionAnt(cbTipoCliente.Items[Convert.ToInt32(campoCondicion)].ToString());
                    sql.setCampoCondicionNew(cbTipoCliente.SelectedItem.ToString());
                    Ent.Add("Evento");
                    sql.setEntidades(Ent);
                    sql.setNameLlavePrimaria(dgClientes.Columns[0].Name);
                }

                sql.setNombreEntidad("Cliente");
                sql.ExecuteQuery(datos, 3);
                sql.setNombreEntidad("Cliente");
                mostrarClientes();
            }
        }
    }
}

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
    public partial class FEmpleadosEvento : Form
    {
        private DataSet empleados;
        private CQuery sql;
        
        public FEmpleadosEvento(string cod, string fecha)
        {
            InitializeComponent();
            sql = new CQuery("Empleado", 0);

            txtCodigoEvento.Text = cod;
            fechaEvento.Text = fecha;
        }

        private void FEmpleadosEvento_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
        }

        private void bloquearEmpleados()
        {
            CQuery qry = new CQuery("Empleado_X_Evento", 0);
            DataTable T;

            qry.obtenerDatos(null);
            T = qry.getDataQuery();

            for (int i = 0; i < T.Rows.Count; i++)
            {
                string idEmp = T.Rows[i].ItemArray[1].ToString();
                
                if (txtCodigoEvento.Text.CompareTo(T.Rows[i].ItemArray[0].ToString()) == 0)
                {
                    for (int reg = 0; reg < dgEmpleados.Rows.Count; reg++)
                        if (idEmp.CompareTo(dgEmpleados.Rows[reg].Cells[0].Value.ToString()) == 0)
                        {
                            dgEmpleados.Rows[reg].DefaultCellStyle.BackColor = Color.DarkGray;
                            break;
                        }
                }
            }
        }

        private void mostrarEmpleados()
        {
            sql.obtenerDatos(dgEmpleados);
            empleados = new DataSet();
            empleados.Tables.Add(sql.getDataQuery());
            dgEmpleados.DataSource = empleados.Tables[0];
            dgEmpleados.Columns[1].Visible = false;
            dgEmpleados.Columns[5].Visible = false;
            dgEmpleados.Columns[6].Visible = false;
            dgEmpleados.Columns[7].Visible = false;
            dgEmpleados.Columns[8].Visible = false;
            dgEmpleados.Columns[9].Visible = false;
            
            bloquearEmpleados();
        }

        private void closeVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void altaEmpleado_Click(object sender, EventArgs e)
        {
            List<string> datos;
            datos = new List<string>();

            DataGridViewRow regEmp =  dgEmpleados.CurrentRow;
            sql.setNombreEntidad("Empleado_X_Evento");

            if (regEmp != null)
            {
                if (regEmp.DefaultCellStyle.BackColor != Color.DarkGray)
                {
                    datos.Add(txtCodigoEvento.Text);
                    datos.Add(regEmp.Cells[0].Value.ToString());
                    sql.ExecuteQuery(datos, 1);
                    sql.setNombreEntidad("Empleado");
                    mostrarEmpleados();
                }
                else
                    MessageBox.Show("Este empleado ya pertence al evento", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bajaEmpleado_Click(object sender, EventArgs e)
        {
            DataGridViewRow regEmp = dgEmpleados.CurrentRow;
            List<string> datos;
            int regAct;

            sql.setNombreEntidad("Empleado_X_Evento");

            if (regEmp != null)
            {
                regAct = regEmp.Index;
                if (regEmp.DefaultCellStyle.BackColor == Color.DarkGray)
                {
                    if (MessageBox.Show("Esta seguro de eliminar al empleado " ,"Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        string idEvento = txtCodigoEvento.Text;
                        string idEmp = dgEmpleados.Rows[regAct].Cells[0].Value.ToString();

                        datos = new List<string>();

                        datos.Add("0");
                        datos.Add("Id_Evento");
                        datos.Add(idEvento);
                        datos.Add("Id_Empleado");
                        datos.Add(idEmp);
                        sql.ExecuteQuery(datos, 2);
                        sql.setNombreEntidad("Empleado");
                        mostrarEmpleados();
                    }
                }
                else
                    MessageBox.Show("Este empleado no existe en el evento", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgEmpleados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mostrarEmpleados();
        }

        private void cbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            empleados.Tables[0].DefaultView.RowFilter = ("ID_TIPO_EMPLEADO like '" + cbTipoEmpleado.SelectedIndex + "%'");
            dgEmpleados.DataSource = empleados.Tables[0].DefaultView;


            bloquearEmpleados();
        }
    }
}


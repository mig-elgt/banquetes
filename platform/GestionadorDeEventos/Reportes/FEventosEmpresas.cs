using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using GestionadorDeEventos.esquemalocDataSetTableAdapters;


namespace GestionadorDeEventos.Reportes
{
    public partial class FEventosEmpresas : Form
    {
        private MySqlConnection conexionMysql_EL; //Conector MySql
        private esquemalocDataSet ds;
        private Eventos_EmpresasTableAdapter empresas;
        private CR_EventosEmpresas reporte;

        private CQuery qry;
        
        public FEventosEmpresas()
        {
            InitializeComponent();
            qry = new CQuery("Tipo_Cliente", 0);
            conexionMysql_EL = new MySqlConnection("server=localhost; Uid=root; password=root; database=esquemaloc; port=3306");

            ds = new esquemalocDataSet();
            empresas = new Eventos_EmpresasTableAdapter();
            reporte = new CR_EventosEmpresas();
        }

        private void FEventosEmpresas_Load(object sender, EventArgs e)
        {
            DataTable datos = preparaDatos();
            almacenaDatosReporte(datos);
            cargaReporte();
        }

        private void cargaReporte()
        {
            DateTime FI = fechaInicial.Value;
            DateTime FF = fechaFinal.Value;

            empresas.Connection = conexionMysql_EL;
            empresas.Fill(ds.Eventos_Empresas, FI, FF);
            reporte.SetDataSource(ds);
            crystalReportViewer1.ReportSource = reporte;

        }

        private void almacenaDatosReporte(DataTable T)
        {
            string qry;
            string idEvento;
            string idCliente;
            string fecha;
            string nombre;
            string direccion;
            string telefono;
            string email;

            qry = "TRUNCATE TABLE reporte_eventos_empresas";
            EjecutaQuery(qry);

            for (int i = 0; i < T.Rows.Count; i++)
            {

                idEvento = T.Rows[i].ItemArray[0].ToString();
                idCliente = T.Rows[i].ItemArray[1].ToString();
                fecha = T.Rows[i].ItemArray[2].ToString();

                fechaEve.Text = fecha;

                nombre = T.Rows[i].ItemArray[3].ToString();
                direccion = T.Rows[i].ItemArray[4].ToString();
                telefono = T.Rows[i].ItemArray[5].ToString();
                email = T.Rows[i].ItemArray[6].ToString();

                fecha = fechaEve.Value.ToString("yy/MM/dd");

                qry = "INSERT INTO reporte_eventos_empresas values(" + idEvento + "," + idCliente + ",'" + fecha + "','" + nombre + "','" + direccion + "','" + telefono + "','" + email + "');";
                EjecutaQuery(qry);
            }
        }

        private void EjecutaQuery(string qry)
        {
            MySqlCommand cmd;
            try
            {
                cmd = new MySqlCommand(qry, conexionMysql_EL);
                conexionMysql_EL.Open();
                cmd.ExecuteNonQuery();
                conexionMysql_EL.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DataTable preparaDatos()
        {
            DataTable tipoCliente;
            DataTable cliente;
            DataTable evento;
            
            List<string> campos = new List<string>();

            //Se recuperan los datos de la tabla Empleado
            qry.obtenerDatos(null);
            tipoCliente = qry.getDataQuery();
            campos.Add("ID_TIPO_CLIENTE");
            campos.Add("0");
            //Se selecciona el tipo de Empleado
            DataTable T2 = Consulta.Seleccion(tipoCliente, campos);

            //Se obtienen los registros de los clientes
            qry.setNombreEntidad("Cliente");
            qry.obtenerDatos(null);
            cliente = qry.getDataQuery();
            //Se hace el inner join entre Empleados_X_Evento y Empleados
            DataTable T4 = Consulta.Interseccion(cliente,T2, "id_tipo_cliente");

            campos.Clear();
            campos.Add("id_cliente");
            campos.Add("nombre");
            campos.Add("direccion");
            campos.Add("telefono");
            campos.Add("email");
            //Se hace una proyeccion en la tabla Empleados
            DataTable T5 = Consulta.Proyeccion(T4, campos);

            //Obtienen los registros de evetos
            qry.setNombreEntidad("Evento");
            qry.obtenerDatos(null);
            evento = qry.getDataQuery();

            //Se hace el innerjoin entre Empleados_X_Evento y Evento
            DataTable T6 = Consulta.Interseccion(evento, T5, "id_cliente");

            campos.Clear();
            
            campos.Add("id_cliente");
            campos.Add("nombre");
            campos.Add("direccion");
            campos.Add("telefono");
            campos.Add("email");
            campos.Add("id_evento");
            campos.Add("fecha");
            //Se hace una proyeccion en la tabla Empleados
            DataTable T7 = Consulta.Proyeccion(T6, campos);
         
            return T7;
        }

        private void btnGeneraReporte_Click(object sender, EventArgs e)
        {
            cargaReporte();
        }
    }
}


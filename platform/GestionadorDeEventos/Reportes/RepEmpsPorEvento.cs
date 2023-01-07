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
    public partial class RepEmpsPorEvento : Form
    {
        private MySqlConnection conexionMysql_EL; //Conector MySql
        private esquemalocDataSet ds;
        private Meseros_X_EventoTableAdapter meseros;
        private CR_EmpEventos reporte;

        private CQuery qry;
        
        public RepEmpsPorEvento()
        {
            InitializeComponent();
            qry = new CQuery("Empleado", 0);
            conexionMysql_EL = new MySqlConnection("server=localhost; Uid=root; password=root; database=esquemaloc; port=3306");

            ds = new esquemalocDataSet();
            meseros = new Meseros_X_EventoTableAdapter();
            reporte = new CR_EmpEventos();
        }

        private void RepEmpsPorEvento_Load(object sender, EventArgs e)
        {
            DataTable datos = preparaDatos();
            almacenaDatosReporte(datos);
            cargaReporte();
        }

        private void cargaReporte()
        {
            meseros.Connection = conexionMysql_EL;
            meseros.Fill(ds.Meseros_X_Evento);
            reporte.SetDataSource(ds);
            crystalReportViewer1.ReportSource = reporte;
        }

        private void almacenaDatosReporte(DataTable T)
        {
            string qry;
            string id_emp;
            string nombre;
            string apellido;
            string sueldo;
            string id_evento;
            string fecha;
            string salon;
            string categoria;
            string tipo_evento;
          
            qry = "TRUNCATE TABLE reporte_emp_x_evento";
            EjecutaQuery(qry);
            
            for (int i = 0; i < T.Rows.Count; i++)
            {
                id_emp = T.Rows[i].ItemArray[0].ToString();
                nombre = T.Rows[i].ItemArray[1].ToString();
                apellido = T.Rows[i].ItemArray[2].ToString();
                sueldo = T.Rows[i].ItemArray[3].ToString();
                id_evento = T.Rows[i].ItemArray[4].ToString();
                fecha = T.Rows[i].ItemArray[5].ToString();
                salon = T.Rows[i].ItemArray[6].ToString();
                categoria = T.Rows[i].ItemArray[7].ToString();
                tipo_evento = T.Rows[i].ItemArray[8].ToString();
                
                qry = "INSERT INTO reporte_emp_x_evento values("+id_emp+",'"+nombre+"','"+apellido+"',"+sueldo+","+id_evento+",'"+fecha+"','"+salon+"','"+categoria+"','"+tipo_evento+"');";
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
            DataTable datosEmp;
            DataTable tipoEmpleado;
            DataTable Emp_X_Event;
            DataTable Eventos;
            DataTable Salones;
            DataTable Categoria;
            DataTable Tipo_Evento;

            List<string> campos = new List<string>();
            
            //Se recuperan los datos de la tabla Empleado
            qry.obtenerDatos(null);
            datosEmp = qry.getDataQuery();

            campos.Add("id_empleado");
            campos.Add("id_tipo_empleado");
            campos.Add("nombre");
            campos.Add("apellido_paterno");
            //Se hace una proyeccion en la tabla Empleados
            DataTable T1 = Consulta.Proyeccion(datosEmp, campos);
            
            //Se recuperan los datos de la tabla Tipo_Empleado
            qry.setNombreEntidad("Tipo_Empleado");
            qry.obtenerDatos(null);
            tipoEmpleado = qry.getDataQuery();
            campos.Clear();
            campos.Add("Id_Tipo_Empleado");
            campos.Add("0");
            //Se selecciona el tipo de Empleado
            DataTable T2 = Consulta.Seleccion(tipoEmpleado, campos);
            
            //Se realiza el inner join entre Empleado y Tipo de Empleado
            DataTable T3 = Consulta.Interseccion(T1, T2, "id_tipo_empleado");

            //Se obtienen los registris de empleados por evento
            qry.setNombreEntidad("Empleado_X_Evento");
            qry.obtenerDatos(null);
            Emp_X_Event = qry.getDataQuery();
            //Se hace el inner join entre Empleados_X_Evento y Empleados
            DataTable T4 = Consulta.Interseccion(T3, Emp_X_Event, "id_empleado");

            //Obtienen los registros de evetos
            qry.setNombreEntidad("Evento");
            qry.obtenerDatos(null);
            Eventos = qry.getDataQuery();

            //Se hace el innerjoin entre Empleados_X_Evento y Evento
            DataTable T5 = Consulta.Interseccion(T4, Eventos, "id_evento");

            //Se obtiene los tipos de salones
            qry.setNombreEntidad("Salon");
            qry.obtenerDatos(null);
            Salones = qry.getDataQuery();

            //Se hace el innerjoin entre Evento y Salon
            DataTable T6 = Consulta.Interseccion(T5, Salones, "id_salon");

            //Se obtiene las categorias de vento
            qry.setNombreEntidad("Categoria");
            qry.obtenerDatos(null);
            Categoria = qry.getDataQuery();

            //Se hace el innerjoin entre Evento y Salon
            DataTable T7 = Consulta.Interseccion(T6, Categoria, "id_categoria");

            //Se obtiene el tipo de evento
            qry.setNombreEntidad("Tipo_Evento");
            qry.obtenerDatos(null);
            Tipo_Evento = qry.getDataQuery();

            //Se hace el innerjoin entre Evento y Salon
            DataTable T8 = Consulta.Interseccion(T7, Tipo_Evento, "id_tipo_evento");
            
            campos.Clear();
            campos.Add("id_empleado");
            campos.Add("nombre");
            campos.Add("apellido_paterno");
            campos.Add("sueldo");
            campos.Add("id_evento");
            campos.Add("fecha");
            campos.Add("nombre_salon");
            campos.Add("nombre_categoria");
            campos.Add("nombre_tipo_evento");
            
            //Se selecciona el tipo de Empleado
            
            DataTable T9 = Consulta.Proyeccion(T8, campos);
            
            return T9;
        }
    }
}










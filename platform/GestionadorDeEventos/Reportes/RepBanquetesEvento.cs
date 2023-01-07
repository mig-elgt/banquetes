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
    public partial class RepBanquetesEvento : Form
    {
        private MySqlConnection conexionMysql_EL; //Conector MySql
        private CQuery qry;
        private esquemalocDataSet ds;
        private Banquetes_X_EventoTableAdapter banquetes;
        private CR_BanquetesEvento reporte;

        public RepBanquetesEvento()
        {
            InitializeComponent();

            qry = new CQuery("Platillo", 0);
            conexionMysql_EL = new MySqlConnection("server=localhost; Uid=root; password=root; database=esquemaloc; port=3306");
            
            ds = new esquemalocDataSet();
            banquetes = new Banquetes_X_EventoTableAdapter();
            reporte = new CR_BanquetesEvento();
        }

        private void RepBanquetesEvento_Load(object sender, EventArgs e)
        {
            DataTable datos = preparaDatos();
            almacenaDatosReporte(datos);
            cargaReporte();
        }

        private void cargaReporte()
        {
            banquetes.Connection = conexionMysql_EL;
            banquetes.Fill(ds.Banquetes_X_Evento);
            reporte.SetDataSource(ds);
            crystalReportViewer1.ReportSource = reporte;
        }

        private void almacenaDatosReporte(DataTable T)
        {
            string qry;
            string tipoEvento;
            string categoria;
            string salon;
            string idEvento;
            string idBanquete;
            string fecha;
            string numInvitados;
            string idPlatillo;
            string cantidad;
            string id_Tipo_platillo;
            string nombre;
            string tipoPlatillo;

            qry = "TRUNCATE TABLE reporte_banquetes_x_evento";
            EjecutaQuery(qry);

            for (int i = 0; i < T.Rows.Count; i++)
            {
                tipoEvento = T.Rows[i].ItemArray[0].ToString();
                categoria = T.Rows[i].ItemArray[1].ToString();
                salon = T.Rows[i].ItemArray[2].ToString();
                idEvento = T.Rows[i].ItemArray[3].ToString();
                idBanquete = T.Rows[i].ItemArray[4].ToString();
                fecha = T.Rows[i].ItemArray[5].ToString();
                numInvitados = T.Rows[i].ItemArray[6].ToString();
                idPlatillo = T.Rows[i].ItemArray[7].ToString();
                cantidad = T.Rows[i].ItemArray[8].ToString();
                id_Tipo_platillo = T.Rows[i].ItemArray[9].ToString();
                nombre = T.Rows[i].ItemArray[10].ToString();
                tipoPlatillo = T.Rows[i].ItemArray[11].ToString();

                qry = "INSERT INTO reporte_banquetes_x_evento values('" + tipoEvento + "','" + categoria + "','" + salon + "'," + idEvento + "," + idBanquete + ",'" 
                    + fecha + "'," + numInvitados + "," + idPlatillo + "," + cantidad + ","+id_Tipo_platillo+",'"+nombre+"','"+tipoPlatillo+"')";
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
            DataTable datos;
            DataTable tipoPlatillo;
            DataTable detalleBanquete;
            DataTable banquete;
            DataTable evento;
            DataTable salon;
            DataTable categoria;
            
            List<string> campos = new List<string>();

            //Se recuperan los datos de la tabla Platillo
            qry.obtenerDatos(null);
            datos = qry.getDataQuery();

            campos.Clear();
            campos.Add("id_platillo");
            campos.Add("id_tipo_platillo");
            campos.Add("nombre");
            DataTable T1 = Consulta.Proyeccion(datos, campos);

            qry.setNombreEntidad("Tipo_Platillo");
            qry.obtenerDatos(null);
            tipoPlatillo = qry.getDataQuery();
            //Se hace el inner join entre Platillo y Tipo Platillo
            DataTable T2 = Consulta.Interseccion(T1, tipoPlatillo, "id_tipo_platillo");

            qry.setNombreEntidad("Detalle_Banquete");
            qry.obtenerDatos(null);
            detalleBanquete = qry.getDataQuery();
            int R = detalleBanquete.Rows.Count / 2;
            for (int i = 0; i < R; i++)
                detalleBanquete.Rows.RemoveAt(0);
            //Se hace el inner join entre Platillo y detalle de banquete
            DataTable T3 = Consulta.Interseccion(detalleBanquete,T2, "id_platillo");


            qry.setNombreEntidad("Banquete");
            qry.obtenerDatos(null);
            banquete = qry.getDataQuery();
            int L = banquete.Rows.Count / 2;
            for (int i = 0; i < L; i++)
                banquete.Rows.RemoveAt(0);
            //Se hace el inner join entre banquete y Detalle de banquete
            DataTable T4 = Consulta.Interseccion(banquete, T3, "id_banquete");

            qry.setNombreEntidad("Evento");
            qry.obtenerDatos(null);
            evento = qry.getDataQuery();
            //Se hace el inner join entre Evento y Banquete
            DataTable T5 = Consulta.Interseccion(evento, T4, "id_banquete");

            qry.setNombreEntidad("Salon");
            qry.obtenerDatos(null);
            salon = qry.getDataQuery();
            //Se hace el inner join entre Evento y Salon
            DataTable T6 = Consulta.Interseccion(salon, T5, "id_salon");

            qry.setNombreEntidad("Categoria");
            qry.obtenerDatos(null);
            categoria = qry.getDataQuery();
            //Se hace el inner join entre Evento y Categoria
            DataTable T7 = Consulta.Interseccion(categoria, T6, "id_categoria");

            qry.setNombreEntidad("Tipo_Evento");
            qry.obtenerDatos(null);
            tipoPlatillo = qry.getDataQuery();
            //Se hace el inner join entre Evento y Tipo evento
            DataTable T8 = Consulta.Interseccion(tipoPlatillo, T7, "id_tipo_evento");

            datos.Clear();
            campos.Add("nombre_tipo_evento");
            campos.Add("nombre_categoria");
            campos.Add("nombre_salon");
            campos.Add("id_evento");
            campos.Add("id_banquete");
            campos.Add("fecha");
            campos.Add("num_invitados");
            campos.Add("id_platillo");
            campos.Add("cantidad");
            campos.Add("tipo_platillo");
            DataTable T9 = Consulta.Proyeccion(T8, campos);            
            return T9;
        }
    }
}

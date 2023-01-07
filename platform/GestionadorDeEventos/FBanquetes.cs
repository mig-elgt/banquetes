using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

using IBM.Data.DB2;
using IBM.Data.DB2Types;

namespace GestionadorDeEventos
{
    public partial class FBanquetes : Form
    {
        //Conexion a Postgres
        private NpgsqlConnection conexionPos;
        private List<TabPage> listPlatillo = new List<TabPage>();
        private CQuery sql;
        private List<string> datos;
        private int[][] coordenadas;
        private int idPlatillo;
        private float totalBanquete;


        public FBanquetes()
        {
            InitializeComponent();
            conexionPos = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=Eventos_S2; User Id=postgres; Password=postgres");
            crearArrayCoordenadas();
            cargaCatPlatillo();
            leerPlatillos();

            datos = new List<string>();
            sql = new CQuery("Banquete", 0);
            //ConexionDB2();
        }

        private void cargaCatPlatillo()
        {
            listPlatillo.Add(tabPage0);
            listPlatillo.Add(tabPage1);
            listPlatillo.Add(tabPage2);
            listPlatillo.Add(tabPage3);
            listPlatillo.Add(tabPage4);
            listPlatillo.Add(tabPage5);
        }
        
        private void crearArrayCoordenadas()
        { 
            coordenadas = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                coordenadas[i] = new int[2];
                coordenadas[i][0] = 35;
                coordenadas[i][1] = 25;
            }
        }

        private void ConexionDB2()
        {
            DB2Connection conexionDB2;
            conexionDB2 = new DB2Connection();
            conexionDB2.ConnectionString = "Database=sample; UserID=db2admin; Password=password";
            conexionDB2.Open();
            MessageBox.Show("Conexion a db2 "+ conexionDB2.State.ToString());
            conexionDB2.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leerPlatillos()
        {
            try
            {
                conexionPos.Open();
                //NpgsqlCommand query = new NpgsqlCommand("select * from platillo_2 order by id_tipo_platillo asc", conexionPos);
                NpgsqlDataAdapter dA = new NpgsqlDataAdapter("select * from platillo_2 order by id_tipo_platillo asc", conexionPos);
                DataSet ds = new DataSet();
             
                dA.Fill(ds);
                dgPlatillosAux.DataSource = ds.Tables[0];
                cargarPlatillos(dgPlatillosAux);
                conexionPos.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarPlatillos( DataGridView platillos)
        {
            PictureBox imgPla;
            int tipoPlatillo;

            for (int i = 0; i < platillos.Rows.Count; i++)
            {
                tipoPlatillo = Convert.ToInt32(platillos.Rows[i].Cells[1].Value);
                imgPla = new PictureBox();
                imgPla.Size = new Size(220, 150);
                imgPla.ImageLocation = platillos.Rows[i].Cells[3].Value.ToString();
                imgPla.SizeMode = PictureBoxSizeMode.StretchImage;
                imgPla.Cursor = Cursors.Hand;
                imgPla.Location = new Point(coordenadas[tipoPlatillo][0], coordenadas[tipoPlatillo][1]);
                imgPla.Click += new System.EventHandler(saluda);
                imgPla.DoubleClick += new System.EventHandler(agregarPlatilloADetalle);
                imgPla.Name = platillos.Rows[i].Cells[0].Value.ToString();

                coordenadas[tipoPlatillo][0] += 240;

                if (coordenadas[tipoPlatillo][0] > 500)
                {
                    coordenadas[tipoPlatillo][0] = 35;
                    coordenadas[tipoPlatillo][1] += 160;
                }
                
                listPlatillo[tipoPlatillo].Controls.Add(imgPla);
            }
        }

        private void agregarPlatilloADetalle(object sender, EventArgs e)
        {
            object[] datos = new object[5];

            if (txtCantidadPlatillo.Text.Length != 0)
            {
                if (Convert.ToInt32(txtNumInvitados.Text) >= Convert.ToInt32(txtCantidadPlatillo.Text))
                {
                    datos[0] = idPlatillo;
                    datos[1] = txtNamePlatillo.Text;
                    datos[2] = lbPrecioPlatillo.Text;
                    datos[3] = txtCantidadPlatillo.Text;
                    datos[4] = Convert.ToInt32(txtCantidadPlatillo.Text) * Convert.ToSingle(lbPrecioPlatillo.Text);

                    totalBanquete += (float)datos[4];
                    lbTotalBanquete.Text = totalBanquete.ToString();
                    dgDetalleBanquete.Rows.Add(datos);
                }
                else
                    Error("La cantidad del platillo no debe exceder al numero de invitados");
            }
            else
                Error("No se asigno la cantidad para este platillo");
        }

        private void saluda(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            idPlatillo = Convert.ToInt32(p.Name);

            for (int i = 0; i < dgPlatillosAux.Rows.Count; i++)
                if (idPlatillo == Convert.ToInt32(dgPlatillosAux.Rows[i].Cells[0].Value))
                {
                    txtNamePlatillo.Text = dgPlatillosAux.Rows[i].Cells[2].Value.ToString();
                    lbPrecioPlatillo.Text = dgPlatillosAux.Rows[i].Cells[4].Value.ToString();
                }
        }

        private void btnQuitarPlatillo_Click(object sender, EventArgs e)
        {
            DataGridViewRow platillo = dgDetalleBanquete.CurrentRow;
            float sub;

            if (platillo != null)
            {
                sub = (float)platillo.Cells[4].Value;
                totalBanquete -= sub;
                lbTotalBanquete.Text = totalBanquete.ToString();
                dgDetalleBanquete.Rows.Remove(dgDetalleBanquete.CurrentRow);
            }
        }

        private void altaBanquete_Click(object sender, EventArgs e)
        {
            int idEvent;

            datos.Clear();

            if (totalBanquete != 0)
            {

                datos.Add(txtNumInvitados.Text);
                datos.Add("'" + fechaBanquete.Value.ToString("yyyy/MM/dd") + "'");
                datos.Add(lbTotalBanquete.Text);
                //Se registran los banquetes a los dos sitios
                sql.ExecuteQuery(datos, 1);

                idEvent = sql.getLlavePrimaria();
                //Se insertar los platillos del banquete

                sql.setNombreEntidad("Detalle_Banquete");
                sql.obtenerFragmentos();
                for (int i = 0; i < dgDetalleBanquete.Rows.Count; i++)
                {
                    datos.Clear();
                    datos.Add(idEvent.ToString());//Id del Evento
                    datos.Add( dgDetalleBanquete.Rows[i].Cells[0].Value.ToString());//Id del Platillo
                    datos.Add(dgDetalleBanquete.Rows[i].Cells[3].Value.ToString());//Cantidad
                    datos.Add(dgDetalleBanquete.Rows[i].Cells[4].Value.ToString());//Subtotal
                    sql.setDatos(datos);
                    sql.Insert();
                }
           
                MessageBox.Show("El banquete se a creado con exito", "Banquete Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarControles();                
            }
            else
                Error("No hay platillos para guardar.");
        }

        private void limpiarControles()
        {
            txtNumInvitados.Text = "";
            dgDetalleBanquete.Rows.Clear();
            lbTotalBanquete.Text = "0";
            totalBanquete = 0;
            txtCantidadPlatillo.Text = "";
            txtNamePlatillo.Text = "";
            lbPrecioPlatillo.Text = "";
            sql.setNombreEntidad("Banquete");
            tabControl1.SelectedIndex = 0;
            txtNumInvitados.Enabled = true;
            gbCatPlatillos.Enabled = false;
        }

        private void Error(string msj)
        {
            MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FBanquetes_Load(object sender, EventArgs e)
        {
            txtNumInvitados.Focus();
        }

        private void btnCargarPlatillos_Click(object sender, EventArgs e)
        {
            if (txtNumInvitados.Text.Length != 0)
            {
                txtNumInvitados.Enabled = false;
                gbCatPlatillos.Enabled = true;
                txtCantidadPlatillo.Text = txtNumInvitados.Text;
            }
            else
                Error("No se asigno el numero de invitados");
        }

        private void btnCancelarBanquet_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void txtNumInvitados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
                e.Handled = true;
        }
    }
}






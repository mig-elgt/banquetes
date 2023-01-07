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

namespace GestionadorDeEventos
{
    public partial class FMusicosEvento : Form
    {
        private List<TabPage> listMusica = new List<TabPage>();
        private int[][] coordenadas;
        private DataTable tM;
        private DataSet musicosXevento;
        private CQuery sql;
        private List<string> datos;
        private List<object> ListIdMusicos;
        private List<object> ListCobroHora;
        private int idMusico;
        private string codigoEvento;
        private string fechaDelEvento;
        private string tipoEvento;
        internal int subTotal;
        
        public FMusicosEvento(string codEvent, string fechaEven,string typeEvent)
        {
            InitializeComponent();
            crearArrayCoordenadas();
            cargaCatMusicos();
            codigoEvento = codEvent;
            fechaDelEvento = fechaEven;
            tipoEvento = typeEvent;

            sql = new CQuery("Musicos_X_Evento", 0);

            txtCodigoEvento.Text = codigoEvento;
            fechaEvento.Text = fechaDelEvento;
            horaInicial.Text = fechaDelEvento;
            HoraFinal.Text = fechaDelEvento;
            subTotal = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearArrayCoordenadas()
        {
            coordenadas = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                coordenadas[i] = new int[2];
                coordenadas[i][0] = 25;
                coordenadas[i][1] = 25;
            }
        }

        private void cargaCatMusicos()
        {
            listMusica.Add(tabPage0);
            listMusica.Add(tabPage1);
            listMusica.Add(tabPage2);
            listMusica.Add(tabPage3);
        }

        private void cargarMusicos()
        {
            PictureBox imgMusic;
            CQuery qryMusic = new CQuery("Musico", 0);
            int tipoMusica;

            qryMusic.obtenerDatos(null);
            tM = qryMusic.getDataQuery();
            modificaRutaImg();

            ListIdMusicos = new List<object>();
            ListCobroHora = new List<object>();
            
            for (int i = 0; i < tM.Rows.Count; i++)
            {
                ListIdMusicos.Add(tM.Rows[i].ItemArray[0]);
                ListCobroHora.Add(tM.Rows[i].ItemArray[8]);

                tipoMusica = Convert.ToInt32(tM.Rows[i].ItemArray[1]);
                
                imgMusic = new PictureBox();
                imgMusic.Size = new Size(220, 150);
                
                imgMusic.ImageLocation = tM.Rows[i].ItemArray[7].ToString();
                
                imgMusic.SizeMode = PictureBoxSizeMode.StretchImage;
                imgMusic.Cursor = Cursors.Hand;
                imgMusic.BorderStyle = BorderStyle.Fixed3D;

                imgMusic.Location = new Point(coordenadas[tipoMusica][0], coordenadas[tipoMusica][1]);
                imgMusic.Click += new System.EventHandler(saluda);

                imgMusic.DoubleClick += new System.EventHandler(agregarMusicos);
                imgMusic.Name = tM.Rows[i].ItemArray[0].ToString();

                coordenadas[tipoMusica][0] += 240;
                listMusica[tipoMusica].Controls.Add(imgMusic);
            }
        }

        private void modificaRutaImg()
        {
            string cad;
            string nuevaRuta;
            char s;

            for (int i = 0; i < tM.Rows.Count; i++)
            {
                cad = tM.Rows[i].ItemArray[7].ToString();
                object[] datos = tM.Rows[i].ItemArray;

                nuevaRuta = "";
                for (int w = 0; w < cad.Length; w++)
                {
                    s = cad[w];
                    if (s == '-')
                        s = '\\';

                    nuevaRuta += s;
                }

                datos[7] = nuevaRuta;
                tM.Rows[i].ItemArray = datos;
                tM.Rows[i].ItemArray[7] = nuevaRuta;
               
            }
        }

        private void agregarMusicos(object sender, EventArgs e)
        {
            datos = new List<string>();
            datos.Add(txtCodigoEvento.Text);
            datos.Add(idMusico.ToString());
            datos.Add("'"+horaInicial.Value.ToString()+"'");
            datos.Add("'"+HoraFinal.Value.ToString()+"'");
            datos.Add("0");
            //1 : Operacion de Insercíón.
            sql.ExecuteQuery(datos, 1);
            mostrarMusicosPorEvento();
/*
            //Se actualiza El total del evento
            //Calcula el numero de horas
            int numHoras = 5;
            int subTotal = numHoras * Convert.ToInt32(lbCostoHora.Text);
            this.subTotal += subTotal;

            datos = new List<string>();
            CQuery cmd = new CQuery("Evento", 0);
            datos.Add(tipoEvento);
            datos.Add(subTotal.ToString());
            cmd.setDatos(datos);
            cmd.ActualizaCostoTotal(1);*/
        }

        private void saluda(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            idMusico  = Convert.ToInt32(p.Name);

            for (int i = 0; i < tM.Rows.Count; i++)
                if (idMusico == Convert.ToInt32(tM.Rows[i].ItemArray[0]))
                {
                    txtNombreMusico.Text = tM.Rows[i].ItemArray[2].ToString();
                    lbCostoHora.Text = tM.Rows[i].ItemArray[8].ToString();
                }
        }

        private void FMusicosEvento_Load(object sender, EventArgs e)
        {
            cargarMusicos();
            mostrarMusicosPorEvento();
        }

        private void mostrarMusicosPorEvento()
        {
            sql.obtenerDatos(null);

            musicosXevento = new DataSet();
            musicosXevento.Tables.Add(sql.getDataQuery());
            dgDetalleMusica.DataSource = musicosXevento.Tables[0];
            dgDetalleMusica.Columns[dgDetalleMusica.ColumnCount - 1].Visible = false;

            List<DataGridViewRow> L = new List<DataGridViewRow>();

            for (int i = 0; i < dgDetalleMusica.Rows.Count; i++)
                if (dgDetalleMusica.Rows[i].Cells[0].Value.ToString().CompareTo(txtCodigoEvento.Text) != 0)
                    L.Add(dgDetalleMusica.Rows[i]);
        
            for (int i = 0; i < L.Count; i++)
                dgDetalleMusica.Rows.Remove(L[i]);
        }
        
        private void btnQuitarMusica_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgDetalleMusica.CurrentRow;
            int regAct;

            if (reg != null)
            {
                regAct = reg.Index;
                if (MessageBox.Show("Esta seguro de eliminarlo ",
                               "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    string idEvento = txtCodigoEvento.Text;
                    string idMusico = dgDetalleMusica.Rows[regAct].Cells[1].Value.ToString();
                    string horaIni = dgDetalleMusica.Rows[regAct].Cells[2].Value.ToString();

                    datos = new List<string>();
                    
                    datos.Add("0");
                    datos.Add(dgDetalleMusica.Columns[0].Name);
                    datos.Add(idEvento);
                    datos.Add(dgDetalleMusica.Columns[1].Name);
                    datos.Add(idMusico);
                    datos.Add(dgDetalleMusica.Columns[2].Name);
                    datos.Add("'"+horaIni+"'");
                    sql.ExecuteQuery(datos, 2);
                    
                  /*  //Se descuenta el saldo del evento
                    int costoHora = buscarCobroHora(idMusico);
                    int numHoras = 5;
                    int subTotal = numHoras * costoHora;
                    
                    this.subTotal -= subTotal;

                    datos = new List<string>();
                    CQuery cmd = new CQuery("Evento", 0);
                    datos.Add(tipoEvento);
                    datos.Add(subTotal.ToString());
                    cmd.setDatos(datos);
                    cmd.ActualizaCostoTotal(0);
                    mostrarMusicosPorEvento();*/
                }
            }
        }

        private int buscarCobroHora(string idMusico)
        {
            int c = 0;
            string id;

            for (int i = 0; i < ListIdMusicos.Count; i++)
            {
                id = ListIdMusicos[i].ToString();
                if (id.CompareTo(idMusico) == 0)
                {
                    c = Convert.ToInt32(ListCobroHora[i]);
                    break;
                }
            }

            return c;
       }

        private void cbBanquete_SelectedIndexChanged(object sender, EventArgs e)
        {
            horaInicial.Value = fechaEvento.Value;
            HoraFinal.Value = fechaEvento.Value;
        }

        private void gbCatPlatillos_Enter(object sender, EventArgs e)
        {

        }
    }
}

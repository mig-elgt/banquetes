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
    public partial class FEventos : Form
    {
        private List<string> idCLientes;
        private List<string> costosBanquete;
        private List<String> datos;
        private DataSet eventos;
        private CQuery sql;
        private float costoBanquete;
        private float costoMusica;
        private float costoTotal;

        public FEventos()
        {
            InitializeComponent();
            idCLientes = new List<string>();
            costosBanquete = new List<string>();
            sql = new CQuery("Evento", 0);
            
        }

        private void closeVentana_Click(object sendesr, EventArgs e)
        {
            this.Close();
        }

        private void FEventos_Load(object sender, EventArgs e)
        {
            cbCategoria.SelectedIndex = 0;
            cbSalon.SelectedIndex = 0;
            cbTipoEvento.SelectedIndex = 0;
            
            //Cargar banquetes y clientesl
            CargaCombox();
            mostrarEventos();
            cbBanquete.SelectedIndex = 0;
            cbClientes.SelectedIndex = 0;
        }

        private void CargaCombox()
        {
            CQuery qB = new CQuery("Banquete", 0);
            CQuery qC = new CQuery("Cliente", 0);
            DataTable tB;
            DataTable tC;
            
            qB.obtenerDatos(null);
            tB = qB.getDataQuery();
            
            //Se agregan los baquetes y sus costos
            for (int i = 0; i < tB.Rows.Count/2; i++)
            {
                costosBanquete.Add(tB.Rows[i].ItemArray[3].ToString());
                cbBanquete.Items.Add(tB.Rows[i].ItemArray[0].ToString());
            }

            qC.obtenerDatos(null);
            tC = qC.getDataQuery();

            for (int i = 0; i < tC.Rows.Count; i++)
            {
                idCLientes.Add(tC.Rows[i].ItemArray[0].ToString());
                cbClientes.Items.Add(tC.Rows[i].ItemArray[2].ToString());
            }
        }

        private void mostrarEventos()
        {
            sql.obtenerDatos(null);
        
            eventos = new DataSet();
            eventos.Tables.Add(sql.getDataQuery());
            dgEventos.DataSource = eventos.Tables[0];
            dgEventos.Columns[dgEventos.ColumnCount - 1].Visible = false;
        }

        private void cbBanquete_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgEventos.CurrentRow;
            int regAct;

            costoBanquete = Convert.ToSingle(costosBanquete[cbBanquete.SelectedIndex]);
            txtCostoBanquete.Text = costosBanquete[cbBanquete.SelectedIndex];
                
            if (reg != null)
            {
                regAct = reg.Index;

                costoTotal = Convert.ToSingle(dgEventos.Rows[regAct].Cells[dgEventos.ColumnCount-1].Value);
                txtCostoTotal.Text = costoTotal.ToString();

                costoMusica = costoTotal - costoBanquete;
                txtCostoMusica.Text = costoMusica.ToString();
            }
        }

        private void altaEvento_Click(object sender, EventArgs e)
        {
            datos = new List<string>();
            
            datos.Add(cbTipoEvento.SelectedItem.ToString());
            datos.Add(idCLientes[cbClientes.SelectedIndex]);
            datos.Add(cbSalon.SelectedIndex.ToString());
            datos.Add( cbBanquete.SelectedItem.ToString());
            datos.Add(cbTipoEvento.SelectedIndex.ToString());
            datos.Add(cbCategoria.SelectedIndex.ToString());
            
            
            if(cbTipoEvento.SelectedIndex == 0)
                datos.Add("'" + fechaEvento.Value.ToString("yyy-MM-dd HH:mm:ss") + "'");
            else
                if (cbTipoEvento.SelectedIndex == 2)
                    datos.Add("'" + fechaEvento.Value.ToString("yyy/MM/dd HH:mm:ss") + "'");
                else
                    datos.Add("'" + fechaEvento.Value.ToString("MM/dd/yyy HH:mm:ss") + "'");
            
            datos.Add(txtCostoBanquete.Text);
            
            //1 : Operacion de Insercíón.
            sql.ExecuteQuery(datos, 1);
            mostrarEventos();
        }

        private void dgEventos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgEventos.CurrentRow;
            int regAct;

            if (reg != null)
            {
                regAct = reg.Index;
                buscaIdCliente(dgEventos.Rows[regAct].Cells[1].Value.ToString());
                cbSalon.SelectedIndex = Convert.ToInt32(dgEventos.Rows[regAct].Cells[2].Value);
                cbBanquete.SelectedItem =  dgEventos.Rows[regAct].Cells[3].Value.ToString();
                cbTipoEvento.SelectedIndex = Convert.ToInt32(dgEventos.Rows[regAct].Cells[4].Value);
                cbCategoria.SelectedIndex = Convert.ToInt32(dgEventos.Rows[regAct].Cells[5].Value);
                fechaEvento.Text = dgEventos.Rows[regAct].Cells[6].Value.ToString();
                txtCostoBanquete.Text = dgEventos.Rows[regAct].Cells[7].Value.ToString();
            }
        }

        private void buscaIdCliente(string idCli)
        { 
            foreach(string Id in idCLientes)
                if (Id.CompareTo(idCli) == 0)
                {
                    cbClientes.SelectedIndex = idCLientes.IndexOf(Id);
                    break;
                }
        }

        private void cbBuscarEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCat = cbBuscarEvento.SelectedIndex;
            eventos.Tables[0].DefaultView.RowFilter = ("id_categoria like '" + idCat + "%'");
            dgEventos.DataSource = eventos.Tables[0].DefaultView;
        }

        private void bajaEvento_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgEventos.CurrentRow;
            int regAct;

            if (reg != null)
            {
                regAct = reg.Index;
                if (MessageBox.Show("Esta seguro de eliminar el evento ",
                               "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    string tipoEvento = cbTipoEvento.SelectedItem.ToString();
                    string id = dgEventos.Rows[regAct].Cells[0].Value.ToString();

                    datos = new List<string>();
                    datos.Add(tipoEvento);
                    datos.Add(dgEventos.Columns[0].Name);
                    datos.Add(id);
                    sql.ExecuteQuery(datos, 2);
                    mostrarEventos();
                }
            }
        }

        private void tsAgregarMusicos_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg;
            FMusicosEvento musicos;
            string codEvent;
            string fechaEvent;
            string tipoEvent;

            reg = dgEventos.CurrentRow;

            if (reg != null)
            {
                codEvent = reg.Cells[0].Value.ToString();
                fechaEvent = reg.Cells[6].Value.ToString();
                tipoEvent = cbTipoEvento.SelectedItem.ToString();

                musicos = new FMusicosEvento(codEvent, fechaEvent,tipoEvent);
                musicos.ShowDialog();

                costoTotal += musicos.subTotal;
                txtCostoTotal.Text = costoTotal.ToString();

                costoMusica = costoTotal - costoBanquete;
                txtCostoMusica.Text = costoMusica.ToString();
            }
        }

        private void tsAgregarEmpleados_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg;
            FEmpleadosEvento emp;
            string codEvent;
            string fechaEvent;

            reg = dgEventos.CurrentRow;

            if (reg != null)
            {
                codEvent = reg.Cells[0].Value.ToString();
                fechaEvent = reg.Cells[6].Value.ToString();
                
                emp = new FEmpleadosEvento(codEvent, fechaEvent);
                emp.ShowDialog();
            }
        }

        private void modificarEvento_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgEventos.CurrentRow;
            string llavePrimaria;
            string campoCondicion;
            List<string> Ent = new List<string>();
            int regAct;

            if (reg != null)
            {
                datos = new List<string>();
                regAct = reg.Index;

                llavePrimaria = reg.Cells[0].Value.ToString();
                campoCondicion = reg.Cells[4].Value.ToString();

                datos.Add(cbTipoEvento.SelectedItem.ToString());
                datos.Add(dgEventos.Columns[0].Name);
                datos.Add(llavePrimaria);

                datos.Add(dgEventos.Columns[1].Name);
                datos.Add(idCLientes[cbClientes.SelectedIndex].ToString());

                datos.Add(dgEventos.Columns[2].Name);
                datos.Add(cbSalon.SelectedIndex.ToString());

                datos.Add(dgEventos.Columns[3].Name);
                datos.Add(cbBanquete.SelectedIndex.ToString());

                datos.Add(dgEventos.Columns[4].Name);
                datos.Add(cbTipoEvento.SelectedIndex.ToString());

                datos.Add(dgEventos.Columns[5].Name);
                datos.Add(cbCategoria.SelectedIndex.ToString());

                datos.Add(dgEventos.Columns[6].Name);
                if (cbTipoEvento.SelectedIndex == 0)
                    datos.Add("'" + fechaEvento.Value.ToString("yyy-MM-dd HH:mm:ss") + "'");
                else
                    if (cbTipoEvento.SelectedIndex == 2)
                        datos.Add("'" + fechaEvento.Value.ToString("yyy/MM/dd HH:mm:ss") + "'");
                    else
                        datos.Add("'" + fechaEvento.Value.ToString("MM/dd/yyy HH:mm:ss") + "'");

                datos.Add(dgEventos.Columns[7].Name);
                datos.Add(dgEventos.Rows[regAct].Cells[7].Value.ToString());

                if (campoCondicion.CompareTo(cbTipoEvento.SelectedIndex.ToString()) == 0)
                    sql.setTipoUpdate(0);//Update simple
                else
                {
                    sql.setTipoUpdate(1);//Update Optimizado, cuida la integridad referencial 
                    sql.setCampoCondicionAnt(cbTipoEvento.Items[Convert.ToInt32(campoCondicion)].ToString());
                    sql.setCampoCondicionNew(cbTipoEvento.SelectedItem.ToString());
                    Ent.Add("Empleado_X_Evento");
                    Ent.Add("Musicos_X_Evento");
                    sql.setEntidades(Ent);
                    sql.setNameLlavePrimaria(dgEventos.Columns[0].Name);
                }
                sql.setNombreEntidad("Evento");
                sql.ExecuteQuery(datos, 3);
                sql.setNombreEntidad("Evento");
                mostrarEventos();
            }
        }

    }
}



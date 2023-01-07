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

namespace GestionadorDeEventos
{
    public partial class FPlatillos : Form
    {
        private CQuery sql;
        private List<string> datos;
        private DataSet platillos;

        public FPlatillos()
        {
            InitializeComponent();
            sql = new CQuery("Platillo", 0);
            datos = new List<string>();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarImagen = new OpenFileDialog();

            buscarImagen.Filter = "Archivos de Imagen |*.jpg";
            buscarImagen.FileName = "";
            buscarImagen.Title = "Seleccionar Imagen de Platillo";
            buscarImagen.InitialDirectory = "C:\\Users\\db2admin\\Documents\\GitHub\\BDD_Eventos\\GestionadorDeEventos\\ImgPlatillos";

            if (buscarImagen.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = buscarImagen.FileName;
                cargarImagen();
            }
        }

        private void cargarImagen()
        {
            imgPlatillo.ImageLocation = txtImagenUrl.Text;
            imgPlatillo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void altaPlatillo_Click(object sender, EventArgs e)
        {
            datos.Clear();
            datos.Add(cbPostres.SelectedIndex.ToString());
            datos.Add("'" + txtNombre.Text + "'");
            datos.Add("'" + txtImagenUrl.Text + "'");
            datos.Add(txtPrecio.Text);
            datos.Add("'" + txtIngredientes.Text + "'");
            datos.Add("'" + txtPreparacion.Text + "'");
            sql.ExecuteQuery(datos, 1);
            mostrarPlatillo();
            cbBuscarPlatillo.SelectedIndex = 0;
        }

        private void mostrarPlatillo()
        {
            sql.obtenerDatos(dgPlatillos);
            platillos = new DataSet();
            platillos.Tables.Add(sql.getDataQuery());
            dgPlatillos.DataSource = platillos.Tables[0];
        }

        private void FPlatillos_Load(object sender, EventArgs e)
        {
            cbPostres.SelectedIndex = 0;
            mostrarPlatillo();
            cbBuscarPlatillo.SelectedIndex = 0;
        }

        private void bajaPlatillo_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgPlatillos.CurrentRow;
            int regAct;

            if (reg != null)
            {
                regAct = reg.Index;
                if (MessageBox.Show("Esta seguro de eliminar el platillo ",
                                "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    string id = dgPlatillos.Rows[regAct].Cells[0].Value.ToString();

                    datos = new List<string>();
                    datos.Add("0");
                    datos.Add(dgPlatillos.Columns[0].Name);
                    datos.Add(id);
                    sql.ExecuteQuery(datos, 2);
                    mostrarPlatillo();
                    cbBuscarPlatillo.SelectedIndex = 0;
                }
            }
        }

        private void dgPlatillos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgPlatillos.CurrentRow;
            int regAct;

            if (reg != null)
            {
                regAct = reg.Index;
                
                cbPostres.SelectedIndex = Convert.ToInt32(dgPlatillos.Rows[regAct].Cells[1].Value);
                txtNombre.Text = dgPlatillos.Rows[regAct].Cells[2].Value.ToString();
                txtImagenUrl.Text = dgPlatillos.Rows[regAct].Cells[3].Value.ToString();
                cargarImagen();
                txtPrecio.Text = dgPlatillos.Rows[regAct].Cells[4].Value.ToString();
                txtIngredientes.Text = dgPlatillos.Rows[regAct].Cells[5].Value.ToString();
                txtPreparacion.Text = dgPlatillos.Rows[regAct].Cells[6].Value.ToString();
            }
        }

        private void closeVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbBuscarPlatillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            platillos.Tables[0].DefaultView.RowFilter = ("id_tipo_platillo like '" + cbBuscarPlatillo.SelectedIndex + "%'");
            dgPlatillos.DataSource = platillos.Tables[0].DefaultView;

            if (dgPlatillos.Rows.Count == 0)
                limpiarControles();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            cbPostres.SelectedIndex = 0;
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtImagenUrl.Text = "";
            txtPreparacion.Text = "";
            txtIngredientes.Text = "";
            imgPlatillo.Image = null;
            imgPlatillo.ImageLocation = "";
        }

        private void modificarPlatillo_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgPlatillos.CurrentRow;
            int regAct;
            string llavePrimaria;

            if (reg != null)
            {
                datos = new List<string>();
                llavePrimaria = reg.Cells[0].Value.ToString();

                datos.Add(dgPlatillos.Columns[0].Name);
                datos.Add(llavePrimaria);

                datos.Add(dgPlatillos.Columns[1].Name);
                datos.Add(cbPostres.SelectedIndex.ToString());

                datos.Add(dgPlatillos.Columns[2].Name);
                datos.Add("'"+txtNombre.Text+"'");

                datos.Add(dgPlatillos.Columns[3].Name);
                datos.Add("'" + txtImagenUrl.Text + "'");

                datos.Add(dgPlatillos.Columns[4].Name);
                datos.Add(txtPrecio.Text);

                datos.Add(dgPlatillos.Columns[0].Name);
                datos.Add(llavePrimaria);

                datos.Add(dgPlatillos.Columns[5].Name);
                datos.Add("'"+txtIngredientes.Text+"'");

                datos.Add(dgPlatillos.Columns[6].Name);
                datos.Add("'"+txtPreparacion.Text+"'");

                
                sql.setNombreEntidad("Platillo");
                sql.ExecuteQuery(datos, 3);
                mostrarPlatillo();
            }
        }
    }
}




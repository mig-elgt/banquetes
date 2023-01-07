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
    public partial class FMusicos : Form
    {
        private CQuery sql;
        private List<string> datos;
        private DataSet musicos;

        public FMusicos()
        {
            InitializeComponent();
            sql = new CQuery("Musico", 0);
        }

        private void closeVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarImagen = new OpenFileDialog();

            buscarImagen.Filter = "Archivos de Imagen |*.jpg";
            buscarImagen.FileName = "";
            buscarImagen.Title = "Seleccionar Imagen de Platillo";
            buscarImagen.InitialDirectory = "C:\\Users\\db2admin\\Documents\\GitHub\\BDD_Eventos\\GestionadorDeEventos\\ImgMusicos";
            
            if (buscarImagen.ShowDialog() == DialogResult.OK)
            {
                txtLogoUrl.Text = buscarImagen.FileName;
                cargarImagen();
            }
        }

        private void cargarImagen()
        {
            imgLogo.ImageLocation = txtLogoUrl.Text;
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void altaMusico_Click(object sender, EventArgs e)
        {
            List<String> datos = new List<string>();

            datos.Add(cbTipoMusica.SelectedItem.ToString());
            datos.Add(cbTipoMusica.SelectedIndex.ToString());
            datos.Add("'" + txtNombre.Text  + "'");
            datos.Add("'" + txtDirector.Text + "'");
            datos.Add("'" + txtDireccion.Text + "'");
            datos.Add("'" + txtEmail.Text +"'");
            datos.Add("'" + txtTelefono.Text + "'");
            datos.Add("'" + cambiarFormato() + "'");
            datos.Add("'" + txtCosto.Text + "'");
            datos.Add("0");
            
            //1 : Operacion de Insercíón.
            sql.ExecuteQuery(datos, 1);
            mostrarMusicos();
            limpiarControles();
        }

        private string cambiarFormato()
        { 
            char []sep = new char[1];
            sep[0] = '\\';
            string url;

            string []ruta = txtLogoUrl.Text.Split(sep);

            url = ruta[0];

            for (int i = 1; i < ruta.Length; i++)
                url += "-" + ruta[i];

            return url;
        }


        private void mostrarMusicos()
        {
            sql.obtenerDatos(dgMusicos);
            musicos = new DataSet();
            musicos.Tables.Add(sql.getDataQuery());

            dgMusicos.DataSource = musicos.Tables[0];
            dgMusicos.Columns[0].Visible = false;
            dgMusicos.Columns[1].Visible = false;
            dgMusicos.Columns[dgMusicos.ColumnCount - 1].Visible = false;
            modificaRutaImg();
        }

        private void modificaRutaImg()
        {
            string cad;
            string nuevaRuta;
            char s;

            for (int i = 0; i < dgMusicos.Rows.Count; i++)
            {
                cad = dgMusicos.Rows[i].Cells[7].Value.ToString();

                nuevaRuta = "";
                for (int w = 0; w < cad.Length; w++)
                {
                    s = cad[w];
                    if (s == '-')
                        s = '\\';

                    nuevaRuta += s;
                }

                dgMusicos.Rows[i].Cells[7].Value = nuevaRuta;
            }
        }

        private void FMusicos_Load(object sender, EventArgs e)
        {
            cbTipoMusica.SelectedIndex = 0;
            mostrarMusicos();
        }

        private void dgMusicos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgMusicos.CurrentRow;
            int regAct;

            if (reg != null)
            {
                regAct = reg.Index;
                cbTipoMusica.SelectedIndex = Convert.ToInt32(dgMusicos.Rows[regAct].Cells[1].Value);
                txtNombre.Text = dgMusicos.Rows[regAct].Cells[2].Value.ToString();
                txtDirector.Text = dgMusicos.Rows[regAct].Cells[3].Value.ToString();
                txtDireccion.Text = dgMusicos.Rows[regAct].Cells[4].Value.ToString();
                txtEmail.Text = dgMusicos.Rows[regAct].Cells[5].Value.ToString();
                txtTelefono.Text = dgMusicos.Rows[regAct].Cells[6].Value.ToString();
                txtLogoUrl.Text = dgMusicos.Rows[regAct].Cells[7].Value.ToString();
                cargarImagen();
                txtCosto.Text = dgMusicos.Rows[regAct].Cells[8].Value.ToString();
            }
        }

        private void bajaMusico_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgMusicos.CurrentRow;
            int regAct;

            if (reg != null)
            {
                regAct = reg.Index;
                if (MessageBox.Show("Esta seguro de eliminar al grupo " + dgMusicos.Rows[regAct].Cells[2].Value.ToString(),
                                "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    string tipoCliente = cbTipoMusica.SelectedItem.ToString();
                    string id = dgMusicos.Rows[regAct].Cells[0].Value.ToString();

                    datos = new List<string>();
                    datos.Add(tipoCliente);
                    datos.Add(dgMusicos.Columns[0].Name);
                    datos.Add(id);
                    sql.ExecuteQuery(datos, 2);
                    mostrarMusicos();
                    limpiarControles();
                }
            }
        }

        private void txtBuscarImg_TextChanged(object sender, EventArgs e)
        {
            musicos.Tables[0].DefaultView.RowFilter = ("nombre like '" + txtBuscarName.Text + "%'");
            dgMusicos.DataSource = musicos.Tables[0].DefaultView;

            if (dgMusicos.Rows.Count == 0)
                limpiarControles();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            cbTipoMusica.SelectedIndex = 0;
            txtNombre.Text = "";
            txtDirector.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtCosto.Text = "";
            txtLogoUrl.Text = "";
            imgLogo.Image = null;
        }

        private void modificarMusico_Click(object sender, EventArgs e)
        {
            DataGridViewRow reg = dgMusicos.CurrentRow;
            string llavePrimaria;
            string campoCondicion;

            if (reg != null)
            {
                datos = new List<string>();

                llavePrimaria = reg.Cells[0].Value.ToString();
                campoCondicion = reg.Cells[1].Value.ToString();

                datos.Add(cbTipoMusica.SelectedItem.ToString());
                datos.Add(dgMusicos.Columns[0].Name);
                datos.Add(llavePrimaria);

                datos.Add(dgMusicos.Columns[1].Name);
                datos.Add(cbTipoMusica.SelectedIndex.ToString());

                datos.Add(dgMusicos.Columns[2].Name);
                datos.Add("'" + txtNombre.Text + "'");

                datos.Add(dgMusicos.Columns[3].Name);
                datos.Add("'" + txtDirector.Text + "'");

                datos.Add(dgMusicos.Columns[4].Name);
                datos.Add("'" + txtDireccion.Text + "'");

                datos.Add(dgMusicos.Columns[5].Name);
                datos.Add("'" + txtEmail.Text + "'");

                datos.Add(dgMusicos.Columns[6].Name);
                datos.Add("'" + txtTelefono.Text + "'");

                datos.Add(dgMusicos.Columns[7].Name);
                datos.Add("'" + cambiarFormato() + "'");

                datos.Add(dgMusicos.Columns[8].Name);
                datos.Add("'" + txtCosto.Text + "'");

                if (campoCondicion.CompareTo(cbTipoMusica.SelectedIndex.ToString()) == 0)
                    sql.setTipoUpdate(0);//Update simple
                else
                    sql.setTipoUpdate(1);//Update Optimizado, cuida la integridad referencial 

                sql.setNombreEntidad("Musico");
                sql.ExecuteQuery(datos, 3);
                mostrarMusicos();
            }
        }
    }
}

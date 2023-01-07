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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsPlatillos_Click(object sender, EventArgs e)
        {
            FPlatillos pla = new FPlatillos();

            pla.MdiParent = this;
            pla.Show();
        }

        private void tsBanquetes_Click(object sender, EventArgs e)
        {
            FBanquetes ban = new FBanquetes();

            ban.MdiParent = this;
            ban.Show();
        }

        private void tsClientes_Click(object sender, EventArgs e)
        {
            FClientes cli = new FClientes();

            cli.MdiParent = this;
            cli.Show();
        }

        private void tsEmpleados_Click(object sender, EventArgs e)
        {
            FEmpleados emp = new FEmpleados();

            emp.MdiParent = this;
            emp.Show();
        }

        private void tsMusicos_Click(object sender, EventArgs e)
        {
            FMusicos mus = new FMusicos();

            mus.MdiParent = this;
            mus.Show();
        }

        private void tsEventos_ButtonClick(object sender, EventArgs e)
        {
            FEventos eve = new FEventos();

            eve.MdiParent = this;
            eve.Show();
        }

        private void agregarMusicos_Click(object sender, EventArgs e)
        {
        }

        private void infEmpPorEvento_Click(object sender, EventArgs e)
        {
            Reportes.RepEmpsPorEvento rep = new Reportes.RepEmpsPorEvento();

            rep.MdiParent = this;
            rep.Show();
        }

        private void tsEventos_Click(object sender, EventArgs e)
        {
            FEventos eve = new FEventos();

            eve.MdiParent = this;
            eve.Show();
        }

        private void banquetesPorEvento_Click(object sender, EventArgs e)
        {
            Reportes.RepBanquetesEvento ban = new Reportes.RepBanquetesEvento();

            ban.MdiParent = this;
            ban.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eventosDeEmpresas_Click(object sender, EventArgs e)
        {
            Reportes.FEventosEmpresas eve = new Reportes.FEventosEmpresas();

            eve.MdiParent = this;
            eve.Show();
        }
    }
}

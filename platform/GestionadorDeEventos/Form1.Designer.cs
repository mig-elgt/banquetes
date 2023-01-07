namespace GestionadorDeEventos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsEventos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBanquetes = new System.Windows.Forms.ToolStripButton();
            this.tsPlatillos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsEmpleados = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMusicos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripSplitButton();
            this.infEmpPorEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.banquetesPorEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.eventosDeEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEventos,
            this.toolStripSeparator2,
            this.tsBanquetes,
            this.tsPlatillos,
            this.toolStripSeparator3,
            this.tsClientes,
            this.toolStripSeparator4,
            this.tsEmpleados,
            this.toolStripSeparator5,
            this.tsMusicos,
            this.toolStripSeparator1,
            this.toolStripButton7});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 761);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsEventos
            // 
            this.tsEventos.Image = global::GestionadorDeEventos.Properties.Resources._event;
            this.tsEventos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEventos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEventos.Name = "tsEventos";
            this.tsEventos.Size = new System.Drawing.Size(78, 83);
            this.tsEventos.Text = "Eventos";
            this.tsEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEventos.Click += new System.EventHandler(this.tsEventos_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(78, 6);
            // 
            // tsBanquetes
            // 
            this.tsBanquetes.Image = global::GestionadorDeEventos.Properties.Resources.banquete;
            this.tsBanquetes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBanquetes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBanquetes.Name = "tsBanquetes";
            this.tsBanquetes.Size = new System.Drawing.Size(78, 83);
            this.tsBanquetes.Text = "Banquetes";
            this.tsBanquetes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBanquetes.Click += new System.EventHandler(this.tsBanquetes_Click);
            // 
            // tsPlatillos
            // 
            this.tsPlatillos.Image = global::GestionadorDeEventos.Properties.Resources.plate;
            this.tsPlatillos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsPlatillos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPlatillos.Name = "tsPlatillos";
            this.tsPlatillos.Size = new System.Drawing.Size(78, 83);
            this.tsPlatillos.Text = "Platillos";
            this.tsPlatillos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPlatillos.Click += new System.EventHandler(this.tsPlatillos_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(78, 6);
            // 
            // tsClientes
            // 
            this.tsClientes.Image = global::GestionadorDeEventos.Properties.Resources.custormer;
            this.tsClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClientes.Name = "tsClientes";
            this.tsClientes.Size = new System.Drawing.Size(78, 83);
            this.tsClientes.Text = "Clientes";
            this.tsClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsClientes.Click += new System.EventHandler(this.tsClientes_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(78, 6);
            // 
            // tsEmpleados
            // 
            this.tsEmpleados.Image = global::GestionadorDeEventos.Properties.Resources.employee;
            this.tsEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEmpleados.Name = "tsEmpleados";
            this.tsEmpleados.Size = new System.Drawing.Size(78, 83);
            this.tsEmpleados.Text = "Empleados";
            this.tsEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEmpleados.Click += new System.EventHandler(this.tsEmpleados_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(78, 6);
            // 
            // tsMusicos
            // 
            this.tsMusicos.Image = global::GestionadorDeEventos.Properties.Resources.music;
            this.tsMusicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMusicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMusicos.Name = "tsMusicos";
            this.tsMusicos.Size = new System.Drawing.Size(78, 83);
            this.tsMusicos.Text = "Musicos";
            this.tsMusicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsMusicos.Click += new System.EventHandler(this.tsMusicos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(78, 6);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infEmpPorEvento,
            this.toolStripSeparator6,
            this.banquetesPorEvento,
            this.toolStripSeparator7,
            this.eventosDeEmpresas});
            this.toolStripButton7.Image = global::GestionadorDeEventos.Properties.Resources.reports;
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(78, 83);
            this.toolStripButton7.Text = "Reportes";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // infEmpPorEvento
            // 
            this.infEmpPorEvento.Name = "infEmpPorEvento";
            this.infEmpPorEvento.Size = new System.Drawing.Size(231, 22);
            this.infEmpPorEvento.Text = "MESEROS POR EVENTO . . .";
            this.infEmpPorEvento.Click += new System.EventHandler(this.infEmpPorEvento_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(228, 6);
            // 
            // banquetesPorEvento
            // 
            this.banquetesPorEvento.Name = "banquetesPorEvento";
            this.banquetesPorEvento.Size = new System.Drawing.Size(231, 22);
            this.banquetesPorEvento.Text = "BANQUETES POR EVENTO . . .";
            this.banquetesPorEvento.Click += new System.EventHandler(this.banquetesPorEvento_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(228, 6);
            // 
            // eventosDeEmpresas
            // 
            this.eventosDeEmpresas.Name = "eventosDeEmpresas";
            this.eventosDeEmpresas.Size = new System.Drawing.Size(231, 22);
            this.eventosDeEmpresas.Text = "EVENTOS DE EMPRESAS . . .";
            this.eventosDeEmpresas.Click += new System.EventHandler(this.eventosDeEmpresas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 761);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTOR DE VENTOS SOCIALEES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClientes;
        private System.Windows.Forms.ToolStripButton tsBanquetes;
        private System.Windows.Forms.ToolStripButton tsPlatillos;
        private System.Windows.Forms.ToolStripButton tsEmpleados;
        private System.Windows.Forms.ToolStripButton tsMusicos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsEventos;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton7;
        private System.Windows.Forms.ToolStripMenuItem infEmpPorEvento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem banquetesPorEvento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem eventosDeEmpresas;
    }
}


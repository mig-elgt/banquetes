namespace GestionadorDeEventos
{
    partial class FEventos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.closeVentana = new System.Windows.Forms.ToolStripButton();
            this.altaEvento = new System.Windows.Forms.ToolStripButton();
            this.bajaEvento = new System.Windows.Forms.ToolStripButton();
            this.modificarEvento = new System.Windows.Forms.ToolStripButton();
            this.tsAgregarMusicos = new System.Windows.Forms.ToolStripButton();
            this.tsAgregarEmpleados = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBanquete = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSalon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoEvento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fechaEvento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBuscarEvento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgEventos = new System.Windows.Forms.DataGridView();
            this.txtCostoBanquete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCostoMusica = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // cbClientes
            // 
            this.cbClientes.AccessibleDescription = "cbClientes";
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(127, 133);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(140, 24);
            this.cbClientes.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cliente :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeVentana,
            this.toolStripSeparator1,
            this.altaEvento,
            this.bajaEvento,
            this.modificarEvento,
            this.tsAgregarMusicos,
            this.tsAgregarEmpleados});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(871, 55);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // closeVentana
            // 
            this.closeVentana.Image = global::GestionadorDeEventos.Properties.Resources.LogOut;
            this.closeVentana.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.closeVentana.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeVentana.Name = "closeVentana";
            this.closeVentana.Size = new System.Drawing.Size(81, 52);
            this.closeVentana.Text = "Salir";
            this.closeVentana.Click += new System.EventHandler(this.closeVentana_Click);
            // 
            // altaEvento
            // 
            this.altaEvento.Image = global::GestionadorDeEventos.Properties.Resources.addEvento;
            this.altaEvento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.altaEvento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.altaEvento.Name = "altaEvento";
            this.altaEvento.Size = new System.Drawing.Size(101, 52);
            this.altaEvento.Text = "Agregar";
            this.altaEvento.Click += new System.EventHandler(this.altaEvento_Click);
            // 
            // bajaEvento
            // 
            this.bajaEvento.Image = global::GestionadorDeEventos.Properties.Resources.deleteEvento;
            this.bajaEvento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bajaEvento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bajaEvento.Name = "bajaEvento";
            this.bajaEvento.Size = new System.Drawing.Size(102, 52);
            this.bajaEvento.Text = "Eliminar";
            this.bajaEvento.Click += new System.EventHandler(this.bajaEvento_Click);
            // 
            // modificarEvento
            // 
            this.modificarEvento.Image = global::GestionadorDeEventos.Properties.Resources.updateEvento;
            this.modificarEvento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.modificarEvento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modificarEvento.Name = "modificarEvento";
            this.modificarEvento.Size = new System.Drawing.Size(110, 52);
            this.modificarEvento.Text = "Modificar";
            this.modificarEvento.Click += new System.EventHandler(this.modificarEvento_Click);
            // 
            // tsAgregarMusicos
            // 
            this.tsAgregarMusicos.Image = global::GestionadorDeEventos.Properties.Resources.addSinger;
            this.tsAgregarMusicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAgregarMusicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAgregarMusicos.Margin = new System.Windows.Forms.Padding(120, 1, 0, 2);
            this.tsAgregarMusicos.Name = "tsAgregarMusicos";
            this.tsAgregarMusicos.Size = new System.Drawing.Size(148, 52);
            this.tsAgregarMusicos.Text = "Agregar Musicos";
            this.tsAgregarMusicos.Click += new System.EventHandler(this.tsAgregarMusicos_Click);
            // 
            // tsAgregarEmpleados
            // 
            this.tsAgregarEmpleados.Image = global::GestionadorDeEventos.Properties.Resources.addEmployee;
            this.tsAgregarEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAgregarEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAgregarEmpleados.Name = "tsAgregarEmpleados";
            this.tsAgregarEmpleados.Size = new System.Drawing.Size(162, 52);
            this.tsAgregarEmpleados.Text = "Agregar Empleados";
            this.tsAgregarEmpleados.Click += new System.EventHandler(this.tsAgregarEmpleados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cod Banquete :";
            // 
            // cbBanquete
            // 
            this.cbBanquete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBanquete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBanquete.FormattingEnabled = true;
            this.cbBanquete.Location = new System.Drawing.Point(127, 93);
            this.cbBanquete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBanquete.Name = "cbBanquete";
            this.cbBanquete.Size = new System.Drawing.Size(140, 24);
            this.cbBanquete.TabIndex = 19;
            this.cbBanquete.SelectedIndexChanged += new System.EventHandler(this.cbBanquete_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Salon :";
            // 
            // cbSalon
            // 
            this.cbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalon.FormattingEnabled = true;
            this.cbSalon.Items.AddRange(new object[] {
            "Parafernalia",
            "Cruz de Celia",
            "Candiles",
            "Escenarios",
            "Frances",
            "Villa Danieli",
            "Champac"});
            this.cbSalon.Location = new System.Drawing.Point(427, 133);
            this.cbSalon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSalon.Name = "cbSalon";
            this.cbSalon.Size = new System.Drawing.Size(140, 24);
            this.cbSalon.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo de Evento :";
            // 
            // cbTipoEvento
            // 
            this.cbTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEvento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoEvento.FormattingEnabled = true;
            this.cbTipoEvento.Items.AddRange(new object[] {
            "Desayuno",
            "Comida",
            "Cena"});
            this.cbTipoEvento.Location = new System.Drawing.Point(427, 91);
            this.cbTipoEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoEvento.Name = "cbTipoEvento";
            this.cbTipoEvento.Size = new System.Drawing.Size(140, 24);
            this.cbTipoEvento.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(604, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Categoría :";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Bautizo",
            "Mis XV",
            "Boda",
            "Graduacion",
            "Posada",
            "Otro"});
            this.cbCategoria.Location = new System.Drawing.Point(695, 89);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(140, 24);
            this.cbCategoria.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha :";
            // 
            // fechaEvento
            // 
            this.fechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fechaEvento.Location = new System.Drawing.Point(695, 133);
            this.fechaEvento.Name = "fechaEvento";
            this.fechaEvento.Size = new System.Drawing.Size(140, 20);
            this.fechaEvento.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(0, 655);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(871, 5);
            this.label9.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBuscarEvento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 68);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Evento";
            // 
            // cbBuscarEvento
            // 
            this.cbBuscarEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarEvento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarEvento.FormattingEnabled = true;
            this.cbBuscarEvento.Items.AddRange(new object[] {
            "Bautizo",
            "Mis XV",
            "Boda",
            "Graduación",
            "Posada",
            "Otro"});
            this.cbBuscarEvento.Location = new System.Drawing.Point(124, 29);
            this.cbBuscarEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBuscarEvento.Name = "cbBuscarEvento";
            this.cbBuscarEvento.Size = new System.Drawing.Size(140, 24);
            this.cbBuscarEvento.TabIndex = 21;
            this.cbBuscarEvento.SelectedIndexChanged += new System.EventHandler(this.cbBuscarEvento_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Categoría :";
            // 
            // dgEventos
            // 
            this.dgEventos.AllowUserToAddRows = false;
            this.dgEventos.AllowUserToDeleteRows = false;
            this.dgEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEventos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEventos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgEventos.Location = new System.Drawing.Point(12, 300);
            this.dgEventos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgEventos.Name = "dgEventos";
            this.dgEventos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgEventos.Size = new System.Drawing.Size(836, 275);
            this.dgEventos.TabIndex = 48;
            this.dgEventos.SelectionChanged += new System.EventHandler(this.dgEventos_SelectionChanged);
            // 
            // txtCostoBanquete
            // 
            this.txtCostoBanquete.Enabled = false;
            this.txtCostoBanquete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoBanquete.ForeColor = System.Drawing.Color.Red;
            this.txtCostoBanquete.Location = new System.Drawing.Point(279, 616);
            this.txtCostoBanquete.Name = "txtCostoBanquete";
            this.txtCostoBanquete.Size = new System.Drawing.Size(116, 25);
            this.txtCostoBanquete.TabIndex = 49;
            this.txtCostoBanquete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 619);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 18);
            this.label10.TabIndex = 50;
            this.label10.Text = "Costo Total =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Costo Banquete $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(401, 619);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 18);
            this.label11.TabIndex = 52;
            this.label11.Text = "+";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(424, 619);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 18);
            this.label12.TabIndex = 53;
            this.label12.Text = "Costo Musica $";
            // 
            // txtCostoMusica
            // 
            this.txtCostoMusica.Enabled = false;
            this.txtCostoMusica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoMusica.ForeColor = System.Drawing.Color.Black;
            this.txtCostoMusica.Location = new System.Drawing.Point(552, 616);
            this.txtCostoMusica.Name = "txtCostoMusica";
            this.txtCostoMusica.Size = new System.Drawing.Size(106, 25);
            this.txtCostoMusica.TabIndex = 54;
            this.txtCostoMusica.Text = "0";
            this.txtCostoMusica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(664, 619);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 18);
            this.label13.TabIndex = 55;
            this.label13.Text = " = ";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Enabled = false;
            this.txtCostoTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTotal.ForeColor = System.Drawing.Color.Red;
            this.txtCostoTotal.Location = new System.Drawing.Point(695, 616);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(140, 25);
            this.txtCostoTotal.TabIndex = 56;
            this.txtCostoTotal.Text = "0";
            this.txtCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(-3, 597);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(871, 5);
            this.label14.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(3, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(871, 5);
            this.label15.TabIndex = 58;
            // 
            // FEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 678);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCostoTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCostoMusica);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCostoBanquete);
            this.Controls.Add(this.dgEventos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fechaEvento);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbTipoEvento);
            this.Controls.Add(this.cbSalon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBanquete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVENTOS";
            this.Load += new System.EventHandler(this.FEventos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bajaEvento;
        private System.Windows.Forms.ToolStripButton closeVentana;
        private System.Windows.Forms.ToolStripButton altaEvento;
        private System.Windows.Forms.ToolStripButton modificarEvento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBanquete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSalon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fechaEvento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgEventos;
        private System.Windows.Forms.TextBox txtCostoBanquete;
        private System.Windows.Forms.ComboBox cbBuscarEvento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton tsAgregarMusicos;
        private System.Windows.Forms.ToolStripButton tsAgregarEmpleados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCostoMusica;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}
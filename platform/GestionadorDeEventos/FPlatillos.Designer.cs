namespace GestionadorDeEventos
{
    partial class FPlatillos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPostres = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgPlatillos = new System.Windows.Forms.DataGridView();
            this.txtPreparacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbBuscarPlatillo = new System.Windows.Forms.ComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imgPlatillo = new System.Windows.Forms.PictureBox();
            this.closeVentana = new System.Windows.Forms.ToolStripButton();
            this.altaPlatillo = new System.Windows.Forms.ToolStripButton();
            this.bajaPlatillo = new System.Windows.Forms.ToolStripButton();
            this.modificarPlatillo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlatillos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlatillo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeVentana,
            this.toolStripSeparator1,
            this.altaPlatillo,
            this.bajaPlatillo,
            this.modificarPlatillo,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(872, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Platillo :";
            // 
            // cbPostres
            // 
            this.cbPostres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPostres.FormattingEnabled = true;
            this.cbPostres.Items.AddRange(new object[] {
            "Entremes",
            "Crema",
            "Sopa",
            "Fuerte",
            "Postre",
            "Niño"});
            this.cbPostres.Location = new System.Drawing.Point(136, 79);
            this.cbPostres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPostres.Name = "cbPostres";
            this.cbPostres.Size = new System.Drawing.Size(140, 24);
            this.cbPostres.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(136, 141);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(140, 22);
            this.txtPrecio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio :";
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Enabled = false;
            this.txtImagenUrl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagenUrl.Location = new System.Drawing.Point(136, 172);
            this.txtImagenUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(328, 22);
            this.txtImagenUrl.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Imagen :";
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(470, 74);
            this.txtIngredientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIngredientes.Size = new System.Drawing.Size(389, 84);
            this.txtIngredientes.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingredientes :";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(470, 169);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(83, 28);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dgPlatillos
            // 
            this.dgPlatillos.AllowUserToAddRows = false;
            this.dgPlatillos.AllowUserToDeleteRows = false;
            this.dgPlatillos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPlatillos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPlatillos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPlatillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlatillos.Location = new System.Drawing.Point(14, 469);
            this.dgPlatillos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgPlatillos.Name = "dgPlatillos";
            this.dgPlatillos.ReadOnly = true;
            this.dgPlatillos.Size = new System.Drawing.Size(843, 241);
            this.dgPlatillos.TabIndex = 13;
            this.dgPlatillos.SelectionChanged += new System.EventHandler(this.dgPlatillos_SelectionChanged);
            // 
            // txtPreparacion
            // 
            this.txtPreparacion.Location = new System.Drawing.Point(136, 202);
            this.txtPreparacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreparacion.Multiline = true;
            this.txtPreparacion.Name = "txtPreparacion";
            this.txtPreparacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreparacion.Size = new System.Drawing.Size(328, 133);
            this.txtPreparacion.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Preparación :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBuscarPlatillo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 68);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tipo de Platillo :";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(1, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(871, 5);
            this.label10.TabIndex = 44;
            // 
            // cbBuscarPlatillo
            // 
            this.cbBuscarPlatillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarPlatillo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarPlatillo.FormattingEnabled = true;
            this.cbBuscarPlatillo.Items.AddRange(new object[] {
            "Entremes",
            "Crema",
            "Sopa",
            "Fuerte",
            "Postre",
            "Niño"});
            this.cbBuscarPlatillo.Location = new System.Drawing.Point(147, 25);
            this.cbBuscarPlatillo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBuscarPlatillo.Name = "cbBuscarPlatillo";
            this.cbBuscarPlatillo.Size = new System.Drawing.Size(140, 24);
            this.cbBuscarPlatillo.TabIndex = 45;
            this.cbBuscarPlatillo.SelectedIndexChanged += new System.EventHandler(this.cbBuscarPlatillo_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // imgPlatillo
            // 
            this.imgPlatillo.BackColor = System.Drawing.Color.LightGray;
            this.imgPlatillo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgPlatillo.Location = new System.Drawing.Point(559, 166);
            this.imgPlatillo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgPlatillo.Name = "imgPlatillo";
            this.imgPlatillo.Size = new System.Drawing.Size(300, 169);
            this.imgPlatillo.TabIndex = 12;
            this.imgPlatillo.TabStop = false;
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
            // altaPlatillo
            // 
            this.altaPlatillo.Image = global::GestionadorDeEventos.Properties.Resources.addPlate;
            this.altaPlatillo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.altaPlatillo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.altaPlatillo.Name = "altaPlatillo";
            this.altaPlatillo.Size = new System.Drawing.Size(101, 52);
            this.altaPlatillo.Text = "Agregar";
            this.altaPlatillo.Click += new System.EventHandler(this.altaPlatillo_Click);
            // 
            // bajaPlatillo
            // 
            this.bajaPlatillo.Image = global::GestionadorDeEventos.Properties.Resources.deletePlate;
            this.bajaPlatillo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bajaPlatillo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bajaPlatillo.Name = "bajaPlatillo";
            this.bajaPlatillo.Size = new System.Drawing.Size(102, 52);
            this.bajaPlatillo.Text = "Eliminar";
            this.bajaPlatillo.Click += new System.EventHandler(this.bajaPlatillo_Click);
            // 
            // modificarPlatillo
            // 
            this.modificarPlatillo.Image = global::GestionadorDeEventos.Properties.Resources.updatePlate;
            this.modificarPlatillo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.modificarPlatillo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modificarPlatillo.Name = "modificarPlatillo";
            this.modificarPlatillo.Size = new System.Drawing.Size(110, 52);
            this.modificarPlatillo.Text = "Modificar";
            this.modificarPlatillo.Click += new System.EventHandler(this.modificarPlatillo_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::GestionadorDeEventos.Properties.Resources.clear_icon;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(99, 52);
            this.toolStripButton1.Text = "Limpiar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FPlatillos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 722);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPreparacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgPlatillos);
            this.Controls.Add(this.imgPlatillo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPostres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPlatillos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLATILLOS";
            this.Load += new System.EventHandler(this.FPlatillos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlatillos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlatillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton altaPlatillo;
        private System.Windows.Forms.ToolStripButton bajaPlatillo;
        private System.Windows.Forms.ToolStripButton modificarPlatillo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPostres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.PictureBox imgPlatillo;
        private System.Windows.Forms.DataGridView dgPlatillos;
        private System.Windows.Forms.TextBox txtPreparacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton closeVentana;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbBuscarPlatillo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
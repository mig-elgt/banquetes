namespace GestionadorDeEventos
{
    partial class FMusicos
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
            this.dgMusicos = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtLogoUrl = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoMusica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.closeVentana = new System.Windows.Forms.ToolStripButton();
            this.altaMusico = new System.Windows.Forms.ToolStripButton();
            this.bajaMusico = new System.Windows.Forms.ToolStripButton();
            this.modificarMusico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusicos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMusicos
            // 
            this.dgMusicos.AllowUserToAddRows = false;
            this.dgMusicos.AllowUserToDeleteRows = false;
            this.dgMusicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMusicos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMusicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMusicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMusicos.Location = new System.Drawing.Point(14, 427);
            this.dgMusicos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgMusicos.Name = "dgMusicos";
            this.dgMusicos.ReadOnly = true;
            this.dgMusicos.Size = new System.Drawing.Size(843, 282);
            this.dgMusicos.TabIndex = 30;
            this.dgMusicos.SelectionChanged += new System.EventHandler(this.dgMusicos_SelectionChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(479, 262);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(349, 24);
            this.btnCargar.TabIndex = 28;
            this.btnCargar.Text = "Cargar Imagen de logo";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtLogoUrl
            // 
            this.txtLogoUrl.Enabled = false;
            this.txtLogoUrl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogoUrl.Location = new System.Drawing.Point(592, 339);
            this.txtLogoUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogoUrl.Name = "txtLogoUrl";
            this.txtLogoUrl.Size = new System.Drawing.Size(236, 22);
            this.txtLogoUrl.TabIndex = 25;
            this.txtLogoUrl.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(176, 172);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(212, 22);
            this.txtDireccion.TabIndex = 23;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dirección :";
            // 
            // txtDirector
            // 
            this.txtDirector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Location = new System.Drawing.Point(176, 142);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(212, 22);
            this.txtDirector.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Director :";
            // 
            // cbTipoMusica
            // 
            this.cbTipoMusica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMusica.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoMusica.FormattingEnabled = true;
            this.cbTipoMusica.Items.AddRange(new object[] {
            "Mariachi",
            "Banda",
            "Sonido",
            "Grupo"});
            this.cbTipoMusica.Location = new System.Drawing.Point(176, 83);
            this.cbTipoMusica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoMusica.Name = "cbTipoMusica";
            this.cbTipoMusica.Size = new System.Drawing.Size(212, 24);
            this.cbTipoMusica.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tipo de Musica :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeVentana,
            this.toolStripSeparator1,
            this.altaMusico,
            this.bajaMusico,
            this.modificarMusico,
            this.toolStripSeparator2,
            this.toolStripButton1});
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
            // altaMusico
            // 
            this.altaMusico.Image = global::GestionadorDeEventos.Properties.Resources.addSinger;
            this.altaMusico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.altaMusico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.altaMusico.Name = "altaMusico";
            this.altaMusico.Size = new System.Drawing.Size(101, 52);
            this.altaMusico.Text = "Agregar";
            this.altaMusico.Click += new System.EventHandler(this.altaMusico_Click);
            // 
            // bajaMusico
            // 
            this.bajaMusico.Image = global::GestionadorDeEventos.Properties.Resources.deleteSinger;
            this.bajaMusico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bajaMusico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bajaMusico.Name = "bajaMusico";
            this.bajaMusico.Size = new System.Drawing.Size(102, 52);
            this.bajaMusico.Text = "Eliminar";
            this.bajaMusico.Click += new System.EventHandler(this.bajaMusico_Click);
            // 
            // modificarMusico
            // 
            this.modificarMusico.Image = global::GestionadorDeEventos.Properties.Resources.updateSinger;
            this.modificarMusico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.modificarMusico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modificarMusico.Name = "modificarMusico";
            this.modificarMusico.Size = new System.Drawing.Size(110, 52);
            this.modificarMusico.Text = "Modificar";
            this.modificarMusico.Click += new System.EventHandler(this.modificarMusico_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
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
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(176, 200);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 22);
            this.txtEmail.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(176, 232);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(212, 22);
            this.txtTelefono.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Teléfono :";
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(176, 262);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(212, 22);
            this.txtCosto.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Cobro por Hora :";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(176, 115);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 22);
            this.txtNombre.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Nombre :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 68);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Musico";
            // 
            // txtBuscarName
            // 
            this.txtBuscarName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarName.Location = new System.Drawing.Point(120, 25);
            this.txtBuscarName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscarName.Name = "txtBuscarName";
            this.txtBuscarName.Size = new System.Drawing.Size(190, 22);
            this.txtBuscarName.TabIndex = 39;
            this.txtBuscarName.TextChanged += new System.EventHandler(this.txtBuscarImg_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Nombre :";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(0, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(871, 5);
            this.label10.TabIndex = 43;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.LightGray;
            this.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgLogo.Location = new System.Drawing.Point(479, 87);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(349, 173);
            this.imgLogo.TabIndex = 29;
            this.imgLogo.TabStop = false;
            // 
            // FMusicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 722);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.dgMusicos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtLogoUrl);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoMusica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMusicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUSICOS";
            this.Load += new System.EventHandler(this.FMusicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMusicos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.ToolStripButton bajaMusico;
        private System.Windows.Forms.DataGridView dgMusicos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ToolStripButton closeVentana;
        private System.Windows.Forms.ToolStripButton altaMusico;
        private System.Windows.Forms.ToolStripButton modificarMusico;
        private System.Windows.Forms.TextBox txtLogoUrl;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoMusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
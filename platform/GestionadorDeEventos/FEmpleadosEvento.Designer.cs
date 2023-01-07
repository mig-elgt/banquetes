namespace GestionadorDeEventos
{
    partial class FEmpleadosEvento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bajaEmpleado = new System.Windows.Forms.ToolStripButton();
            this.altaEmpleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeVentana = new System.Windows.Forms.ToolStripButton();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEvento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaEvento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bajaEmpleado
            // 
            this.bajaEmpleado.Image = global::GestionadorDeEventos.Properties.Resources.deleteEmployee;
            this.bajaEmpleado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bajaEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bajaEmpleado.Name = "bajaEmpleado";
            this.bajaEmpleado.Size = new System.Drawing.Size(102, 52);
            this.bajaEmpleado.Text = "Eliminar";
            this.bajaEmpleado.Click += new System.EventHandler(this.bajaEmpleado_Click);
            // 
            // altaEmpleado
            // 
            this.altaEmpleado.Image = global::GestionadorDeEventos.Properties.Resources.addEmployee;
            this.altaEmpleado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.altaEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.altaEmpleado.Name = "altaEmpleado";
            this.altaEmpleado.Size = new System.Drawing.Size(101, 52);
            this.altaEmpleado.Text = "Agregar";
            this.altaEmpleado.Click += new System.EventHandler(this.altaEmpleado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
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
            // dgEmpleados
            // 
            this.dgEmpleados.AllowUserToAddRows = false;
            this.dgEmpleados.AllowUserToDeleteRows = false;
            this.dgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmpleados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgEmpleados.Location = new System.Drawing.Point(0, 259);
            this.dgEmpleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgEmpleados.Size = new System.Drawing.Size(709, 453);
            this.dgEmpleados.TabIndex = 69;
            this.dgEmpleados.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEmpleados_ColumnHeaderMouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeVentana,
            this.toolStripSeparator1,
            this.altaEmpleado,
            this.bajaEmpleado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(709, 55);
            this.toolStrip1.TabIndex = 60;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 70;
            this.label1.Text = "LISTA DE EMPLEADOS";
            // 
            // txtCodigoEvento
            // 
            this.txtCodigoEvento.Enabled = false;
            this.txtCodigoEvento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEvento.Location = new System.Drawing.Point(166, 134);
            this.txtCodigoEvento.Name = "txtCodigoEvento";
            this.txtCodigoEvento.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoEvento.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Fecha del Evento :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "Codigo del Evento :";
            // 
            // fechaEvento
            // 
            this.fechaEvento.Enabled = false;
            this.fechaEvento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEvento.Location = new System.Drawing.Point(460, 132);
            this.fechaEvento.Name = "fechaEvento";
            this.fechaEvento.Size = new System.Drawing.Size(232, 22);
            this.fechaEvento.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoEmpleado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 68);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // cbTipoEmpleado
            // 
            this.cbTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEmpleado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoEmpleado.FormattingEnabled = true;
            this.cbTipoEmpleado.Items.AddRange(new object[] {
            "Mesero",
            "Cocinero",
            "Coordinador"});
            this.cbTipoEmpleado.Location = new System.Drawing.Point(169, 25);
            this.cbTipoEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoEmpleado.Name = "cbTipoEmpleado";
            this.cbTipoEmpleado.Size = new System.Drawing.Size(160, 24);
            this.cbTipoEmpleado.TabIndex = 76;
            this.cbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbTipoEmpleado_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tipo de Empleado :";
            // 
            // FEmpleadosEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 712);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodigoEvento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEmpleadosEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLEADOS POR EVENTO";
            this.Load += new System.EventHandler(this.FEmpleadosEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bajaEmpleado;
        private System.Windows.Forms.ToolStripButton altaEmpleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton closeVentana;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaEvento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipoEmpleado;
    }
}
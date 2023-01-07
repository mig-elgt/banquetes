namespace GestionadorDeEventos
{
    partial class FMusicosEvento
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
            this.gbCatPlatillos = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HoraFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.horaInicial = new System.Windows.Forms.DateTimePicker();
            this.lbCostoHora = new System.Windows.Forms.Label();
            this.txtNombreMusico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab0 = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fechaEvento = new System.Windows.Forms.DateTimePicker();
            this.dgDetalleMusica = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuitarMusica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEvento = new System.Windows.Forms.TextBox();
            this.gbCatPlatillos.SuspendLayout();
            this.tab0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleMusica)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCatPlatillos
            // 
            this.gbCatPlatillos.Controls.Add(this.label5);
            this.gbCatPlatillos.Controls.Add(this.HoraFinal);
            this.gbCatPlatillos.Controls.Add(this.label3);
            this.gbCatPlatillos.Controls.Add(this.horaInicial);
            this.gbCatPlatillos.Controls.Add(this.lbCostoHora);
            this.gbCatPlatillos.Controls.Add(this.txtNombreMusico);
            this.gbCatPlatillos.Controls.Add(this.label6);
            this.gbCatPlatillos.Controls.Add(this.label4);
            this.gbCatPlatillos.Controls.Add(this.tab0);
            this.gbCatPlatillos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCatPlatillos.Location = new System.Drawing.Point(12, 51);
            this.gbCatPlatillos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCatPlatillos.Name = "gbCatPlatillos";
            this.gbCatPlatillos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCatPlatillos.Size = new System.Drawing.Size(788, 355);
            this.gbCatPlatillos.TabIndex = 13;
            this.gbCatPlatillos.TabStop = false;
            this.gbCatPlatillos.Text = "Catálogo de Musica";
            this.gbCatPlatillos.Enter += new System.EventHandler(this.gbCatPlatillos_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Hora Final :";
            // 
            // HoraFinal
            // 
            this.HoraFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraFinal.Location = new System.Drawing.Point(659, 22);
            this.HoraFinal.Name = "HoraFinal";
            this.HoraFinal.Size = new System.Drawing.Size(98, 22);
            this.HoraFinal.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Hora Inicial :";
            // 
            // horaInicial
            // 
            this.horaInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaInicial.Location = new System.Drawing.Point(428, 22);
            this.horaInicial.Name = "horaInicial";
            this.horaInicial.Size = new System.Drawing.Size(103, 22);
            this.horaInicial.TabIndex = 28;
            // 
            // lbCostoHora
            // 
            this.lbCostoHora.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostoHora.ForeColor = System.Drawing.Color.Red;
            this.lbCostoHora.Location = new System.Drawing.Point(691, 313);
            this.lbCostoHora.Name = "lbCostoHora";
            this.lbCostoHora.Size = new System.Drawing.Size(85, 22);
            this.lbCostoHora.TabIndex = 15;
            this.lbCostoHora.Text = "0";
            this.lbCostoHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreMusico
            // 
            this.txtNombreMusico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreMusico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreMusico.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombreMusico.Location = new System.Drawing.Point(96, 316);
            this.txtNombreMusico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreMusico.Multiline = true;
            this.txtNombreMusico.Name = "txtNombreMusico";
            this.txtNombreMusico.ReadOnly = true;
            this.txtNombreMusico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNombreMusico.Size = new System.Drawing.Size(369, 22);
            this.txtNombreMusico.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cobro por hora : $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre :";
            // 
            // tab0
            // 
            this.tab0.Controls.Add(this.tabPage0);
            this.tab0.Controls.Add(this.tabPage1);
            this.tab0.Controls.Add(this.tabPage2);
            this.tab0.Controls.Add(this.tabPage3);
            this.tab0.Location = new System.Drawing.Point(15, 51);
            this.tab0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab0.Name = "tab0";
            this.tab0.SelectedIndex = 0;
            this.tab0.Size = new System.Drawing.Size(761, 244);
            this.tab0.TabIndex = 0;
            // 
            // tabPage0
            // 
            this.tabPage0.AutoScroll = true;
            this.tabPage0.Location = new System.Drawing.Point(4, 25);
            this.tabPage0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage0.Size = new System.Drawing.Size(753, 215);
            this.tabPage0.TabIndex = 3;
            this.tabPage0.Text = "Mariachi";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(753, 215);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Banda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(753, 215);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Sonido";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(753, 215);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Grupo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fechaEvento
            // 
            this.fechaEvento.Enabled = false;
            this.fechaEvento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEvento.Location = new System.Drawing.Point(568, 18);
            this.fechaEvento.Name = "fechaEvento";
            this.fechaEvento.Size = new System.Drawing.Size(232, 22);
            this.fechaEvento.TabIndex = 19;
            // 
            // dgDetalleMusica
            // 
            this.dgDetalleMusica.AllowUserToAddRows = false;
            this.dgDetalleMusica.AllowUserToDeleteRows = false;
            this.dgDetalleMusica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetalleMusica.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalleMusica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetalleMusica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleMusica.Location = new System.Drawing.Point(27, 427);
            this.dgDetalleMusica.Name = "dgDetalleMusica";
            this.dgDetalleMusica.ReadOnly = true;
            this.dgDetalleMusica.Size = new System.Drawing.Size(761, 244);
            this.dgDetalleMusica.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Codigo del Evento :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(662, 687);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuitarMusica
            // 
            this.btnQuitarMusica.AccessibleDescription = "";
            this.btnQuitarMusica.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarMusica.Location = new System.Drawing.Point(27, 687);
            this.btnQuitarMusica.Name = "btnQuitarMusica";
            this.btnQuitarMusica.Size = new System.Drawing.Size(126, 23);
            this.btnQuitarMusica.TabIndex = 26;
            this.btnQuitarMusica.Text = "Eliminar";
            this.btnQuitarMusica.UseVisualStyleBackColor = true;
            this.btnQuitarMusica.Click += new System.EventHandler(this.btnQuitarMusica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha del Evento :";
            // 
            // txtCodigoEvento
            // 
            this.txtCodigoEvento.Enabled = false;
            this.txtCodigoEvento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEvento.Location = new System.Drawing.Point(180, 18);
            this.txtCodigoEvento.Name = "txtCodigoEvento";
            this.txtCodigoEvento.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoEvento.TabIndex = 28;
            // 
            // FMusicosEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 722);
            this.Controls.Add(this.txtCodigoEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitarMusica);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgDetalleMusica);
            this.Controls.Add(this.fechaEvento);
            this.Controls.Add(this.gbCatPlatillos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMusicosEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MUSICOS POR EVENTO";
            this.Load += new System.EventHandler(this.FMusicosEvento_Load);
            this.gbCatPlatillos.ResumeLayout(false);
            this.gbCatPlatillos.PerformLayout();
            this.tab0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleMusica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCatPlatillos;
        private System.Windows.Forms.DateTimePicker fechaEvento;
        private System.Windows.Forms.Label lbCostoHora;
        private System.Windows.Forms.TextBox txtNombreMusico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tab0;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgDetalleMusica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuitarMusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker HoraFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker horaInicial;
        private System.Windows.Forms.TextBox txtCodigoEvento;
    }
}
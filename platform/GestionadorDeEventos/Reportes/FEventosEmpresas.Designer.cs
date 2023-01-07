namespace GestionadorDeEventos.Reportes
{
    partial class FEventosEmpresas
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
            this.fechaEve = new System.Windows.Forms.DateTimePicker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.fechaInicial = new System.Windows.Forms.DateTimePicker();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeneraReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fechaEve
            // 
            this.fechaEve.Location = new System.Drawing.Point(370, 504);
            this.fechaEve.Name = "fechaEve";
            this.fechaEve.Size = new System.Drawing.Size(200, 20);
            this.fechaEve.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 75);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(980, 637);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // fechaInicial
            // 
            this.fechaInicial.Location = new System.Drawing.Point(146, 34);
            this.fechaInicial.Name = "fechaInicial";
            this.fechaInicial.Size = new System.Drawing.Size(200, 20);
            this.fechaInicial.TabIndex = 3;
            // 
            // fechaFinal
            // 
            this.fechaFinal.Location = new System.Drawing.Point(588, 32);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(200, 20);
            this.fechaFinal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha Inicial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Final :";
            // 
            // btnGeneraReporte
            // 
            this.btnGeneraReporte.Location = new System.Drawing.Point(835, 29);
            this.btnGeneraReporte.Name = "btnGeneraReporte";
            this.btnGeneraReporte.Size = new System.Drawing.Size(133, 23);
            this.btnGeneraReporte.TabIndex = 7;
            this.btnGeneraReporte.Text = "Generar Reporte";
            this.btnGeneraReporte.UseVisualStyleBackColor = true;
            this.btnGeneraReporte.Click += new System.EventHandler(this.btnGeneraReporte_Click);
            // 
            // FEventosEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 712);
            this.Controls.Add(this.btnGeneraReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaFinal);
            this.Controls.Add(this.fechaInicial);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.fechaEve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEventosEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEventosEmpresas";
            this.Load += new System.EventHandler(this.FEventosEmpresas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaEve;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker fechaInicial;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeneraReporte;
    }
}
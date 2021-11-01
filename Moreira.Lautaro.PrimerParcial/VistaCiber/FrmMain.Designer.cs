
namespace VistaCiber
{
    partial class FrmMain
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
            this.btnMostrarComputadoras = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsInformacion = new System.Windows.Forms.ToolStripLabel();
            this.btnCalculadoraDeSalario = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrarComputadoras
            // 
            this.btnMostrarComputadoras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMostrarComputadoras.BackColor = System.Drawing.SystemColors.Control;
            this.btnMostrarComputadoras.Location = new System.Drawing.Point(0, 88);
            this.btnMostrarComputadoras.Name = "btnMostrarComputadoras";
            this.btnMostrarComputadoras.Size = new System.Drawing.Size(288, 125);
            this.btnMostrarComputadoras.TabIndex = 2;
            this.btnMostrarComputadoras.Text = "Mostrar equipos.";
            this.btnMostrarComputadoras.UseVisualStyleBackColor = false;
            this.btnMostrarComputadoras.Click += new System.EventHandler(this.btnMostrarComputadoras_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHistorial.Location = new System.Drawing.Point(0, 229);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(288, 125);
            this.btnHistorial.TabIndex = 5;
            this.btnHistorial.Text = "Mostrar Historial del ciber";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInformacion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(288, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsInformacion
            // 
            this.tsInformacion.Name = "tsInformacion";
            this.tsInformacion.Size = new System.Drawing.Size(86, 22);
            this.tsInformacion.Text = "toolStripLabel1";
            // 
            // btnCalculadoraDeSalario
            // 
            this.btnCalculadoraDeSalario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalculadoraDeSalario.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculadoraDeSalario.Location = new System.Drawing.Point(0, 369);
            this.btnCalculadoraDeSalario.Name = "btnCalculadoraDeSalario";
            this.btnCalculadoraDeSalario.Size = new System.Drawing.Size(288, 125);
            this.btnCalculadoraDeSalario.TabIndex = 7;
            this.btnCalculadoraDeSalario.Text = "Calculadora de salario";
            this.btnCalculadoraDeSalario.UseVisualStyleBackColor = false;
            this.btnCalculadoraDeSalario.Click += new System.EventHandler(this.btnCalculadoraDeSalario_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(191, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(85, 58);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(288, 506);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCalculadoraDeSalario);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnMostrarComputadoras);
            this.MinimumSize = new System.Drawing.Size(304, 545);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterLVM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarComputadoras;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsInformacion;
        private System.Windows.Forms.Button btnCalculadoraDeSalario;
        private System.Windows.Forms.Button btnHelp;
    }
}
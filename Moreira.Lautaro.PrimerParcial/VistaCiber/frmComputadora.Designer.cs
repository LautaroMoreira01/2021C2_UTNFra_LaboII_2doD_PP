
namespace VistaCiber
{
    partial class frmComputadora
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
            this.rtbInformacionComputadora = new System.Windows.Forms.RichTextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAsignarCliente = new System.Windows.Forms.Button();
            this.cbTiempoSolicitado = new System.Windows.Forms.ComboBox();
            this.lblTiempoSolicitado = new System.Windows.Forms.Label();
            this.nupMinutos = new System.Windows.Forms.NumericUpDown();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.nupHoras = new System.Windows.Forms.NumericUpDown();
            this.lblHoras = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbInformacionComputadora
            // 
            this.rtbInformacionComputadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbInformacionComputadora.Location = new System.Drawing.Point(1, 72);
            this.rtbInformacionComputadora.Name = "rtbInformacionComputadora";
            this.rtbInformacionComputadora.ReadOnly = true;
            this.rtbInformacionComputadora.Size = new System.Drawing.Size(284, 301);
            this.rtbInformacionComputadora.TabIndex = 0;
            this.rtbInformacionComputadora.Text = "";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFinalizar.Location = new System.Drawing.Point(12, 476);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(121, 61);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAsignarCliente
            // 
            this.btnAsignarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAsignarCliente.Location = new System.Drawing.Point(12, 409);
            this.btnAsignarCliente.Name = "btnAsignarCliente";
            this.btnAsignarCliente.Size = new System.Drawing.Size(121, 61);
            this.btnAsignarCliente.TabIndex = 2;
            this.btnAsignarCliente.Text = "Asignar cliente.";
            this.btnAsignarCliente.UseVisualStyleBackColor = true;
            this.btnAsignarCliente.Click += new System.EventHandler(this.btnAsignarCliente_Click);
            // 
            // cbTiempoSolicitado
            // 
            this.cbTiempoSolicitado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTiempoSolicitado.FormattingEnabled = true;
            this.cbTiempoSolicitado.Items.AddRange(new object[] {
            "Ingresar tiempo",
            "Libre"});
            this.cbTiempoSolicitado.Location = new System.Drawing.Point(151, 427);
            this.cbTiempoSolicitado.Name = "cbTiempoSolicitado";
            this.cbTiempoSolicitado.Size = new System.Drawing.Size(121, 23);
            this.cbTiempoSolicitado.TabIndex = 3;
            this.cbTiempoSolicitado.SelectedIndexChanged += new System.EventHandler(this.cbTiempoSolicitado_SelectedIndexChanged);
            // 
            // lblTiempoSolicitado
            // 
            this.lblTiempoSolicitado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTiempoSolicitado.AutoSize = true;
            this.lblTiempoSolicitado.Location = new System.Drawing.Point(151, 409);
            this.lblTiempoSolicitado.Name = "lblTiempoSolicitado";
            this.lblTiempoSolicitado.Size = new System.Drawing.Size(101, 15);
            this.lblTiempoSolicitado.TabIndex = 4;
            this.lblTiempoSolicitado.Text = "Tiempo solicitado";
            // 
            // nupMinutos
            // 
            this.nupMinutos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nupMinutos.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupMinutos.Location = new System.Drawing.Point(224, 519);
            this.nupMinutos.Name = "nupMinutos";
            this.nupMinutos.ReadOnly = true;
            this.nupMinutos.Size = new System.Drawing.Size(48, 23);
            this.nupMinutos.TabIndex = 5;
            this.nupMinutos.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupMinutos.ValueChanged += new System.EventHandler(this.nupMinutos_ValueChanged);
            // 
            // lblMinutos
            // 
            this.lblMinutos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinutos.Location = new System.Drawing.Point(151, 519);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(67, 21);
            this.lblMinutos.TabIndex = 6;
            this.lblMinutos.Text = "Minutos";
            // 
            // nupHoras
            // 
            this.nupHoras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nupHoras.InterceptArrowKeys = false;
            this.nupHoras.Location = new System.Drawing.Point(224, 479);
            this.nupHoras.Name = "nupHoras";
            this.nupHoras.ReadOnly = true;
            this.nupHoras.Size = new System.Drawing.Size(48, 23);
            this.nupHoras.TabIndex = 7;
            // 
            // lblHoras
            // 
            this.lblHoras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoras.Location = new System.Drawing.Point(151, 479);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(51, 21);
            this.lblHoras.TabIndex = 8;
            this.lblHoras.Text = "Horas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.Location = new System.Drawing.Point(75, 441);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 75);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(197, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 46);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmComputadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 633);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.nupHoras);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.nupMinutos);
            this.Controls.Add(this.lblTiempoSolicitado);
            this.Controls.Add(this.cbTiempoSolicitado);
            this.Controls.Add(this.btnAsignarCliente);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.rtbInformacionComputadora);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(300, 489);
            this.Name = "frmComputadora";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computadora";
            this.Load += new System.EventHandler(this.frmComputadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInformacionComputadora;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAsignarCliente;
        private System.Windows.Forms.ComboBox cbTiempoSolicitado;
        private System.Windows.Forms.NumericUpDown nupMinutos;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.NumericUpDown nupHoras;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblTiempoSolicitado;

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnHelp;
    }
}
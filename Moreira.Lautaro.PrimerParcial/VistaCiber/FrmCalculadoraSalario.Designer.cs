namespace VistaCiber
{
    partial class FrmCalculadoraSalario
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.nupDiasTrabajados = new System.Windows.Forms.NumericUpDown();
            this.nupHorasTrabajadas = new System.Windows.Forms.NumericUpDown();
            this.lblDiasTrabajados = new System.Windows.Forms.Label();
            this.lblHorasPorDia = new System.Windows.Forms.Label();
            this.tbSalarioPorHora = new System.Windows.Forms.TextBox();
            this.lblSalarioPorhora = new System.Windows.Forms.Label();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.gbImpuestos = new System.Windows.Forms.GroupBox();
            this.cbxImpuestoALasGanancias = new System.Windows.Forms.CheckBox();
            this.cbxSindicato = new System.Windows.Forms.CheckBox();
            this.cbxObraSocial = new System.Windows.Forms.CheckBox();
            this.cbxJubilacion = new System.Windows.Forms.CheckBox();
            this.rtbInformacionSalario = new System.Windows.Forms.RichTextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.gbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiasTrabajados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHorasTrabajadas)).BeginInit();
            this.gbImpuestos.SuspendLayout();
            this.gbDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(669, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(48, 44);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // gbInformacion
            // 
            this.gbInformacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbInformacion.Controls.Add(this.nupDiasTrabajados);
            this.gbInformacion.Controls.Add(this.nupHorasTrabajadas);
            this.gbInformacion.Controls.Add(this.lblDiasTrabajados);
            this.gbInformacion.Controls.Add(this.lblHorasPorDia);
            this.gbInformacion.Controls.Add(this.tbSalarioPorHora);
            this.gbInformacion.Controls.Add(this.lblSalarioPorhora);
            this.gbInformacion.Location = new System.Drawing.Point(269, 205);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(414, 100);
            this.gbInformacion.TabIndex = 8;
            this.gbInformacion.TabStop = false;
            // 
            // nupDiasTrabajados
            // 
            this.nupDiasTrabajados.Location = new System.Drawing.Point(282, 63);
            this.nupDiasTrabajados.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nupDiasTrabajados.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDiasTrabajados.Name = "nupDiasTrabajados";
            this.nupDiasTrabajados.ReadOnly = true;
            this.nupDiasTrabajados.Size = new System.Drawing.Size(120, 23);
            this.nupDiasTrabajados.TabIndex = 7;
            this.nupDiasTrabajados.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupHorasTrabajadas
            // 
            this.nupHorasTrabajadas.Location = new System.Drawing.Point(142, 62);
            this.nupHorasTrabajadas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupHorasTrabajadas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupHorasTrabajadas.Name = "nupHorasTrabajadas";
            this.nupHorasTrabajadas.ReadOnly = true;
            this.nupHorasTrabajadas.Size = new System.Drawing.Size(120, 23);
            this.nupHorasTrabajadas.TabIndex = 6;
            this.nupHorasTrabajadas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDiasTrabajados
            // 
            this.lblDiasTrabajados.AutoSize = true;
            this.lblDiasTrabajados.Location = new System.Drawing.Point(282, 34);
            this.lblDiasTrabajados.Name = "lblDiasTrabajados";
            this.lblDiasTrabajados.Size = new System.Drawing.Size(87, 15);
            this.lblDiasTrabajados.TabIndex = 5;
            this.lblDiasTrabajados.Text = "Dias trabajados";
            // 
            // lblHorasPorDia
            // 
            this.lblHorasPorDia.AutoSize = true;
            this.lblHorasPorDia.Location = new System.Drawing.Point(142, 33);
            this.lblHorasPorDia.Name = "lblHorasPorDia";
            this.lblHorasPorDia.Size = new System.Drawing.Size(95, 15);
            this.lblHorasPorDia.TabIndex = 3;
            this.lblHorasPorDia.Text = "Horas trabajadas";
            // 
            // tbSalarioPorHora
            // 
            this.tbSalarioPorHora.Location = new System.Drawing.Point(6, 62);
            this.tbSalarioPorHora.Name = "tbSalarioPorHora";
            this.tbSalarioPorHora.Size = new System.Drawing.Size(119, 23);
            this.tbSalarioPorHora.TabIndex = 2;
            // 
            // lblSalarioPorhora
            // 
            this.lblSalarioPorhora.AutoSize = true;
            this.lblSalarioPorhora.Location = new System.Drawing.Point(6, 34);
            this.lblSalarioPorhora.Name = "lblSalarioPorhora";
            this.lblSalarioPorhora.Size = new System.Drawing.Size(89, 15);
            this.lblSalarioPorhora.TabIndex = 1;
            this.lblSalarioPorhora.Text = "salario por hora";
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalcularSalario.Location = new System.Drawing.Point(323, 712);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(101, 55);
            this.btnCalcularSalario.TabIndex = 10;
            this.btnCalcularSalario.Text = "Calcular salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // gbImpuestos
            // 
            this.gbImpuestos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbImpuestos.Controls.Add(this.cbxImpuestoALasGanancias);
            this.gbImpuestos.Controls.Add(this.cbxSindicato);
            this.gbImpuestos.Controls.Add(this.cbxObraSocial);
            this.gbImpuestos.Controls.Add(this.cbxJubilacion);
            this.gbImpuestos.Location = new System.Drawing.Point(63, 205);
            this.gbImpuestos.Name = "gbImpuestos";
            this.gbImpuestos.Size = new System.Drawing.Size(200, 179);
            this.gbImpuestos.TabIndex = 11;
            this.gbImpuestos.TabStop = false;
            // 
            // cbxImpuestoALasGanancias
            // 
            this.cbxImpuestoALasGanancias.AutoSize = true;
            this.cbxImpuestoALasGanancias.Location = new System.Drawing.Point(18, 139);
            this.cbxImpuestoALasGanancias.Name = "cbxImpuestoALasGanancias";
            this.cbxImpuestoALasGanancias.Size = new System.Drawing.Size(183, 19);
            this.cbxImpuestoALasGanancias.TabIndex = 3;
            this.cbxImpuestoALasGanancias.Text = "Impuesto a las ganancias 10%";
            this.cbxImpuestoALasGanancias.UseVisualStyleBackColor = true;
            // 
            // cbxSindicato
            // 
            this.cbxSindicato.AutoSize = true;
            this.cbxSindicato.Location = new System.Drawing.Point(18, 103);
            this.cbxSindicato.Name = "cbxSindicato";
            this.cbxSindicato.Size = new System.Drawing.Size(94, 19);
            this.cbxSindicato.TabIndex = 2;
            this.cbxSindicato.Text = "Sindicato 5%";
            this.cbxSindicato.UseVisualStyleBackColor = true;
            // 
            // cbxObraSocial
            // 
            this.cbxObraSocial.AutoSize = true;
            this.cbxObraSocial.Location = new System.Drawing.Point(18, 67);
            this.cbxObraSocial.Name = "cbxObraSocial";
            this.cbxObraSocial.Size = new System.Drawing.Size(104, 19);
            this.cbxObraSocial.TabIndex = 1;
            this.cbxObraSocial.Text = "Obra social 3%";
            this.cbxObraSocial.UseVisualStyleBackColor = true;
            // 
            // cbxJubilacion
            // 
            this.cbxJubilacion.AutoSize = true;
            this.cbxJubilacion.Location = new System.Drawing.Point(18, 34);
            this.cbxJubilacion.Name = "cbxJubilacion";
            this.cbxJubilacion.Size = new System.Drawing.Size(104, 19);
            this.cbxJubilacion.TabIndex = 0;
            this.cbxJubilacion.Text = "Jubilacion 11%";
            this.cbxJubilacion.UseVisualStyleBackColor = true;
            // 
            // rtbInformacionSalario
            // 
            this.rtbInformacionSalario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtbInformacionSalario.Location = new System.Drawing.Point(63, 408);
            this.rtbInformacionSalario.Name = "rtbInformacionSalario";
            this.rtbInformacionSalario.Size = new System.Drawing.Size(620, 298);
            this.rtbInformacionSalario.TabIndex = 12;
            this.rtbInformacionSalario.Text = "";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNombre.Location = new System.Drawing.Point(18, 60);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(119, 23);
            this.tbNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "nombre";
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbApellido.Location = new System.Drawing.Point(173, 60);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.ReadOnly = true;
            this.tbApellido.Size = new System.Drawing.Size(119, 23);
            this.tbApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(173, 32);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "apellido";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(328, 60);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.ReadOnly = true;
            this.tbEdad.Size = new System.Drawing.Size(119, 23);
            this.tbEdad.TabIndex = 4;
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(328, 32);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "edad";
            // 
            // tbDni
            // 
            this.tbDni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDni.Location = new System.Drawing.Point(488, 60);
            this.tbDni.Name = "tbDni";
            this.tbDni.ReadOnly = true;
            this.tbDni.Size = new System.Drawing.Size(119, 23);
            this.tbDni.TabIndex = 6;
            // 
            // lblDni
            // 
            this.lblDni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(488, 32);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(24, 15);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "dni";
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDatosPersonales.Controls.Add(this.lblDni);
            this.gbDatosPersonales.Controls.Add(this.tbDni);
            this.gbDatosPersonales.Controls.Add(this.lblEdad);
            this.gbDatosPersonales.Controls.Add(this.tbEdad);
            this.gbDatosPersonales.Controls.Add(this.lblApellido);
            this.gbDatosPersonales.Controls.Add(this.tbApellido);
            this.gbDatosPersonales.Controls.Add(this.lblNombre);
            this.gbDatosPersonales.Controls.Add(this.tbNombre);
            this.gbDatosPersonales.Location = new System.Drawing.Point(63, 85);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(620, 100);
            this.gbDatosPersonales.TabIndex = 0;
            this.gbDatosPersonales.TabStop = false;
            // 
            // FrmCalculadoraSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 779);
            this.Controls.Add(this.rtbInformacionSalario);
            this.Controls.Add(this.gbImpuestos);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.gbDatosPersonales);
            this.Name = "FrmCalculadoraSalario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de salario";
            this.Load += new System.EventHandler(this.FrmCalculadoraSalario_Load);
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiasTrabajados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHorasTrabajadas)).EndInit();
            this.gbImpuestos.ResumeLayout(false);
            this.gbImpuestos.PerformLayout();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.Label lblDiasTrabajados;
        private System.Windows.Forms.Label lblHorasPorDia;
        private System.Windows.Forms.TextBox tbSalarioPorHora;
        private System.Windows.Forms.Label lblSalarioPorhora;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.NumericUpDown nupDiasTrabajados;
        private System.Windows.Forms.NumericUpDown nupHorasTrabajadas;
        private System.Windows.Forms.GroupBox gbImpuestos;
        private System.Windows.Forms.CheckBox cbxObraSocial;
        private System.Windows.Forms.CheckBox cbxJubilacion;
        private System.Windows.Forms.CheckBox cbxImpuestoALasGanancias;
        private System.Windows.Forms.CheckBox cbxSindicato;
        private System.Windows.Forms.RichTextBox rtbInformacionSalario;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
    }
}
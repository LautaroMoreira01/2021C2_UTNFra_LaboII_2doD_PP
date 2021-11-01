
namespace VistaCiber
{
    partial class FrmTelefono
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
            this.tbCodigoPais = new System.Windows.Forms.TextBox();
            this.tbPrefijoLocalidad = new System.Windows.Forms.TextBox();
            this.tbRestoDelNumero = new System.Windows.Forms.TextBox();
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.lblPrefijo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.rtbInformacionTelefono = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCodigoPais
            // 
            this.tbCodigoPais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCodigoPais.Location = new System.Drawing.Point(8, 313);
            this.tbCodigoPais.Name = "tbCodigoPais";
            this.tbCodigoPais.Size = new System.Drawing.Size(63, 23);
            this.tbCodigoPais.TabIndex = 0;
            // 
            // tbPrefijoLocalidad
            // 
            this.tbPrefijoLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPrefijoLocalidad.Location = new System.Drawing.Point(98, 313);
            this.tbPrefijoLocalidad.Name = "tbPrefijoLocalidad";
            this.tbPrefijoLocalidad.Size = new System.Drawing.Size(63, 23);
            this.tbPrefijoLocalidad.TabIndex = 1;
            // 
            // tbRestoDelNumero
            // 
            this.tbRestoDelNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbRestoDelNumero.Location = new System.Drawing.Point(211, 313);
            this.tbRestoDelNumero.Name = "tbRestoDelNumero";
            this.tbRestoDelNumero.Size = new System.Drawing.Size(116, 23);
            this.tbRestoDelNumero.TabIndex = 2;
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(8, 295);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(70, 15);
            this.lblCodigoPais.TabIndex = 4;
            this.lblCodigoPais.Text = "Codigo pais";
            // 
            // lblPrefijo
            // 
            this.lblPrefijo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrefijo.AutoSize = true;
            this.lblPrefijo.Location = new System.Drawing.Point(98, 295);
            this.lblPrefijo.Name = "lblPrefijo";
            this.lblPrefijo.Size = new System.Drawing.Size(92, 15);
            this.lblPrefijo.TabIndex = 5;
            this.lblPrefijo.Text = "Prefijo localidad";
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(211, 295);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAsignar.Location = new System.Drawing.Point(8, 357);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(154, 91);
            this.btnAsignar.TabIndex = 9;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnLiberar
            // 
            this.btnLiberar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLiberar.Location = new System.Drawing.Point(189, 357);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(154, 91);
            this.btnLiberar.TabIndex = 10;
            this.btnLiberar.Text = "Liberar";
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // rtbInformacionTelefono
            // 
            this.rtbInformacionTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbInformacionTelefono.Location = new System.Drawing.Point(-1, 76);
            this.rtbInformacionTelefono.Name = "rtbInformacionTelefono";
            this.rtbInformacionTelefono.ReadOnly = true;
            this.rtbInformacionTelefono.Size = new System.Drawing.Size(359, 203);
            this.rtbInformacionTelefono.TabIndex = 11;
            this.rtbInformacionTelefono.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.Location = new System.Drawing.Point(98, 357);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(139, 91);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(268, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 58);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FrmTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 468);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rtbInformacionTelefono);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblPrefijo);
            this.Controls.Add(this.lblCodigoPais);
            this.Controls.Add(this.tbRestoDelNumero);
            this.Controls.Add(this.tbPrefijoLocalidad);
            this.Controls.Add(this.tbCodigoPais);
            this.MinimumSize = new System.Drawing.Size(375, 443);
            this.Name = "FrmTelefono";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefono";
            this.Load += new System.EventHandler(this.FrmTelefono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigoPais;
        private System.Windows.Forms.TextBox tbPrefijoLocalidad;
        private System.Windows.Forms.TextBox tbRestoDelNumero;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.Label lblPrefijo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.RichTextBox rtbInformacionTelefono;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnHelp;
    }
}
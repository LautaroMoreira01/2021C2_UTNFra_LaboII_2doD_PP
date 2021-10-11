
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
            this.SuspendLayout();
            // 
            // tbCodigoPais
            // 
            this.tbCodigoPais.Location = new System.Drawing.Point(12, 224);
            this.tbCodigoPais.Name = "tbCodigoPais";
            this.tbCodigoPais.Size = new System.Drawing.Size(63, 23);
            this.tbCodigoPais.TabIndex = 0;
            // 
            // tbPrefijoLocalidad
            // 
            this.tbPrefijoLocalidad.Location = new System.Drawing.Point(102, 224);
            this.tbPrefijoLocalidad.Name = "tbPrefijoLocalidad";
            this.tbPrefijoLocalidad.Size = new System.Drawing.Size(63, 23);
            this.tbPrefijoLocalidad.TabIndex = 1;
            // 
            // tbRestoDelNumero
            // 
            this.tbRestoDelNumero.Location = new System.Drawing.Point(215, 224);
            this.tbRestoDelNumero.Name = "tbRestoDelNumero";
            this.tbRestoDelNumero.Size = new System.Drawing.Size(116, 23);
            this.tbRestoDelNumero.TabIndex = 2;
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(12, 206);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(70, 15);
            this.lblCodigoPais.TabIndex = 4;
            this.lblCodigoPais.Text = "Codigo pais";
            // 
            // lblPrefijo
            // 
            this.lblPrefijo.AutoSize = true;
            this.lblPrefijo.Location = new System.Drawing.Point(102, 206);
            this.lblPrefijo.Name = "lblPrefijo";
            this.lblPrefijo.Size = new System.Drawing.Size(92, 15);
            this.lblPrefijo.TabIndex = 5;
            this.lblPrefijo.Text = "Prefijo localidad";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(215, 206);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(12, 268);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(154, 91);
            this.btnAsignar.TabIndex = 9;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnLiberar
            // 
            this.btnLiberar.Location = new System.Drawing.Point(193, 268);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(154, 91);
            this.btnLiberar.TabIndex = 10;
            this.btnLiberar.Text = "Liberar";
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // rtbInformacionTelefono
            // 
            this.rtbInformacionTelefono.Location = new System.Drawing.Point(12, 22);
            this.rtbInformacionTelefono.Name = "rtbInformacionTelefono";
            this.rtbInformacionTelefono.ReadOnly = true;
            this.rtbInformacionTelefono.Size = new System.Drawing.Size(335, 181);
            this.rtbInformacionTelefono.TabIndex = 11;
            this.rtbInformacionTelefono.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(102, 268);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(139, 91);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 404);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 443);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 443);
            this.Name = "FrmTelefono";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTelefono";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTelefono_FormClosing);
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
    }
}
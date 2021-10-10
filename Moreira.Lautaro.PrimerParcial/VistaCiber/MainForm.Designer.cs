
namespace VistaCiber
{
    partial class MainForm
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
            this.btnMostrarHistorialDeClientes = new System.Windows.Forms.Button();
            this.btnMostrarComputadoras = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarHistorialDeClientes
            // 
            this.btnMostrarHistorialDeClientes.Location = new System.Drawing.Point(91, 12);
            this.btnMostrarHistorialDeClientes.Name = "btnMostrarHistorialDeClientes";
            this.btnMostrarHistorialDeClientes.Size = new System.Drawing.Size(186, 86);
            this.btnMostrarHistorialDeClientes.TabIndex = 1;
            this.btnMostrarHistorialDeClientes.Text = "Mostrar historial de clientes.";
            this.btnMostrarHistorialDeClientes.UseVisualStyleBackColor = true;
            // 
            // btnMostrarComputadoras
            // 
            this.btnMostrarComputadoras.Location = new System.Drawing.Point(91, 121);
            this.btnMostrarComputadoras.Name = "btnMostrarComputadoras";
            this.btnMostrarComputadoras.Size = new System.Drawing.Size(186, 86);
            this.btnMostrarComputadoras.TabIndex = 2;
            this.btnMostrarComputadoras.Text = "Mostrar equipos.";
            this.btnMostrarComputadoras.UseVisualStyleBackColor = true;
            this.btnMostrarComputadoras.Click += new System.EventHandler(this.btnMostrarComputadoras_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(91, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 86);
            this.button6.TabIndex = 5;
            this.button6.Text = "Mostrar clientes en espera";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 337);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnMostrarComputadoras);
            this.Controls.Add(this.btnMostrarHistorialDeClientes);
            this.MaximumSize = new System.Drawing.Size(417, 376);
            this.MinimumSize = new System.Drawing.Size(417, 376);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarHistorialDeClientes;
        private System.Windows.Forms.Button btnMostrarComputadoras;
        private System.Windows.Forms.Button button6;
    }
}
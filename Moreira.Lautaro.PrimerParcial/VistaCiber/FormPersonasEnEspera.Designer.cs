
namespace VistaCiber
{
    partial class FormPersonasEnEspera
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
            this.rtbListaClientesEnEspera = new System.Windows.Forms.RichTextBox();
            this.btnMostrarConRequerimientos = new System.Windows.Forms.Button();
            this.btnMostrarSinRequerimientos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbListaClientesEnEspera
            // 
            this.rtbListaClientesEnEspera.Location = new System.Drawing.Point(216, 12);
            this.rtbListaClientesEnEspera.Name = "rtbListaClientesEnEspera";
            this.rtbListaClientesEnEspera.ReadOnly = true;
            this.rtbListaClientesEnEspera.Size = new System.Drawing.Size(541, 426);
            this.rtbListaClientesEnEspera.TabIndex = 0;
            this.rtbListaClientesEnEspera.Text = "";
            // 
            // btnMostrarConRequerimientos
            // 
            this.btnMostrarConRequerimientos.Location = new System.Drawing.Point(41, 89);
            this.btnMostrarConRequerimientos.Name = "btnMostrarConRequerimientos";
            this.btnMostrarConRequerimientos.Size = new System.Drawing.Size(122, 100);
            this.btnMostrarConRequerimientos.TabIndex = 1;
            this.btnMostrarConRequerimientos.Text = "Mostrar usuarios con requerimientos.";
            this.btnMostrarConRequerimientos.UseVisualStyleBackColor = true;
            this.btnMostrarConRequerimientos.Click += new System.EventHandler(this.btnMostrarConRequerimientos_Click);
            // 
            // btnMostrarSinRequerimientos
            // 
            this.btnMostrarSinRequerimientos.Location = new System.Drawing.Point(41, 240);
            this.btnMostrarSinRequerimientos.Name = "btnMostrarSinRequerimientos";
            this.btnMostrarSinRequerimientos.Size = new System.Drawing.Size(122, 100);
            this.btnMostrarSinRequerimientos.TabIndex = 2;
            this.btnMostrarSinRequerimientos.Text = "Mostrar usuarios sin requerimientos.";
            this.btnMostrarSinRequerimientos.UseVisualStyleBackColor = true;
            this.btnMostrarSinRequerimientos.Click += new System.EventHandler(this.btnMostrarSinRequerimientos_Click);
            // 
            // FormPersonasEnEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.btnMostrarSinRequerimientos);
            this.Controls.Add(this.btnMostrarConRequerimientos);
            this.Controls.Add(this.rtbListaClientesEnEspera);
            this.MaximumSize = new System.Drawing.Size(785, 489);
            this.MinimumSize = new System.Drawing.Size(785, 489);
            this.Name = "FormPersonasEnEspera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonasEnEspera";
            this.Load += new System.EventHandler(this.FormPersonasEnEspera_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListaClientesEnEspera;
        private System.Windows.Forms.Button btnMostrarConRequerimientos;
        private System.Windows.Forms.Button btnMostrarSinRequerimientos;
    }
}

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
            this.SuspendLayout();
            // 
            // btnMostrarComputadoras
            // 
            this.btnMostrarComputadoras.Location = new System.Drawing.Point(26, 12);
            this.btnMostrarComputadoras.Name = "btnMostrarComputadoras";
            this.btnMostrarComputadoras.Size = new System.Drawing.Size(186, 125);
            this.btnMostrarComputadoras.TabIndex = 2;
            this.btnMostrarComputadoras.Text = "Mostrar equipos.";
            this.btnMostrarComputadoras.UseVisualStyleBackColor = true;
            this.btnMostrarComputadoras.Click += new System.EventHandler(this.btnMostrarComputadoras_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(26, 172);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(186, 125);
            this.btnHistorial.TabIndex = 5;
            this.btnHistorial.Text = "Mostrar Historial del ciber";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(242, 337);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnMostrarComputadoras);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(258, 376);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(258, 376);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterLVM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarComputadoras;
        private System.Windows.Forms.Button btnHistorial;
    }
}
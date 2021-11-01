
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
            this.btnMostrarSinRequerimientos = new System.Windows.Forms.Button();
            this.btnMostrarConRequerimientos = new System.Windows.Forms.Button();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.rtbListaClientesEnEspera = new System.Windows.Forms.RichTextBox();
            this.gbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrarSinRequerimientos
            // 
            this.btnMostrarSinRequerimientos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMostrarSinRequerimientos.Location = new System.Drawing.Point(17, 251);
            this.btnMostrarSinRequerimientos.Name = "btnMostrarSinRequerimientos";
            this.btnMostrarSinRequerimientos.Size = new System.Drawing.Size(215, 110);
            this.btnMostrarSinRequerimientos.TabIndex = 2;
            this.btnMostrarSinRequerimientos.Text = "Mostrar clientes sin requerimientos.";
            this.btnMostrarSinRequerimientos.UseVisualStyleBackColor = true;
            this.btnMostrarSinRequerimientos.Click += new System.EventHandler(this.btnMostrarSinRequerimientos_Click);
            // 
            // btnMostrarConRequerimientos
            // 
            this.btnMostrarConRequerimientos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMostrarConRequerimientos.Location = new System.Drawing.Point(17, 110);
            this.btnMostrarConRequerimientos.Name = "btnMostrarConRequerimientos";
            this.btnMostrarConRequerimientos.Size = new System.Drawing.Size(215, 110);
            this.btnMostrarConRequerimientos.TabIndex = 1;
            this.btnMostrarConRequerimientos.Text = "Mostrar clientes con requerimientos.";
            this.btnMostrarConRequerimientos.UseVisualStyleBackColor = true;
            this.btnMostrarConRequerimientos.Click += new System.EventHandler(this.btnMostrarConRequerimientos_Click);
            // 
            // gbBotones
            // 
            this.gbBotones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbBotones.Controls.Add(this.btnHelp);
            this.gbBotones.Controls.Add(this.btnMostrarConRequerimientos);
            this.gbBotones.Controls.Add(this.btnMostrarSinRequerimientos);
            this.gbBotones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbBotones.Location = new System.Drawing.Point(24, 12);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(256, 426);
            this.gbBotones.TabIndex = 3;
            this.gbBotones.TabStop = false;
            this.gbBotones.Text = "botones";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(157, 22);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 72);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // rtbListaClientesEnEspera
            // 
            this.rtbListaClientesEnEspera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rtbListaClientesEnEspera.Location = new System.Drawing.Point(323, 0);
            this.rtbListaClientesEnEspera.Name = "rtbListaClientesEnEspera";
            this.rtbListaClientesEnEspera.ReadOnly = true;
            this.rtbListaClientesEnEspera.Size = new System.Drawing.Size(445, 450);
            this.rtbListaClientesEnEspera.TabIndex = 0;
            this.rtbListaClientesEnEspera.Text = "";
            // 
            // FormPersonasEnEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.rtbListaClientesEnEspera);
            this.Controls.Add(this.gbBotones);
            this.MinimumSize = new System.Drawing.Size(785, 489);
            this.Name = "FormPersonasEnEspera";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonasEnEspera";
            this.gbBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListaClientesEnEspera;
        private System.Windows.Forms.Button btnMostrarSinRequerimientos;
        private System.Windows.Forms.Button btnMostrarConRequerimientos;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btnHelp;
    }
}
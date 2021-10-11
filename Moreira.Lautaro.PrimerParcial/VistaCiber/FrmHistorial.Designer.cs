
namespace VistaCiber
{
    partial class FrmHistorial
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
            this.rtbHistorial = new System.Windows.Forms.RichTextBox();
            this.lbFormasDeOrdenar = new System.Windows.Forms.ListBox();
            this.nupTamanioFuente = new System.Windows.Forms.NumericUpDown();
            this.lblFont = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbHistorial
            // 
            this.rtbHistorial.Location = new System.Drawing.Point(12, 112);
            this.rtbHistorial.Name = "rtbHistorial";
            this.rtbHistorial.Size = new System.Drawing.Size(776, 326);
            this.rtbHistorial.TabIndex = 0;
            this.rtbHistorial.Text = "";
            // 
            // lbFormasDeOrdenar
            // 
            this.lbFormasDeOrdenar.FormattingEnabled = true;
            this.lbFormasDeOrdenar.ItemHeight = 15;
            this.lbFormasDeOrdenar.Items.AddRange(new object[] {
            "Listar computadoras ordenadas por minutos de forma descendiente",
            "Listar cabinas ordenadas por minutos de uso de forma descendiente",
            "Ganancias totales y clasificadas por servicios",
            "Horas totales y recaudacion por tipo de llamada",
            "Sofware mas pedido por clientes",
            "Periferico mas pedido por los clientes",
            "Juego mas pedido por los clientes"});
            this.lbFormasDeOrdenar.Location = new System.Drawing.Point(12, 12);
            this.lbFormasDeOrdenar.Name = "lbFormasDeOrdenar";
            this.lbFormasDeOrdenar.Size = new System.Drawing.Size(407, 94);
            this.lbFormasDeOrdenar.TabIndex = 1;
            // 
            // nupTamanioFuente
            // 
            this.nupTamanioFuente.Location = new System.Drawing.Point(445, 57);
            this.nupTamanioFuente.Name = "nupTamanioFuente";
            this.nupTamanioFuente.Size = new System.Drawing.Size(120, 23);
            this.nupTamanioFuente.TabIndex = 2;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(445, 39);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(114, 15);
            this.lblFont.TabIndex = 3;
            this.lblFont.Text = "Tamaño de la fuente";
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.nupTamanioFuente);
            this.Controls.Add(this.lbFormasDeOrdenar);
            this.Controls.Add(this.rtbHistorial);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmHistorial";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioFuente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbHistorial;
        private System.Windows.Forms.ListBox lbFormasDeOrdenar;
        private System.Windows.Forms.NumericUpDown nupTamanioFuente;
        private System.Windows.Forms.Label lblFont;
    }
}
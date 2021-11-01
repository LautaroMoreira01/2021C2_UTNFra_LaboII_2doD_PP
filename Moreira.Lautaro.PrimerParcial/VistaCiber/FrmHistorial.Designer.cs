
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
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbHistorial
            // 
            this.rtbHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lbFormasDeOrdenar.Size = new System.Drawing.Size(546, 94);
            this.lbFormasDeOrdenar.TabIndex = 1;
            this.lbFormasDeOrdenar.SelectedIndexChanged += new System.EventHandler(this.lbFormasDeOrdenar_SelectedIndexChanged);
            // 
            // nupTamanioFuente
            // 
            this.nupTamanioFuente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nupTamanioFuente.Location = new System.Drawing.Point(564, 30);
            this.nupTamanioFuente.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupTamanioFuente.MinimumSize = new System.Drawing.Size(120, 0);
            this.nupTamanioFuente.Name = "nupTamanioFuente";
            this.nupTamanioFuente.Size = new System.Drawing.Size(120, 23);
            this.nupTamanioFuente.TabIndex = 2;
            this.nupTamanioFuente.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupTamanioFuente.ValueChanged += new System.EventHandler(this.nupTamanioFuente_ValueChanged);
            // 
            // lblFont
            // 
            this.lblFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(564, 12);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(114, 15);
            this.lblFont.TabIndex = 3;
            this.lblFont.Text = "Tamaño de la fuente";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(707, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(81, 45);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.nupTamanioFuente);
            this.Controls.Add(this.lbFormasDeOrdenar);
            this.Controls.Add(this.rtbHistorial);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioFuente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbHistorial;
        private System.Windows.Forms.ListBox lbFormasDeOrdenar;
        private System.Windows.Forms.NumericUpDown nupTamanioFuente;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Button btnHelp;
    }
}
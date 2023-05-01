namespace Tp2_Programacion
{
    partial class FrmVentanaCatalago
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
            this.TsmAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DgbArticulos = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // TsmAgregar
            // 
            this.TsmAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TsmAgregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TsmAgregar.Name = "TsmAgregar";
            this.TsmAgregar.Size = new System.Drawing.Size(161, 29);
            this.TsmAgregar.Text = "Agregar articulo";
            this.TsmAgregar.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem_Click);
            // 
            // TsmModificar
            // 
            this.TsmModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TsmModificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmModificar.Name = "TsmModificar";
            this.TsmModificar.Size = new System.Drawing.Size(184, 29);
            this.TsmModificar.Text = "Modificar Artículos";
            this.TsmModificar.Click += new System.EventHandler(this.TsmModificar_Click);
            // 
            // TsmEliminar
            // 
            this.TsmEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TsmEliminar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmEliminar.Name = "TsmEliminar";
            this.TsmEliminar.Size = new System.Drawing.Size(172, 29);
            this.TsmEliminar.Text = "Eliminar Artículos";
            // 
            // TsmBusqueda
            // 
            this.TsmBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TsmBusqueda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmBusqueda.Name = "TsmBusqueda";
            this.TsmBusqueda.Size = new System.Drawing.Size(229, 29);
            this.TsmBusqueda.Text = "Búsqueda Personalizada";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmAgregar,
            this.TsmModificar,
            this.TsmEliminar,
            this.TsmBusqueda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DgbArticulos
            // 
            this.DgbArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbArticulos.Location = new System.Drawing.Point(128, 81);
            this.DgbArticulos.Name = "DgbArticulos";
            this.DgbArticulos.Size = new System.Drawing.Size(337, 187);
            this.DgbArticulos.TabIndex = 1;
            this.DgbArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgbArticulos_CellContentClick);
            // 
            // FrmVentanaCatalago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 448);
            this.Controls.Add(this.DgbArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVentanaCatalago";
            this.Text = "FrmVentanaCatalago";
            this.Load += new System.EventHandler(this.FrmVentanaCatalago_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem TsmAgregar;
        private System.Windows.Forms.ToolStripMenuItem TsmModificar;
        private System.Windows.Forms.ToolStripMenuItem TsmEliminar;
        private System.Windows.Forms.ToolStripMenuItem TsmBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView DgbArticulos;
    }
}
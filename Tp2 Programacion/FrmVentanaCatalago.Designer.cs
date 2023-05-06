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
            this.DgbArticulos = new System.Windows.Forms.DataGridView();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.TsmAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgbArticulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgbArticulos
            // 
            this.DgbArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbArticulos.Location = new System.Drawing.Point(278, 128);
            this.DgbArticulos.Name = "DgbArticulos";
            this.DgbArticulos.Size = new System.Drawing.Size(224, 187);
            this.DgbArticulos.TabIndex = 1;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(124, 339);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(29, 13);
            this.lblFiltrar.TabIndex = 2;
            this.lblFiltrar.Text = "Filtro";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(173, 339);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(100, 20);
            this.txtfiltro.TabIndex = 3;
            this.txtfiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiltro_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(518, 339);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TsmAgregar
            // 
            this.TsmAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TsmAgregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TsmAgregar.Name = "TsmAgregar";
            this.TsmAgregar.Size = new System.Drawing.Size(751, 29);
            this.TsmAgregar.Text = "Agregar articulo";
            this.TsmAgregar.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem_Click);
            // 
            // TsmModificar
            // 
            this.TsmModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TsmModificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmModificar.Name = "TsmModificar";
            this.TsmModificar.Size = new System.Drawing.Size(751, 29);
            this.TsmModificar.Text = "Modificar Artículos";
            this.TsmModificar.Click += new System.EventHandler(this.TsmModificar_Click);
            // 
            // TsmEliminar
            // 
            this.TsmEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TsmEliminar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmEliminar.Name = "TsmEliminar";
            this.TsmEliminar.Size = new System.Drawing.Size(751, 29);
            this.TsmEliminar.Text = "Eliminar Artículos";
            this.TsmEliminar.Click += new System.EventHandler(this.TsmEliminar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmAgregar,
            this.TsmModificar,
            this.TsmEliminar});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 93);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(358, 339);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnDetalles.TabIndex = 5;
            this.btnDetalles.Text = " Ver Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // FrmVentanaCatalago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 448);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.DgbArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVentanaCatalago";
            this.Text = "FrmVentanaCatalago";
            this.Load += new System.EventHandler(this.FrmVentanaCatalago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgbArticulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgbArticulos;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem TsmAgregar;
        private System.Windows.Forms.ToolStripMenuItem TsmModificar;
        private System.Windows.Forms.ToolStripMenuItem TsmEliminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnDetalles;
    }
}
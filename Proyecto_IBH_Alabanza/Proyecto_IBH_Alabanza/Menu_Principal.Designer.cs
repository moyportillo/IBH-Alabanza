namespace Proyecto_IBH_Alabanza
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasDeResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntNuevacancion = new System.Windows.Forms.Button();
            this.btnNuevoInventario = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.bntCalendario = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(225, 90);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(168, 170);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem1,
            this.mantenimientoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(826, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivosToolStripMenuItem1
            // 
            this.archivosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasDeResultadosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivosToolStripMenuItem1.Name = "archivosToolStripMenuItem1";
            this.archivosToolStripMenuItem1.Size = new System.Drawing.Size(77, 24);
            this.archivosToolStripMenuItem1.Text = "Archivos";
            // 
            // tablasDeResultadosToolStripMenuItem
            // 
            this.tablasDeResultadosToolStripMenuItem.Name = "tablasDeResultadosToolStripMenuItem";
            this.tablasDeResultadosToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.tablasDeResultadosToolStripMenuItem.Text = "Tablas de Resultados";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // bntNuevacancion
            // 
            this.bntNuevacancion.Image = ((System.Drawing.Image)(resources.GetObject("bntNuevacancion.Image")));
            this.bntNuevacancion.Location = new System.Drawing.Point(441, 90);
            this.bntNuevacancion.Name = "bntNuevacancion";
            this.bntNuevacancion.Size = new System.Drawing.Size(168, 170);
            this.bntNuevacancion.TabIndex = 3;
            this.bntNuevacancion.UseVisualStyleBackColor = true;
            this.bntNuevacancion.Click += new System.EventHandler(this.bntNuevacancion_Click);
            // 
            // btnNuevoInventario
            // 
            this.btnNuevoInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoInventario.Image")));
            this.btnNuevoInventario.Location = new System.Drawing.Point(225, 294);
            this.btnNuevoInventario.Name = "btnNuevoInventario";
            this.btnNuevoInventario.Size = new System.Drawing.Size(168, 170);
            this.btnNuevoInventario.TabIndex = 4;
            this.btnNuevoInventario.UseVisualStyleBackColor = true;
            this.btnNuevoInventario.Click += new System.EventHandler(this.btnNuevoInventario_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Image = ((System.Drawing.Image)(resources.GetObject("btnResultados.Image")));
            this.btnResultados.Location = new System.Drawing.Point(441, 294);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(168, 170);
            this.btnResultados.TabIndex = 5;
            this.btnResultados.UseVisualStyleBackColor = true;
            // 
            // bntCalendario
            // 
            this.bntCalendario.Image = ((System.Drawing.Image)(resources.GetObject("bntCalendario.Image")));
            this.bntCalendario.Location = new System.Drawing.Point(225, 493);
            this.bntCalendario.Name = "bntCalendario";
            this.bntCalendario.Size = new System.Drawing.Size(168, 170);
            this.bntCalendario.TabIndex = 6;
            this.bntCalendario.UseVisualStyleBackColor = true;
            // 
            // btnSalida
            // 
            this.btnSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnSalida.Image")));
            this.btnSalida.Location = new System.Drawing.Point(441, 493);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(168, 170);
            this.btnSalida.TabIndex = 7;
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.button6_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(826, 747);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.bntCalendario);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnNuevoInventario);
            this.Controls.Add(this.bntNuevacancion);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu | IBH Ministerio ";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.Button bntNuevacancion;
        private System.Windows.Forms.Button btnNuevoInventario;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button bntCalendario;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.ToolStripMenuItem tablasDeResultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}


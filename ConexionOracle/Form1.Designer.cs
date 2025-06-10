namespace ConexionOracle
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.CMSEntrenador = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atletasDisciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.atletaDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.atleDiscHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.CMSEntrenador.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.ContextMenuStrip = this.CMSEntrenador;
            this.DGVDatos.Location = new System.Drawing.Point(4, 149);
            this.DGVDatos.Margin = new System.Windows.Forms.Padding(2);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.RowHeadersWidth = 51;
            this.DGVDatos.RowTemplate.Height = 24;
            this.DGVDatos.Size = new System.Drawing.Size(950, 293);
            this.DGVDatos.TabIndex = 0;
            // 
            // CMSEntrenador
            // 
            this.CMSEntrenador.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSEntrenador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.CMSEntrenador.Name = "contextMenuStrip1";
            this.CMSEntrenador.Size = new System.Drawing.Size(127, 48);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.insertarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrenadorToolStripMenuItem,
            this.atletasToolStripMenuItem,
            this.disciplinasToolStripMenuItem,
            this.calificacionesToolStripMenuItem,
            this.atletasDisciplinasToolStripMenuItem,
            this.atleDiscHorasToolStripMenuItem});
            this.aToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.aToolStripMenuItem.Text = "Datos";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // entrenadorToolStripMenuItem
            // 
            this.entrenadorToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.entrenadorToolStripMenuItem.Name = "entrenadorToolStripMenuItem";
            this.entrenadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entrenadorToolStripMenuItem.Text = "Entrenador";
            this.entrenadorToolStripMenuItem.Click += new System.EventHandler(this.entrenadorToolStripMenuItem_Click);
            // 
            // atletasToolStripMenuItem
            // 
            this.atletasToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.atletasToolStripMenuItem.Name = "atletasToolStripMenuItem";
            this.atletasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atletasToolStripMenuItem.Text = "Atletas";
            this.atletasToolStripMenuItem.Click += new System.EventHandler(this.atletasToolStripMenuItem_Click);
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            this.disciplinasToolStripMenuItem.Click += new System.EventHandler(this.disciplinasToolStripMenuItem_Click);
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calificacionesToolStripMenuItem.Text = "Calificaciones";
            this.calificacionesToolStripMenuItem.Click += new System.EventHandler(this.calificacionesToolStripMenuItem_Click);
            // 
            // atletasDisciplinasToolStripMenuItem
            // 
            this.atletasDisciplinasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.atletasDisciplinasToolStripMenuItem.Name = "atletasDisciplinasToolStripMenuItem";
            this.atletasDisciplinasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atletasDisciplinasToolStripMenuItem.Text = "Atletas_Disciplinas";
            this.atletasDisciplinasToolStripMenuItem.Click += new System.EventHandler(this.atletasDisciplinasToolStripMenuItem_Click);
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrenadorToolStripMenuItem1,
            this.atletaToolStripMenuItem,
            this.disciplinaToolStripMenuItem,
            this.calificacionToolStripMenuItem,
            this.atletaDisciplinaToolStripMenuItem,
            this.toolStripMenuItem2});
            this.insertarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.insertarToolStripMenuItem.Text = "Insertar";
            // 
            // entrenadorToolStripMenuItem1
            // 
            this.entrenadorToolStripMenuItem1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.entrenadorToolStripMenuItem1.Name = "entrenadorToolStripMenuItem1";
            this.entrenadorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.entrenadorToolStripMenuItem1.Text = "Entrenador";
            this.entrenadorToolStripMenuItem1.Click += new System.EventHandler(this.entrenadorToolStripMenuItem1_Click);
            // 
            // atletaToolStripMenuItem
            // 
            this.atletaToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.atletaToolStripMenuItem.Name = "atletaToolStripMenuItem";
            this.atletaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atletaToolStripMenuItem.Text = "Atleta";
            this.atletaToolStripMenuItem.Click += new System.EventHandler(this.atletaToolStripMenuItem_Click);
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disciplinaToolStripMenuItem.Text = "Disciplina";
            this.disciplinaToolStripMenuItem.Click += new System.EventHandler(this.disciplinaToolStripMenuItem_Click);
            // 
            // calificacionToolStripMenuItem
            // 
            this.calificacionToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calificacionToolStripMenuItem.Name = "calificacionToolStripMenuItem";
            this.calificacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calificacionToolStripMenuItem.Text = "Calificacion";
            this.calificacionToolStripMenuItem.Click += new System.EventHandler(this.calificacionToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // TXTNombre
            // 
            this.TXTNombre.Enabled = false;
            this.TXTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNombre.Location = new System.Drawing.Point(101, 40);
            this.TXTNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(129, 21);
            this.TXTNombre.TabIndex = 3;
            this.TXTNombre.TextChanged += new System.EventHandler(this.TXTNombre_TextChanged);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Orange;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(309, 33);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(90, 27);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refrescar";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.AutoSize = true;
            this.textBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(33, 40);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(63, 20);
            this.textBuscar.TabIndex = 6;
            this.textBuscar.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "🔍";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(12, 105);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(254, 25);
            this.btnBusqueda.TabIndex = 8;
            this.btnBusqueda.Text = "Busquedas en la base de datos";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "🌐";
            // 
            // atletaDisciplinaToolStripMenuItem
            // 
            this.atletaDisciplinaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.atletaDisciplinaToolStripMenuItem.Name = "atletaDisciplinaToolStripMenuItem";
            this.atletaDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atletaDisciplinaToolStripMenuItem.Text = "Atleta_Disciplina";
            this.atletaDisciplinaToolStripMenuItem.Click += new System.EventHandler(this.atletaDisciplinaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(813, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // atleDiscHorasToolStripMenuItem
            // 
            this.atleDiscHorasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.atleDiscHorasToolStripMenuItem.Name = "atleDiscHorasToolStripMenuItem";
            this.atleDiscHorasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atleDiscHorasToolStripMenuItem.Text = "Atle_Disc_Horas";
            this.atleDiscHorasToolStripMenuItem.Click += new System.EventHandler(this.atleDiscHorasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Atle_Disc_Horas";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.TXTNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Gatos Negos Sports";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.CMSEntrenador.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atletasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip CMSEntrenador;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNombre;
        private System.Windows.Forms.ToolStripMenuItem atletaToolStripMenuItem;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionToolStripMenuItem;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem atletasDisciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atletaDisciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atleDiscHorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}


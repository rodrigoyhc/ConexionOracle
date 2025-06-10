namespace ConexionOracle
{
    partial class InsCalificaciones
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
            this.cmbAtleta = new System.Windows.Forms.ComboBox();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaEvaluacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNInsertar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.numCalificacion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAtleta
            // 
            this.cmbAtleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAtleta.FormattingEnabled = true;
            this.cmbAtleta.Location = new System.Drawing.Point(180, 23);
            this.cmbAtleta.Name = "cmbAtleta";
            this.cmbAtleta.Size = new System.Drawing.Size(80, 23);
            this.cmbAtleta.TabIndex = 17;
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(180, 75);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(80, 23);
            this.cmbDisciplina.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre del atleta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre de la Disciplina:";
            // 
            // dtpFechaEvaluacion
            // 
            this.dtpFechaEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEvaluacion.Location = new System.Drawing.Point(26, 217);
            this.dtpFechaEvaluacion.Name = "dtpFechaEvaluacion";
            this.dtpFechaEvaluacion.Size = new System.Drawing.Size(234, 21);
            this.dtpFechaEvaluacion.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Entrega de calidicaciones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Calificacion:";
            // 
            // BTNInsertar
            // 
            this.BTNInsertar.BackColor = System.Drawing.Color.DimGray;
            this.BTNInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNInsertar.Location = new System.Drawing.Point(35, 281);
            this.BTNInsertar.Name = "BTNInsertar";
            this.BTNInsertar.Size = new System.Drawing.Size(96, 31);
            this.BTNInsertar.TabIndex = 26;
            this.BTNInsertar.Text = "Insertar";
            this.BTNInsertar.UseVisualStyleBackColor = false;
            this.BTNInsertar.Click += new System.EventHandler(this.BTNInsertar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.BackColor = System.Drawing.Color.DimGray;
            this.BTNEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEliminar.Location = new System.Drawing.Point(154, 281);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(96, 31);
            this.BTNEliminar.TabIndex = 27;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = false;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click_1);
            // 
            // numCalificacion
            // 
            this.numCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCalificacion.Location = new System.Drawing.Point(180, 131);
            this.numCalificacion.Name = "numCalificacion";
            this.numCalificacion.Size = new System.Drawing.Size(79, 21);
            this.numCalificacion.TabIndex = 28;
            // 
            // InsCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(291, 344);
            this.Controls.Add(this.numCalificacion);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNInsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaEvaluacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.cmbAtleta);
            this.Name = "InsCalificaciones";
            this.Text = "InsCalificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.numCalificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAtleta;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaEvaluacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNInsertar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.NumericUpDown numCalificacion;
    }
}
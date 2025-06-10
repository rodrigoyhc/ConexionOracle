namespace ConexionOracle
{
    partial class Form2
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
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAtleta
            // 
            this.cmbAtleta.FormattingEnabled = true;
            this.cmbAtleta.Location = new System.Drawing.Point(137, 33);
            this.cmbAtleta.Name = "cmbAtleta";
            this.cmbAtleta.Size = new System.Drawing.Size(121, 21);
            this.cmbAtleta.TabIndex = 0;
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(137, 85);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(121, 21);
            this.cmbDisciplina.TabIndex = 1;
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEliminar.Location = new System.Drawing.Point(40, 162);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(94, 25);
            this.BTNEliminar.TabIndex = 2;
            this.BTNEliminar.Text = "Insertar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNInsertar
            // 
            this.BTNInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNInsertar.Location = new System.Drawing.Point(164, 162);
            this.BTNInsertar.Name = "BTNInsertar";
            this.BTNInsertar.Size = new System.Drawing.Size(94, 25);
            this.BTNInsertar.TabIndex = 3;
            this.BTNInsertar.Text = "Eliminar";
            this.BTNInsertar.UseVisualStyleBackColor = true;
            this.BTNInsertar.Click += new System.EventHandler(this.BTNInsertar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Atleta: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Disciplina:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 237);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNInsertar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.cmbAtleta);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAtleta;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
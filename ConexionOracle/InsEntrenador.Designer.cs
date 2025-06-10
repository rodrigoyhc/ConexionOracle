namespace ConexionOracle
{
    partial class InsEntrenador
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.TXTApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTPais = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DTMFecNac = new System.Windows.Forms.DateTimePicker();
            this.BTNInsertar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTNombre
            // 
            this.TXTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNombre.Location = new System.Drawing.Point(103, 33);
            this.TXTNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(157, 21);
            this.TXTNombre.TabIndex = 1;
            this.TXTNombre.TextChanged += new System.EventHandler(this.TXTNombre_TextChanged);
            // 
            // TXTApellido
            // 
            this.TXTApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTApellido.Location = new System.Drawing.Point(103, 79);
            this.TXTApellido.Margin = new System.Windows.Forms.Padding(2);
            this.TXTApellido.Name = "TXTApellido";
            this.TXTApellido.Size = new System.Drawing.Size(157, 21);
            this.TXTApellido.TabIndex = 3;
            this.TXTApellido.TextChanged += new System.EventHandler(this.TXTApellido_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // TXTCorreo
            // 
            this.TXTCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCorreo.Location = new System.Drawing.Point(138, 276);
            this.TXTCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCorreo.Name = "TXTCorreo";
            this.TXTCorreo.Size = new System.Drawing.Size(122, 21);
            this.TXTCorreo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo Electronico:";
            // 
            // TXTDireccion
            // 
            this.TXTDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDireccion.Location = new System.Drawing.Point(103, 194);
            this.TXTDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.TXTDireccion.Name = "TXTDireccion";
            this.TXTDireccion.Size = new System.Drawing.Size(157, 21);
            this.TXTDireccion.TabIndex = 7;
            this.TXTDireccion.TextChanged += new System.EventHandler(this.TXTDireccion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion:";
            // 
            // TXTTelefono
            // 
            this.TXTTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTelefono.Location = new System.Drawing.Point(85, 233);
            this.TXTTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.TXTTelefono.Name = "TXTTelefono";
            this.TXTTelefono.Size = new System.Drawing.Size(175, 21);
            this.TXTTelefono.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // TXTPais
            // 
            this.TXTPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPais.Location = new System.Drawing.Point(85, 322);
            this.TXTPais.Margin = new System.Windows.Forms.Padding(2);
            this.TXTPais.Name = "TXTPais";
            this.TXTPais.Size = new System.Drawing.Size(175, 21);
            this.TXTPais.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pais:";
            // 
            // DTMFecNac
            // 
            this.DTMFecNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTMFecNac.Location = new System.Drawing.Point(23, 150);
            this.DTMFecNac.Margin = new System.Windows.Forms.Padding(2);
            this.DTMFecNac.Name = "DTMFecNac";
            this.DTMFecNac.Size = new System.Drawing.Size(237, 21);
            this.DTMFecNac.TabIndex = 14;
            this.DTMFecNac.Value = new System.DateTime(2025, 6, 7, 20, 15, 2, 0);
            // 
            // BTNInsertar
            // 
            this.BTNInsertar.BackColor = System.Drawing.Color.DimGray;
            this.BTNInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNInsertar.Location = new System.Drawing.Point(41, 367);
            this.BTNInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.BTNInsertar.Name = "BTNInsertar";
            this.BTNInsertar.Size = new System.Drawing.Size(77, 30);
            this.BTNInsertar.TabIndex = 15;
            this.BTNInsertar.Text = "Insertar";
            this.BTNInsertar.UseVisualStyleBackColor = false;
            this.BTNInsertar.Click += new System.EventHandler(this.BTNInsertar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.BackColor = System.Drawing.Color.DimGray;
            this.BTNEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEliminar.Location = new System.Drawing.Point(160, 367);
            this.BTNEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(83, 30);
            this.BTNEliminar.TabIndex = 16;
            this.BTNEliminar.Text = "Eliminar:";
            this.BTNEliminar.UseVisualStyleBackColor = false;
            // 
            // InsEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 421);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNInsertar);
            this.Controls.Add(this.DTMFecNac);
            this.Controls.Add(this.TXTPais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsEntrenador";
            this.Text = "InsEntrenador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNombre;
        private System.Windows.Forms.TextBox TXTApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTPais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTMFecNac;
        private System.Windows.Forms.Button BTNInsertar;
        private System.Windows.Forms.Button BTNEliminar;
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
    }
}
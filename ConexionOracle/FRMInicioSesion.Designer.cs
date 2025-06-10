namespace ConexionOracle
{
    partial class FRMInicioSesion
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
            this.TXTUsuario = new System.Windows.Forms.TextBox();
            this.TXTContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PBMostrar = new System.Windows.Forms.PictureBox();
            this.BTNInicio = new System.Windows.Forms.Button();
            this.PBOcultar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.Location = new System.Drawing.Point(147, 56);
            this.TXTUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.Size = new System.Drawing.Size(101, 20);
            this.TXTUsuario.TabIndex = 1;
            // 
            // TXTContraseña
            // 
            this.TXTContraseña.Location = new System.Drawing.Point(147, 97);
            this.TXTContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTContraseña.Name = "TXTContraseña";
            this.TXTContraseña.Size = new System.Drawing.Size(101, 20);
            this.TXTContraseña.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrseña:";
            // 
            // PBMostrar
            // 
            this.PBMostrar.Image = global::ConexionOracle.Properties.Resources.eye_visible_hide_hidden_show_icon_145988;
            this.PBMostrar.Location = new System.Drawing.Point(262, 97);
            this.PBMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBMostrar.Name = "PBMostrar";
            this.PBMostrar.Size = new System.Drawing.Size(25, 25);
            this.PBMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMostrar.TabIndex = 4;
            this.PBMostrar.TabStop = false;
            this.PBMostrar.Click += new System.EventHandler(this.PBMostrar_Click);
            // 
            // BTNInicio
            // 
            this.BTNInicio.Location = new System.Drawing.Point(94, 157);
            this.BTNInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNInicio.Name = "BTNInicio";
            this.BTNInicio.Size = new System.Drawing.Size(98, 25);
            this.BTNInicio.TabIndex = 6;
            this.BTNInicio.Text = "Ingresar";
            this.BTNInicio.UseVisualStyleBackColor = true;
            this.BTNInicio.Click += new System.EventHandler(this.BTNInicio_Click);
            // 
            // PBOcultar
            // 
            this.PBOcultar.Image = global::ConexionOracle.Properties.Resources.eye_slash_visible_hide_hidden_show_icon_145987;
            this.PBOcultar.Location = new System.Drawing.Point(262, 97);
            this.PBOcultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBOcultar.Name = "PBOcultar";
            this.PBOcultar.Size = new System.Drawing.Size(25, 25);
            this.PBOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBOcultar.TabIndex = 7;
            this.PBOcultar.TabStop = false;
            this.PBOcultar.Click += new System.EventHandler(this.PBOcultar_Click_1);
            // 
            // FRMInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 220);
            this.Controls.Add(this.PBOcultar);
            this.Controls.Add(this.BTNInicio);
            this.Controls.Add(this.PBMostrar);
            this.Controls.Add(this.TXTContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTUsuario);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRMInicioSesion";
            this.Text = "FRMInicioSesion";
            this.Load += new System.EventHandler(this.FRMInicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOcultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTUsuario;
        private System.Windows.Forms.TextBox TXTContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PBMostrar;
        private System.Windows.Forms.Button BTNInicio;
        private System.Windows.Forms.PictureBox PBOcultar;
    }
}
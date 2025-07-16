namespace Agencia_de_viajes
{
    partial class frmVentana_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentana_principal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picVideos = new System.Windows.Forms.PictureBox();
            this.picGestionTareas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.paPanel_Opciones = new System.Windows.Forms.Panel();
            this.btnCerrar_sesion = new System.Windows.Forms.Button();
            this.btnDesplazar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picVideos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGestionTareas)).BeginInit();
            this.paPanel_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 30F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(246, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mabup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenid@ nombre del usuario ¿Que deseas hacer?";
            // 
            // picVideos
            // 
            this.picVideos.BackColor = System.Drawing.Color.DimGray;
            this.picVideos.Image = global::Agencia_de_viajes.Properties.Resources.Videos;
            this.picVideos.Location = new System.Drawing.Point(350, 175);
            this.picVideos.Name = "picVideos";
            this.picVideos.Size = new System.Drawing.Size(200, 200);
            this.picVideos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVideos.TabIndex = 3;
            this.picVideos.TabStop = false;
            this.picVideos.Click += new System.EventHandler(this.picVideos_Click);
            // 
            // picGestionTareas
            // 
            this.picGestionTareas.BackColor = System.Drawing.Color.DimGray;
            this.picGestionTareas.Image = global::Agencia_de_viajes.Properties.Resources.Tareas;
            this.picGestionTareas.Location = new System.Drawing.Point(57, 175);
            this.picGestionTareas.Name = "picGestionTareas";
            this.picGestionTareas.Size = new System.Drawing.Size(200, 200);
            this.picGestionTareas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGestionTareas.TabIndex = 2;
            this.picGestionTareas.TabStop = false;
            this.picGestionTareas.Click += new System.EventHandler(this.picGestionTareas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Abrir Gestor de Tareas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(289, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Abrir El Servicio De Streaming";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNomUsuario.Location = new System.Drawing.Point(18, 182);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(20, 17);
            this.lblNomUsuario.TabIndex = 0;
            this.lblNomUsuario.Text = "...";
            // 
            // paPanel_Opciones
            // 
            this.paPanel_Opciones.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.paPanel_Opciones.Controls.Add(this.btnCerrar_sesion);
            this.paPanel_Opciones.Controls.Add(this.lblNomUsuario);
            this.paPanel_Opciones.Location = new System.Drawing.Point(-5, -5);
            this.paPanel_Opciones.Name = "paPanel_Opciones";
            this.paPanel_Opciones.Size = new System.Drawing.Size(212, 430);
            this.paPanel_Opciones.TabIndex = 7;
            this.paPanel_Opciones.Visible = false;
            // 
            // btnCerrar_sesion
            // 
            this.btnCerrar_sesion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCerrar_sesion.Location = new System.Drawing.Point(3, 368);
            this.btnCerrar_sesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar_sesion.Name = "btnCerrar_sesion";
            this.btnCerrar_sesion.Size = new System.Drawing.Size(205, 25);
            this.btnCerrar_sesion.TabIndex = 10;
            this.btnCerrar_sesion.Text = "Cerrar Sesion";
            this.btnCerrar_sesion.UseVisualStyleBackColor = false;
            this.btnCerrar_sesion.Click += new System.EventHandler(this.btnCerrar_sesion_Click);
            // 
            // btnDesplazar
            // 
            this.btnDesplazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDesplazar.Location = new System.Drawing.Point(16, 20);
            this.btnDesplazar.Name = "btnDesplazar";
            this.btnDesplazar.Size = new System.Drawing.Size(80, 37);
            this.btnDesplazar.TabIndex = 8;
            this.btnDesplazar.Text = "≡";
            this.btnDesplazar.UseVisualStyleBackColor = true;
            this.btnDesplazar.Click += new System.EventHandler(this.btnDesplazar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 13F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(369, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "©2021";
            // 
            // frmVentana_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 411);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDesplazar);
            this.Controls.Add(this.paPanel_Opciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picVideos);
            this.Controls.Add(this.picGestionTareas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmVentana_principal";
            this.Text = "Ventana Principal";
            ((System.ComponentModel.ISupportInitialize)(this.picVideos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGestionTareas)).EndInit();
            this.paPanel_Opciones.ResumeLayout(false);
            this.paPanel_Opciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picGestionTareas;
        private System.Windows.Forms.PictureBox picVideos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Panel paPanel_Opciones;
        private System.Windows.Forms.Button btnDesplazar;
        private System.Windows.Forms.Button btnCerrar_sesion;
        private System.Windows.Forms.Label label3;
    }
}
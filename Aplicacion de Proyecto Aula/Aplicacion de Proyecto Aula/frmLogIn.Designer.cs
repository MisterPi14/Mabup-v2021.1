namespace Agencia_de_viajes
{
    dfgdg
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar_Sesion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picApp_Load = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picApp_Load)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CORREO ELECTRONICO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // btnIniciar_Sesion
            // 
            this.btnIniciar_Sesion.Location = new System.Drawing.Point(93, 364);
            this.btnIniciar_Sesion.Name = "btnIniciar_Sesion";
            this.btnIniciar_Sesion.Size = new System.Drawing.Size(155, 23);
            this.btnIniciar_Sesion.TabIndex = 7;
            this.btnIniciar_Sesion.Text = "INICIAR SESION";
            this.btnIniciar_Sesion.UseVisualStyleBackColor = true;
            this.btnIniciar_Sesion.Click += new System.EventHandler(this.btnIniciar_Sesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(343, 364);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrarse.TabIndex = 8;
            this.btnRegistrarse.Text = "REGISTRARSE";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(198, 246);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(211, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(198, 302);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(211, 20);
            this.txtContraseña.TabIndex = 10;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(208, 335);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(0, 13);
            this.lblAviso.TabIndex = 11;
            this.lblAviso.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 56F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(182, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 92);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mabup";
            // 
            // picApp_Load
            // 
            this.picApp_Load.Image = ((System.Drawing.Image)(resources.GetObject("picApp_Load.Image")));
            this.picApp_Load.Location = new System.Drawing.Point(-74, -1);
            this.picApp_Load.Name = "picApp_Load";
            this.picApp_Load.Size = new System.Drawing.Size(743, 418);
            this.picApp_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picApp_Load.TabIndex = 13;
            this.picApp_Load.TabStop = false;
            this.picApp_Load.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MingLiU-ExtB", 17F);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(395, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "©2021";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 411);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picApp_Load);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciar_Sesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogIn";
            this.Text = "Log_In";
            this.Load += new System.EventHandler(this.frmPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picApp_Load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciar_Sesion;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picApp_Load;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}


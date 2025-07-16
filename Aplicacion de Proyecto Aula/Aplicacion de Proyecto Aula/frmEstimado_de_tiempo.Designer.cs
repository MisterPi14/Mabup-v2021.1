
namespace Agencia_de_viajes
{
    partial class frmEstimado_de_tiempo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstimado_de_tiempo));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblCarga = new System.Windows.Forms.Label();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblSemanas = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.lblFU_Dias = new System.Windows.Forms.Label();
            this.lblFD_Dias = new System.Windows.Forms.Label();
            this.lblFU_Semanas = new System.Windows.Forms.Label();
            this.lblFD_Semanas = new System.Windows.Forms.Label();
            this.lblFU_Meses = new System.Windows.Forms.Label();
            this.lblFD_Meses = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "YA CASI ACABAS CON TU REGISTRO!!!";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(171, 368);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(114, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar Prueba";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Visible = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(313, 368);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(114, 23);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Finalizar";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Visible = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(472, 363);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Aceptar";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 82);
            this.label2.TabIndex = 9;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(541, 55);
            this.label3.TabIndex = 10;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.BackColor = System.Drawing.Color.Transparent;
            this.lblCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblCronometro.ForeColor = System.Drawing.Color.White;
            this.lblCronometro.Location = new System.Drawing.Point(208, 320);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(192, 36);
            this.lblCronometro.TabIndex = 11;
            this.lblCronometro.Text = "00:00:00:000";
            this.lblCronometro.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(232, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 49);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mabup";
            // 
            // timer2
            // 
            this.timer2.Interval = 6000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblCarga
            // 
            this.lblCarga.BackColor = System.Drawing.Color.Transparent;
            this.lblCarga.ForeColor = System.Drawing.Color.Teal;
            this.lblCarga.Location = new System.Drawing.Point(12, 286);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(146, 34);
            this.lblCarga.TabIndex = 13;
            this.lblCarga.Text = "Espera un momento estamos procesando tu registro...";
            this.lblCarga.Visible = false;
            // 
            // picLoad
            // 
            this.picLoad.BackColor = System.Drawing.Color.Transparent;
            this.picLoad.Image = global::Agencia_de_viajes.Properties.Resources.Load;
            this.picLoad.Location = new System.Drawing.Point(34, 336);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(100, 50);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoad.TabIndex = 14;
            this.picLoad.TabStop = false;
            this.picLoad.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(192, 274);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Cronometro";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(313, 274);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(122, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Añadir manualmente";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(516, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "O tambien puedes seleccionar la opcion de añadir manuelmente para ingresar tu tie" +
    "mpo de manera manual";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtMinutos.Location = new System.Drawing.Point(241, 325);
            this.txtMinutos.Multiline = true;
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(44, 33);
            this.txtMinutos.TabIndex = 19;
            this.txtMinutos.Text = "00";
            this.txtMinutos.Visible = false;
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtHoras.Location = new System.Drawing.Point(176, 325);
            this.txtHoras.Multiline = true;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(44, 33);
            this.txtHoras.TabIndex = 20;
            this.txtHoras.Text = "00";
            this.txtHoras.Visible = false;
            // 
            // txtSegundos
            // 
            this.txtSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtSegundos.Location = new System.Drawing.Point(313, 325);
            this.txtSegundos.Multiline = true;
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(43, 33);
            this.txtSegundos.TabIndex = 21;
            this.txtSegundos.Text = "00";
            this.txtSegundos.Visible = false;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.BackColor = System.Drawing.Color.Transparent;
            this.lblDias.ForeColor = System.Drawing.Color.White;
            this.lblDias.Location = new System.Drawing.Point(321, 368);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(55, 13);
            this.lblDias.TabIndex = 24;
            this.lblDias.Text = "Segundos";
            this.lblDias.Visible = false;
            // 
            // lblSemanas
            // 
            this.lblSemanas.AutoSize = true;
            this.lblSemanas.BackColor = System.Drawing.Color.Transparent;
            this.lblSemanas.ForeColor = System.Drawing.Color.White;
            this.lblSemanas.Location = new System.Drawing.Point(241, 365);
            this.lblSemanas.Name = "lblSemanas";
            this.lblSemanas.Size = new System.Drawing.Size(44, 13);
            this.lblSemanas.TabIndex = 25;
            this.lblSemanas.Text = "Minutos";
            this.lblSemanas.Visible = false;
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.BackColor = System.Drawing.Color.Transparent;
            this.lblMeses.ForeColor = System.Drawing.Color.White;
            this.lblMeses.Location = new System.Drawing.Point(182, 363);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(35, 13);
            this.lblMeses.TabIndex = 26;
            this.lblMeses.Text = "Horas";
            this.lblMeses.Visible = false;
            // 
            // lblFU_Dias
            // 
            this.lblFU_Dias.AutoSize = true;
            this.lblFU_Dias.BackColor = System.Drawing.Color.Transparent;
            this.lblFU_Dias.ForeColor = System.Drawing.Color.White;
            this.lblFU_Dias.Location = new System.Drawing.Point(328, 307);
            this.lblFU_Dias.Name = "lblFU_Dias";
            this.lblFU_Dias.Size = new System.Drawing.Size(13, 13);
            this.lblFU_Dias.TabIndex = 29;
            this.lblFU_Dias.Text = "↑";
            this.lblFU_Dias.Visible = false;
            this.lblFU_Dias.Click += new System.EventHandler(this.lblFU_Dias_Click);
            // 
            // lblFD_Dias
            // 
            this.lblFD_Dias.AutoSize = true;
            this.lblFD_Dias.BackColor = System.Drawing.Color.Transparent;
            this.lblFD_Dias.ForeColor = System.Drawing.Color.White;
            this.lblFD_Dias.Location = new System.Drawing.Point(328, 389);
            this.lblFD_Dias.Name = "lblFD_Dias";
            this.lblFD_Dias.Size = new System.Drawing.Size(13, 13);
            this.lblFD_Dias.TabIndex = 30;
            this.lblFD_Dias.Text = "↓";
            this.lblFD_Dias.Visible = false;
            this.lblFD_Dias.Click += new System.EventHandler(this.lblFD_Dias_Click);
            // 
            // lblFU_Semanas
            // 
            this.lblFU_Semanas.AutoEllipsis = true;
            this.lblFU_Semanas.AutoSize = true;
            this.lblFU_Semanas.BackColor = System.Drawing.Color.Transparent;
            this.lblFU_Semanas.ForeColor = System.Drawing.Color.White;
            this.lblFU_Semanas.Location = new System.Drawing.Point(259, 307);
            this.lblFU_Semanas.Name = "lblFU_Semanas";
            this.lblFU_Semanas.Size = new System.Drawing.Size(13, 13);
            this.lblFU_Semanas.TabIndex = 31;
            this.lblFU_Semanas.Text = "↑";
            this.lblFU_Semanas.Visible = false;
            this.lblFU_Semanas.Click += new System.EventHandler(this.lblFU_Semanas_Click);
            // 
            // lblFD_Semanas
            // 
            this.lblFD_Semanas.AutoSize = true;
            this.lblFD_Semanas.BackColor = System.Drawing.Color.Transparent;
            this.lblFD_Semanas.ForeColor = System.Drawing.Color.White;
            this.lblFD_Semanas.Location = new System.Drawing.Point(259, 389);
            this.lblFD_Semanas.Name = "lblFD_Semanas";
            this.lblFD_Semanas.Size = new System.Drawing.Size(13, 13);
            this.lblFD_Semanas.TabIndex = 32;
            this.lblFD_Semanas.Text = "↓";
            this.lblFD_Semanas.Visible = false;
            this.lblFD_Semanas.Click += new System.EventHandler(this.lblFD_Semanas_Click);
            // 
            // lblFU_Meses
            // 
            this.lblFU_Meses.AutoSize = true;
            this.lblFU_Meses.BackColor = System.Drawing.Color.Transparent;
            this.lblFU_Meses.ForeColor = System.Drawing.Color.White;
            this.lblFU_Meses.Location = new System.Drawing.Point(189, 307);
            this.lblFU_Meses.Name = "lblFU_Meses";
            this.lblFU_Meses.Size = new System.Drawing.Size(13, 13);
            this.lblFU_Meses.TabIndex = 33;
            this.lblFU_Meses.Text = "↑";
            this.lblFU_Meses.Visible = false;
            this.lblFU_Meses.Click += new System.EventHandler(this.lblFU_Meses_Click);
            // 
            // lblFD_Meses
            // 
            this.lblFD_Meses.AutoSize = true;
            this.lblFD_Meses.BackColor = System.Drawing.Color.Transparent;
            this.lblFD_Meses.ForeColor = System.Drawing.Color.White;
            this.lblFD_Meses.Location = new System.Drawing.Point(189, 389);
            this.lblFD_Meses.Name = "lblFD_Meses";
            this.lblFD_Meses.Size = new System.Drawing.Size(13, 13);
            this.lblFD_Meses.TabIndex = 34;
            this.lblFD_Meses.Text = "↓";
            this.lblFD_Meses.Visible = false;
            this.lblFD_Meses.Click += new System.EventHandler(this.lblFD_Meses_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(205, 258);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(195, 13);
            this.lblAviso.TabIndex = 35;
            this.lblAviso.Text = "Verifica que este seleccionada la casilla";
            this.lblAviso.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MingLiU-ExtB", 13F);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(374, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "©2021";
            // 
            // frmEstimado_de_tiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 411);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblFD_Meses);
            this.Controls.Add(this.lblFU_Meses);
            this.Controls.Add(this.lblFD_Semanas);
            this.Controls.Add(this.lblFU_Semanas);
            this.Controls.Add(this.lblFD_Dias);
            this.Controls.Add(this.lblFU_Dias);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblSemanas);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Name = "frmEstimado_de_tiempo";
            this.Text = "Registro Tiempo de Trabajo";
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblSemanas;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Label lblFU_Dias;
        private System.Windows.Forms.Label lblFD_Dias;
        private System.Windows.Forms.Label lblFU_Semanas;
        private System.Windows.Forms.Label lblFD_Semanas;
        private System.Windows.Forms.Label lblFU_Meses;
        private System.Windows.Forms.Label lblFD_Meses;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label label5;
    }
}
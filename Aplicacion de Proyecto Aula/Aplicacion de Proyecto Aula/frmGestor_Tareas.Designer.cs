
namespace Agencia_de_viajes
{
    partial class frmGestor_Tareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestor_Tareas));
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnAgregar_Tarea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvTareas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic);
            this.lblLogo.ForeColor = System.Drawing.Color.Yellow;
            this.lblLogo.Location = new System.Drawing.Point(226, 21);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(126, 49);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Mabup";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // btnAgregar_Tarea
            // 
            this.btnAgregar_Tarea.BackColor = System.Drawing.Color.Black;
            this.btnAgregar_Tarea.ForeColor = System.Drawing.Color.Yellow;
            this.btnAgregar_Tarea.Location = new System.Drawing.Point(33, 124);
            this.btnAgregar_Tarea.Name = "btnAgregar_Tarea";
            this.btnAgregar_Tarea.Size = new System.Drawing.Size(248, 44);
            this.btnAgregar_Tarea.TabIndex = 1;
            this.btnAgregar_Tarea.Text = "Agregar Nueva Tarea";
            this.btnAgregar_Tarea.UseVisualStyleBackColor = false;
            this.btnAgregar_Tarea.Click += new System.EventHandler(this.btnAgregar_Tarea_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(382, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TAREAS PENDIENTES";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lvTareas);
            this.panel1.Location = new System.Drawing.Point(322, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 262);
            this.panel1.TabIndex = 3;
            // 
            // lvTareas
            // 
            this.lvTareas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvTareas.HideSelection = false;
            this.lvTareas.Location = new System.Drawing.Point(3, 3);
            this.lvTareas.Name = "lvTareas";
            this.lvTareas.Size = new System.Drawing.Size(229, 252);
            this.lvTareas.TabIndex = 6;
            this.lvTareas.UseCompatibleStateImageBehavior = false;
            this.lvTareas.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Columna1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Columna 2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(33, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Actualizar test de rapidez";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(33, 376);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCompletar
            // 
            this.btnCompletar.BackColor = System.Drawing.Color.Black;
            this.btnCompletar.ForeColor = System.Drawing.Color.Lime;
            this.btnCompletar.Location = new System.Drawing.Point(33, 294);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(108, 40);
            this.btnCompletar.TabIndex = 7;
            this.btnCompletar.Text = "Marcar como completada";
            this.btnCompletar.UseVisualStyleBackColor = false;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de la tarea";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 13F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(358, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "©2021";
            // 
            // frmGestor_Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 411);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar_Tarea);
            this.Controls.Add(this.lblLogo);
            this.Name = "frmGestor_Tareas";
            this.Text = "Gestor de Tareas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnAgregar_Tarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvTareas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}